using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtGalleryManagement.Entities
{
    public class ArtGallery
    {
        int id;
        string artTitle;
        string artistName;
        string customerName;
        string phoneNo;
        CustomerType type;

        public ArtGallery()
        {

        }

        public ArtGallery(int id, string artTitle, string artistName, string customerName, string phoneNo, CustomerType type)
        {
            this.id = id;
            this.artTitle = artTitle;
            this.artistName = artistName;
            this.customerName = customerName;
            this.phoneNo = phoneNo;
            this.type = type;
        }

        public int InvoiceId { get; set; }
        public int Discount { get; set; }
        public int DeliveryCost { get; set; }
        public int Dues { get; set; }

        public int Id { get => id; set => id = value; }
        public string ArtTitle { get => artTitle; set => artTitle = value; }
        public string ArtistName { get => artistName; set => artistName = value; }
        public string CustomerName { get => customerName; set => customerName = value; }
        public string PhoneNo { get => phoneNo; set => phoneNo = value; }
        public CustomerType Type { get => type; set => type = value; }
    }
}
