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

            //var students = _context.Students.FirstOrDefault();

            //_context.Entry(students).Collection(e => e.Evaluations).Load();

            //_context.Entry(students).Collection(ss => ss.StudentSubjects).Load();

            //foreach (var studentSubject in students.StudentSubjects)
            //{
            //    _context.Entry(studentSubject).Reference(s => s.Subject).Load();
            //}

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

            var rowsAffected = _context.Database.ExecuteSqlRaw(@"UPDATE Student SET Age = {0} WHERE Name = {1}", 28, "Jurgen Emanuels");

            return Ok(new { rowsAffected = rowsAffected });
        }
    }
}
