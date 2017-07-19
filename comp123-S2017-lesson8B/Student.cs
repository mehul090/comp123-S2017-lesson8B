using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comp123_S2017_lesson8B
{
    /// <summary>
    /// this is the student class
    /// </summary>
    class Student : Person
    {
        //private instance variable(fields)
        private string _studentID;

        public Student(string name, int age) : base(name, age)
        {
        }

        //public properties
        public string StudentID
        {
            get
            {
                return this._studentID;
            }
            set
            {
                this._studentID = value;
            }
        }
        //constructors----------------------
        /// <summary>
        /// this is the constructor for the student class
        /// this takes three arguments- name(string) , age(int) , studentID(string)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="studentID"></param>
        public Student(string name, int age, string studentID)
            : base(name, age)
        {
            this.StudentID = studentID;
        }

        // public methods---------------
        /// <summary>
        /// this is the student method
        /// enable the student to study.
        /// </summary>
        public void Studies()
        {
            Console.WriteLine(this.Name + "is studying!");
        }

    }
}
