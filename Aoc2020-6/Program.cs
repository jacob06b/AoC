using System;

namespace Aoc // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(twentysix());


            int twentysix()
            {
                int counter = 0;
                using (StreamReader sr = new StreamReader("PuzzleInput.txt"))
                {
                    HashSet<char> group = new HashSet<char>();
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        

                        foreach (char i in line)
                        {
                            group.Add(i);
                        }
                        if (line == "")
                        {
                            
                            counter += group.Count();
                            group.Clear();

                        }
                    }
                    return counter;

                }


            }

        }

        
    }
    
    
        
    
}