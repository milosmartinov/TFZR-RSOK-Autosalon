using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TFZRAutosalon.Data.Repository.IRepository;
using TFZRAutosalon.Models;

namespace TFZRAutosalon.Data.Repository
{
    public class CategorizesRepository : Repository<Categorizes>, ICategorizesRepository
    {
        private readonly ApplicationDbContext _context;
        public CategorizesRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
