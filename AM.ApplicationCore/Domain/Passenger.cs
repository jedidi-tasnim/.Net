using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Passenger
    {   public int Id { get; set; }
        public DateTime BirthDate { get; set; }
        public int PassportNumber { get; set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TelNumber { get; set; }
        public List<Flight> flights { get; set; }
        public override string ToString()
        {
            return (BirthDate + "\n" +
                " " + PassportNumber + " " + EmailAddress + "" + FirstName + "" + LastName + "" + TelNumber + "" );

        }
        //10-a)

        //public bool checkProfil(string nom, string prenom) {

        //    return FirstName==nom && LastName==prenom;
        //}
        //b)

        //public bool checkProfil(string nom, string prenom,string email)
        //{

        //    return FirstName == nom && LastName == prenom && EmailAddress==email;
        //}

        //c)
        public bool checkProfil(string nom, string prenom, string email = null)
        {
            if (email == null)
            {
                return FirstName == nom && LastName == prenom;
            }
            return FirstName == nom && LastName == prenom && EmailAddress == email;
        }
        //11)
        public virtual void PassengerType()
        {
            Console.WriteLine("I am a passenger");
        }



    }
}
