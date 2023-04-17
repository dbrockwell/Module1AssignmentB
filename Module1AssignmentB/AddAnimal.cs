using System;

namespace us.mattgreen
{
    public class AddAnimal
    {
        private int animalType;

        public void enterType()
        {
            Console.WriteLine("What animal would you like to enter");
            Console.WriteLine("1. Cat");
            Console.WriteLine("2. Dog");
            Console.WriteLine("3. Teacher");
            bool isCorrect = false;
            do
            {
                try
                {
                    animalType = Int32.Parse(Console.ReadLine());
                    if (animalType == 1 || animalType == 2 || animalType == 3)
                    {
                        isCorrect = true;
                    }
                    else
                    {
                        Console.WriteLine("Enter one of the numbers");
                    }
                }
                catch
                {
                    Console.WriteLine("Enter one of the numbers");
                }
            } while (isCorrect == false);
        }

        public Talkable newAnimal()
        {
            if (animalType == 1)
            {
                Console.WriteLine("Enter name");
                string name = Console.ReadLine();
                int miceKilled = 0;
                bool isCorrect = false;
                do
                {
                    Console.WriteLine("Enter number of mice killed");
                    try
                    {
                        miceKilled = Int32.Parse(Console.ReadLine());
                        isCorrect = true;
                    }
                    catch
                    {
                        Console.WriteLine("Enter a valid number");
                    }
                } while (isCorrect == false);

                return new Cat(miceKilled, name);
            }
            
            if (animalType == 2)
            {
                Console.WriteLine("Enter name");
                string name = Console.ReadLine();
                bool isFriendly = false;
                bool isCorrect = false;
                do
                {
                    Console.WriteLine("Is dog friendly? (Y/N)");
                    string yOrN = Console.ReadLine().ToUpper();
                    if (yOrN == "Y")
                    {
                        isFriendly = true;
                        isCorrect = true;
                    }
                    else if (yOrN == "N")
                    {
                        isFriendly = false;
                        isCorrect = true;
                    }
                    else
                    {
                        Console.WriteLine("Please enter either Y or N");
                    }
                } while (isCorrect == false);

                return new Dog(isFriendly, name);
            }

            if (animalType == 3)
            {
                Console.WriteLine("Enter name");
                string name = Console.ReadLine();
                int age = 0;
                bool isCorrect = false;
                do
                {
                    Console.WriteLine("Enter age");
                    try
                    {
                        age = Int32.Parse(Console.ReadLine());
                        isCorrect = true;
                    }
                    catch
                    {
                        Console.WriteLine("Enter a valid number");
                    }
                } while (isCorrect == false);

                return new Teacher(age, name);
            }
            else
            {
                return new Teacher(0, "Unknown");
            }
        }
    }
}