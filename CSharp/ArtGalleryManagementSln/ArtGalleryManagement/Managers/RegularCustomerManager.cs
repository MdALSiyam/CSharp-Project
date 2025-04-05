using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtGalleryManagement.Managers
{
    public class RegularCustomerManager : ICustomerManager
    {
        public int GetDelivery()
        {
            return 0;
        }

        public int GetDiscount()
        {
            return 500;
        }

        public int GetPromoCode()
        {
            return 00;
        }
    }
}
