using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _105
{
    class Gun
    {
        private int reserve;
        private int clip;
        private int cartridge;
        public Gun()
        {
            reserve = 10;
            clip = 3;
            cartridge = 2;
        }
        public void Shoot()
        {
            Console.WriteLine("Ba-Baaah");
            cartridge--;
        }

        public void Charge()
        {
            while (reserve > 0 && cartridge < clip)
            {
                reserve--;
                cartridge++;
            }
            Console.WriteLine($"{cartridge} cartridges are loaded into the clip");
        }
        public int Reserve
        {
            get { return reserve; }
            set { reserve = value; }
        }
        public int Cartridge
        {
            get { return cartridge; }
            set { cartridge = value; }
        }
        public int Clip
        {
            get { return clip; }
        }
    }
}
