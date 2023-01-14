using System;
namespace AM.ApplicationCore.Domain
{
	public class Flight
	{

		public int FlightId { get; set; }
		public DateTime FlightDate { get; set; }
		public DateTime EstimatedDuration { get; set; }
		public DateTime EffectiveArrival { get; set; }
		public string Departure { get; set; }
		public DateTime Destination { get; set; }

		public Plane Plane { get; set; }

		public ICollection<Passenger> Passengers { get; set; }

		public Flight()
		{
		}
	}
}

