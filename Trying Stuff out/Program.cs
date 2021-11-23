using System;

namespace Trying_Stuff_out
{
    class Program
    {
        static void Main(string[] args)
        {
            int result1 = 0;
            Console.Title = "Hello World";
            Console.WriteLine("We are testing Stuff out!");
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Please enter your surname: ");
            string surname = Console.ReadLine();
            Console.Write("Please enter your password: ");
            string password = Console.ReadLine();
            //Console.Write("Please enter your age: ");
            //int age = int.Parse(Console.ReadLine());
            //if (age < 18)
            //{
            //    Console.WriteLine("Thank You for coming! Now leave");
            //}
            //else if(age >= 18)
            //{

            //    Console.Clear();
            //    GetMenu(result1, name, surname);
                
                
            //}

            Done();
            Console.ReadLine();


        }
        static void Done()
        {
            Console.WriteLine("Thank you, Good bye ;-)");
        }
        static int GetMenu(int result, string name, string surname)
        {
            Console.WriteLine("Welcome " + name + " " + surname);
           int count = 0;
            while (count <=2 )
            {
                Console.WriteLine("Select from the Menu below what you'd like to do");
                Console.WriteLine("1. Change your surname \n2. Change first name \n3.Add Cellphone number \n4. Exit");
                Console.Write("Your response: ");
                result = int.Parse(Console.ReadLine());
                if (result == 1)
                {
                    SurnameChange();
                }
                else if (result == 2)
                {
                    NameChange();
                }
                else if (result == 3)
                {
                    CellphoneNumberUpdate();
                }
                else if(result == 4)
                {
                    
                    break;
                }
                else
                {
                    Console.WriteLine("You have entered an invalid option");
                }
                count++;
            }
            return result;

        }
        static void SurnameChange()
        {
            bool done;
            do
            {
                try
                {
                    done = true;
                    Console.Write("Please enter your new surname: ");
                    string surname = Console.ReadLine();
                    Console.WriteLine("Please ensure that this {0}, is your updated surname", surname);
                    Console.Write("Enter either Y or N: ");

                    char correct = char.Parse(Console.ReadLine());
                    if (correct == 'Y' || correct == 'y')
                    {
                        Console.WriteLine("Your surname has been successfully updated!");
                        done = true;
                    }
                    else if (correct == 'n' || correct == 'N')
                    {
                        Console.Write("Enter the correct surname: ");
                        surname = Console.ReadLine();
                        Console.WriteLine("Thank you, \nYour surname has been successfully updated!");
                        done = true;
                    }
                    else
                    {
                        Console.WriteLine("What you have entered is bad.");
                        done = false;
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex + "\nApologies we ran into an error");
                    done = false;
                }
            }
            while (done == false);
            
        }
        static void NameChange()
        {
            bool done = true;
            do
            {
                try
                {
                    done = true;
                    Console.Write("Please enter your new first name: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Please ensure that this {0}, is your updated name", name);
                    Console.Write("Enter either Y or N: ");
                    char correct = char.Parse(Console.ReadLine());
                    if (correct == 'Y' || correct == 'y')
                    {
                        Console.WriteLine("Your name has been successfully updated!");
                        done = true;
                    }
                    else if (correct == 'n' || correct == 'N')
                    {
                        Console.Write("Enter the correct name: ");
                        name = Console.ReadLine();
                        Console.WriteLine("Thank you, \nYour name has been successfully updated!");
                        done = true;
                    }
                    else
                    {
                        Console.WriteLine("What you have entered is bad.");
                        done = false;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex + "\nApologies we ran into an error");
                    done = false;
                }
            }
            while (done == false);
        }
        static void CellphoneNumberUpdate()
        {
            bool valid;
            do
            {
                valid = true;
                try
                {
                    Console.Write("Please enter your cellphone number: ");
                    string cellNum = Console.ReadLine();
                    if (cellNum.Length == 10)
                    {
                        Console.WriteLine("Your number is: " + cellNum);
                    }
                    else if (cellNum.Length < 10 || cellNum.Length > 10)
                    {
                        Console.WriteLine("Please enter the correct number.");
                        Console.Write("Your correct 10 digit number: ");
                        cellNum = Console.ReadLine();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Apologies");
                }
            }
            while (valid == false);
        }
    }
}
