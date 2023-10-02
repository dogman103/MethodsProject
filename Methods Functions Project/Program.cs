using System.Runtime.CompilerServices;

namespace Methods_Functions_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // it works! kind of an awful amalgamation of code and it looks like. someone vomited on my screen
            //but.... it works
            //edit: it looked worse before i cleaned it up.. thanks jakedawg
            string name = GetName();
            string bday = GetBday();
            int dogs = GetDogs();
            int cats = GetCats();
            int otherPets = GetOtherPets();
            string finalString = AllTogetherNow(name, bday, dogs, cats, otherPets);
            Console.WriteLine(finalString);
            //this kind of makes me want to kill myself (joking)
        }
        static string GetName()
        {
            Console.WriteLine("Please enter your name.");
            string name = Console.ReadLine();
            return name;
        }
        static string GetBday()
        {
            Console.WriteLine("Please enter your birthday.");
            string bDay = Console.ReadLine();
            return bDay;
        }
        static int GetInteger(string prompt) 
            // this was used not to just get a random number, like i thought
            // but to REUSE CODE, NOT REWRITE IT (the point of methods)
        {
            Console.WriteLine(prompt);
            int input = Convert.ToInt32(Console.ReadLine());
            return (input);
        }
        //god im stupid
        static int GetDogs()
        {
            int input = GetInteger("How many dogs do you have?");
            return input;
        }
        static int GetCats()
        {
            int input = GetInteger("How many cats do you have?");
            return input;
        }
        static int GetOtherPets()
        {
            int input = GetInteger("How many other pets do you have?");
            return input;
        }

        static string AllTogetherNow(string name, string bday, int dogs, int cats, int others)
        {
            string interpString = $"{name}, born {bday}, has {dogs} dogs, {cats} cats, and {dogs + cats + others} pets in total.";
            return interpString;
        }
    }
}
