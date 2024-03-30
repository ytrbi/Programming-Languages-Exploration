using System;
using System.Collections.Generic;
using System.Linq;

namespace ProgrammingLanguages
{
    class Program
    {
        static void Main(string[] args)
        {
            // Data import is already taken care of

            // Task 1: Print all languages
            PrintAllLanguages();

            Console.WriteLine();

            // Task 2: Print details of each language
            PrintLanguageDetails();

            Console.WriteLine();

            // Task 3: Find and print C# details
            PrintCSharpDetails();

            Console.WriteLine();

            // Task 4: Find languages developed by Microsoft
            PrintMicrosoftLanguages();

            Console.WriteLine();

            // Task 5: Find languages descending from Lisp
            PrintLispDescendants();

            Console.WriteLine();

            // Task 6: Find languages containing "Script"
            PrintScriptLanguages();

            Console.WriteLine();

            // Task 7: Count total languages
            PrintTotalLanguages();

            Console.WriteLine();

            // Task 8: Count languages launched between 1995 and 2005
            PrintLanguagesBetween1995And2005();

            Console.WriteLine();

            // Task 9: Print near-millennium languages
            PrintNearMillenniumLanguages();

            Console.WriteLine();
        }

        // Task 1: Print all languages
        static void PrintAllLanguages()
        {
            foreach (var language in Languages)
            {
                Console.WriteLine(language.Prettify());
            }
        }

        // Task 2: Print details of each language
        static void PrintLanguageDetails()
        {
            var details = Languages.Select(lang => $"{lang.Name} ({lang.Year}) - Chief Developer: {lang.ChiefDeveloper}");
            PrintAll(details);
        }

        // Task 3: Find and print C# details
        static void PrintCSharpDetails()
        {
            var csharpDetails = Languages.Where(lang => lang.Name == "C#").Select(lang => lang.Prettify());
            PrintAll(csharpDetails);
        }

        // Task 4: Find languages developed by Microsoft
        static void PrintMicrosoftLanguages()
        {
            var microsoftLanguages = Languages.Where(lang => lang.ChiefDeveloper.Contains("Microsoft")).Select(lang => lang.Prettify());
            PrintAll(microsoftLanguages);
        }

        // Task 5: Find languages descending from Lisp
        static void PrintLispDescendants()
        {
            var lispDescendants = Languages.Where(lang => lang.Predecessors.Contains("Lisp")).Select(lang => lang.Prettify());
            PrintAll(lispDescendants);
        }

        // Task 6: Find languages containing "Script"
        static void PrintScriptLanguages()
        {
            var scriptLanguages = Languages.Where(lang => lang.Name.Contains("Script")).Select(lang => lang.Name);
            PrintAll(scriptLanguages);
        }

        // Task 7: Count total languages
        static void PrintTotalLanguages()
        {
            var totalLanguages = Languages.Count();
            Console.WriteLine($"Total languages: {totalLanguages}");
        }

        // Task 8: Count languages launched between 1995 and 2005
        static void PrintLanguagesBetween1995And2005()
        {
            var languagesBetween1995And2005 = Languages.Count(lang => lang.Year >= 1995 && lang.Year <= 2005);
            Console.WriteLine($"Languages launched between 1995 and 2005: {languagesBetween1995And2005}");
        }

        // Task 9: Print near-millennium languages
        static void PrintNearMillenniumLanguages()
        {
            var nearMillenniumLanguages = Languages
                .Where(lang => lang.Year >= 1995 && lang.Year <= 2005)
                .Select(lang => $"{lang.Name} was invented in {lang.Year}");
            PrintAll(nearMillenniumLanguages);
        }

        // Method to print IEnumerable of strings
        static void PrintAll(IEnumerable<string> items)
        {
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }

        // Data
        static List<Language> Languages = new List<Language>
        {
            new Language { Year = 1990, Name = "AMOS BASIC", ChiefDeveloper = "François Lionet, Constantin Sotiropoulos", Predecessors = "STOS BASIC" },
            new Language { Year = 1991, Name = "Visual Basic", ChiefDeveloper = "Alan Cooper (sold to Microsoft)", Predecessors = "QuickBASIC" },
            new Language { Year = 1995, Name = "Ruby", ChiefDeveloper = "Yukihiro Matsumoto", Predecessors = "Smalltalk;Perl" },
            new Language { Year = 2009, Name = "Go", ChiefDeveloper = "Google", Predecessors = "C;Oberon;Limbo;Smalltalk" }
            // Add more languages as needed
        };
    }
}
