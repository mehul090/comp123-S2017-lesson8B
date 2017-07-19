using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace comp123_S2017_lesson8B
{
    public class DomesticStudent : Student
    {
        //PUBLIC PROPERTIES----------
        public string DomesticAddress
        {
            get; private set;
        }//READ ONLY



        //constructor--------

        /// <summary>
        /// this is the constructor 
        /// it takes three argument - name, age , studentID
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="studentID"></param>

        public DomesticStudent(string name, int age, string studentID) : base(name, age, studentID)

        {

        }


        //public methods---------------------------------------------

            /// <summary>
            /// this method sets the domestic address property
            /// </summary>
            /// <param name="address"></param>
        public void SetDomesticAddress( string address)
        {
            this.DomesticAddress = address;
        }

    }
}