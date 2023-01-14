using System;
namespace AM.ApplicationCore.Domain
{
	public class Plane
	{
        #region example
        string nom;

		public string GetNom()
		{
			return nom;
		}

		public void SetNom(string nom)
		{
			this.nom = nom;
		}

		// prop + tab : light version
		public string Nom { get; set; }

		// propfull + tab : full version
		//public string Nom { get { return nom; } set { nom = value; } }
		#endregion
		public int Capacity { get; set; }
		public DateTime ManufactureDate { get; set; }
		public int PlaneId { get; set; }
		public PlaneType PlaneType { get; set; }
		public ICollection<Flight> Flights { get; set; }

		public Plane()
		{
		}

        public Plane(int capacity, DateTime manufactureDate, int planeId)
        {
            Capacity = capacity;
            ManufactureDate = manufactureDate;
            PlaneId = planeId;
        }
    }
}

