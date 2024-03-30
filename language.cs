using System;

namespace ProgrammingLanguages
{
    public class Language
    {
        public int Year { get; set; }
        public string Name { get; set; }
        public string ChiefDeveloper { get; set; }
        public string Predecessors { get; set; }

        public string Prettify()
        {
            return $"{Name} ({Year}) - Chief Developer: {ChiefDeveloper}";
        }
    }
}
