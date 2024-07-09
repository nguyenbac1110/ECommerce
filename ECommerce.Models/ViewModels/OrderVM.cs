using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Models.ViewModels
{
	public class OrderVM
	{
		public List<Order>? Orders { get; set; }
		public Order? Order { get; set; }
		public List<Item>? Items { get; set; }
		public string? RadioSelected { get; set; }
	}
}
