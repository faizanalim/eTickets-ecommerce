using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tickets.Data.Base;
using Tickets.Models;

namespace Tickets.Data.Services
{
    public class ActorsService : EntityBaseRepository<Actor>, IActorsService
    {
        public ActorsService(AppDbContext context) : base(context) { }
    }
}
