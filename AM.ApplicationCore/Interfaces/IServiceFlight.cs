using System;
using AM.ApplicationCore.Domain;

namespace AM.ApplicationCore.Interfaces
{
	public interface IServiceFlight
	{
		IList<DateTime> GetFlightDates(string destination);

		void ShowFlightDetails(Plane plane);

		int ProgrammedFlightNumber(DateTime startDate);

		double DurationAverage(string destination);

		IEnumerable<Flight> OrderedDurationFlights();

		IEnumerable<Traveller> SeniorTravellers(Flight flight);

        IEnumerable<IGrouping<string, Flight>> DestinationGroupedFlights();
    }
}

