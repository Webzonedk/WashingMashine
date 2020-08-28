using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;

namespace WashingMashine
{
    class Wash
    {
        #region Field

        private byte machineNumber;
        private bool powerState;
        private bool doorClosed;
        private byte program;
        private bool doorLocked;
        private bool waterOn;
        private bool waterFull;
        private bool champerTurning;
        private byte temperature;

        private byte waterTime;
        private byte washingTime;
        private byte emptyTime;
        private byte centrifugeTime;


        #endregion


        /// <summary>
        /// Returning the number of the washing mashine
        /// </summary>
        public byte Machine
        {
            get
            {
                return this.machineNumber;
            }
            set
            {
                this.machineNumber = value;
            }
        }

        #region Properties

        /// <summary>
        /// Returning if the machine is powered on or off
        /// </summary>
        public bool PowerOn
        {
            get
            {
                return this.powerState;
            }
            set
            {
                this.powerState = value;
            }
        }

        /// <summary>
        /// return if the door is closed
        /// </summary>
        public bool DoorClosed
        {
            get
            {
                return this.doorClosed;
            }
            set
            {
                this.doorClosed = value;
            }
        }

        /// <summary>
        /// Return the program
        /// </summary>
        public string Program
        {
            get
            {
                switch (program)
                {
                    case 1:

                        return "Eco program";
                    case 2:

                        return "Normal program";
                    case 3:

                        return "Wool program";
                    case 4:

                        return "Sensitive program";
                    case 5:

                        return "Turbo program";

                    default:
                        return "Please pick 1 - 5";
                }
                //  return this.program;
            }
            //set
            //{
            //    this.program = value;
            //}
        }

        /// <summary>
        /// Return the temperature
        /// </summary>
        public string Temperature
        {
            get
            {
                switch (temperature)
                {
                    case 1:

                        return "Cold water";
                    case 2:

                        return "30 degrees";
                    case 3:

                        return "40 degrees";
                    case 4:

                        return "60 degrees";
                    case 5:

                        return "90 degrees";

                    default:
                        return "Please pick 1 - 5";
                }
            }
            //set
            //{
            //    this.temperature = value;
            //}
        }

        /// <summary>
        /// return if the door is locked
        /// </summary>
        public bool DoorLocked
        {
            get
            {
                return this.doorLocked;
            }
            set
            {
                this.doorLocked = value;
            }
        }

        /// <summary>
        /// Return if the water is on or off
        /// </summary>
        public bool WaterOn
        {
            get
            {
                return this.waterOn;
            }
            set
            {
                this.waterOn = value;
            }
        }

        /// <summary>
        /// Return if the waterlevel is reached
        /// </summary>
        public bool WaterFull
        {
            get
            {
                return this.waterFull;
            }
            set
            {
                this.waterFull = value;
            }
        }

        /// <summary>
        /// Return if the champer is turning
        /// </summary>
        public bool ChamperTurning
        {
            get
            {
                return this.champerTurning;
            }
            set
            {
                this.champerTurning = value;
            }
        }
        #endregion

        #region Constructors
        public Wash()
        {

        }

        public Wash(byte machineNumber, bool powerState, bool doorClosed, byte program, bool doorLocked, bool waterOn, bool waterFull, bool champerTurning, byte temperature)
        {
            this.machineNumber = machineNumber;
            this.powerState = powerState;
            this.doorClosed = doorClosed;
            this.program = program;
            this.doorLocked = doorLocked;
            this.waterOn = waterOn;
            this.waterFull = waterFull;
            this.champerTurning = champerTurning;
            this.temperature = temperature;
        }
        #endregion



        /// <summary>
        /// Decide what machine number the user choose
        /// </summary>
        /// <returns>mashineNumber</returns>
        public byte ChooseMachine()
        {

            //Chose the washing mashine number
            bool pickMachine = true;
            byte machineNumber = 0;

            while (pickMachine == true)
            {
                switch (Console.ReadKey(true).KeyChar)
                {
                    case '1':
                        machineNumber = 1;
                        pickMachine = false;
                        break;

                    case '2':
                        machineNumber = 2;
                        pickMachine = false;
                        break;

                    case '3':
                        machineNumber = 3;
                        pickMachine = false;
                        break;

                    case '4':
                        machineNumber = 4;
                        pickMachine = false;
                        break;

                    case '5':
                        machineNumber = 5;
                        pickMachine = false;
                        break;

                    default:
                        Console.WriteLine("You need to pick a washing mashine beween 1 and 5");
                        break;
                }
            }
            return machineNumber;

        }


        /// <summary>
        /// Decides if the washing machine is turned on or off
        /// </summary>
        /// <returns>onOff</returns>
        public bool PowerState()
        {
            bool powerState = false;
            // string onOff = null;
            while (powerState == false)
            {
                switch (Console.ReadKey(true).KeyChar)
                {
                    case '1':
                        powerState = true;
                        break;
                    default:
                        Console.WriteLine("I can't wash your dirty laundry when I'm turned off! Please turn on the washing machine!");
                        break;
                }
            }
            if (powerState == true)
            {
                Console.WriteLine("Power is now turned on");
            }
            return powerState;
        }


        /// <summary>
        /// Decides if the washing machine is turned on or off
        /// </summary>
        /// <returns>onOff</returns>
        public bool DoorState()
        {
            bool doorClosed = false;
            // string onOff = null;
            while (doorClosed == false)
            {
                switch (Console.ReadKey(true).KeyChar)
                {
                    case '1':
                        doorClosed = true;
                        break;
                    default:
                        Console.WriteLine("Close the door please. I won't be able to wash with the door open");
                        doorClosed = false;
                        break;
                }
            }
            if (doorClosed == true)
            {
                Console.WriteLine("Power is now turned on");
                doorClosed = true;
            }

            return doorClosed;
        }

        /// <summary>
        /// Here we are choosing wich program to run
        /// </summary>
        /// <returns>programNumber</returns>
        public byte ChooseProgram()
        {

            //Chose the Program
            bool pickProgram = true;
            byte programNumber = 0;



            while (pickProgram == true)
            {
                switch (Console.ReadKey(true).KeyChar)
                {
                    case '1':
                        //eco
                        programNumber = 1;
                        waterTime = 20;
                        washingTime = 30;
                        emptyTime = 20;
                        centrifugeTime = 20;
                        pickProgram = false;
                        break;

                    case '2':
                        //normal
                        programNumber = 2;
                        waterTime = 20;
                        washingTime = 80;
                        emptyTime = 20;
                        centrifugeTime = 20;
                        pickProgram = false;
                        break;

                    case '3':
                        //wool
                        programNumber = 3;
                        waterTime = 20;
                        washingTime = 40;
                        emptyTime = 20;
                        centrifugeTime = 20;
                        pickProgram = false;
                        break;

                    case '4':
                        //sensitive
                        programNumber = 4;
                        waterTime = 20;
                        washingTime = 10;
                        emptyTime = 20;
                        centrifugeTime = 20;
                        pickProgram = false;
                        break;

                    case '5':
                        //turbo
                        programNumber = 5;
                        waterTime = 20;
                        washingTime = 20;
                        emptyTime = 20;
                        centrifugeTime = 20;
                        pickProgram = false;
                        break;

                    default:
                        Console.WriteLine("You need to pick a program beween 1 and 5");
                        break;
                }
            }
            program = programNumber;
            return programNumber;

        }

        /// <summary>
        /// Here we choose the temperature
        /// </summary>
        /// <returns>tempNumber</returns>
        public byte ChooseTemperature()
        {

            //Chose the washing mashine number
            bool pickTemp = true;
            byte tempNumber = 0;


            while (pickTemp == true)
            {
                switch (Console.ReadKey(true).KeyChar)
                {
                    case '1':
                        tempNumber = 1;
                        pickTemp = false;
                        break;

                    case '2':
                        tempNumber = 2;
                        pickTemp = false;
                        break;

                    case '3':
                        tempNumber = 3;
                        pickTemp = false;
                        break;

                    case '4':
                        tempNumber = 4;
                        pickTemp = false;
                        break;

                    case '5':
                        tempNumber = 5;
                        pickTemp = false;
                        break;

                    default:
                        Console.WriteLine("You need to pick a program beween 1 and 5");
                        break;
                }
            }
            temperature = tempNumber;
            return tempNumber;

        }


        /// <summary>
        /// Washing progress running with some loops and with variables set in ChooseProgram method.
        /// </summary>
        public void Washing()
        {
            Console.Clear();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Filling water into champer");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine();
            for (int i = 0; i < waterTime; i++)
            {
                Console.Write($"{i} swirl\n");
                Thread.Sleep(500);
            }
            Console.Clear();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Now washing your dirty laundry");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine();
            for (int i = 0; i < washingTime; i++)
            {
                Console.Write($"{i} Swush swush\n");
               Thread.Sleep(500);
            }
            Console.Clear();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Now pumping out water");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine();
            for (int i = 0; i < emptyTime; i++)
            {
                Console.Write($"{i} Pumping\n");
               Thread.Sleep(500);
            }
            Console.Clear();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Now throwing oround your clothes to try to dry it a bit before");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine();
            for (int i = 0; i < centrifugeTime; i++)
            {
                Console.Write($"{i} Wruuuuummmmm\n");
               Thread.Sleep(500);
            }
            Console.WriteLine("Your Clothes is now almost as good as new.");
            Console.WriteLine("Press a key to exit");
            Console.ReadKey();

        }


    }
}

