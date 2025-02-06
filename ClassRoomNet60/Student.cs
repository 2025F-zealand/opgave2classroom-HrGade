using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomNet60
{
    public class Student
    {

        public string Name;
 
        public int BirthMonth;

        public int Birthday;

        public Student()
        {
        }

        public Student(string name, int birthday, int birthmonth) 
        {

        Name = name;
            Birthday = birthday;
            BirthMonth = birthmonth;
        }

        public string Season()
        {
            string season;
            switch (BirthMonth)
            {
                case 12:
                case 1:
                case 2:
                    season = "Winter";
                    break;
                case 3:
                case 4:
                case 5:
                    season = "Spring";
                    break;
                case 6:
                case 7:
                case 8:
                    season = "Summer";
                    break;
                case 9:
                case 10:
                case 11:
                    season = "Autumn";
                    break;
                default:
                    season = "Invalid month";
                    break;
            }
            return season;
        }

        public override string ToString()
        {
            Console.WriteLine();
            return $"{Name} - Født: {Birthday}/{BirthMonth} ({Season()})";
        }
    }
}
