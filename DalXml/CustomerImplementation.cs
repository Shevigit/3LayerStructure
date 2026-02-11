

using DalApi;
using DO;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Runtime.Serialization.Json;
using System.Xml.Serialization;

namespace Dal
{
    public class CustomerImplementation : ICustomer
    {
        private string path = @"..\xml\customers.xml";
        //public List<Customer> LoadCustomerList()
        //{
        //    XmlSerializer serializer = new XmlSerializer(typeof(List<Customer>));
        //    List<Customer> customers;
        //    using (StreamReader streamReader = new StreamReader(path))
        //    {
        //        customers=serializer.Deserialize(streamReader) as List<Customer>;
        //    }
        //    if (customers!=null)
        //        return customers;
        //    throw new Exception();
        //}
        public List<Customer> LoadCustomerList()
        {
            if (!File.Exists(path))
                return new List<Customer>();

            XmlSerializer serializer = new XmlSerializer(typeof(List<Customer>));

            using (StreamReader streamReader = new StreamReader(path))
            {
                return serializer.Deserialize(streamReader) as List<Customer>
                       ?? new List<Customer>();
            }
        }



        public void SaveListCustomers(List<Customer> customers)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Customer>));
            using (StreamWriter streamWriter = new StreamWriter(path))
            {
                if (customers!=null)
                    serializer.Serialize(streamWriter, customers);
            }
        }
        public int Create(Customer item)
        {
            //using (StreamReader sr = new StreamReader(filePath))
            //{
            //    list = serializer.Deserialize(sr) as List<Customer>;
            //    Customer isExist = list.FirstOrDefault(i => i.Identity == item.Identity);
            //    if (isExist == null)
            //        list.Add(item);


            //}
            //using (StreamWriter sw = new StreamWriter(filePath))
            //{
            //    serializer.Serialize(sw, list);
            //}
            //return item.Identity;



            List<Customer> customers;
            customers = LoadCustomerList();
            //TODO: if()
            if (customers==null)
                customers = new List<Customer>();
            Customer isExist=customers.FirstOrDefault(i=>i.Customer_Id==item.Customer_Id);
            if(isExist==null)
                customers.Add(item);
            if (isExist != null)
                throw new DalIdExistsException("Customer with this ID already exists");
            SaveListCustomers(customers);
            return item.Customer_Id;
        }

        public void Delete(int id)
        {
            List<Customer> customers = LoadCustomerList();
            if (customers==null)
                throw new Exception();
            Customer customer = customers.FirstOrDefault(c => c.Customer_Id == id);
            if (customer==null) throw new Exception();
            else
                customers.Remove(customer);
            SaveListCustomers(customers);
        }

        public Customer? Read(int id)
        {
            List<Customer?> customers = LoadCustomerList();
            if (customers==null)
                throw new Exception();
            Customer? customer = customers.FirstOrDefault(c => c.Customer_Id==id);
            if (customer==null)
                throw new Exception();
            else
                return customer;
        }

        public Customer? Read(Func<Customer, bool> filter)
        {
            List<Customer?> customers = LoadCustomerList();
            if (customers==null)
                throw new Exception();

            Customer? customer = customers.FirstOrDefault(filter);
            if (customer==null)
                throw new Exception();
            return customer;

        }

        public List<Customer?> ReadAll(Func<Customer, bool>? filter = null)//???
        {
            List<Customer?> customers = LoadCustomerList();
            if (filter != null)
            {
                if (customers==null)
                    throw new Exception();
                else
                    customers=customers.Where(filter).ToList();
            }
      
            if (customers==null)
                throw new Exception();
            return customers;

        }

        public void Update(Customer item)
        {
            List<Customer> customers = LoadCustomerList();
            Customer customer = customers.FirstOrDefault(c => c.Customer_Id == item.Customer_Id);
            if (customer != null)
            {
                customers.Remove(customer);
                if (customers==null)
                    customers = new List<Customer>();
                customers.Add(item);
                SaveListCustomers(customers);
            }
            else
                throw new Exception();

        }
    }
}
