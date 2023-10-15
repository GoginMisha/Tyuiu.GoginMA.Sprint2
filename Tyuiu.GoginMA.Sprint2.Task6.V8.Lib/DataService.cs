using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.GoginMA.Sprint2.Task6.V8.Lib
{
    public class DataService : ISprint2Task6V8
    {
        public string FindDateOfPreviousDay(int m, int n)
        {
            if (n == 1)
            {
                switch (m)
                {
                    case 2: return "31.01";
                    case 3: return "28.02";
                    case 4: return "31.03";
                    case 5: return "30.04";
                    case 6: return "31.05";
                    case 7: return "30.06";
                    case 8: return "31.07";
                    case 9: return "31.08";
                    case 10: return "30.09";
                    case 11: return "31.10";
                    case 12: return "30.11";
                    default: throw new ArgumentException($"Месяц должен быть от 2 до 12. Значение {m}");
                }
            }
            else
            {
                if (n < 11)
                {
                    switch (m)
                    {
                        case 1: return (Convert.ToString("0" + (n - 1)) + ".01");
                        case 2: return (Convert.ToString("0" + (n - 1)) + ".02");
                        case 3: return (Convert.ToString("0" + (n - 1)) + ".03");
                        case 4: return (Convert.ToString("0" + (n - 1)) + ".04");
                        case 5: return (Convert.ToString("0" + (n - 1)) + ".05");
                        case 6: return (Convert.ToString("0" + (n - 1)) + ".06");
                        case 7: return (Convert.ToString("0" + (n - 1)) + ".07");
                        case 8: return (Convert.ToString("0" + (n - 1)) + ".08");
                        case 9: return (Convert.ToString("0" + (n - 1)) + ".09");
                        case 10: return (Convert.ToString("0" + (n - 1)) + ".10");
                        case 11: return (Convert.ToString("0" + (n - 1)) + ".11");
                        case 12: return (Convert.ToString("0" + (n - 1)) + ".12");
                        default: throw new ArgumentException($"Месяц должен быть от 1 до 12. Значение {m}");
                    }
                }
                else
                {
                    switch (m)
                    {
                        case 1: return (Convert.ToString((n - 1)) + ".01");
                        case 2: return (Convert.ToString((n - 1)) + ".02");
                        case 3: return (Convert.ToString((n - 1)) + ".03");
                        case 4: return (Convert.ToString((n - 1)) + ".04");
                        case 5: return (Convert.ToString((n - 1)) + ".05");
                        case 6: return (Convert.ToString((n - 1)) + ".06");
                        case 7: return (Convert.ToString((n - 1)) + ".07");
                        case 8: return (Convert.ToString((n - 1)) + ".08");
                        case 9: return (Convert.ToString((n - 1)) + ".09");
                        case 10: return (Convert.ToString((n - 1)) + ".10");
                        case 11: return (Convert.ToString((n - 1)) + ".11");
                        case 12: return (Convert.ToString((n - 1)) + ".12");
                        default: throw new ArgumentException($"Месяц должен быть от 1 до 12. Значение {m}");
                    }
                }
            }
        }
    }
}
