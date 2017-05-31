using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;

namespace BettingCA
{
    public class ReadData
    {
        public void ReadTeamNames()
        {
            using (TextFieldParser parser = new TextFieldParser(@"C:\Users\Goran\Documents\Visual Studio 2017\Projects\BettingCA\Data\test.csv"))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");
                while (!parser.EndOfData)
                {
                    //Processing row
                    string[] fields = parser.ReadFields();
                    int lastElement = fields.Length;
                    int count = 0;
                    foreach (string i in fields)
                    {
                        if (count < lastElement - 1)
                        {
                            System.Console.Write(i);
                        }
                        else
                        {
                            System.Console.WriteLine(i);
                        }
                        count++;
                    }
                    foreach (string field in fields)
                    {
                        //TODO: Process field
                        System.Console.WriteLine(field);
                    }
                }
            }
        }
        
    }
}
