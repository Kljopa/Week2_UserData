using System;

namespace InstagramAgeCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kusib kasutaja vanust;
            //programm kontrolib, kas kasutaja on vanem kui 13 v6i 13 aastat vana;
            //kui kasutaja on 13 aastat vana v6i vanem, siis ta v6ib Instagrammi kasutatda;
            //kui kasutaja on noorem, kui 13, siis ta on liiga noor;

            Console.WriteLine("Palun, sisesta oma vanus:");
            int userAge = Convert.ToInt32(Console.ReadLine());

            if(userAge > 13)
            {
                Console.WriteLine("Oled piisavalt vana, et Instagramm'i kontot luua.");
            }
            else if(userAge < 13)
            {
                Console.WriteLine("Oled liiga noor, et Instagramm'i kontot luua.");
            }else
            {
                Console.WriteLine("Oledki 13, nüüd saab endale Instagramm'i kontot luua.");
            }

            Console.WriteLine("Head päeva!");
        }
    }
}
