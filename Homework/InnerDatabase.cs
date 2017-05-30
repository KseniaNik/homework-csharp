using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class InnerDatabase
    {

        public InnerDatabase(ExportedDatabase database)
        {
            Offices = database.offices.ToList();
            Employees = database.employees.ToList();
            Services = database.services.ToList();
            Orders = database.orders.ToList();
        }

        public List<Office> Offices {get; set;}
        public List<Employee> Employees { get; set; }
        public List<Service> Services { get; set; }
        public List<Order> Orders { get; set; }

        public ExportedDatabase toExported()
        {
            // TODO implement
            throw new NotImplementedException();
        }
    }
}
