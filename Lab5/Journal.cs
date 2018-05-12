using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Journal : Good
    {
        public DateTime DataOfPublic { get; set; }


        public Journal(Sale Good_Name, string Book_Title, double Price, DateTime DataOfPublic) : base(Good_Name, Book_Title, Price)
        {
            this.DataOfPublic = DataOfPublic;

        }
        public override void Get_Info()
        {
            Console.WriteLine("Наименование - "+ Good_Name.ToString() + "; Заголовок - " + Book_Title.ToString() + "; Цена - " + Price.ToString() + "; Дата выпуска - " + DataOfPublic.ToString());

        }
    }
}
