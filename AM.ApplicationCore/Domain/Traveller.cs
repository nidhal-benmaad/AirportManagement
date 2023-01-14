using System;
namespace AM.ApplicationCore.Domain
{
	public class Traveller:Passenger
	{
		public string HealthInformation { get; set; }
		public string Nationality { get; set; }
		public Traveller()
		{
		}
	}
}

