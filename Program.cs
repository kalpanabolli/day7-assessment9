using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7Assessment9
{

    public class ValidationException : Exception
    {
        public ValidationException(string message) : base(message)
        {
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string name, email, password;
                Console.WriteLine("Enter your Name: ");
                name = Console.ReadLine();
                Console.WriteLine("Enter your Email: ");
                email = Console.ReadLine();
                Console.WriteLine("Enter your Password: ");
                password = Console.ReadLine();

                if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
                {
                    throw new ValidationException("All fields are required");
                }
                if (name.Length < 6)
                {
                    throw new ValidationException("user name must have atleast 6 characters");
                }
                if (password.Length < 8)
                {
                    throw new ValidationException("password must have atleast 8 characters");
                }
                Console.WriteLine("Registration successful!" + name + "" + email + "" + password);
            }

            catch (ValidationException ex)
            {
                Console.WriteLine("Validation Exception!! " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error!! " + ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
