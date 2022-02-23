using System;

namespace week4Task2Portf
{
    class Program
    {

        

        static public void SelectionSort(Book[] a)
        {
            for (int i = 0; i < a.Length - 1; i++)
            {
                // find the position of the smallest number
                // in the array starting at a[i] and ending in [a.length-1]
                // swap it with the beginning of the array
                int smallest = i;
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[j].CompareTo(a[smallest]) < 0)
                    {
                        smallest = j;
                    }
                }
                swap(ref a[i], ref a[smallest]);
            }
        }
        static void swap<T>(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }


        static void Main(string[] args)
        {
            // Code to construct an array of Book

            string[] titles = {"Writing Solid Code",
                "Objects First","Programming Gems",
                "Head First Java","The C Programming Language",
                "Mythical Man Month","The Art of Programming",
                "Coding Complete","Design Patterns",
                "ZZ"};
            string[] authors = { "Maguire", "Kolling", "Bentley", "Sierra", "Richie", "Brooks", "Knuth", "McConnal", "Gamma", "Weiss" };
            string[] isbns = { "948343", "849328493", "38948932", "394834342", "983492389", "84928334", "4839455", "21331322", "348923948", "43893284",
                "9483294", "9823943" };

            Book[] library = new Book[10];

            // fill an array of books
            for (int i = 0; i < library.Length; i++)
            {
                library[i] = new Book(isbns[i], titles[i], authors[i]);

            }
            Console.WriteLine("Before sorting");
            for(int i = 0; i < library.Length; i++)
            {
                Console.WriteLine(library[i]);
            }
            
            SelectionSort(library);
            Console.WriteLine("After sorting");
            for (int i = 0; i < library.Length; i++)
            {
                Console.WriteLine(library[i]);
            }
        }
    }
}
