using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopMobil
{
    internal class mobil
    {
        public string color { get; set; }
        public string brand { get; set; }
        public string type { get; set; }
        public string horn { get; set; }
        public int doors { get; set; }
        public int since { get; set; }
        public int speed { get; set; }

        
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
            Console.WriteLine("Method 3:");
            Console.WriteLine("Mobil saya berwarna {0}, merek {1} model {2} keluaran tahun {3}\ndengan jumlah pintu sebanyak {4}.", color, brand, type, since, doors);
        }
    }
}



