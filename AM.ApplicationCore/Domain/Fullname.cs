using System;
using Microsoft.EntityFrameworkCore;

namespace AM.ApplicationCore.Domain
{
    [Owned]
	public class Fullname
	{
		
	
		public string Firstname { get; set; }
		public string Lastname { get; set; }
	}
}

