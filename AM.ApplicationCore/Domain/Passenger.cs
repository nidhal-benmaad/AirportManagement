using System;
using System.ComponentModel.DataAnnotations;

namespace AM.ApplicationCore.Domain
{
	public class Passenger
	{
        //public int Id { get; set; }
        [Key]
        [StringLength(7)]
        public string PassportNumber { get; set; }
        [MinLength(3),MaxLength(25,ErrorMessage ="invalid")]
		public Fullname Fullname { get; set; }
		public DateTime BirthDate { get; set; }
		public int TellNumber { get; set; }
		public string EmailAddress { get; set; }
		public ICollection<Flight> Flights { get; set; }

		//polymorphism par signature
		public bool checkProfile(string firstName, string lastName)
		{
			return Fullname.Firstname.Equals(firstName) && Fullname.Lastname.Equals(lastName);
		}
        public bool checkProfile(string firstName, string lastName, string email)
        {
            return checkProfile(firstName,lastName) && EmailAddress.Equals(email);
        }

		public bool login(string firstName, string lastName, string email = null)
		{
			if(email != null)  return checkProfile(firstName, lastName, email);

			return checkProfile(firstName, lastName);
		}

		public virtual void PassengerType()
		{
			Console.WriteLine("I am Passenger");
		}
        public Passenger()
		{
		}
	}
}

