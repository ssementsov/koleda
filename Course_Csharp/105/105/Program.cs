using System;

namespace _105
{
    class Program //Task_105
    {
        static void Main(string[] args)
        {
            var gun = new Gun();
            gun.Reserve -= gun.Cartridge;

            while (gun.Reserve > 0 | gun.Cartridge > 0)
            {
                Console.WriteLine($"\nThere are {gun.Reserve + gun.Cartridge} rounds\n");
                Console.WriteLine("How many shots do you want to make?");
                int shots = Int32.Parse(Console.ReadLine());
                if (shots == 0)
                {
                    break;
                }
                int shooting = 0;
                if (gun.Cartridge < gun.Clip)
                {
                    gun.Charge();
                }
                do
                {
                    if (gun.Cartridge > 0)
                    {
                        gun.Shoot();
                        shooting++;
                    }
                    else if (gun.Reserve > 0)
                    {
                        gun.Charge();
                    }
                    else
                    {
                        Console.WriteLine("We're out of ammo!");
                        break;
                    }
                }
                while (shooting < shots);
            }
            Console.WriteLine("Game over, boy!");
        }
    }
}
