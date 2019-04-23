using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bonus_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberGrade;
            bool continuing = true;
            string letterGrade;

            while (continuing)
            {
                continuing = false;

                Console.WriteLine("Enter a numerical grade: ");
                numberGrade = int.Parse(Console.ReadLine());    

                if (numberGrade >= 88)
                {
                    letterGrade = "A";
                }
                else if(numberGrade <= 87 && numberGrade >= 80)
                {
                    letterGrade = "B";
                }
                else if(numberGrade <= 79 && numberGrade >= 67)
                {
                    letterGrade = "C";
                }
                else if(numberGrade <= 66 && numberGrade >= 60)
                {
                    letterGrade = "D";
                }
                else
                {
                    letterGrade = "F";
                }

                Console.WriteLine("Letter grade: {0}.\nDo you want to continue?(Y/N)", letterGrade);

                string answer = Console.ReadLine();
                if (answer == "Y" || answer == "y")
                {
                    continuing = true;
                }
            }
        }
    }
}
