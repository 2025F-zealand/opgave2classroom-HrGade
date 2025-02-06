using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using ClassRoomNet60;

public class Program
{
    private static void Main(string[] args)
    {
        
        ClassRoom classRoom = new ClassRoom // Opretter et nyt klasselokale
        {
            ClassName = "3Q",
            SemesterStart = new DateTime(2025, 01, 27)
        };
        
        
        classRoom.StudentList.Add(new Student("Adam", 20, 01)); // Tilføj elev

        classRoom.StudentList.Add(new Student("Batur", 16, 05));// Tilføj elev

        classRoom.PrintClassInfo(); // Udskriver klassens information

        

        Console.ReadKey();
    }
}