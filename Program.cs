using oopMobil;
using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopMobil;

internal class Program
{
    static void Main(string[] args)
    {
        
        mobil mobil1 = new mobil();
        mobil1.color = "MetaBlack";
        mobil1.brand = "Nissan GT-R";
        mobil1.type = "R-36";
        mobil1.horn = "Ratatata!!";
        mobil1.doors = 2;
        mobil1.since = 2027;
        mobil1.speed = 320;

        mobil1.Gas(mobil1.speed);
        mobil1.Klakson(mobil1.horn);
        mobil1.TampilkanInfo();

        Console.ReadKey();
    }
}