using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;


public class EmployeeController: Controller 
{

    private readonly EMSContext db;
    public EmployeeController(EMSContext _db){
        //construction injection
        db = _db;
    }

    // public List<Person> persons = Person.GetEmployee();

    //listing employee list
    public ActionResult Index() {
        var persons = db.People.ToList();
        // var persons = Person.GetEmployee();
        return View(persons);
    }

    //listing employee detail
    //[FromQuery] is attribute
    // [Route("summary")] if we want to change url
    public ActionResult Detail(int id){
        // var persons = Person.GetEmployee();
        // Person p1 = null;
        // foreach(var p in persons){
        //     if (p.FirstName == firstName){
        //         p1 = p;
        //     }
        // }
        // if (p1 != null){
        //     return View(p1);
        // }
        // return View();
       
        var p1 = from person in db.People
                     where person.Id == id
                     select person;

        return View(p1.FirstOrDefault());
    }

    //view to add employee
    public ActionResult Add(){
        return View();
    }

    [HttpPost]
    public ActionResult<string> Add(Person person){
        db.People.Add(person);
        db.SaveChanges();
        return Redirect("/employee");
    }
}

