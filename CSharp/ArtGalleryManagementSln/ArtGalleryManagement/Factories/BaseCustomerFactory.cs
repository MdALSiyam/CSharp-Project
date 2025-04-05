using ArtGalleryManagement.Entities;
using ArtGalleryManagement.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtGalleryManagement.Factories
{
    public abstract class BaseCustomerFactory
    {
        protected ArtGallery _cus;

        protected BaseCustomerFactory(ArtGallery cus)
        {
            _cus = cus;
        }

        public abstract ICustomerManager Create();

        public ArtGallery GetCharge()
        {
            ICustomerManager manager = this.Create();
            _cus.DeliveryCost = manager.GetDelivery();
            _cus.Discount = manager.GetDiscount();

            return _cus;
        }
    }
}
