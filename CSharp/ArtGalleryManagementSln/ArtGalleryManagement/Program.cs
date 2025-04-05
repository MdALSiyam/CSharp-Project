using ArtGalleryManagement.Entities;
using ArtGalleryManagement.Factories;
using ArtGalleryManagement.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtGalleryManagement
{
    internal class Program
    {
        public static CustomerRepository repo = new CustomerRepository();

        static void Main(string[] args)
        {
			try
			{
                DoTask();
			}
			catch (Exception ex)
			{

                Console.WriteLine(ex.Message);
			}
            finally
            {
                Console.ReadLine();
            }
        }

        private static void DoTask()
        {
            Console.WriteLine("\t\t\t\t\t********* C Sharp Project ********\n");
            Console.WriteLine("\t\t\t\t\t===== Art Gallery Management =====\n");
            Console.WriteLine("\t\t\t\t\t~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
            Console.WriteLine("\t\t\t\t\t   Name: Md. Abdul Latif (Siyam)  \n");
            Console.WriteLine("\t\t\t\t\t      Batch: CS/SCSL-M/61/01      \n");
            Console.WriteLine("\t\t\t\t\t            ID-1285124            \n");
            Console.WriteLine("\t\t\t\t\t             Round-61             \n");
            Console.WriteLine("\t\t\t\t =============================================== \n");
            Console.WriteLine("\t\t\t\t How many operations would you like to perform ? ");

            int count = Convert.ToInt32(Console.ReadLine());
            if (count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine();
                    Console.WriteLine("\t\t\t\t\t\t Select Operation ");
                    Console.WriteLine("\t\t\t\t\t\t------------------\n");
                    //Console.WriteLine("\t\t\t\t\t\tHints: " + "\n\t\t\t\t\tSelect -1\n\t\t\t\t\tCreate -2\n\t\t\t\t\tUpdate -3" +
                    //    "\n\t\t\t\t\tDelete -4");
                    Console.WriteLine("\t\t\t\t\t\t      Hints: \n");
                    Console.WriteLine("\t\t\t\t\t\t    Select = 1    ");
                    Console.WriteLine("\t\t\t\t\t\t    Create = 2    ");
                    Console.WriteLine("\t\t\t\t\t\t    Update = 3    ");
                    Console.WriteLine("\t\t\t\t\t\t    Delete = 4    ");
                    Console.WriteLine();
                    Console.WriteLine("\t\t\t\t\t _____=====************=====_____\n");

                    int opeCount = Convert.ToInt32(Console.ReadLine());
                    switch (opeCount)
                    {
                        case 1: ShowCustomer(null); break;
                        case 2: CreateCustomer(); break;
                        case 3: UpdateCustomer(); break;
                        case 4: DeleteCustomer(); break;


                    }
                }

            }
        }

        private static void DeleteCustomer()
        {
            Console.WriteLine("Enter ID");
            int deleteID = Convert.ToInt32(Console.ReadLine());
            ArtGallery DeleteCustomer = new ArtGallery();
            DeleteCustomer.Id = deleteID;
            DeleteCustomer = repo.DeleteCustomer(DeleteCustomer.Id);

            Console.WriteLine();
            Console.WriteLine("\t\t\t\t    ---------- Deleted Successfully ---------- \n");
            ShowCustomer(DeleteCustomer);

            Console.WriteLine("\n\t\t\t============================== Thank You ==============================");
        }

        private static void UpdateCustomer()
        {
            ArtGallery update = new ArtGallery();
            Console.WriteLine("Enter ID");
            update.Id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Art Title");
            update.ArtTitle = Console.ReadLine();

            Console.WriteLine("Enter Artist Name");
            update.ArtistName = Console.ReadLine();

            Console.WriteLine("Enter Customer Name");
            update.CustomerName = Console.ReadLine();

            Console.WriteLine("Enter Phone Number");
            update.PhoneNo = Console.ReadLine();

        EnterType:
            Console.WriteLine("Enter Type: General=0, Regular=1");
            string typeRead = Console.ReadLine();
            CustomerType type;
            try
            {
                type = (CustomerType)Enum.Parse(typeof(CustomerType), typeRead);
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid");
                goto EnterType;
            }

            update.Type = type;


            update = repo.UpdateCustomer(update);
            Console.WriteLine();
            Console.WriteLine("\t\t\t\t    ---------- Updated Successfully ---------- \n");
            ShowCustomer(update);
        }

        private static void CreateCustomer()
        {
            ArtGallery art = new ArtGallery();

            //Console.WriteLine("Enter ID");
            //art.Id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Art Title");
            art.ArtTitle = Console.ReadLine();

            Console.WriteLine("Enter Artist Name");
            art.ArtistName = Console.ReadLine();

            Console.WriteLine("Enter Customer Name");
            art.CustomerName = Console.ReadLine();

            Console.WriteLine("Enter Phone Number");
            art.PhoneNo = Console.ReadLine();

        EnterType:
            Console.WriteLine("Enter Type: General=0, Regular=1");
            string typeRead = Console.ReadLine();
            CustomerType type;
            try
            {
                type = (CustomerType)Enum.Parse(typeof(CustomerType), typeRead);
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid");
                goto EnterType;
            }

            art.Type = type;
            BaseCustomerFactory Factory = new CustomerManagerFactory().CreateFactory(art);
            Factory.GetCharge();
            repo.CreateCustomer(art);
            Console.WriteLine();
            Console.WriteLine("\t\t\t\t    ---------- Created Successfully ---------- \n");
            ShowCustomer(art);
        }

        private static void ShowCustomer(ArtGallery art)
        {
            IEnumerable<ArtGallery> show = repo.GetAllCustomer();
            Console.WriteLine();
            Console.WriteLine("\t\t\t\t\t ~~~~~~~~~~ Art Gallery ~~~~~~~~~~ \n");
            Console.WriteLine("========================================================================================================================");

            Console.WriteLine(string.Format("|{0,5} |{1,15} |{2,15} |{3,15} |{4,15} |{5,15}|{6,10}|{7,15} |", "ID", "Art Title   ", "Artist    ", "Customer Name ", "Phone Number ", "Customer Type ", "Discount ", "Delivery Cost "));
            Console.WriteLine("========================================================================================================================");

            foreach (ArtGallery a in show)
            {
                Console.WriteLine(string.Format("|{0,5} |{1,15} |{2,15} |{3,15} |{4,15} |{5,15}|{6,10}|{7,15} |", a.Id, a.ArtTitle, a.ArtistName, a.CustomerName, a.PhoneNo, a.Type, a.Discount, a.DeliveryCost));
               
            }
            Console.WriteLine("========================================================================================================================\n");
        }
    }
}
