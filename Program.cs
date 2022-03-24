using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
             PlayersArray();
        }

        static void PlayersArray(){
            Console.WriteLine("Type the players Amount");
            int playersAmount = int.Parse(Console.ReadLine());
            var playersArray = new int[playersAmount];
            string[] playersNames = new string[playersAmount];

            for(int index = 0; index < playersAmount; index++){
                Console.Clear();
                Console.WriteLine($"type the player name {index+1} ");
                playersNames[index] = Console.ReadLine();
            }

            Console.WriteLine("Do you want to see the list?");
            Console.WriteLine("1 for yes");
            Console.WriteLine("2 to exit");
            short option = short.Parse(Console.ReadLine());
            switch (option){
                case 1: 
                Console.Clear();
                Console.WriteLine("Players List");
                foreach(var item in playersNames){
                Console.WriteLine(item);
                } break;
                case 2: Environment.Exit(0); break;
            }    
        }

        
    }
}