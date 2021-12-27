using System;
using System.Linq;
using System.Collections.Generic;

namespace ChristmasGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            List<string> listOfPeople = new List<string>();
            List<string> listOfPeopleWhoGiveGifts = new List<string>();

            bool isAlrigt = true;

            while (isAlrigt)
            {
                Console.WriteLine($"Please Enter All Names:");
                string commnad = Console.ReadLine();
                while (commnad != "stop")
                {
                    listOfPeople.Add(commnad);
                    listOfPeopleWhoGiveGifts.Add(commnad);
                    commnad = Console.ReadLine();
                }
                Console.WriteLine();
                while (listOfPeople.Any() && listOfPeopleWhoGiveGifts.Any())
                {
                    int chosenOne = rnd.Next(0, listOfPeople.Count);
                    int chosenTwo = rnd.Next(0, listOfPeopleWhoGiveGifts.Count);

                    if (listOfPeopleWhoGiveGifts[chosenTwo] == listOfPeople[chosenOne])
                    {
                        isAlrigt = true;
                        Console.Clear();
                        Console.WriteLine($"Sorry, {listOfPeopleWhoGiveGifts[chosenTwo]} cannot give a gift to him/her-self!");
                        listOfPeopleWhoGiveGifts.Clear();
                        listOfPeople.Clear();
                        break;
                    }
                    Console.WriteLine($"{listOfPeopleWhoGiveGifts[chosenTwo]} gives a gift to: {listOfPeople[chosenOne]}");

                    listOfPeopleWhoGiveGifts.Remove(listOfPeopleWhoGiveGifts[chosenTwo]);
                    listOfPeople.Remove(listOfPeople[chosenOne]);
                    isAlrigt = false;
                }
            }     
        }
    }
}
