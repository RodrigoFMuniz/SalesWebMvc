using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Models;
using SalesWebMvc.Models.Enums;

namespace SalesWebMvc.Data
{
    public class SeedingService
    {
        private readonly SalesWebMvcContext _context;

        public SeedingService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Department.Any()||
                _context.Sellers.Any()||
                _context.SalesRecords.Any())
            {
                return; //O banco de dados já foi populado, então não faça nada
            }

            Department d1 = new Department( "Computers");
            Department d2 = new Department( "Electronic");
            Department d3 = new Department( "Design");
            Department d4 = new Department( "Books");

            Seller s1 = new Seller( "Rodrigo", "r@r.com", new DateTime(1986, 10, 24), 1200.00, d1);
            Seller s2 = new Seller( "Ana", "a@a.com", new DateTime(1985, 12, 23), 1200.00, d3);
            Seller s3 = new Seller( "Bob", "b@b.com", new DateTime(1986, 02, 01), 1200.00, d4);
            Seller s4 = new Seller("Carlos", "c@c.com", new DateTime(1990, 03, 14), 1200.00, d1);
            Seller s5 = new Seller("Vilma", "v@v.com", new DateTime(1975, 08, 15), 1200.00, d2);

            SalesRecord sr1 = new SalesRecord(new DateTime(2021, 01, 14), 1000.00,SaleStatus.Pending,s2);
            SalesRecord sr2 = new SalesRecord(new DateTime(2021, 02, 17), 1030.00, SaleStatus.Billing, s1);
            SalesRecord sr3 = new SalesRecord(new DateTime(2021, 03, 03), 900.00, SaleStatus.Canceled, s3);
            SalesRecord sr4 = new SalesRecord(new DateTime(2021, 03, 21), 1460.00, SaleStatus.Billing, s5);
            SalesRecord sr5 = new SalesRecord(new DateTime(2021, 01, 22), 1230.00, SaleStatus.Pending, s4);
            SalesRecord sr6 = new SalesRecord(new DateTime(2021, 04, 28), 3050.00, SaleStatus.Pending, s2);

            _context.Department.AddRange(d1,d2,d3,d4);
            _context.Sellers.AddRange(s1,s2,s3,s4,s5);
            _context.SalesRecords.AddRange(sr1,sr2,sr3,sr4,sr5,sr6);

            _context.SaveChanges();
        }
    }
}
