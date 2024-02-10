using System;

namespace SchoolProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentManager studentManager = new StudentManager();

            while (true)
            {
                Console.WriteLine("1. Opret elev");
                Console.WriteLine("2. Se elever");
                Console.WriteLine("0. Afslut");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Navn: ");
                        string name = Console.ReadLine();

                        Console.Write("Age: ");
                        if (int.TryParse(Console.ReadLine(), out int age))
                        {
                            Console.Write("ID: ");
                            if (int.TryParse(Console.ReadLine(), out int id))
                            {
                                Console.Write("Subject: ");
                                string subject = Console.ReadLine();

                                studentManager.CreateStudent(name, age, id, subject);
                                Console.WriteLine("Elev oprettet med succes!");
                            }
                            else
                            {
                                Console.WriteLine("Ugyldig ID. Prøv igen.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Ugyldig alder. Prøv igen.");
                        }
                        break;

                    case "2":
                        studentManager.DisplayStudents();
                        break;

                    case "0":
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Ugyldigt valg. Prøv igen.");
                        break;
                }
            }
        }
    }
}
