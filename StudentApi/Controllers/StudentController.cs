using System;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using StudentApi.Data;
using System.Collections.Generic;



[Route("student")]
[ApiController]

public class StudentController : ControllerBase
{
    private readonly StudentContext db;
        public StudentController(StudentContext _db){

            db = _db;
        }

    [HttpGet]
    [Route("all")]
    public IEnumerable<Student> GetAllStudent()
    {
        var students = db.Student.ToList();
        return students;
    }

    [HttpGet]
    [Route("{id}")]
    public ActionResult GetStudent(int id) {
        var student = db.Student.Find(id);
        return Ok(student);
    }

    [HttpPost]
    [Route("create")]
    public ActionResult CreateStudent(Student student) {
        if (student == null) {
            return BadRequest();
        }
        db.Student.Add(student);
        db.SaveChanges();
        // Add student to db
        return Created("", student);
    }

    [HttpPut]
    [Route("update/{id}")]
    public ActionResult UpdateStudent(Student student, int id) {
        // update student from db
        db.Student.Attach(student);
        db.Student.Update(student);
        db.SaveChanges();
        return Ok(student);
    }

    [HttpDelete]
    [Route("delete/{id}")]
    public ActionResult DeleteStudent(int id) {
        // delete student to db
        var student = db.Student.Find(id);
        db.Student.Attach(student);
        db.Student.Remove(student);
        db.SaveChanges();
        return NoContent();
    }

}

