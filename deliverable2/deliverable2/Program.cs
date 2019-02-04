using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deliverable2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] userAnswers = new string[3];
            Console.WriteLine("Hello user, what are you in the mood for?");
            Console.WriteLine("1) Action");
            Console.WriteLine("2) Chill Times");
            Console.WriteLine("3) Danger");
            Console.WriteLine("4) Good Food");

            bool correctResponse1 = false;
            while (correctResponse1 == false)
            {
                int entry1 = Convert.ToInt16(Console.ReadLine());

                switch (entry1)
                {
                    case 1:
                        userAnswers[0] = "action";
                        userAnswers[1] = "go stock car racing";
                        correctResponse1 = true;
                        break;
                    case 2:
                        userAnswers[0] = "chill times";
                        userAnswers[1] = "go hiking";
                        correctResponse1 = true;
                        break;
                    case 3:
                        userAnswers[0] = "danger";
                        userAnswers[1] = "skydiving";
                        correctResponse1 = true;
                        break;
                    case 4:
                        userAnswers[0] = "good food";
                        userAnswers[1] = "go to Taco Bell";
                        correctResponse1 = true;
                        break;
                    default:
                        Console.WriteLine("I didn't understand your response please enter an integer 1-4");
                        correctResponse1 = false;
                        break;
                }
            }

            Console.WriteLine("How many people are you bringing with you?");

            bool correctResponse2 = false;
            while (correctResponse2 == false)
            {
                int entry2 = Convert.ToInt16(Console.ReadLine());
                switch (entry2)
                {

                    case int n when (n < 1 && n > -1):
                        userAnswers[2] = "some sneakers";
                        correctResponse2 = true;
                        break;
                    case int n when (n >= 1 && n < 5):
                        userAnswers[2] = "a sedan";
                        correctResponse2 = true;
                        break;
                    case int n when (n >= 5 && n <= 10):
                        userAnswers[2] = "a Volkswagen bus";
                        correctResponse2 = true;
                        break;
                    case int n when (n >= 11):
                        userAnswers[2] = "an airplane";
                        correctResponse2 = true;
                        break;
                    default:
                        Console.WriteLine("I didn't understand your response please enter an integer value greater than  or equal to 0");
                        break;
                }
            }
            Console.WriteLine("Okay!  If you're in the mood for {0} then you should {1} and travel in {2}", userAnswers[0], userAnswers[1], userAnswers[2]);
            Console.WriteLine("Goodbye");

        }
    }
}
