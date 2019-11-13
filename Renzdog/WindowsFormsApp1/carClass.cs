using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Karbro
{
    class BMW
    {
        public string[] model = new string[] { "BMW X7", "BMW Z4", "BMW 6 Series Gran Turismo", "BMW 5 Series", "BMW 4 Series Coupe", "BMW X4", "BMW 7 Series" };
        public string[] engine = new string[] { "265", "197", "262", "330i", "430", "188", "265" };
        public string[] enginetype = new string[] { "In-Line 6", "In-Line 4", "In-Line 6", "In-Line 6", "In-Line 6", "In-Line4", "In-Line 6" };
        public string[] horsepower = new string[] { "265hp", "197hp", "262hp", "265hp", "425hp", "188hp", "265hp" };
        public string[] transimission = new string[] { "Automatic", "Automatic", "Automatic", "Automatic", "Automatic", "Automatic", "Automatic" };
        public string[] maxspeed = new string[] { "250 kph", "250 kph", "240 kph", "250kph", "249kph", "250kph", "260kph" };
        public int[] price = new int[] { 9290000, 3990000, 8790000, 7390000, 8880000, 5190000, 8990000 };
    }
    class Volvo
    {
        public string[] model = new string[] { "Volvo XC40", "Volvo XC60", "Volvo XC90" };
        public string[] engine = new string[] { "244", "245", "251" };
        public string[] enginetype = new string[] { "In-Line 4", "In-Line 4", "In-Line 4" };
        public string[] horsepower = new string[] { "244hp", "190hp", "235hp" };
        public string[] transimission = new string[] { "Automatic", "Automatic", "Automatic" };
        public string[] maxspeed = new string[] { "180kph", "220 kph", "209kph" };
        public int[] price = new int[] { 3350000, 4288000, 5495000 };
    }
    class Ferrari
    {
        public string[] model = new string[] { "Ferrari Portofino", "Ferrari 812 Superfast" };
        public string[] engine = new string[] { "592", "F140" };
        public string[] enginetype = new string[] { "V8", "V12" };
        public string[] horsepower = new string[] { "592hp", "800hp", };
        public string[] transimission = new string[] { "Dual-Clutch", "Dual-Clutch", };
        public string[] maxspeed = new string[] { "320 kph", "340 kph", };
        public int[] price = new int[] { 11500000, 39900000, };
    }
    class Jaguar
    {
        public string[] model = new string[] { "Jaguar E-Pace", "Jaguar XE", "Jaguar F-Type", "Jaguar XJ" };
        public string[] engine = new string[] { "148", "355", "355", "355" };
        public string[] enginetype = new string[] { "In-line 4", "V6", "V6", "V6" };
        public string[] horsepower = new string[] { "148hp", "335hp", "340hp", "335hp" };
        public string[] transimission = new string[] { "Automatic", "Automatic", "Automatic", "Automatic" };
        public string[] maxspeed = new string[] { "223 kph", "249 kph", "250 kph", "250 kph" };
        public int[] price = new int[] { 4190000, 2700000, 3100000, 3990000 };
    }
    class Ford
    {
        public string[] model = new string[] { "Ford Mustang", " Ford Expedition", "Ford Explorer" };
        public string[] engine = new string[] { "460", "375", "355" };
        public string[] enginetype = new string[] { "V8", "V6", "V6" };
        public string[] horsepower = new string[] { "460hp", "375hp", "178hp" };
        public string[] transimission = new string[] { "Automatic", "Automatic", "Automatic" };
        public string[] maxspeed = new string[] { "252 kph", "200 kph", "230 kph" };
        public int[] price = new int[] { 3700000, 4600000, 3100000 };
    }
    class Lamborghini
    {
        public string[] model = new string[] { "Lamborghini Urus", "Lamborghini Huracan", "Lamborghini Aventador" };
        public string[] engine = new string[] { "641", "602", "729" };
        public string[] enginetype = new string[] { "V8", "V10", "V12" };
        public string[] horsepower = new string[] { "641hp", "602hp", "729hp" };
        public string[] transimission = new string[] { "Automatic", "Dual-Clutch", "Automated Manual" };
        public string[] maxspeed = new string[] { "305 kph", "320 kph", "349 kph" };
        public int[] price = new int[] { 12700000, 10800000, 27000000 };
    }

    class Audi
    {
        public string[] model = new string[] { "Audi A4", "Audi RS5", "Audi RS6" };
        public string[] engine = new string[] { "188", "444", "597" };
        public string[] enginetype = new string[] { "In-Line 4", "V6", "V8" };
        public string[] horsepower = new string[] { "148hp", "444hp", "597" };
        public string[] transimission = new string[] { "Dual-Clutch", "Automatic", "Automatic" };
        public string[] maxspeed = new string[] { "210 kph", "280 kph", "304 kph" };
        public int[] price = new int[] { 3450000, 8500000, 11800000 };
    }
    class Honda
    {
        public string[] model = new string[] { "Honda CR-V", "Honda BR-V", "Honda Odyssey" };
        public string[] engine = new string[] { "118", "118", "173" };
        public string[] enginetype = new string[] { "In-Line 4", "In-Line 4", "In-Line 4" };
        public string[] horsepower = new string[] { "118hp", "118hp", "173hp" };
        public string[] transimission = new string[] { "Automatic", "Continuosly Variable", "Continuosly Variable" };
        public string[] maxspeed = new string[] { "195 kph", "210 kph", "210 kph" };
        public int[] price = new int[] { 2100000, 1100000, 2600000 };
    }
    class Porsche
    {
        public string[] model = new string[] { "Porsche Cayenne", "Porsche Macan" };
        public string[] engine = new string[] { "255", "I-4 2, 0 1" };
        public string[] enginetype = new string[] { "V8", "V6" };
        public string[] horsepower = new string[] { "434hp", "348hp", };
        public string[] transimission = new string[] { "Automatic", "7-Speed automatic", };
        public string[] maxspeed = new string[] { "286 kph", "268 kph", };
        public int[] price = new int[] { 8500000, 3050000 };
    }
    class Dodge
    {
        public string[] model = new string[] { "Dodge Charger RT", "Dodge Charger SXT", "Dodge Charger GT" };
        public string[] engine = new string[] { "592", "292", "292" };
        public string[] enginetype = new string[] { "V6", "V6", "V6" };
        public string[] horsepower = new string[] { "370hp", "292hp", "292hp" };
        public string[] transimission = new string[] { "8-spd w/OD", "8-Speed Automatic", "8-Speed Automatic" };
        public string[] maxspeed = new string[] { "249 kph", "200 kph", "200kph" };
        public int[] price = new int[] { 1880000, 1400000, 1600000 };
    }
}
