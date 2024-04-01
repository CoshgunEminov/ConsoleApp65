namespace ConsoleApp65
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Kitabın Adı", "Müəllifin Adı", "Nəşriyyatın Adı", 10);
            book.DisplayInfo();

            Console.WriteLine("nNüsxələrin sayını artırmaq:");
            book.IncreaseCopies(5);
            book.DisplayInfo();

            Console.WriteLine("nNüsxələrin sayını azaltmaq:");
            book.DecreaseCopies(3);
            book.DisplayInfo();
        }
  }
    }
