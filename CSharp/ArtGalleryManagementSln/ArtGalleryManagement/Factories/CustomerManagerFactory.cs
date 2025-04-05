using ArtGalleryManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtGalleryManagement.Factories
{
    public class CustomerManagerFactory
    {
        public BaseCustomerFactory CreateFactory(ArtGallery customer)
        {
            BaseCustomerFactory factory = null;

            if (customer.Type == CustomerType.Regular)
            {
                factory = new RegularCustomerFactory(customer);
            }
            else if (customer.Type == CustomerType.General)
            {
                factory = new GeneralCustomerFactory(customer);
            }
            return factory;
        }
    }
}
