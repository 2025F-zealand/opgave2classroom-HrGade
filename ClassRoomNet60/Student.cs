﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomNet60
{
    internal class Student
    {

        public string Name;
 
        public int Birtmonth;

        public int Birthday;

        public Student(string name, int birthday, int birthmonth) 
        {

        Name = name;
            Birthday = birthday;
                Birtmonth = birthmonth;
        }
    }
}
