using Eighth_lesson.Store;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace Tenth_lesson
{

    internal class Program
    {
        static void Main(string[] args)
        {

            //Задание 0:

            //1.У вас есть следующая коллекция:

            ArrayList list = new ArrayList();

            //try
            //{
            //    object s = list[18];
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.ToString());
            //}

            //2.Необходимо создать коллекцию Dictionary, в которой будет находиться 10
            //различных пар объектов.Необходимо вывести содержимое коллекции на экран

            //Dictionary<int,string> dict = new Dictionary<int,string>();
            //for (int i = 0; i < 10; i++)
            //{
            //    dict.Add(i, $"{i}");
            //    Console.WriteLine(dict[i]);
            //}

            //3.Пользователь вводит набор чисел в виде одной строки "1, 2, 3, 4, 4, 5".
            //Избавиться от повторяющихся элементов в строке и вывести результат на экран.

            //string a = "1, 2, 3, 4, 4, 5";

            //Console.WriteLine(String.Join("", a.Distinct())); // <= Ну я то избавался а вот как оно избавило это уже интересно :)




            //Предисловие: Данное задание выполняется на основе готового решения Задания 2 из
            //темы «Наследование»

            //Задание 1:

            //а) Создать динамический массив, содержащий объекты класса Product

            List<Product> products =
           [
               new Product("Молоко", 5.5, "15.06.2023", "15.06.2023-15.07.2024"),
               new Product("Хлеб", 6.6, "12.12.2022", "12.12.2022-20.12.2024"),
               new Product("Яйца", 7.7, "01.05.2022", "01.05.2022-01.05.2024"),
               new Product("Мясо", 302, "10.09.2023", "10.09.2023-15.09.2024"),
               new Product("Сыр", 301, "03.08.2023", "03.08.2023-10.08.2024"),
           ];

            //б) Распечатать его содержимое используя for each.

            //foreach (Product product in products )
            //{
            //    product.InfoFor();
            //}

            //в) Изменить цену одного продукта на 100.

            //products[0].Price = 5.6;
            //products[0].InfoFor();

            //г) Удалить последний продукт.

            //products.Remove(products.Last());

            //е) Получить массив содержащий продукты из коллекции тремя способами и вывести на
            //консоль.

            // ???

            //ж) Удалить все продукты.

            //products.RemoveAll(products.Contains);



            //Задание 2:

            //Создать SortedSet содержащий объекты Product.Содержимое данной коллекции
            //распечатать с помощью for each.

            //List<Set> sortedSet = [
            //      new Set("МЕГА СЕТ ПРОДУКТОВ ", 99.99, products)
            //    ];
            //foreach (Set set in sortedSet)
            //{
            //    set.InfoFor();
            //}



            //Задание 3:

            //Создать коллекцию, содержащую объекты Product. Написать метод, который перебирает
            //элементы коллекции и проверяет цену продуктов.Если цена продукта больше 300
            //рублей, продукт перемещается в другую коллекцию.
            //Необходимо вывести минимальное значение продукта из полученной коллекции

            //List<Product> sortProdut = new List<Product>();

            //sortProdut = GetMeinProduct(products);

            //products.RemoveAll(q => sortProdut.Contains(q));

            //Console.WriteLine(sortProdut.Min(q => q.Price));



            //Задание 4:

            //Создайте Dictionary, содержащий пары значений -имя продукта и количестов единиц
            //продукта(класс Product).
            //Перебрать и распечатать пары значений в формате "Name = abc, Price = 15, Count = 5"
            //Перебрать и распечатать набор из имен продуктов
            //Перебрать и распечатать значения количества единиц продуктов.
            //Для каждого перебора создать свой метод.

            Dictionary<string, int> sortProduct = new Dictionary<string, int>();
            Random rand = new Random();

            for (int i = 0; i < products.Count; i++)
            {
                sortProduct.Add(products[i].Name, rand.Next(1, 99));
                Console.WriteLine($"Name = {products[i].Name}, Price = {products[i].Price}, Coint = {sortProduct[products[i].Name]}");
            }


            //Задание 5:

            //На основе задания 4 необходимо написать преобразование Dictionary в List.

            List<string> sortList = sortProduct.Select(q=>q.Key).ToList(); 

            //На основе задания 3 необходимо написать преобразование List в Dictionary.

            var res = sortList.ToDictionary(x => x, x => x);


        }
        public static List<Product> GetMeinProduct(List<Product> products)
        {
            List<Product> sortProdut = new List<Product>();
            sortProdut = products.Where(q => q.Price > 300).ToList();

            return sortProdut;
        }
    }
}
