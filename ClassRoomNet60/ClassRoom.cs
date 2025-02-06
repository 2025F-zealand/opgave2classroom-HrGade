using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomNet60
{
    public class ClassRoom
    {
        public string ClassName { get; set; }
        public List<Student> StudentList { get; set; }
        public DateTime SemesterStart { get; set; }

        public ClassRoom() // konstruktør
        {
            StudentList = new List<Student>(); //Opretter en liste med studerende
        }


        public void CountStudentsBySeason()
        {
            var seasonCounts = new Dictionary<string, int> //Dictionary til <TKey,TValue>
            {
                { "Winter", 0 },
                { "Spring", 0 },
                { "Summer", 0 },
                { "Autumn", 0 }
            };

            foreach (var student in StudentList)
            {
                string season = student.Season();
                if (seasonCounts.ContainsKey(season))
                {
                    seasonCounts[season]++;
                }
            }

            Console.WriteLine("Fødselsdagsfordeling pr. årstid:");
            foreach (var kvp in seasonCounts)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}"); //Key Value Pair
            }
        }

        public void PrintClassInfo()
        {
            Console.WriteLine($"Klassenavn: {ClassName}");
            Console.WriteLine($"Semesterstart: {SemesterStart:dd-MM-yyyy}");
            Console.WriteLine("Studerende:");
            foreach (var student in StudentList)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine();
            CountStudentsBySeason();
        }
    }
}

