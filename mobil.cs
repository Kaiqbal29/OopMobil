using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace oopMobil
{
    
    internal class mobil
    {
        
        private String color;
        private String brand;
        private String type;
        private String horn;
        private int doors;
        private int since;
        private int speed;

        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }

        public int Doors
        {
            get
            {
                return doors;
            }
            set
            {
                doors = value;
            }
        }

        public string Brand
        {
            get
            {
                return brand;
            }
            set
            {
                brand = value;
            }
        }

        public string Horn
        {
            get
            {
                return horn;
            }
            set
            {
                horn = value;
            }
        }

        public string Type
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
            }
        }

        public int Since
        {
            get
            {
                return since;
            }
            set
            {
                since = value;
            }
        }
        public int Speed
        {
            get
            {
                return speed;
            }
            set
            {
                speed = value;
            }
        }


        public void Gas(int sound)
        {
            Console.WriteLine("Speed");
            Console.WriteLine("Mobil {0} berjalan dengan kecepatan {1} Km/h.\n", type, speed);
        }
        
        public void Klakson(string sound)
        {
            Console.WriteLine("Suara");
            Console.WriteLine("{0}\n", sound);
        }
    
        public void TampilkanInfo()
        {
            Console.WriteLine("Mobil saya berwarna {0}, merek {1} model {2} keluaran tahun {3}\ndengan jumlah pintu sebanyak {4}.", color, brand, type, since, doors);
        }
    }
}



