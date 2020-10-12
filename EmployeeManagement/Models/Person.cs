using System.Collections.Generic;

public class Person {
    public Person(string firstName, string lastName, char gender, long contact, string address=default) {
        FirstName = firstName;
        LastName = lastName;
        Address = address;
        Gender = gender;
        Contact = contact;
    }
    public string FirstName {get; set;}
    public string LastName {get; set;}

    public string Address {get; set; } = "Kapan, Kathmandu";

    public char Gender { get; set; }
    public long Contact {get; set; }

    public static List<Person> GetEmployee(){
        Person p1 = new Person("Rajesh", "Pudasaini", 'M', 9860476499, "Bhaktapur");
        Person p2 = new Person("Rajendra", "Pudasaini", 'M', 9860476499, "Syangja");
        Person p3 = new Person("Kabita", "Pudasaini", 'F', 9860476499);
        Person p4 = new Person("Krishna", "Pudasaini", 'F', 9860476499);
        Person p5 = new Person("Sunil", "KC", 'M', 9860476499);

        List<Person> persons = new List<Person>{p1, p2, p3, p4, p5};
        return persons;
    }
}