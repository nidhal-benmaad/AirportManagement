using System;
namespace AM.ApplicationCore.Domain
{
	public class Flight
	{

		public int FlightId { get; set; }
		public DateTime FlightDate { get; set; }
		public int EstimatedDuration { get; set; }
		public DateTime EffectiveArrival { get; set; }
		public string Departure { get; set; }
		public string Destination { get; set; }

		public string MyProperty { get; set; }
		public int PlaneFk { get; set; }

		public Plane Plane { get; set; }

		public ICollection<Passenger> Passengers { get; set; }

		public Flight()
		{
		}
	}
}

