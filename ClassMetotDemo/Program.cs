using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            // Aşağıda müşterileri özellikleriyle birlikte oluşturuyoruz.
            Customer musteri1 = new Customer();
            musteri1.Name = "Ahmet";
            musteri1.Surname = "Yılmaz";
            musteri1.Address = "XYZ Mah. Silahtar sok. 65/11 Ankara";
            musteri1.PhoneNumber = "05428889990";

            Customer musteri2 = new Customer();
            musteri2.Name = "Mehmet";
            musteri2.Surname = "Kapı";
            musteri2.Address = "Zeki Mah. At sok. 25/5 İstanbul";
            musteri2.PhoneNumber = "05458389570";

            Customer musteri3 = new Customer();
            musteri3.Name = "Cemil";
            musteri3.Surname = "Kara";
            musteri3.Address = "Okul mah. Kalem sok. 23/7 Sivas";
            musteri3.PhoneNumber = "05414586970";

            // CustomerManager classından bir instance oluşturuyoruz.
            CustomerManager customerManager = new CustomerManager();
            // Elemanları eklemek için yazdığımız metot ile elemanlarımızı ekliyoruz.
            customerManager.AddCustomer(musteri1);
            customerManager.AddCustomer(musteri2);
            customerManager.AddCustomer(musteri3);
            
            // Eleman silme metodu ile musteri2 'yi sistemden siliyoruz.
            customerManager.DeleteCustomer(musteri2);
            // Güncel olarak varolan elemanları listeleyen metodumuzu çağırıyoruz.
            customerManager.ListCustomers();


        }
    }
}
