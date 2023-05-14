using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tickets.Data.Cart;

namespace Tickets.Data.ViewModels
{
	public class ShoppingCartVM
	{
		public ShoppingCart ShoppingCart { get; set; }
		public double ShoppingCartTotal { get; set; }
	}
}
