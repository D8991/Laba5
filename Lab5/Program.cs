using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Good> ListGood = new List<Good>();
            Sale book_Sale = new Sale("Книга");
            Sale journal_Sale = new Sale("Журнал");
            Sale notebook_Sale = new Sale("Тетрадь");

            ListGood.Add(new Book(book_Sale, "Мастер и маргарита", 250, "Булгаков", "Роман", "Эксмо"));
            ListGood.Add(new Book(book_Sale, "Война и мир", 350, "Толстой", "Роман", "Эксмо"));
            ListGood.Add(new Good(notebook_Sale, "Животные", 60));
            ListGood.Add(new Journal (journal_Sale, "Вестник", 150, new DateTime (2018, 01, 13)));
            ListGood.Add(new Good(notebook_Sale, "Цветы", 60));
            ListGood.Add(new Book(book_Sale, "Преступление и наказание", 300, "Достоевский", "Роман", "Эксмо"));
            ListGood.Add(new Journal(journal_Sale, "Наука", 160, new DateTime (2018,03,15)));

            foreach (Good g in ListGood)
            {
                g.Get_Info();
            }
            Console.ReadLine();
        }
    }
}

