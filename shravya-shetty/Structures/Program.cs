using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    struct Books
    {
        public string title;
        public string author;
        public string subject;
        public int book_id;
    };

    public class testStructure
    {
        public static void Main(string[] args)
        {

            Books Book1;  
            Books Book2;   

          
            Book1.title = "C Programming";
            Book1.author = "Ali";
            Book1.subject = "C Programming Tutorial";
            Book1.book_id = 6495;

           
            Book2.title = "C# Learning";
            Book2.author = "Bradd Lewis";
            Book2.subject = "Learning from basics";
            Book2.book_id = 6496;

          
            Console.WriteLine("Book 1 title : {0}", Book1.title);
            Console.WriteLine("Book 1 author : {0}", Book1.author);
            Console.WriteLine("Book 1 subject : {0}", Book1.subject);
            Console.WriteLine("Book 1 book_id :{0}", Book1.book_id);

          
            Console.WriteLine("Book 2 title : {0}", Book2.title);
            Console.WriteLine("Book 2 author : {0}", Book2.author);
            Console.WriteLine("Book 2 subject : {0}", Book2.subject);
            Console.WriteLine("Book 2 book_id : {0}", Book2.book_id);

            Console.ReadKey();

        }
    }
}