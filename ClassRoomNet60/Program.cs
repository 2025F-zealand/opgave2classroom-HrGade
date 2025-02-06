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
        ClassRoom ClassRoom3Q = new ClassRoom();

        List<Student> students = new List<Student>();


        students.Add(new Student("Adam", 2003, 20 / 01));

        foreach (Student student in students)
        {
            Console.WriteLine(student);
        }
       

        Console.ReadKey();
    }
}