using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld3
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Part one greeting statement
            //string messageOne = "Hello World!";
            string messageTwo = "I am Spartacus";


            ////Part two set initial Spartacus attributes
            int ageOne = 35;
            int ageTwo = 45;
            //int ageThree = 80;
            //double heightOne = 72.50;
            //double heightTwo = 91.45;
            //float weightOne = 210.0284606f;
            //float weightTwo = 331.12345678f;
            bool isGodLikeOne = true;
            //bool isGodLikeTwo = false;
            //char genderMale = 'M';
            //char genderFemale = 'f';


            ////Part three display variable values
            //Console.WriteLine(messageOne);
            //Console.WriteLine(messageTwo);


            ////Part four mathematical operator, bool and char examples
            //Console.WriteLine(ageOne + ageTwo);// addition example
            //Console.WriteLine(heightOne - heightTwo);//subtraction example
            //Console.WriteLine(weightOne * weightTwo);//multiplication example
            //Console.WriteLine(isGodLikeOne);//bool example
            //Console.WriteLine(genderMale);//char example


            ////Part five variable reassignment
            //ageTwo = 70;
            //heightTwo = 35.12345f;
            //weightTwo = -429.1234573f;


            ////Part six mathematical operator examples
            //Console.WriteLine(ageOne + ageTwo);
            //Console.WriteLine(heightOne - heightTwo);
            //Console.WriteLine(weightOne * weightTwo);
            //Console.WriteLine(ageTwo / ageOne);
            //Console.WriteLine(ageTwo % ageOne);
            //Console.WriteLine(ageThree / ageOne);
            //Console.WriteLine(ageThree % ageOne);


            ////Part seven increment and decrement operator example
            //ageTwo = ageTwo + 1;
            //Console.WriteLine(ageTwo);
            //ageTwo++;
            //Console.WriteLine(ageTwo);
            //ageTwo--;
            //Console.WriteLine(ageTwo);
            //Console.WriteLine("5" == "5");
            //Console.WriteLine(40 != 40);
            //Console.WriteLine(11 < 4);


            ////Part eight concatenation
            //Console.WriteLine(messageOne + " " + messageTwo + ".");
            //Console.WriteLine("I am " +ageOne + "years old, and yes it's " +isGodLikeOne +" I am godlike.");
            //Console.WriteLine("I weigh around " +weightOne + ", and I am around " + heightOne + " inches tall.");
            //Console.WriteLine("I am {0} years old, and yes it's {1} I am godlike.", ageOne, isGodLikeOne);
            //Console.WriteLine("i weigh around {0}, and I am around {1} inches tall", weightOne, heightOne);


            ////Part nine string equality examples
            //Console.WriteLine(messageTwo.Equals(messageOne));
            //Console.WriteLine(messageTwo.Equals("I am Spartacus"));
            //Console.WriteLine(messageTwo.ToUpper());
            //Console.WriteLine(messageTwo.ToLower());


            //Part ten string length examples
            //int messOneLength = messageOne.Length;
            //int messTwoLength = messageTwo.Length;
            //Console.WriteLine("The length of messageOne is " + messageOne.Length);
            //Console.WriteLine("The length of messageTwo is " + messageTwo.Length);
            //Console.WriteLine("The length of messageOne is " + messOneLength);
            //Console.WriteLine("The length of messageTwo is " + messTwoLength);


            //Part eleven conditional examples
            //string city1 = "Vesuvius";
            //string city2 = "Nola";
            //string city3 = "Nuceria";
            //int city1Distance,city2Distance,city3Distance;


            ////solicit user input example
            //Console.WriteLine("What is the distance to {0}?", city1);
            //city1Distance = int.Parse(Console.ReadLine());
            //Console.WriteLine("What is the distance to " + city2 + "?");
            //city2Distance = int.Parse(Console.ReadLine());
            //Console.WriteLine("What is the distance to Nuceria");
            //city3Distance = int.Parse(Console.ReadLine());

            //if ((city1Distance <= 125) && ((city1Distance < city2Distance) && (city1Distance < city3Distance)))
            //{
            //    Console.WriteLine("We will march to Vesuvius");
            //}
            //if ((city2Distance <= 125) && ((city2Distance < city1Distance) && (city2Distance < city3Distance)))
            //{
            //    Console.WriteLine("We will march to Nola");
            //}
            //if ((city3Distance <= 125) && ((city3Distance < city1Distance) && (city3Distance < city2Distance)))
            //{
            //    Console.WriteLine("We will march to Nuceria");
            //}


            //Part twelve if-else and switch statements
            //Console.WriteLine("What is your rank soldier?");
            //string rank = Console.ReadLine().ToLower();
            //Console.WriteLine("What is your age soldier?");
            //int age = int.Parse(Console.ReadLine());
            //Console.WriteLine("What is your job soldier?");
            //string job = Console.ReadLine().ToLower();
            //if((rank == "officer") || (age<= 26))
            //{
            //    Console.WriteLine("Get your gear, kiss your family goodbye, put on your marching boots.");
            //}
            //else if ((job== "cook") || (age>=26))
            //{
            //    Console.WriteLine("My army has to eat. Pack your pots and pans.");
            //}
            //else
            //{
            //    Console.WriteLine("Sorry you are staying home.");
            //}
            //switch(job)
            //{
            //    case "infantry":
            //        Console.WriteLine("You will carry a sword");
            //        break;

            //    case "archers":
            //        Console.WriteLine("You will carry a bow and arrow");
            //        break;

            //   case "supply":
            //        Console.WriteLine("You will carry pots and pans");
            //        break;

            //    case "specialist":
            //        Console.WriteLine("You will operate the catapult");
            //        break;

            //    default:
            //        Console.WriteLine("You will ride horseback");
            //        break;
            //}

            // Part Thirteen array examples

            //string[] foodList = new string[5];
            //foodList[0] = "Milk";
            //foodList[1] = "Fruit";
            //foodList[2] = "Meat";
            //foodList[3] = "Wine";
            //foodList[4] = "Bread";
            //Console.WriteLine(" {0}, {1},{2}, {3}, {4}",foodList[0],foodList[1], foodList[2],foodList[3],foodList[4]);
            //int[] foodAmount = new int[5];
            //foodAmount[0] = 1000;
            //foodAmount[1] = 100;
            //foodAmount[2] = 2000;
            //foodAmount[3] = 10000;
            //foodAmount[4] = 1500;
            //Console.WriteLine(" {0}, {1},{2}, {3}, {4}", foodAmount[0], foodAmount[1], foodAmount[2], foodAmount[3], foodAmount[4]);
            //Console.WriteLine(foodList[0] + ":" + foodAmount[0] + "," + foodList[1] + ":" + foodAmount[1] + "," + foodList[2]+ ":" + foodAmount[2] + "," + foodList[3] + ":" + foodAmount[3]+","+ foodList[4]+":"+foodAmount[4]);
            //Console.WriteLine(foodList.Length);

            //Part Fourteen loops examples
            //string[] elements = messageTwo.Split(' ');
            //Console.WriteLine(elements[0]);// Prints "I"
            //Console.WriteLine(elements[1]);// Prints "am"
            //Console.WriteLine(elements[2]);// Prints "Spartacus"
            //Console.WriteLine(elements.Length);

            //Part fifteen character array
            //string myName = "Sue";
            //char[] letters = myName.ToCharArray();
            //Console.WriteLine(letters[0]);
            //Console.WriteLine(letters[1]);
            //Console.WriteLine(letters[2]);

            // Part sixteen while and do while loops examples
            //string action = " ";
            //while (action != "exit")
            //{
            //    Console.WriteLine("What is your rank soldier?");
            //    string rank = Console.ReadLine();
            //    Console.WriteLine("What is your age soldier?");
            //    int age = int.Parse(Console.ReadLine());
            //    Console.WriteLine("What is your job soldier?");
            //    string job = Console.ReadLine();
            //    if ((rank == "officer") || (age <= 26))
            //    {
            //        Console.WriteLine("Get your gear, kiss your family goodbye, put on your marching boots.");
            //    }
            //    else if ((job == "cook") || (age >= 26))
            //    {
            //        Console.WriteLine("My army has to eat. Pack your pots and pans.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Sorry you are staying home.");
            //    }
            //    Console.WriteLine("Add another? Type exit to quit");
            //    action = Console.ReadLine();
            //}
            //string action = " ";
            //do
            //{
            //    Console.WriteLine("What is your rank soldier?");
            //    string rank = Console.ReadLine();

            //    Console.WriteLine("What is your age soldier?");
            //    int age = int.Parse(Console.ReadLine());
            //    Console.WriteLine("What is your job soldier?");
            //    string job = Console.ReadLine();

            //    if ((rank == "officer") || (age <= 26))
            //    {
            //        Console.WriteLine("Get your gear, kiss your family goodbye, put on your marching boots.");
            //    }
            //    else if ((job == "cook") || (age >= 26))
            //    {
            //        Console.WriteLine("My army has to eat. Pack your pots and pans");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Sorry you are staying home.");
            //    }
            //    Console.WriteLine("Add another? Type exit to quit");
            //    action = Console.ReadLine();
            //} while (action != "exit");

            //Part seventeen for-loop examples
            //for (int i = 0; i<foodAmount.Length; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //for (int i = 0; i < foodAmount.Length; i++)
            //{
            //    Console.WriteLine("Enter a value for " + foodList[i]);
            //    foodAmount[i] = int.Parse(Console.ReadLine());
            //}

            //Part eighteen nested for loops
            //int size = 5;    //Equals the max number of columns and rows
            //int i, k;
            //for (i = 0; i <= size; i++)
            //{
            //    for (k = 0; k < i; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine("");
            //}
            //Console.ReadLine();

            //Part nineteen method calls
            ageOne = 34;
            bool isGodLike = true; // I am not showing all the code.
            isGodLikeOne = IsGodLike(ageOne);
            Console.WriteLine("To say our hero is God like is " + isGodLikeOne);
            Console.WriteLine(Reverse(messageTwo));
        }
        static bool IsGodLike(int age)
        {
            bool status;
            if (age % 2 == 0)
            {
                status = false;
            }
            else
            {
                status = true;
            }
            return status;
        }
        static string Reverse(string text)
        {
            char[] cArray = text.ToCharArray();
            string reverse = " ";
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverse += cArray[i];
            }
            return reverse;
        }
        static int[] Reverse(string text)
        {
            char[] cArray = text.ToCharArray();
            string reverse = " ";
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverse += cArray[i];
            }
            return reverse;
        }
    }
}

