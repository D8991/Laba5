using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Book : Good
    {
        public string Book_Author { get; set; }
        public string Book_Genre { get; set; }
        public string Book_Publisher { get; set; }

        public Book(Sale Good_Name, string Book_Title, double Price, string Book_Author, string Book_Genre, string Book_Publisher) : base(Good_Name, Book_Title, Price)


        {
            this.Book_Author = Book_Author;
            this.Book_Genre = Book_Genre;
            this.Book_Publisher = Book_Publisher;

        }
        public override void Get_Info()
        {
            Console.WriteLine("Наименование - " + Good_Name.ToString() + "; Заголовок -  " + Book_Title.ToString() + "; Цена - " + Price.ToString()+ "; Автор - " + Book_Author.ToString()+"; Жанр -  "+Book_Genre.ToString()+"; Издательство -  " + Book_Publisher.ToString());

        }
    }
    }
