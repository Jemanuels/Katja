using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Katja.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public StudentsController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            // var students = _context.Students.AsNoTracking().Where(s => s.Age > 25).ToList();
            //var students = _context.Students
            //    .Include(e => e.Evaluations)
            //    .Include(ss => ss.StudentSubjects)
            //    .ThenInclude(s => s.Subject)
            //    .FirstOrDefault();

            var students = _context.Students.ToList();

            foreach( var student in students)
            {
                _context.Entry(student).Collection(e => e.Evaluations).Load();

                _context.Entry(student).Collection(ss => ss.StudentSubjects).Load();

                foreach (var studentSubject in student.StudentSubjects)
                {
                    _context.Entry(studentSubject).Reference(s => s.Subject).Load();
                }
            }

           

            

            //var evaluationsCount = _context.Entry(students).Collection(e => e.Evaluations).Query().Count();

            //var gradesPerStudent = _context.Entry(students).Collection(e => e.Evaluations).Query().Select(e => e.Grade).ToList();

            //students.LocalCalculation = evaluationsCount;

            //var students = _context.Students.Select(s => new
            //{
            //    s.Name,
            //    s.Age,
            //    NumberOfEvaluations = s.Evaluations.Count
            //}).ToList();

            //var students = _context.Students.Where(s => s.Name.Equals("Jurgen Emanuels")).Select(s => new
            //{
            //    s.Name,
            //    s.Age,
            //    Explanations = string.Join(",", s.Evaluations.Select(e => e.AdditionalExplanation))
            //}).FirstOrDefault();

            //var students = _context.Students.FromSqlRaw(@"SELECT * FROM Student WHERE Name = {0}", "Jurgen Emanuels")
            //    .Include(e => e.Evaluations)
            //    .FirstOrDefault();

            //return Ok(students);
            //var studentForUpdate = _context.Students.FirstOrDefault(s => s.Name.Equals("Jurgen Emanuels"));

            //var age = 37;


            //var rowsAffected = _context.Database.ExecuteSqlRaw(@"UPDATE Student SET Age = {0} WHERE Name = {1}", age, studentForUpdate.Name);

            //_context.Entry(studentForUpdate).Reload();

            return Ok(students);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Student student)
        {
            if (student == null)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            student.StudentDetails = new StudentDetails
            {
                Address = "Added Address",
                AdditionalInformation = "Additional Information added"
            };

            _context.Add(student);

            _context.SaveChanges();

            return Created("URI of the created entity", student);
        }

        [HttpPost("postrange")]
        public IActionResult PostRange([FromBody] IEnumerable<Student> students)
        {
            // additional checks

            _context.AddRange(students);
            _context.SaveChanges();

            return Created("URI is going here", students);
        }[HttpPut("{id}")]
        public IActionResult PUT(Guid id, [FromBody] Student student)
        {
            var dbStudent = _context.Students.FirstOrDefault(s => s.Id.Equals(id));

            dbStudent.Age = student.Age;
            dbStudent.Name = student.Name;
            dbStudent.IsRegularStudent = student.IsRegularStudent;

            var isAgeModified = _context.Entry(dbStudent).Property("Age").IsModified;
            var isNameModified = _context.Entry(dbStudent).Property("Name").IsModified;
            var isIsRegularStudentModified = _context.Entry(dbStudent).Property("IsRegularStudent").IsModified;

            _context.SaveChanges();

            return NoContent();
        }

        [HttpPut("{id}/relationship")]
        public IActionResult UpdateRelationship(Guid id, [FromBody] Student student)
        {
            var dbStudent = _context.Students.Include(s => s.StudentDetails).FirstOrDefault(s => s.Id.Equals(id));

            //dbStudent.Age = student.Age;
            //dbStudent.Name = student.Name;
            //dbStudent.IsRegularStudent = student.IsRegularStudent;
            //dbStudent.StudentDetails.Address = "Added Address";
            //dbStudent.StudentDetails.AdditionalInformation = "Additional information updated";

            dbStudent.StudentDetails = new StudentDetails
            {
                Id = new Guid(),
                Address = "Added Address",
                AdditionalInformation = "Additional information for " + student.Name
            };

            _context.SaveChanges();

            return NoContent();
        }

        [HttpPut("disconnected")]
        public IActionResult UpdateDisconnected([FromBody] Student student)
        {
            _context.Students.Attach(student);
            _context.Entry(student).State = EntityState.Modified;

            _context.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            var student = _context.Students.FirstOrDefault(s => s.Id.Equals(id));
            if(student == null)
            {
                return BadRequest();
            }

            student.Deleted = true;
            _context.SaveChanges();

            return NoContent();
        }



    }
}
