﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JakeDemoSite1.Models
{
	public class Suppliers
	{
		[Key]
		public int SupplierID { get; set; }
		[Required]
		[DisplayName("Company Name")]
		public string? CompanyName { get; set; }
		[DisplayName("Contact Name")]
		public string? ContactName { get; set; }
		[DisplayName("Contact Title")]
		public string? ContactTitle { get; set; }
		public string? Address { get; set; }
		public string? City { get; set; }
		public string? Region { get; set; }
		[DisplayName("Postal Code")]
		public string? PostalCode { get; set; }
		public string? Country { get; set; }
		public string? Phone { get; set; }
		public string? Fax { get; set; }
		public string? Homepage { get; set; }
	}
}
