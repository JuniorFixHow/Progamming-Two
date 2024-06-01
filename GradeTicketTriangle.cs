using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOne
{
    internal class GradeTicketTriangle
    {
        private static char Grade()
        {
            char grade;
            Console.WriteLine("Grading system");
            Console.WriteLine("\nEnter your score (0 - 100): ");
            try
            {
                int score = Convert.ToInt32(Console.ReadLine());
                if (score < 0 || score > 100)
                {
                    return '\0';
                }
                switch (score)
                {
                    case >= 90:
                        grade = 'A';
                        return grade;
                    case >= 80:
                        grade = 'B';
                        return grade;
                    case >= 70:
                        grade = 'C';
                        return grade;
                    case >= 60:
                        grade = 'D';
                        return grade;
                    case < 60:
                        grade = 'F';
                        return grade;
                }
            }
            catch (FormatException)
            {
                return '\0';
            }
            
           
        }

        private static int Ticket()
        {
            int discount = 7;
            int grossPrice = 10;
            int price;
            Console.WriteLine("\n\nTicket System");
            Console.WriteLine("\nEnter your age: ");
            try
            {
                int age = Convert.ToInt32(Console.ReadLine());
                if (age < 0)
                {
                    return -1;
                }
                else if (age >= 65 || age <= 12)
                {
                    price = grossPrice - discount;
                }
                else
                {
                    price = grossPrice;
                }
                return price;
            }
            catch (FormatException)
            {
                return -1;
            }
        }

        private static string Traingle()
        {
            string triangle;

            try
            {
                Console.WriteLine("\n\nTriangle Type ");
                Console.WriteLine("\nEnter side 1: ");
                double side1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter side 2: ");
                double side2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter side 3: ");
                double side3 = Convert.ToDouble(Console.ReadLine());

                if (side1 <= 0 || side2 <= 0 || side3 <= 0)
                {
                    return "Error: Invalid side length(s) entered.";
                }

                if ((side1 == side2) && (side1 == side3))
                {
                    triangle = "Equilateral";
                }
                else if ((side1 == side2) && (side1 != side3))
                {
                    triangle = "Isosceles";
                }
                else if ((side1 == side3) && (side1 != side2))
                {
                    triangle = "Isosceles";
                }
                else if ((side2 == side3) && (side2 != side1))
                {
                    triangle = "Isosceles";
                }
                else
                {
                    triangle = "Scalene";
                }
            }
            catch (FormatException)
            {
                return "Error: Invalid input. Please enter valid numbers for the side lengths.";
            }

            return triangle;
        }


        public static void getGrade()
        {
            char grade = Grade();
            if(grade == '\0')
            {
                Console.WriteLine("\n\nEnter correct Score");
            }
            else
            {
                Console.WriteLine($"\n\nYou had {grade}");
            }
        }

        public static void getTicket()
        {
            int ticket = Ticket();
            if(ticket == -1)
            {
                Console.WriteLine("\n\nEnter correct age");
            }
            else
            {
                Console.WriteLine($"\n\nTicket price is GHC {ticket}");
            }
        }

        public static void getTriangle()
        {
            string triangle = Traingle();
            Console.WriteLine($"\n\n{triangle}");
        }
    }
}
