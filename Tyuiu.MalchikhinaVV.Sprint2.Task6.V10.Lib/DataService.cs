using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.MalchikhinaVV.Sprint2.Task6.V10.Lib
{
    public class DataService : ISprint2Task6V10
    {
        public string FindDateOfPreviousDay(int g, int m, int n)
        {
            switch (n)
            {
                case 1:
                    switch (m)
                    {
                        case 1:
                            n = 31; m = 12; g--;
                            break;
                        default:
                            m--;
                            n = m switch
                            {
                                1 or 3 or 5 or 7 or 8 or 10 => 31,
                                2 => 28,
                                _ => 30
                            };
                            break;
                    }
                    break;
                default:
                    n--;
                    break;
            }
            return $"{n:D2}.{m:D2}.{g}";
        }
    }
}
