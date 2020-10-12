using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

public class EmployeeController: Controller 
{
    public ActionResult Index() {

        List<Person> persons = Person.GetEmployee();
        return View(persons);
    }

    public ActionResult Detail(string firstName){
        List<Person> persons = Person.GetEmployee();
        Person p1 = null;
        foreach(var p in persons){
            if (p.FirstName == firstName){
                p1 = p;
            }
        }
        if (p1 != null){
            return View(p1);
        }
        return View();
    }
}

