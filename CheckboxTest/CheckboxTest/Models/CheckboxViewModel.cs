using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CheckboxTest.Models
{
	public class CheckboxViewModel
	{
		[Display(Name="Test checkbox")]
		public bool TestCheckbox { get; set; }
	}
}