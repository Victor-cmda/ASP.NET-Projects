using MVC_SalesWeb.Data;
using MVC_SalesWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_SalesWeb.Services
{
    public class SellerService
    {
        private readonly MVC_SalesWebContext _context;
        public SellerService(MVC_SalesWebContext context)
        {
            _context = context;
        }
        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }
        public void Insert(Seller obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
