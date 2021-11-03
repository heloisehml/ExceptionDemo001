using System;

namespace ExceptionDemo001
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exception Demonstration");










            int[] number = new int[2];

            try
            {
                number[0] = 0;
                number[1] = 1;
                number[2] = 2;

                foreach (int i in number)
                {
                    Console.WriteLine(i);
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("An IndexOutOfRangeException was thrown");
                Console.WriteLine(ex.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("A General Exception was thrown");
            }
            finally
            {
                Console.WriteLine("Finished process, exception trhown, have closed all issues");
            }

            try
            {
                Divide(6, 0, "Answer");
            }
            catch(DivideByZeroException ex)
            {

            }
            catch(Exception ex)
            {

            }
            finally
            {

            }
            try
            {
                Show(null, 59);
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        private static void Divide(int a, int b, string s)
        {
            int result = a / b;
            Console.WriteLine($"{s.ToUpper()} : result");
        }

        private static void Show(string fname, int age)
        {
            if(fname is null)
            {
                throw new ArgumentException("parameter fname cannot be null");
            }
            Console.WriteLine($"{fname} is {age} years old");
        }
    }
}
