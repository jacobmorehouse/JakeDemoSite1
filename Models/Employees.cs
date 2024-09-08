using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;
using System.Reflection.Metadata;

namespace JakeDemoSite1.Models
{
	public class Employees
	{
		[Key]
		public int EmployeeID { get; set; }
        [DisplayName("Last Name")]
        public string? LastName  { get; set; }
        [DisplayName("First Name")]
        public string? FirstName { get; set; }
		public string? Title { get; set; }
		public string? TitleOfCourtesy { get; set; }
        [DisplayName("Birthday")]
        public DateTime BirthDate { get; set; }
        [DisplayName("Hire Date")]
        public DateTime HireDate { get; set; }
		public string? Address { get; set; }
		public string? City { get; set; }
		public string? Region { get; set; }
        [DisplayName("Postal Code")]
        public string? PostalCode { get; set; }
		public string? Country { get; set; }
        [DisplayName("Home Phone")]
        public string? HomePhone { get; set; }
		public string? Extension { get; set; }
		[NotMapped]
		public Blob? Photo { get; set; }
		public string? Notes { get; set; }
		public int? ReportsTo { get; set; } //TODO can I make this into an Employee not just an int?
		public int? PhotoPath { get; set; }
	}
}
