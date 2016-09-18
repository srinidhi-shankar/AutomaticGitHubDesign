using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace githubdesign
{
    /// <summary>
    /// Create Checkin dates for GitHub to create a pattern in the contribution visualizer at https://github.com/srinidhi-shankar 
    /// Takes a pattern input string. Currently supports only chars A-Z (not case-sensitive)
    /// All alphabets occupy 5x3 (rows x columns)
    /// </summary>
    class Program
    {
		// Sunday = 0, Saturday =1 ... 
        public enum Days { Sunday,Saturday,Friday,Thursday,Wednesday,Tuesday, Monday};
      
        static void Main(string[] args)
        {
			//Input the Pattern string
            string str = Console.ReadLine();

            Generatedatesforcheckin(str);
            
            
            Console.ReadKey();
        }

        private static void Generatedatesforcheckin(string str)
        {
            Type type = Type.GetType("githubdesign.Program+Days");
            //All checkins start from Sunday. Get next saturday (or today if today is saturday) and then start generating check-in dates from the next day.  
            DateTime nextsaturday = DateTime.Now.AddDays(((int)type.GetField(DateTime.Now.DayOfWeek + "").GetValue(type))-1);

            DateTime dt = nextsaturday;

            var datelist = new List<DateTime>();

            foreach(char ch in str)
            {
                if (ch != ' ')
                {
                    char chUpper = Char.ToUpper(ch);
                    Type type1 = Type.GetType("githubdesign.Alphabet");
                    int[,] arr = (int[,])type1.GetField(chUpper.ToString()).GetValue(type1);
                    for (int i = 0; i < arr.GetLength(1); i++)
                    {
                        for (int j = 0; j < arr.GetLength(0); j++)
                        {
                            dt = dt.AddDays(1);
                            if (arr[j, i] == 1)
                            {
                                datelist.Add(dt);
                            }
                        }
                        dt = dt.AddDays(2);
                    }
                    //Leave a column after every alphabet
                    dt = dt.AddDays(7);
                }
                else if( ch == ' ')
                {
                    //Leave a column for space between words
                    dt = dt.AddDays(7);
                }

            }

            //Write the check-in dates to a file. Thsese dates will be picked up by a powershell application that runs everyday and pushes them to github.
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(path: str+".txt", append: false))
            {
                foreach (DateTime date in datelist)
                {
                    file.WriteLine(date.ToString("M/dd/yyyy"));
                }
            }
            
            
        }
    }
}
    