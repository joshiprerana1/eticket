using e_ticket.Data.Base;
using e_ticket.Models;
using Microsoft.EntityFrameworkCore;

namespace e_ticket.Data.Services
{
    public class ActorsService : EntityBaseRepository<Actor>, IActorsServices
    {
        public ActorsService(AppDbContext context) : base(context) { }
    }


}
