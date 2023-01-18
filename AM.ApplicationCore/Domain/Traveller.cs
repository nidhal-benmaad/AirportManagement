using System;
namespace AM.ApplicationCore.Domain
{
	public class Traveller:Passenger
	{
		public string HealthInformation { get; set; }
		public string Nationality { get; set; }

        public override void PassengerType()
        {
			//base.PassengerType();
			Console.WriteLine("Je suis traveller");
        }

        public Traveller()
		{
		}
	}
}

