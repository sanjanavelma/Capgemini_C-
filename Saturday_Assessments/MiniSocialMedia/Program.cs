using System;
using System.Collections;
using System.Text.RegularExpressions;
namespace MiniSocialMedia
{
    class Program
    {
        private static Repository<User> _users = new Repository<User>();
        private static User? _currentUser = null;
        private static readonly string _dataFile = "social - data.json";
        static void Main()
        {
            Console.Title = "MiniSocial - Console Edition";
            Console.WriteLine("==== MiniSocial ====");
            Console.WriteLine();
            LoadData();
            while(true)
            {
                try
                {
                    if (CurrentUser == null)
                    {
                        ShowLoginMenu();
                    }
                    else
                    {
                        ShowMainMenu();
                    }
                }
                catch (SocialException ex)
                {
                    ConsoleColor originalColor = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Error: {ex.Message}");
                    if (ex.InnerException != null)
                    {
                        Console.WriteLine($"Details: {ex.InnerException.Message}");
                    }
                    Console.ForegroundColor = originalColor;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Unexpected Error!!");
                    Console.WriteLine(ex);
                    LogError(ex);
                }
                finally
                {
                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey(intercept: true);
                    Console.Clear();
                    Console.WriteLine("==== MiniSocial ====");
                    Console.WriteLine();
                }
            }
            static void LoadData()
            {
                
            }
            static void ShowLoginMenu()
            {
                
            }
            static void ShowMainMenu()
            {
                Console.WriteLine("Main Menu");
            }
        }
    }
}