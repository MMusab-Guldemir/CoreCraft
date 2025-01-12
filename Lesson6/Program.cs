using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var firstName = "Mosh";
            var lastName = "Hamedani";

            var fullName = firstName + " " + lastName;
            var myFullName = string.Format("My name is {0} {1} ", firstName, lastName);
            ///yerlerini değiştirdik yani 0 first name oldu.
            ///
            Console.WriteLine(myFullName); // My name is Mosh Hamedani

            var names = new string[3] { "John", "Jack", "Ninja" };
            var formattedNames = string.Join(",", names);
            Console.WriteLine(formattedNames); //arlarına virgül koycak ve John, Jack, Ninja
            // \n new line yani yeni satır alt satıra geçiyor tek satırda write gibi
            var text = "Hi John\nLook into the following paths";
            Console.WriteLine(text);
            
            var text1 = @"Hi John
Look into the following paths";//otomatik olarak yapıyor yani et işareti koyunca
        }
    }
}
