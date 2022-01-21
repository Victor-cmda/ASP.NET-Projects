using MVC_SalesWeb.Data;
using MVC_SalesWeb.Models;
using System.Collections.Generic;
using System.Linq;

namespace MVC_SalesWeb.Services
{
    public class DepartmentService
    {
        private readonly MVC_SalesWebContext _context;
        public DepartmentService(MVC_SalesWebContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
