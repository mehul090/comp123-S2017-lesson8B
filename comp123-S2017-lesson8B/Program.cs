using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comp123_S2017_lesson8B
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("\n");
            Person person = new Person("mehul ", 25);
            person.Talks();
            Console.WriteLine("\n");
            Student student = new Student("bobbo ", 20, "155683151A");
            student.Studies();
            student.Talks();
            Console.WriteLine("\n");
            DomesticStudent domestic = new DomesticStudent("mary ", 19, "135463A");
            domestic.Talks();
            domestic.Studies();
            Console.WriteLine("\n");
        }
    }
}
