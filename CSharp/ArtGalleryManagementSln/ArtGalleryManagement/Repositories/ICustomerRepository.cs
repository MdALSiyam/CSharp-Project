using ArtGalleryManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtGalleryManagement.Repositories
{
    public interface ICustomerRepository
    {
        IEnumerable<ArtGallery> GetAllCustomer();

        ArtGallery GetCustomer(int id);
        ArtGallery CreateCustomer(ArtGallery customer);
        ArtGallery UpdateCustomer(ArtGallery customer);
        ArtGallery DeleteCustomer(int id);
    }
}
