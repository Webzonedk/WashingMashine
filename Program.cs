using System;
using System.Runtime.InteropServices;

namespace WashingMashine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello and welcome to the environmental CO2 neutral washery. Please chose your washing machine: pick 1 - 5.");
            Wash wash = new Wash();
            //byte waterTime = 0;
            //byte washingTime = 0;
            //byte emptyTime = 0;
            //byte centrifugeTime = 0;

            wash.Machine = wash.ChooseMachine();
            Console.WriteLine($"Yor have chosen mashine {wash.Machine}");
            Console.WriteLine();

            Console.WriteLine("press 1 to power on the washing machine");
            // wash.PowerState();
            wash.PowerOn = wash.PowerState();
            Console.WriteLine();

            Console.WriteLine("Fill in the clothes into the washing champer and press 1 to confirm the door is is closed proberbly");
            wash.DoorClosed = wash.DoorState();
            Console.WriteLine();

            Console.WriteLine("Chose program");
            Console.WriteLine("Press 1 = Eco program");
            Console.WriteLine("Press 2 = Normal program");
            Console.WriteLine("Press 3 = Wool program");
            Console.WriteLine("Press 4 = Sensitive program");
            Console.WriteLine("Press 5 = Turbo program");
            wash.ChooseProgram();

            Console.WriteLine($"You have chosen {wash.Program}");
            Console.WriteLine();

            Console.WriteLine("Choose temperature");
            Console.WriteLine("Press 1 = cold water");
            Console.WriteLine("Press 2 = 30 degrees");
            Console.WriteLine("Press 3 = 40 degrees");
            Console.WriteLine("Press 4 = 60 degrees");
            Console.WriteLine("Press 5 = 90 degrees");
            wash.ChooseTemperature();
            Console.WriteLine($"You have chosen {wash.Temperature}");
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("---------------The washing mashine is washing--------------");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine();
            wash.Washing();
        }
    }
}
