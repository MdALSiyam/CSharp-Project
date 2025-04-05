using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtGalleryManagement.Managers
{
    public class GeneralCustomerManager : ICustomerManager
    {
        public int GetDelivery()
        {
            return 100;
        }

        public int GetDiscount()
        {
            return 0;
        }

        public int GetPromoCode()
        {
            return 00;
        }
    }
}
