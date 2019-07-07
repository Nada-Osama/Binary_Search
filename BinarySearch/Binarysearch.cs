using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Binarysearch<T>
    {
        public String Search (T[] list, T item)
        {
            Comparer<T> comparer = Comparer<T>.Default;
            int low = 0, high = list.Length - 1;
            while ( low <= high )
            {
                int mid = (low + high) / 2;
                if ((list[mid]).Equals(item))
                    return mid.ToString();
                if (comparer.Compare(list[mid], item) > 0)
                    high = mid - 1;
                else
                    low = mid + 1;
            }
            return "Not found in this list!";
        }
    }
}
