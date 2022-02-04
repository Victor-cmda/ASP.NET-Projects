using MVC_SalesWeb.Data;
using MVC_SalesWeb.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MVC_SalesWeb.Services
{
    public class DepartmentService
    {
        private readonly MVC_SalesWebContext _context;
        public DepartmentService(MVC_SalesWebContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
