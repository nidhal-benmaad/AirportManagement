using System;
using System.Linq;
using System.Numerics;
using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;

namespace AM.ApplicationCore.Services
{
	public class ServiceFlight:IServiceFlight
	{
        public IList<Flight> Flights { get; set; } = new List<Flight>();
       
        public ServiceFlight()
		{
		}

        //public IList<DateTime> GetFlightDates(string destination)
        //{
        //    IList<DateTime> Dates = new List<DateTime>(); 
        //    foreach (Flight item in Flights)
        //    {
        //        if (item.Destination.Equals(destination))
        //        {
        //            Dates.Add(item.FlightDate);
        //        }
        //    }

        //    return Dates;
        //}

        // By Linq method
        public IList<DateTime> GetFlightDates(string destination)
        {
            var query = from fl in Flights
                        where fl.Destination ==destination
                        select fl.FlightDate;
            return query.ToList();
        }

        public void ShowFlightDetails(Domain.Plane plane)
        {
            var query = from fl in Flights
                        where fl.Plane == plane
                        select (fl.FlightDate, fl.Destination);
            var lambda = Flights.Where(fl => fl.Plane == plane).Select(p => new { p.FlightDate, p.Destination });

            foreach (var item in lambda)
            {
                Console.WriteLine(item.FlightDate +" "+ item.Destination);
            }
        }

        public int ProgrammedFlightNumber(DateTime startDate)
        {
            // Linq
            //var query = from fl in Flights
            //            where (fl.FlightDate - startDate).TotalDays < 7 && fl.FlightDate > startDate
            //            select fl;

            //return query.Count();

             // lambda
            return Flights.Where(fl => (fl.FlightDate - startDate).TotalDays < 7 && fl.FlightDate > startDate).Count(); ;
        }

        public double DurationAverage(string destination)
        {
            return Flights.Where(fl => fl.Destination.Equals(destination)).Average(f => f.EstimatedDuration);
        }

        public IEnumerable<Flight> OrderedDurationFlights()
        {
            var query = from f in Flights
                        orderby f.EstimatedDuration descending
                        select f;
            return Flights.OrderByDescending(fl=>fl.EstimatedDuration);
        }

        public IEnumerable<Traveller> SeniorTravellers(Flight flight)
        {
            var result = from f in flight.Passengers.OfType<Traveller>()
                         orderby f.BirthDate
                         select f;
            result.Take(3);

            return flight.Passengers.OfType<Traveller>().OrderBy(f => f.BirthDate).Take(3);
        }

        public IEnumerable<IGrouping<string, Flight>> DestinationGroupedFlights()
        {
            var result = from f in Flights
                         group f by f.Destination;


            foreach (var item in result)
            {
                Console.WriteLine(item.Key);
                foreach (var elem in item)
                {
                    Console.WriteLine(elem.FlightDate);
                }
            }

            var lambda = Flights.GroupBy(fl => fl.Destination);
            return  lambda;
        }
    }
}

