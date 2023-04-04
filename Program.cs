using oopMobil;
using System;
using System.Collections.Generic;
using System.Drawing;
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

        mobil1.Color = "Meta Black";
        mobil1.Brand = "Nissan GT-R";
        mobil1.Type = "R-36";
        mobil1.Horn = "Ratatata!!";
        mobil1.Doors = 2;
        mobil1.Since = 2027;
        mobil1.Speed = 320;

        mobil1.Gas(mobil1.Speed);
        mobil1.Klakson(mobil1.Horn);
        mobil1.TampilkanInfo();

        Console.ReadKey();
    }
}