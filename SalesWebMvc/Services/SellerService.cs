using SalesWebMvc.Data;
using SalesWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Services
{
    public class SellerService
    {
        private readonly SalesWebMvcContext _context;

        public SellerService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public ICollection<Seller> FindAll()
        {
            return _context.Sellers.ToList();
        }
        public void Insert(Seller seller)
        {
            seller.Department = _context.Department.First();
            _context.Add(seller);
            _context.SaveChanges();
        }
    }
}
