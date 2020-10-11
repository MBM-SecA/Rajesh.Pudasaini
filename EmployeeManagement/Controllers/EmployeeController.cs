using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

public class EmployeeController: Controller 
{
    public ActionResult Index() {

        Person p1 = new Person("Rajesh", "Pudasaini", 'M', 9860476499, "Bhaktapur");
        Person p2 = new Person("Rajendra", "Pudasaini", 'M', 9860476499, "Syangja");
        Person p3 = new Person("Kabita", "Pudasaini", 'F', 9860476499);
        Person p4 = new Person("Krishna", "Pudasaini", 'F', 9860476499);
        Person p5 = new Person("Sunil", "KC", 'M', 9860476499);

        List<Person> persons = new List<Person>{p1, p2, p3, p4, p5};
        return View(persons);
    }
}

