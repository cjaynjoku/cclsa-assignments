using System;
using System.Collections.Generic;
using System.IO;

namespace Assignment15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IndexOutOfRangeHandler();
            Console.WriteLine();
            OverflowExceptionHandler();
            Console.WriteLine();
            NullReferenceExceptionHandler();
            Console.WriteLine();
            InvalidCastExceptionHandler();
            Console.WriteLine();
            DirectoryNotFoundExceptionHandler();
            Console.WriteLine();
            FileNotFoundExceptionHandler();
            Console.WriteLine();
            FormatExceptionHandler();


            Console.WriteLine();
            // ProductNotFound test
            List<string> products = new List<string>() { "apple", "orange" };
            try
            {
                if (products.Contains("banana"))
                {
                    Console.WriteLine("banana has been added to your cart");
                }
                else
                {
                    throw (new ProductNotFoundException("The product is out of stock."));
                }
            }
            catch (ProductNotFoundException pnfe)
            {
                Console.WriteLine(pnfe.Message);
            }



            Console.WriteLine();
            // LessThanException test

            int a = 7;
            int b = 5;

            try
            {
                if (b < 7)
                {
                    throw (new LessThanException("The number is less than the other."));
                }
                
            }
            catch(LessThanException lte)
            {
                Console.WriteLine(lte.Message);
                Console.WriteLine("You need a larger Number'.");
            }



            Console.WriteLine();
            // InputNotValidExceptionTest
            string input = "rtthj6h54urnggf";
            try
            {
                if(input == "password123")
                {
                    Console.WriteLine("Access Granted");
                }
                else
                {
                    throw (new PasswordNotValidException("Incorrect Password."));
                }
            }
            catch(PasswordNotValidException pnve)
            {
                Console.Write("An error occured: ");
                Console.WriteLine(pnve.Message);
            }

        }







        public static void IndexOutOfRangeHandler()
        {
            int[] intArray = new int[5] { 3, 4, 5, 6, 7 };

            try
            {
                Console.WriteLine(intArray[8]);
            }
            catch(IndexOutOfRangeException iore)
            {
                Console.WriteLine("The index specified is not valid.");
                Console.WriteLine(iore.Message);
            }
        }


        public static void OverflowExceptionHandler()
        {
            double myDouble = 4445433345433455;
            checked
            {
                try
                {
                    sbyte mySByte = (sbyte)myDouble;
                    Console.WriteLine(mySByte);
                }
                catch (OverflowException oe)
                {
                    Console.WriteLine(oe.Message);
                    Console.WriteLine(myDouble + ">" + SByte.MaxValue);
                }
            }
        }

        public static void NullReferenceExceptionHandler()
        {
            string myText = null;
            try
            {
                Console.WriteLine(myText.Length);
            }
            catch(NullReferenceException nre)
            {
                Console.WriteLine(nre.Message);
                Console.WriteLine("null operation is invalid");
            }
        }

        public static void DirectoryNotFoundExceptionHandler()
        {
            string fileLocation = @"C://truth";

            try
            {
                Directory.SetCurrentDirectory(fileLocation);
            }
            catch(DirectoryNotFoundException dnfe)
            {
                Console.WriteLine("Directory not found:");
                Console.WriteLine(dnfe.Message);
            }

            

        }

        public static void InvalidCastExceptionHandler()
        {
            object anObject = "10";
            try
            {
                int x = (int)anObject;
            }
            catch(InvalidCastException ice)
            {
                Console.WriteLine(ice.Message);
            }
        }

        public static void FileNotFoundExceptionHandler()
        {
            string fileName = "santisimo.pfd";
            try
            {
                TextReader reader = new StreamReader(fileName);
                string newLine = reader.ReadLine();
                reader.Close();
            }
            catch(FileNotFoundException fnfe)
            {
                Console.WriteLine(fnfe.Message);
            }
           
        }

        public static void FormatExceptionHandler()
        {
            decimal amount = 3445.664m;
            try
            {
                Console.WriteLine("The amount given is {0:Q44}", amount);
            }
            catch(FormatException fe)
            {
                Console.Write("An exception occured: ");
                Console.WriteLine(fe.Message);
            }
        }
       

    }
    public class ProductNotFoundException : Exception
    {
        public ProductNotFoundException(string message) : base(message)
        {

        }
    }

    public class LessThanException: Exception
    {
        public LessThanException(string message): base(message)
        {

        }
    }


    public class PasswordNotValidException: Exception
    {
        public PasswordNotValidException(string message): base(message)
        {

        }
    }

}
