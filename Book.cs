using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp65
{
    internal class Book
    {
        private string title;
        private string author;
        private string publisher;
        private int availableCopies;

        public Book(string title, string author, string publisher, int availableCopies)
        {
            this.title = title;
            this.author = author;
            this.publisher = publisher;
            this.availableCopies = availableCopies;
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        public string Publisher
        {
            get { return publisher; }
            set { publisher = value; }
        }

        public int AvailableCopies
        {
            get { return availableCopies; }
            set { availableCopies = value; }
        }

        public void IncreaseCopies(int amount)
        {
            availableCopies += amount;
        }

        public void DecreaseCopies(int amount)
        {
            availableCopies -= amount;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Kitabın adı: " + title);
            Console.WriteLine("Müəllifi: " + author);
            Console.WriteLine("Nəşriyyat: " + publisher);
            Console.WriteLine("Mövcud nüsxələrin sayı: " + availableCopies);
        }
    }
}

