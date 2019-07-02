using LukaszDrozdzLab6Api.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LukaszDrozdzLab6Api.Controllers
{
    [Route("api/students")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private static Dictionary<string, Student> _students;

        static StudentsController()
        {
            _students = new Dictionary<string, Student>();
        }

        /// <summary>
        /// Get all the students
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get()
        {
            var allStudents = _students.Select(x => x.Value);
            return Ok(allStudents);
        }

        /// <summary>
        /// Add new student
        /// </summary>
        /// <param name="student"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Post([FromBody] Student student)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var id = Guid.NewGuid().ToString();
            student.Id = id;
            _students.Add(id, student);

            return NoContent();
        }

        /// <summary>
        /// Get student by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            var searchResults = _students.TryGetValue(id, out Student student);

            if (!searchResults)
            {
                return NotFound();
            }

            return Ok(student);
        }

        /// <summary>
        /// Update student info
        /// </summary>
        /// <param name="id"></param>
        /// <param name="student"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public IActionResult Put(string id, [FromBody] Student student)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var searchResult = _students.TryGetValue(id, out Student studentOut);

            if (!searchResult)
            {
                return NotFound();
            }

            studentOut.FirstName = student.FirstName;
            studentOut.LastName = student.LastName;
            studentOut.Age = student.Age;

            return NoContent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            var resultFound = _students.TryGetValue(id, out Student studentOut);

            if (!resultFound)
            {
                return NotFound();
            }
            _students.Remove(id);
            return NoContent();
        }
    }
}
