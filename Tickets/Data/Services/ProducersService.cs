using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tickets.Data.Base;
using Tickets.Models;

namespace Tickets.Data.Services
{
	public class ProducersService : EntityBaseRepository<Producer>, IProducersService
	{

		public ProducersService(AppDbContext context) : base(context)
		{
		}
	}
}
