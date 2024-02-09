using FluentAPI3_22_10.DataAccess;
using FluentAPI3_22_10.Domain.Abstractions;
using FluentAPI3_22_10.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace FluentAPI3_22_10
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static IUnitOfWork DB;
        public App()
        {
            DB = new EFUnitOfWork();

            if(DB.CustomerRepository.GetAll().Count() == 0 )
            {
                var c1 = new Customer
                {
                    City="Baku",
                    CompanyName="STEP IT MMC",
                    ContactName="+9884654653145",
                    Country="Azerbaijan"
                };


                var c2 = new Customer
                {
                    City="California:Silicon Valley",
                    CompanyName="Elvin MMC",
                    ContactName="+760-511-01010",
                    Country="USA"
                };

                DB.CustomerRepository.AddData(c1);
                DB.CustomerRepository.AddData(c2);
            }

            if(DB.OrderRepository.GetAll().Count() == 0 )
            {
                var order1 = new Order
                {
                    CustomerId = 1,
                    OrderDate = DateTime.Now.AddDays(-1),
                    ImagePath= "https://fdn.gsmarena.com/imgroot/news/23/09/samsung-galaxy-s24-design-renders/inline/-1200/gsmarena_001.jpg"
                };

                var order2 = new Order
                {
                    CustomerId = 1,
                    OrderDate = DateTime.Now.AddDays(-5),
                    ImagePath = "https://timesofindia.indiatimes.com/photo/99960182/99960182.jpg"
                };

                var order3 = new Order
                {
                    CustomerId = 2,
                    OrderDate = DateTime.Now.AddDays(-3),
                    ImagePath = "https://consumer.huawei.com/content/dam/huawei-cbg-site/common/mkt/plp/phones-20230509/view-all-phones/all-nova-y91.png"
                };

                var order4 = new Order
                {
                    CustomerId = 2,
                    OrderDate = DateTime.Now.AddDays(-10),
                    ImagePath = "https://i01.appmifile.com/webfile/globalimg/products/pc/xiaomi-12-pro/m-section01.jpg"
                };

                DB.OrderRepository.AddData(order1);
                DB.OrderRepository.AddData(order2);
                DB.OrderRepository.AddData(order3);
                DB.OrderRepository.AddData(order4);

            }
        }
    }
}
