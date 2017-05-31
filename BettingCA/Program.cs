using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BettingCA
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadData instance = new ReadData();
            //System.Console.WriteLine("Hej");
            instance.ReadTeamNames();
            System.Console.ReadKey();

        }
    }
}
