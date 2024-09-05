using System.ComponentModel.DataAnnotations;
using System.Numerics;
using System.Reflection.Metadata;

namespace JakeDemoSite1.Models
{
	public class Customers
	{
		[Key]
		public string CustomerID { get; set; }
		[Required]
		public string CustomerName { get; set; }
		public string? ContactName { get; set; }
		public string? ContactTitle { get; set; }
		[Required]
		public string? Address { get; set; }
		[Required]
		public string? City { get; set; }
		[Required]
		public string? Region { get; set; }
		[Required]
		public string? PortalCode { get; set; }
		[Required]
		public string? Country { get; set; }
		public string? Phone { get; set; }
		public string? Fax { get; set; }
	}
}
