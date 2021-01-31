using System;
using System.Collections.Generic;
using System.Linq;


namespace Assignment_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 1
            Console.WriteLine("Q1 : Enter the number of rows for the traingle:");
            int n = Convert.ToInt32(Console.ReadLine());
            printTriangle(n);
            Console.WriteLine();
            static void printTriangle(int n)
            {
                try
                {
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n - i - 1; j++)
                        {
                            Console.Write(" ");
                        }

                        for (int k = 0; k < 2 * i + 1; k++)
                        {
                            Console.Write("*");
                        }

                        Console.WriteLine();
                    }
                }
                catch (Exception e)
                {

                    Console.WriteLine("Exception caught: {0}", e);
                }

            }
            /* Q1 Comments :
             * We need to display the stars in triangle pattern and numbers of stars to be displayed in
             * odd number of times in a row,the row number is eneterd as an input
             */
            Console.WriteLine();
            //Question 2:
            Console.WriteLine("Q2 : Enter the number of terms in the Pell Series:");
            int n2 = Convert.ToInt32(Console.ReadLine());
            printPellSeries(n2);
            Console.WriteLine();
            static void printPellSeries(int n2)
            {
                try
                {
                    int a = 0;
                    int b = 1;
                    int sum = 0;
                    Console.Write(a);
                    while (n2 > 1)
                    {
                        a = b;
                        b = sum;
                        sum = 2 * b + a;
                        Console.Write("  ");
                        Console.Write(sum);
                        n2--;
                    }
                }
                catch (Exception e)
                {

                    Console.WriteLine("Exception caught: {0}", e);
                }

            }
            /*Q2 Comments: read input value using redaline.console,we have to display the pelle numbers
             * till the value which a user entered.
             * for this we need to use swap numbers to get the desired output.
             */

            Console.WriteLine();
            //Question 3:

            Console.WriteLine("Q3 : Enter the number to check if squareSums exist:");
            int n3 = Convert.ToInt32(Console.ReadLine());
            //int count_sq = 0;
            bool flag = squareSums(n3);
            if (flag)
            {
                Console.WriteLine("Yes, the number can be expressed as a sum of squares of 2 integers");
            }
            else
            {
                Console.WriteLine("No, the number cannot be expressed as a sum of squares of 2 integers");
            }

            static bool squareSums(int n3)
            {
                try
                {
                    int count_sq = 0;
                    for (int m = 0; m <= n3; m++)
                    {
                        for (int o = m; o <= n3; o++)
                        {
                            if (n3 == o * o + m * m)
                            {
                                //Console.WriteLine("the entered value {0} is poitive number", n3);
                                count_sq += 1;
                            }
                            if (count_sq >= 1)
                            {
                                return true;
                            }
                        }
                    }


                }
                catch (Exception e)
                {

                    Console.WriteLine("Exception caught: {0}", e);
                }
                return false;
            }
            /*Q3 Comments : read the number from console and we need to find ,whether the given number 
             * is combination of a*a+b*b , these two values should be less than the entered number.
             * from the code we can see , I have created a counter , if counter value less than or equal to 1
             * then it has satisfied the condition and we can say the entered value is sqauresum of two numbers.Otherwise its not.
             */

            Console.WriteLine();
            //Question 4:
            int[] arr = { 3, 1, 4, 1, 5 };
            Console.WriteLine("Q4: Enter the absolute difference to check");
            int k = Convert.ToInt32(Console.ReadLine());
            int n4 = diffPairs(arr, k);
            Console.WriteLine("There exists {0} pairs with the given difference", n4);
            static int diffPairs(int[] nums, int k)
            {
                try
                {
                    //Console.WriteLine("Enter the difference value : ");
                    //int diff = Convert.ToInt32(Console.ReadLine());
                    int[] ba = new int[5];
                    int count = 0;
                    if (k != 0)
                    {
                        for (int i = 0; i < nums.Length; i++)
                        {
                            ba[i] = nums[i];
                            for (int j = i + 1; j < nums.Length; j++)
                            {

                                if (!ba.Contains(nums[j]))
                                {
                                    if ((k == Math.Abs(nums[i] - nums[j])))
                                    {
                                        ba[j] = nums[j];
                                        count += 1;

                                    }


                                }

                            }

                        }
                        //Console.WriteLine("the count is {0} ", count);
                    }
                    int value = 0;
                    if (k == 0)
                    {
                        for (int i = 0; i < nums.Length; i++)
                        {

                            for (int j = i + 1; j < nums.Length; j++)
                            {

                                if ((nums[i] == nums[j]))
                                {
                                    value += 1;
                                    if (value == 1)
                                    {
                                        count += 1;
                                    }
                                    else
                                    {
                                        break;
                                    }


                                }
                                else
                                {

                                    value = 0;

                                }

                            }

                        }
                        //Console.WriteLine("the count is {0} ", count);
                    }
                    return count;
                }
                catch (Exception e)
                {

                    Console.WriteLine("An error occured: " + e.Message);
                    throw;
                }

            }
            /*Q4 Comments: I have used two if loops for difference is 0 and greater than 0.
             * diff = 0, if loop is to find out the duplicated values and remove duplicated values
             * in an array and to count the difference 0 has got repeated
             * how many times.
             * diff > 0, if loop is used within the same loop used counter to how many times the difference has got reapeated
             */
            Console.WriteLine();

            //Question 5:
            List<string> emails = new List<string>();
            emails.Add("dis.email + bull@usf.com");
            emails.Add("dis.e.mail+bob.cathy@usf.com");
            emails.Add("disemail+david@us.f.com");
            int ans5 = UniqueEmails(emails);
            Console.WriteLine("Q5 : Distinct email id");
            Console.WriteLine("The number of unique emails is " + ans5);
            static int UniqueEmails(List<string> emails)
            {
                try
                {
                    int index = 0;
                    int index1 = 0;
                    for (int i = 0; i < emails.LongCount(); i++)
                    {
                        index = emails[i].IndexOf("@");
                        int len = emails[i].Length - index;

                        index1 = emails[i].Substring(0, index).IndexOf("+");
                        int len1 = index - index1;
                        string s1 = emails[i].Substring(0, index1);

                        string main = s1.Replace(".", "");

                        string mailid = main.Trim() + emails[i].Substring(index, len);

                        emails[i] = mailid;


                    }

                    return emails.Distinct().Count();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    throw;
                }

            }
            /*Q5 Comments : For the given problem I have used index,Trim, Substring,Distinct count.
             * using indexof value for * ,to seperate the email into 2 parts and stored in different string values.
             * Later using substring method, seperated values before the character + and concatenated the value to
             * domain id.Storing the final mailid in the same given array and counted the distinct values in an given array.             * 
             */
            Console.WriteLine();
            //Quesiton 6:
            string[,] paths = new string[,] { { "London", "New York" }, { "New York", "Tampa" },
                                        { "Delhi", "London" } };
            string destination = DestCity(paths);
            Console.WriteLine("Q6 : Destination");
            Console.WriteLine("Destination city is " + destination);
            static string DestCity(string[,] paths)
            {

                try
                {

                    string[] origin = new string[paths.GetLength(0)];
                    string[] destination = new string[paths.GetLength(0)];


                    for (int i = 0; i < paths.GetLength(0); i++)
                    {
                        origin[i] = paths[i, 0];
                        destination[i] = paths[i, 1];
                    }
                    for (int i = 0; i < origin.Length; i++)
                    {
                        for (int j = 0; j < destination.Length; j++)
                        {
                            if (!origin.Contains(destination[j]))
                            {
                                return destination[j];
                            }
                        }
                    }
                }
                catch (Exception e)
                {

                    Console.WriteLine("the error is " + e.Message);
                }
                return "";

            }
            /*Q6 Comments: Seperated origin and destination values from 2d array to 1d array.
             * later finding out the value which is not in origin.
             */


        }
    }
}
