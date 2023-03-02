using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Passenger
    {   public int Id { get; set; }
        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        [Key]
        [MaxLength(7)]
        public int PassportNumber { get; set; }
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }
        [MinLength(3,ErrorMessage ="erreur")]
        [MaxLength(25,ErrorMessage ="erreur")]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [MinLength(8),MaxLength(8)]
        ///[RegularExpression("[0-9]")] pour max 8(public string)
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
