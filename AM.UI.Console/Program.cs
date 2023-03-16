//// See https://aka.ms/new-console-template for more information
////declaration variable 
//string ch;
////type: string, int, char, double, float, bool,DateTime, long, ....

//for (int i = 0; i < 2; i++)
//{
//    ch = Console.ReadLine();

//    Console.WriteLine("Bonjour " + ch);



//    int chiffreValue = 0;

//    // do
//    //
//    try
//    {
//        string chiffre = Console.ReadLine();
//        chiffreValue = int.Parse(chiffre);
//        if (chiffreValue > 15 && chiffreValue <= 18)
//        { Console.WriteLine("Ados"); }
//        else if (chiffreValue > 18)
//        { Console.WriteLine("Adulte"); }

//    }
//    catch
//    {
//        Console.WriteLine("Erreur au niveau de conversion du chiffre");
//    }
//    //} while (chiffreValue == 0);

//    Console.WriteLine("Votre nombre est " + (chiffreValue + 1));

//}

using AM.ApplicationCore.Services;
using System.Collections;
using System.Collections.Generic;
using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using AM.Infrastructure;

//Personne p2 = new Personne()
//{
//    Nom = "nom",
//    Prenom = "prenom",
//    DateNaissance = DateTime.Now,
//    Email = "email",
//    Password = "password",
//    ConfirmPassword = "confirmPassword"
//};



//Création d'un objet non initialisé de type Plane
//Plane plane = new Plane();
//plane.Planeid = 12;
//plane.Capacity = 333;
//plane.ManufactureDate = DateTime.Now;
//plane.PlaneType = PlaneType.Airbus;
//Console.WriteLine(plane);
//Plane plane1 = new Plane(PlaneType.Boing, 125, new DateTime(2022, 11, 11));
//Console.WriteLine(plane1) ;

//Initialisateur d'objet pour
//Plane plane2 = new Plane()
//{
//    Planeid = 11,
//    Capacity = 103,
//    ManufactureDate = new DateTime(2022, 3, 19),
//    PlaneType = PlaneType.Airbus
//};
// 9)On remarque que l'initialistaeur d'objet nous permet de créer et intialiser un objet sans besoin d'un constructeur explicite. 

//11)
//Passenger traveller = new Traveller();
//Passenger staff = new Staff();
//Passenger Passenger = new Passenger();
//traveller.PassengerType();
//staff.PassengerType();
//Passenger.PassengerType();

//collection des objets non génériques
//ArrayList list = new ArrayList();
//list.Add(plane);
//list.Add(1);
//list.Add("Bonjour");

//for (int i = 0; i < list.Count; i++)
//{
//    Console.WriteLine(list[i]);
//}
//foreach (var item in list)
//{
//    Console.WriteLine(item);
//}
AMContexte aMContexte = new AMContexte();
//aMContexte.flights.Add(new Flight()
//{
//    Destination = "tunis",
//    Departure = "bizert",
//    EffectiveArrival = new DateTime(2000, 2, 1),
//    EstmateDuration = "20",
//    FlightDate = new DateTime(2022, 5, 6),
//    plane = new Plane()
//    {
//        Capacity = 1,
//        ManufactureDate = new DateTime(2022, 10, 10),
//        PlaneType = PlaneType.Airbus
//    }
//});
//aMContexte.SaveChanges();
foreach(var item in aMContexte.flights.ToList())
{
    Console.WriteLine(item.FlightId+"/"+item.plane.Capacity+"/"+item.plane.ManufactureDate);
}




    
























