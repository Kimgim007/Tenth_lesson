using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eighth_lesson.Store
{
    public class Product
    {

        public Product()
        {

        }
        public Product(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }
        public Product(string name, double price, string dateManufacture, string shelfLife)
        {
            this.Name = name;
            this.Price = price;
            this.DateManufacture = dateManufacture;
            this.ShelfLife = shelfLife;
        }
        public string Name { get; set; }
        public double Price { get; set; }
        public string DateManufacture { get; set; }
        public string ShelfLife { get; set; }

        public virtual void InfoFor()
        {
            Console.WriteLine($"{Name} - название продукта,{Price} - цена продукта,{DateManufacture} - дата изготовления, {ShelfLife} - Дата изготовления продукта");
        }

        public virtual void ExpirationDate()
        {
            string[] dates = ShelfLife.Split('-');
            DateTime endDate = DateTime.ParseExact(dates[1], "dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture);
            if (DateTime.Today > endDate)
            {
                Console.WriteLine("Срок годности истёк.");
            }
            else
            {
                Console.WriteLine("Срок годности не истёк.");
            }
        }
    }
}
