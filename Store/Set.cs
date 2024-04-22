using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
namespace Eighth_lesson.Store
{
    public class Set : Product
    {
        public Set() { }

        public Set(string name,double price,List<Product> products):base(name,price)
        {
            this.Name = name;
            this.Price = price;
            this.Products = products;
        }

        private List<Product> Products { get; set; }

        public override void InfoFor()
        {
            Console.WriteLine($"{Name} - название комплекта,{Price} - цена партии, {String.Join(",",Products.Select(q=>q.Name))}");
        }

        public override void ExpirationDate()
        {
            int count = 0;
            foreach(var item in this.Products.Select(q => q.ShelfLife))
            {
                string[] dates = item.Split('-');
                DateTime endDate = DateTime.ParseExact(dates[1], "dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture);
                if (DateTime.Today > endDate)
                {
                  
                    count++;
                }
               
            }
            if (count == 0)
            {
                
                Console.WriteLine("Срок сета продуктов не истёк.");
            }
            else
            {
                Console.WriteLine("Срок сета продуктов истёк.");
            }
        }
    }
}
