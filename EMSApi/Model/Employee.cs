using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Employee {

    public Employee(){

    }
    public Employee(int id, string firstName, string lastName, char gender, long contact, string address=default) {
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
    public long? Contact {get; set; }

    public Department Department { get; set; }
    public int DepartmentId { get; set;}
    
}