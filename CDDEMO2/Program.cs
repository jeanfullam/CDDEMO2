/*
 * Purpose Demonstrate a class composition
 * Input: Artist.cs, CD.cs
 * Output: CD[]
 * Author: Jean Fullam
 * Date: 14/11/2022
 */
using CDDEMO2;

namespace CDClassDemo
{
    internal class Program
    {
        const int PhysicalSize = 25;
        static void Main(string[] args)
        {
            CD[] cds = new CD[PhysicalSize];
            int logicalSize;

            try
            {
                logicalSize = LoadArray(cds, PhysicalSize);
                DisplayArray(cds, logicalSize);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }//end of main
        static int GetSafeInt(string prompt)
        {
            bool isValid = false;
            int number = 0;
            do
            {
                try
                {
                    Console.Write(prompt);
                    number = int.Parse(Console.ReadLine());
                    isValid = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input ... please try again");
                }
            } while (!isValid);
            return number;
        }//end fo GetSafeInt
        static string GetSafeString(string prompt)
        {
            bool isValid = false;
            string text;
            do
            {

                Console.Write(prompt);
                text = Console.ReadLine();
                if (text.Length > 0)
                {
                    isValid = true;
                }
                else
                {
                    Console.WriteLine($"No text entered ... Please try again.");
                }


            } while (!isValid);
            return text;
        }//end fo GetSafeString
        static double GetSafeDouble(string prompt)
        {
            bool isValid = false;
            double number = 0;
            do
            {
                try
                {
                    Console.Write(prompt);
                    number = double.Parse(Console.ReadLine());
                    isValid = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input ... please try again");
                }
            } while (!isValid);
            return number;
        }
        static CD CreateCD()
        {
            string title,
                firstname,
                lastname;
            int tracks;
            double price;
            title = GetSafeString($"{"Enter CD title: ",28}");
            firstname = GetSafeString($"{"Enter Artsits first name: ",28}");
            lastname = GetSafeString($"{"Enter Artsits last name: ",28}");
            tracks = GetSafeInt($"{"Enter number of tracks: ",28}");
            price = GetSafeDouble($"{"Enter CD price: ",28}");

            //Artist artist = new Artist(firstname, lastname);
            //CD cd = new CD(title, artist, tracks, price);
            CD cd = new CD(title, new Artist(firstname, lastname), tracks, price);
            return cd;
        }// end of CreateCD
        static int LoadArray(CD[] cds, int size)
        {
            int logicalSize = 0;
            char another;

            do
            {
                //create a CD object & store the CD object in the array
                cds[logicalSize] = CreateCD();
                // increment logicalSize
                logicalSize++;
                //check to make sure the array is not full
                if (logicalSize < size)
                {
                    // prompt to add another CD
                    Console.Write("Add another CD (y/n): ");
                    another = char.Parse(Console.ReadLine().ToLower().Substring(0, 1));
                }
                else
                {
                    another = 'n';
                }

            } while (another == 'y');
            return logicalSize;
        }// end of Load Array

        static void DisplayArray(CD[] CDS, int size)
        {
            //column headings
            Console.WriteLine($"{"Title",-20}{"Artist",-20}{"Price",8}");
            for (int index = 0; index < size; index++)
            {
                Console.WriteLine(CDS[index].CDInfo());
            }
        }//end of DisplayArray
    }
}
