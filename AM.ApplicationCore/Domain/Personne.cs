using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Personne
    {
        public Personne()
        {

        }
        public Personne(string nom, string prenom, string email, string password, string confirmPassword, DateTime dateNaissance)
        {
            Nom = nom;
            Prenom = prenom;
            Email = email;
            Password = password;
            ConfirmPassword = confirmPassword;
            DateNaissance = dateNaissance;
        }

        public bool Login(string nom, string password)
        {
           // var result = nom == Nom && password == Password ? true : false;       
           //if(nom==Nom&& password  == password)
            //    return true;
            //else
            //return false;
            return nom == Nom && password == Password;
        }
        public bool Login(string nom, string password,string email)
        {
            return nom == Nom && password == Password && email == Email; 
        } 
        
        public virtual void  GetMyType()
        {
            Console.WriteLine("je suis un personne");
        }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public DateTime DateNaissance { get; set; }

        public int Id { get; set; }
        public override string ToString()
        {
            return (Id + "\n" +
                " " + Nom + " " + Prenom + ""+DateNaissance+"" + Email + "" + Password + "" + ConfirmPassword + "");

        }
    }
}
