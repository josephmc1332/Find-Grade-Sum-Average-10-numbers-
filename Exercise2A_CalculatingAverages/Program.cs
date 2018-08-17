using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2A_CalculatingAverages
{
    class Program
    {
        static void Main(string[] args)
        {
            //ask user for the 10 grades
            Console.WriteLine("Please enter the 10 grades for the term");
            
            //user acknowledge
            Console.ReadLine();
            
            //ask for first grade
            Console.WriteLine("What is the first grade");
            //user input is converted into integer
            int firstGrade = Convert.ToInt32(Console.ReadLine());

            //ask for second grade
            Console.WriteLine("what is the second grade");
            //convert second number
            int secondGrade = Convert.ToInt32(Console.ReadLine());

            //ask for third number then convert to int
            Console.WriteLine("what is the third grade");
            int thirdGrade = Convert.ToInt32(Console.ReadLine());

            //ask for fourth number then convert to int
            Console.WriteLine("what is the fourth grade");
            int fourthGrade = Convert.ToInt32(Console.ReadLine());

            //ask for fifth number then convert to int
            Console.WriteLine("what is the fifth grade");
            int fifthGrade = Convert.ToInt32(Console.ReadLine());

            //ask for sixth number then convert to int
            Console.WriteLine("what is the sixth grade");
            int sixthGrade = Convert.ToInt32(Console.ReadLine());

            //ask for seventh number then convert to int
            Console.WriteLine("what is the seventh grade");
            int seventhGrade = Convert.ToInt32(Console.ReadLine());

            //ask for eighth number then convert to int
            Console.WriteLine("what is the eighth grade");
            int eighthGrade = Convert.ToInt32(Console.ReadLine());

            //ask for nineth number then convert to int
            Console.WriteLine("what is the nineth number");
            int ninethGrade = Convert.ToInt32(Console.ReadLine());

            //ask for tenth number then convert to int
            Console.WriteLine("what is the tenth grade");
            int tenthGrade = Convert.ToInt32(Console.ReadLine());

            //formula to find sum of total grades
            int sumOfGrades = firstGrade + secondGrade + thirdGrade
                + fourthGrade + fifthGrade + sixthGrade + seventhGrade
                + eighthGrade + ninethGrade + tenthGrade;

            //convert sum of grades to string
            string addGrades = sumOfGrades.ToString();

            //tell user the sum of total grades
            Console.WriteLine($"The sum of the grades you entered is: {addGrades}");

            //find total average of grades entered
            int intGradeAverage = (firstGrade + secondGrade + thirdGrade
                + fourthGrade + fifthGrade + sixthGrade + seventhGrade
                + eighthGrade + ninethGrade + tenthGrade) / 10;

            //convert average to string
            string gradeAverage = intGradeAverage.ToString();

            //tell user the average of their grades
            Console.WriteLine($"The average of the grades you entered is: {gradeAverage}");

            //if range between 90-100 it is A
            if (intGradeAverage > 89)
            {
                Console.WriteLine("your grade is an A");
            }
            //if range between 80-90 it is B
            if (intGradeAverage > 79 && intGradeAverage < 90)
            {
                Console.WriteLine("your grade is an B");
            }
            //if range between 70-80 it is C
            if (intGradeAverage > 69 && intGradeAverage < 80)
            {
                Console.WriteLine("your grade is an C");
            }
            //if range between 60-70 it is D
            if (intGradeAverage > 59 && intGradeAverage < 70)
            {
                Console.WriteLine("your grade is an D");
            }
            //if below 0-59 it is F
            if (intGradeAverage < 60)
            {
                Console.WriteLine("your grade is an F");
            }



            Console.ReadLine();

        }
    }
}
