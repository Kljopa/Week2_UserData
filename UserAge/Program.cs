using System;

namespace UserAge
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kusib kasutaja vanust;
            //programm arvutab kasutaja sunniaastat;
            //prorramm kuvab sunniaastat konsoolis;
            //"oled sundinud aastal {yearOfBirth};

            Console.WriteLine("Palun, sisesta oma vanus:");
            int birthAge = Convert.ToInt32(Console.ReadLine());

            //int ageOfBirth = 2022 - birthAge;


            var currentYear = DateTime.UtcNow.Year;
            int ageOfBirth = currentYear - birthAge;

                    
            Console.WriteLine($"Oled sündinud {ageOfBirth} aastal.");
        }
    }
}
