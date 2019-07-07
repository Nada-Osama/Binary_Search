using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the item you are searching for: ");
            int my_item = int.Parse(Console.ReadLine());
            int[] my_list = { 1, 3, 5, 7, 9 };
            Binarysearch<int> binsrch = new Binarysearch<int>();
            Console.WriteLine( binsrch.Search(my_list, my_item) );
        }
    }
}
