using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class InnerDatabase
    {

        private ExportedDatabase exportedInitial;

        public InnerDatabase(ExportedDatabase database)
        {
            exportedInitial = database;
            Offices = database.offices.ToList();
            foreach (var office in Offices)
            {
                maxOfficeId = Math.Max(maxOfficeId, office.id);
            }
            Employees = database.employees.ToList();
            foreach (var employee in Employees)
            {
                maxEmployeeId = Math.Max(maxEmployeeId, employee.id);
            }
            Services = database.services.ToList();
            foreach (var service in Services)
            {
                maxServiceId = Math.Max(maxServiceId, service.id);
            }
            Orders = database.orders.ToList();
            foreach (var order in Orders)
            {
                maxOrderId = Math.Max(maxOrderId, order.id);
            }
        }

        private long maxOfficeId;
        private long maxOrderId;
        private long maxEmployeeId;
        private long maxServiceId;


        public List<Office> Offices {get; set;}
        public List<Employee> Employees { get; set; }
        public List<Service> Services { get; set; }
        public List<Order> Orders { get; set; }

        public ExportedDatabase toExported()
        {
            ExportedDatabase db = new ExportedDatabase();

            db.services = Services.ToArray();
            db.offices = Offices.ToArray();
            db.employees = Employees.ToArray();
            db.orders = Orders.ToArray();

            return db;
        }

        public int addOffice()
        {
            Office toAdd = new Office();
            toAdd.id = (++maxOfficeId);
            toAdd.idSpecified = true;
            Offices.Add(toAdd);
            return Offices.Count - 1;
        }

        public bool removeOffice(int idx)
        {
            long idToRemove = Offices[idx].id;
            Offices.RemoveAt(idx);
            bool clean = true;
            foreach (var order in Orders)
            {
                if (order.office != null && order.office.id == idToRemove)
                {
                    order.office = null;
                    clean = false;
                }
            }
            return clean;
        }

        public void saveOffice(int idx, string name, string address)
        {
            Offices[idx].address = address;
            Offices[idx].name = name;
            Offices[idx].idSpecified = true;
        }

        public int addEmployee()
        {
            Employee toAdd = new Employee();
            toAdd.id = (++maxEmployeeId);
            toAdd.hireDate = DateTime.Now;
            toAdd.dateOfBirth = DateTime.Now;
            Employees.Add(toAdd);
            return Employees.Count - 1;
        }

        public bool removeEmployee(int idx)
        {
            long idToRemove = Employees[idx].id;
            Employees.RemoveAt(idx);
            bool clean = true;
            foreach (var order in Orders)
            {
                if (order.employee != null && order.employee.id == idToRemove)
                {
                    order.employee = null;
                    clean = false;
                }
            }
            return clean;
        }

        public void saveEmployee(int idx, string name, string lastName, string patrName,
            string phoneNumber, DateTime dateOfBirth, DateTime hireDate, double salary)
        {
            Employee emp = Employees[idx];
            emp.lastName = lastName;
            emp.patronymicName = patrName;
            emp.phoneNumber = phoneNumber;
            emp.salary = salary;
            emp.firstName = name;
            emp.hireDate = hireDate;
            emp.dateOfBirth = dateOfBirth;
            emp.dateOfBirthSpecified = true;
            emp.hireDateSpecified = true;
            emp.idSpecified = true;
            emp.salarySpecified = true;
        }

        public int addService()
        {
            Service toAdd = new Service();
            toAdd.id = (++maxServiceId);
            Services.Add(toAdd);
            return Services.Count - 1;
        }

        public bool removeService(int idx)
        {
            long idToRemove = Services[idx].id;
            Services.RemoveAt(idx);
            bool clean = true;
            foreach (var order in Orders)
            {
                if (order.service != null && order.service.id == idToRemove)
                {
                    order.service = null;
                    clean = false;
                }
            }
            return clean;
        }

        public void saveService(int idx, string name, double price)
        {
            if (idx < 0)
            {
                return;
            }
            Services[idx].name = name;
            Services[idx].idSpecified = true;
            Services[idx].price = price;
            Services[idx].priceSpecified = true;
        }

        public int addOrder()
        {
            Order toAdd = new Order();
            toAdd.id = (++maxOrderId);
            toAdd.idSpecified = true;
            toAdd.orderDate = DateTime.Now;
            toAdd.orderDateSpecified = true;
            toAdd.executedSpecified = false;
            toAdd.executedSpecified = true;
            Orders.Add(toAdd);
            return Orders.Count - 1;
        }

        public bool removeOrder(int idx)
        {
            Orders.RemoveAt(idx);
            return true;
        }

        public void saveOrder(int idx, string name, string last, string patr,
            string phone, DateTime orderDate, bool executed,
            int serviceIdx, int officeIdx, int employeeIdx, Article[] articles)
        {
            Order ord = Orders[idx];
            ord.clientFirstName = name;
            ord.clientLastName = last;
            ord.clientPatronymicName = patr;
            ord.phoneNumber = phone;
            ord.executedSpecified = true;
            ord.idSpecified = true;
            ord.orderDateSpecified = true;
            ord.orderDate = orderDate;
            if (officeIdx >= 0)
            {
                ord.office = Offices[officeIdx];
            }
            if (employeeIdx >= 0)
            {
                ord.employee = Employees[employeeIdx];
            }
            if (serviceIdx >= 0)
            {
                ord.service = Services[serviceIdx];
            }
            ord.articleList = articles;
            ord.executed = executed;
        }

        public int findOfficeIdxById(long id)
        {
            return Offices.FindIndex(office => { return office.id == id; });
        }

        public int findEmployeeIdxById(long id)
        {
            return Employees.FindIndex(emp => { return emp.id == id; });
        }

        public int findServiceIdxById(long id)
        {
            return Services.FindIndex(serv => { return serv.id == id; });
        }
    }
}
