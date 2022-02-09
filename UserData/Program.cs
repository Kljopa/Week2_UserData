using System;

namespace UserData
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kusib kasutaja sunniaastat;
            //programm arvutab kasutaja vanust;
            //programm kuvab kasutajat vanust konsoolis;

            Console.WriteLine("Palun, sisesta oma sünniaasta:");
            int yearOfBirth = Convert.ToInt32(Console.ReadLine());

            //int userAge = 2022 - yearOfBirth;
            //Console.WriteLine("Oled " + userAge + " aastat vana.");
            //string interpolatsion

            //leidsin kuidas panna praegune aeg;
            var userAge = DateTime.UtcNow.Year - yearOfBirth; 

            

            Console.WriteLine($"Oled {userAge} aastat vana.");


        }
    }
}
