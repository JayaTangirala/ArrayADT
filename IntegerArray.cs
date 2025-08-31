using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayADT
{
    internal class IntegerArray
    {
        private int[] A;
        private int maxLength;
        private int length;
        public IntegerArray(int n)
        {
            maxLength = n;
            A = new int[maxLength];
            length = 0;
        }

        public void traverse()
        {
            if (length == 0)
                Console.WriteLine("Array is empty");
            else
            {
                Console.WriteLine("Elements in Array are: ");
                foreach (int element in A)
                    Console.Write(element + "\t");
                Console.WriteLine();
            }
        }

        public void insert(int index, int element)
        {
            if (index < 0 || index > length)
            {
                Console.WriteLine("Invalid index.");
                return;
            }

            if (length == maxLength)
            {
                Console.WriteLine("Cant insert the element, No space available in the array");
                return;
            }
            else
            {
                for (int i = length; i > index; i--)
                    A[i] = A[i - 1];
                A[index] = element;
                length++;
                Console.WriteLine(element + " is inserted at "+index+ " successfully");
            }
        }
        public int search(int element)
        {
            return (Array.IndexOf(A, element));
        }
        public void delete(int element)
        {
            int index = Array.IndexOf(A, element);
            if (index == -1)
            {
                Console.WriteLine(element +" not found!");
                return;
            }
            for (int i = index; i < length; i++)
                A[i] = A[i + 1];
            length--;
            Console.WriteLine(element + " deleted successfully!");
        }
    }
}
