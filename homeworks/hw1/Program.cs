using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw1
{
    internal class Program
    {

        /// <summary>
        /// Delegate defining the signature for handling mark addition events.
        /// </summary>
        public delegate void MarkHandler(string msg); // MarkHandler is datatype (we declare it) that data type can only hold metods which take string parameter and return void



        /// <summary>
        /// Holds course code and credit hours.
        /// </summary>
        public struct CourseCode
        {
            /// <summary>
            /// The unique code of the course.
            /// </summary>
            public string code;

            /// <summary>
            /// The credit value of the course.
            /// </summary>
            public int credits;
        }


        /// <summary>
        /// Base abstract class for people. Contains basic personal details.
        /// </summary>
        public abstract class Person
        {
            protected string name;
            public string surname;


            /// <summary>
            /// Prints student info, enrolled course, and exam mark to the console.
            /// </summary>
            public abstract void Describe();

            public Person(string name, string surname)
            {
                this.name = name;
                this.surname = surname;
            }
        }


        /// <summary>
        /// Represents a student derived from Person. Manages marks and course data.
        /// </summary>
        public class Student : Person
        {

            private int _mark;


            /// <summary>
            /// Student mark property. Validates that the input is between 0 and 100.
            /// </summary>
            public int Mark
            {
                get { return _mark; }
                set
                {
                    if (value >= 0 && value <=100)
                    {
                        _mark = value;
                        if (OnMarkAdded != null)
                        {
                            OnMarkAdded($"Mark {value} successfully added for student {name} in course {studentInfo.code} ({studentInfo.credits} Credits).");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Error: For student {name}, entered mark {value} is invalid for course {studentInfo.code} ({studentInfo.credits} Credits)! (Must be between 0-100)");
                    }
                }
            }


            /// <summary>
            /// Event triggered when a valid grade is assigned to the student.
            /// </summary>
            public event MarkHandler OnMarkAdded; // OnMarkAdded is variable name, it's data type is MarkHandler as we declare in line 12. similar like: int age


            /// <summary>
            /// Stores course information for the student.
            /// </summary>
            public CourseCode studentInfo;

            public Student(string name, string surname) : base(name, surname) { }

            public override void Describe()
            {
                Console.WriteLine($"Student Name: {name} {surname} | Mark: {Mark}");
            }

        }



        /// <summary>
        /// Handles the event when a valid mark is added and prints a system message.
        /// </summary>
        static void NotifyWhenEventFires(string msg)
        {
            Console.WriteLine($"[SYSTEM MESSAGE] {msg}");
        }









        /// MAIN

        static void Main(string[] args)
        {
            /// HW-1 [week-4]:  Build a Student Register (with console app)
            /// Project Owner Name and studentID = Eray Dilmen - 2310213568

            Student s1 = new Student("Eray", "Dilmen");
            Student s2 = new Student("Deniz", "Ata");

            s1.OnMarkAdded += NotifyWhenEventFires;
            s2.OnMarkAdded += NotifyWhenEventFires;


            s1.studentInfo.code = "CPE317";
            s1.studentInfo.credits = 3;
            s2.studentInfo.code = "CPE317";
            s2.studentInfo.credits = 3;
            s1.Mark = 98;
            s2.Mark = 150;
           


            Console.WriteLine("\n Student Informations\n");
            s1.Describe();
            s2.Describe();

            Console.WriteLine("\n------------------------------------------------------------\nProject Owner Name and studentID = Eray Dilmen - 2310213568\n------------------------------------------------------------");

        }
    }
}
