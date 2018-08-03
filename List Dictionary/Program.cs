using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("would you like to receive Name only or name and Grade");
            Console.WriteLine("Enter 'Y' for name and grade or 'N' for Name Only;");
            char c = Convert.ToChar(Console.ReadLine());

            if (c == 'n')
                StudentName();
            if (c == 'y')
                StudentNameAndGrade();



        }
        public static void StudentName()
        {
            List<string> names = new List<string>();
            string name = string.Empty;

            while (name != "q")
            {
                Console.WriteLine(" Enter Student Name:");
                name = Console.ReadLine();
                if (name != "q")
                    names.Add(name);

            }
            foreach (string n in names)
                Console.WriteLine(n);

        }
        public static void StudentNameAndGrade()
        {
            Dictionary<string, int> grades = new Dictionary<string, int>();
            string name = string.Empty;
            int grade = 0;
            
             while (name != "q")
            { 
            
                Console.Write(" Enter Name or Q  to exit:  ");
                name = Console.ReadLine();
                Console.WriteLine("Enter Grade or 0 to exit: ");
                grade = Convert.ToInt32(Console.ReadLine());

                if (name != "q" | grade != 0)
                    grades.Add(name, grade);
                else
                    break;
                   


            }
            foreach (KeyValuePair<string, int> kvp in grades)
                Console.WriteLine("Name = {0}, Grade = {1}.", kvp.Key, kvp.Value);

            Console.ReadKey();
        }
    }
}


