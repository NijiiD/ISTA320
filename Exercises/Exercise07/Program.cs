using System;

namespace Exercise07
{
    class Program
    {
        static void Main(string[] args)
        {
            var spot = new Places[36];
            var place = new Places();

            for (int i = 1; i <= 36; i++)
            {
                //var place = new Places();
                double rowCounter = 3;
                place.number = i;
                place.color = i % 2 == 0 ? "Black" : "Red";
                place.column = (int)Math.Ceiling((double)i / 3);
                //place.row = (int)Math.Ceiling((double) i % 3);
                place.row = (int) rowCounter;
                if (i % 3 == 0)
                {
                    rowCounter--;
                }
             
                Console.WriteLine($"{place.number} {place.color}, Column {place.column}, Row {rowCounter} ");
            }
            
            Console.ReadLine();



        }
    }
    public class Places
    {
        public int number { get; set; }

        public string color { get; set; }

        public int row { get; set; }

        public int column { get; set; }


    }
}
