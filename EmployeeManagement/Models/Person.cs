using System;
using System.Collections.Generic;

public class Person {
    public Person(int id, string firstName, string lastName, char gender, long contact, string address=default) {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Address = address;
        Gender = gender;
        Contact = contact;
    }

    public int Id {get; set;}
    public string FirstName {get; set;}
    public string LastName {get; set;}

    public string Address {get; set; } = "Kapan, Kathmandu";

    public char Gender { get; set; }
    public long Contact {get; set; }

    public static List<Person> GetEmployee(){
        Person p1 = new Person(1, "Rajesh", "Pudasaini", 'M', 9860476499, "Bhaktapur");
        Person p2 = new Person(2, "Rajendra", "Pudasaini", 'M', 9860476499, "Syangja");
        Person p3 = new Person(3, "Kabita", "Pudasaini", 'F', 9860476499);
        Person p4 = new Person(4, "Krishna", "Pudasaini", 'F', 9860476499);
        Person p5 = new Person(5, "Sunil", "KC", 'M', 9860476499);

        List<Person> persons = new List<Person>{p1, p2, p3, p4, p5};
        return persons;
    }
}