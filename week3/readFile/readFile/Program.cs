using System;
using System.IO;

namespace readFile
{
    class Program
    {
        static void Main(string[] args)
        {
            readFile("textFile.txt");
        }
        static void readFile(string textFile)
        {
            const int MAX_FILE_LINES = 50000;
            string[] AllLines = new string[MAX_FILE_LINES];

            //reads from bin/DEBUG subdirectory of project directory
            AllLines = File.ReadAllLines(textFile);


            foreach (string line in AllLines)
            {
                //split words using space , . ?
                string[] words = line.Split(' ', ',', '.', '?', ';', ':', '!');
                foreach (string word in words)
                    if (word != "")
                    {
                        Console.Write("" + word.ToLower());
   
                    }

            }

        }
    }
}
