// See https://aka.ms/new-console-template for more information
using AM.ApplicationCore.Domain;

Console.WriteLine("Hello, World!");
//Plane p1 = new Plane(100, new DateTime(12/12/2022),1);

//initialisation d'objets

//Plane p2 = new Plane
//{
//    Capacity = 100,
//    ManufactureDate = new DateTime(12 - 12 - 2022),
//    PlaneId=3
//};

Passenger pr1 = new Passenger
{
    Fullname = new()
    {
        Firstname = "foulen",
        Lastname = "foulani",
    },
    EmailAddress = "foulen@gmail.com"
};

Staff sf1 = new Staff
{
    Fullname = new()
    {
        Firstname = "teus",
        Lastname = "polir",
    },
    EmailAddress = "polisr@gmail.com"
};

Traveller tr1= new Traveller
{
    Fullname = new()
    {
        Firstname = "freud",
        Lastname = "artag",
    },
    EmailAddress = "freud@gmail.com"
};

Console.WriteLine(pr1.checkProfile("foulen","foulani"));
Console.WriteLine(pr1.checkProfile("foulen","foulani", "sdfkjh@dsfk.dsf"));

pr1.PassengerType();
sf1.PassengerType();
tr1.PassengerType();