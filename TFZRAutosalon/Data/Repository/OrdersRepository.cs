using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TFZRAutosalon.Data.Repository.IRepository;
using TFZRAutosalon.Models;

namespace TFZRAutosalon.Data.Repository
{
    public class OrdersRepository : Repository<Orders>, IOrdersRepository
    {
        private readonly ApplicationDbContext _context;
        public OrdersRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
