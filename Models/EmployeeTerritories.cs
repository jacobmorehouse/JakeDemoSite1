using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Numerics;
using System.Reflection.Metadata;

namespace JakeDemoSite1.Models
{

	[PrimaryKey(nameof(EmployeeID), nameof(TerritoryID))]
	public class EmployeeTerritories
	{
		[Required]
		public int EmployeeID { get; set; }
		[Required]
		public int TerritoryID { get; set; }
	}
}
