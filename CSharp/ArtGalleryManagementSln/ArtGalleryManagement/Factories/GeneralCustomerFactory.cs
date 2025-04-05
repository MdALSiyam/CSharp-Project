using ArtGalleryManagement.Entities;
using ArtGalleryManagement.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtGalleryManagement.Factories
{
    public class GeneralCustomerFactory : BaseCustomerFactory
    {
        public GeneralCustomerFactory(ArtGallery cus) : base(cus)
        {
        }

        public override ICustomerManager Create()
        {
            GeneralCustomerManager manager = new GeneralCustomerManager();
            _cus.DeliveryCost = manager.GetDelivery();
            _cus.Discount = manager.GetDiscount();

            return manager;
        }
    }
}
