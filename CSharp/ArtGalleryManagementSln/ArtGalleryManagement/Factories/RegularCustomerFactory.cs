using ArtGalleryManagement.Entities;
using ArtGalleryManagement.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtGalleryManagement.Factories
{
    public class RegularCustomerFactory : BaseCustomerFactory
    {
        ArtGallery cust;

        public RegularCustomerFactory(ArtGallery cus) : base(cus)
        {
            cust = cus;
        }

        public override ICustomerManager Create()
        {
            RegularCustomerManager manager = new RegularCustomerManager();
            cust.DeliveryCost = manager.GetDelivery();
            cust.Discount = manager.GetDiscount();

            return manager;
        }
    }
}
