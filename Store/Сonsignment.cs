using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Eighth_lesson.Store
{
    public class Сonsignment : Product
    {
        public Сonsignment() { }
        public Сonsignment(string nameConsigment, double price, double countProduct, string dateManufacture, string shelfLife)

            : base(nameConsigment, price, dateManufacture, shelfLife) 
        {
            this.CountProduct = countProduct;
        }

        public double CountProduct { get; set; }

        public override void InfoFor()
        {
            Console.WriteLine($"{Name} - название партии,{Price} - цена партии,{CountProduct} - количство штук ,{DateManufacture} - дата изготовления, {ShelfLife} - Дата изготовления продукта");
        }

    }
}
