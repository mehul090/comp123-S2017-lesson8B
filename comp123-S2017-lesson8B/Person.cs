using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comp123_S2017_lesson8B
{
    /// <summary>
    /// this is the person class
    /// </summary>
   public class Person
    {
        // ptivate instance variable(fields)
        private string _name;
        private int _age;

        //public properties------------
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }

        public int Age
        {
            get { return this._age; }
            set { this._age = value; }
        }

        //constructors-----------------

            /// <summary>
            /// this is the constructor for the person class.
            /// it takes two arguments - name(string) and age(int)
            /// </summary>
            /// <param name="name"></param>
            /// <param name="age"></param>
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        //public methods-----------------
        /// <summary>
        /// this method enables the person object to talk
        /// and also tells the age
        /// </summary>
        public void Talks()
        {
            Console.WriteLine(this.Name + "is talking and "+ this.Name +" is "  + this.Age +" years old");
        }
    }
}
