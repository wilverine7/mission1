using System;

namespace mission1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int rollCount = 0;
            string[] histogram = { "2: ", "3: ", "4: ", "5: ", "6: ", "7: ", "8: ", "9: ", "10: ", "11: ", "12: " };
            string value = "";
            int[] rolls = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };


            Console.WriteLine("Welcome to the dice throwing simulator!");
            Console.Write("How many dice rolls would you like to simulate? ");
            
            value = Console.ReadLine();
            rollCount = Convert.ToInt32(value);

      
            for (int i = 0; i < rollCount; i++)
            {
                
                
                int die1 = rnd.Next(1,7);
                int die2 = rnd.Next(1, 7);
                int num = die1 + die2;

                if (num == 2)
                {
                    rolls[0] += 1;
                }
                else if (num == 3)
                {
                    rolls[1] += 1;
                }
                else if (num == 4)
                {
                    rolls[2] += 1;
                }
                else if (num == 5)
                {
                    rolls[3] += 1;
                }
                else if (num == 6)
                {
                    rolls[4] += 1;
                }
                else if (num == 7)
                {
                    rolls[5] += 1;
                }
                else if (num == 8)
                {
                    rolls[6] += 1;
                }
                else if (num == 9)
                {
                    rolls[7] += 1;
                }
                else if (num == 10)
                {
                    rolls[8] += 1;
                }
                else if (num == 11)
                {
                    rolls[9] += 1;
                }
                else if (num == 12)
                {
                    rolls[10] += 1;
                }
                

            }
            for (int i = 0; i < rolls.Length; i++)
            {
                float percent = (((float)rolls[i] / (float)rollCount) *100);
                for (int x = 0; x < percent; x++)
                {
                    histogram[i] += "*";
                }

            }

            Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
            Console.WriteLine("Total number of rolls = " + rollCount +".");




            for (int i = 0; i < histogram.Length; i++)
            {
                Console.WriteLine(histogram[i]);
            }
            Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");





        }
    }
}
