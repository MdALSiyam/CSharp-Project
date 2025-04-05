using ArtGalleryManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtGalleryManagement.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private List<ArtGallery> CustomerList;

        public CustomerRepository() 
        {
            CustomerList = new List<ArtGallery>()
            {
                new ArtGallery()
                {
                    Id = 1,
                    ArtTitle = "Laughing Teeth",
                    ArtistName = "Carol Chaining",
                    CustomerName = "Jack Cook",
                    PhoneNo = "0123456789",
                    Type = CustomerType.General,
                    DeliveryCost = 100,
                    
                },

                new ArtGallery()
                {
                    Id = 2,
                    ArtTitle = "Emerald Sea",
                    ArtistName = "Dennis Frings",
                    CustomerName = "Terry Kim",
                    PhoneNo = "0987654321",
                    Type = CustomerType.Regular,
                    Discount = 500,
                },

                new ArtGallery()
                {
                    Id = 3,
                    ArtTitle = "At the Movies",
                    ArtistName = "James Warne",
                    CustomerName = "Tom Moddy",
                    PhoneNo = "0135798642",
                    Type = CustomerType.General,
                    DeliveryCost = 100,
                },

                new ArtGallery()
                {
                    Id = 4,
                    ArtTitle = "Never Give Up",
                    ArtistName = "Pablo Picaso",
                    CustomerName = "Roy Smith",
                    PhoneNo = "0246897531",
                    Type = CustomerType.Regular,
                    Discount = 500,
                },

                new ArtGallery()
                {
                    Id = 5,
                    ArtTitle = "Starry Night",
                    ArtistName = "Taylor Swift",
                    CustomerName = "Jack Cook",
                    PhoneNo = "0123456789",
                    Type = CustomerType.General,
                    DeliveryCost = 100,
                }

            };
        }

        public ArtGallery CreateCustomer(ArtGallery customer)
        {
            ArtGallery existingCustomer = ((from e in CustomerList orderby e.Id descending select e).Take(1)).Single()
            as ArtGallery;
            customer.Id = existingCustomer.Id + 1;
            CustomerList.Add(customer);
            return customer;
        }

        public ArtGallery DeleteCustomer(int id)
        {
            ArtGallery deleteCustomer = GetCustomer(id);
            if (deleteCustomer != null)
            {
                CustomerList.Remove(deleteCustomer);
            }
            return deleteCustomer;
        }

        public IEnumerable<ArtGallery> GetAllCustomer()
        {
            return from rows in CustomerList select rows;
        }

        public ArtGallery GetCustomer(int id)
        {
            var customer = (from e in CustomerList where e.Id == id select e).Single();
            return customer;
        }

        public ArtGallery UpdateCustomer(ArtGallery update)
        {
            ArtGallery updateCustomer = GetCustomer(update.Id);
            if (updateCustomer != null)
            {
                updateCustomer.Id = update.Id;
                updateCustomer.ArtTitle = update.ArtTitle;
                updateCustomer.ArtistName = update.ArtistName;
                updateCustomer.CustomerName = update.CustomerName;
                updateCustomer.PhoneNo = update.PhoneNo;
                updateCustomer.Type = update.Type;

                updateCustomer.InvoiceId = update.InvoiceId;
                updateCustomer.Discount = update.Discount;
                updateCustomer.DeliveryCost = update.DeliveryCost;
                updateCustomer.Dues = update.Dues;
            }
            return updateCustomer;
        }
    }
}
