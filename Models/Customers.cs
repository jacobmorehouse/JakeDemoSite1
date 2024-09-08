using System.ComponentModel;
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
        [DisplayName("Customer Company Name")]
        public string CustomerName { get; set; }
        [DisplayName("Contact Name")]
        public string? ContactName { get; set; }
        [DisplayName("Contact Title")]
        public string? ContactTitle { get; set; }
		[Required]
		public string? Address { get; set; }
		[Required]
		public string? City { get; set; }
		[Required]
		public string? Region { get; set; }
		[Required]
        [DisplayName("Postal Code")]
        public string? PortalCode { get; set; }
		[Required]
		public string? Country { get; set; }
		public string? Phone { get; set; }
		public string? Fax { get; set; }
	}
}
