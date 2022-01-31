using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace ClassMetotDemo
{
   
    class CustomerManager
    {
        // Müşterilerin tutulacağı bir anlamda veritabanı gibi çalışacak Array'i oluşturuyoruz.
        Customer[] customers = new Customer[] { };

        // Müşteri ekleme metodu
        public void AddCustomer(Customer customer)
        {
            // Parametre olarak verilen objeyi yukarıdaki Array'e ekliyoruz. Böylece kayıt işlemi yapılmış oluyor.
            customers = customers.Append(customer).ToArray();
            Console.WriteLine(customer.Name+" isimli müşteri başarıyla EKLENDİ!");
        }
        public void DeleteCustomer(Customer customer)
        {
            // Parametre olarak verilen objenin customers arrayindeki index'ini buluyoruz ve tutuyoruz.
            int index = Array.IndexOf(customers, customer);
            // Geçici bir liste oluşturarak customers arrayinin elemanlarını kopyalıyoruz.
            List<Customer> delcustomer = new List<Customer>(customers);
            // Listeden silmek istediğimiz müşteri nesnesinin bulunduğu indexteki elemanı siliyoruz.
            delcustomer.RemoveAt(index);
            // customers arrayini elemanı silmek için kullandığımız liste ile güncelliyoruz.
            customers = delcustomer.ToArray();
            Console.WriteLine(customer.Name+" isimli müşteri sistemden SİLİNDİ.");
        }
        public void ListCustomers()
        {
            // customers listesinde mevcut olan müşterileri ekranda listeliyoruz.
            foreach (var customer in customers)
            {
                Console.WriteLine("Adı: " + customer.Name + "\nSoyadi: " + customer.Surname + "\nTelefonu: " + customer.PhoneNumber + "\nAdresi: " + customer.Address+"\n------------------------------------");
            }
        }
    }
}
