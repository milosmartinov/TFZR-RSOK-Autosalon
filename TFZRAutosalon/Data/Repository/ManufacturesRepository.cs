using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TFZRAutosalon.Data.Repository.IRepository;
using TFZRAutosalon.Models;

namespace TFZRAutosalon.Data.Repository
{
    public class ManufacturesRepository : Repository<Manufacturers>, IManufacturesRepository
    {
        private readonly ApplicationDbContext _context;
        public ManufacturesRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
