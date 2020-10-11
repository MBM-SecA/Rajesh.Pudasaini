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
}