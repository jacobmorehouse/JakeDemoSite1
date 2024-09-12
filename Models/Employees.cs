using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;
using System.Reflection.Metadata;
using System.Runtime.Serialization;

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
		[DisplayName("Name")]
		public string? LastCommaFirst
		{
			get
			{
				return this.LastName + ", " + this.FirstName;
			}
		}

		public string? Title { get; set; }
		[DisplayName("Prefix")]
		public string? TitleOfCourtesy { get; set; }
		[DisplayName("Birthday")]
		[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
		public DateTime BirthDate { get; set; }
		[DisplayName("Hire Date")]
		[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
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
		[DataType(DataType.MultilineText)]
		public string? Notes { get; set; }
		[Column("ReportsTo")]
		[ForeignKey("Employer")]
		public int? ReportsToEmployeeID { get; set; } //TODO can I make this into an Employee not just an int?
		[DisplayName("Reports To")]
		public Employees ReportsToEmployee { get; set; }
	}
}
