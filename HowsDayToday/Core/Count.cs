using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace HowsDayToday.Core
{
    public class Count
    {
        public string name;
        public DateTime birthday;

        public int Tday, Tmonth, Tyear;

        public int BDay, BMonth, BYear;

        public int nameScore;

        public Count(string name,DateTime birthday)
        {
            name=name.ToLower();
            this.name = name;
            this.birthday = birthday;

            DateTime today = DateTime.Now;

            Tday = today.Day;
            Tmonth = today.Month;
            Tyear = today.Year;

            BDay = birthday.Day;
            BMonth = birthday.Month;
            BYear = birthday.Year;

            nameScore = 0;
            
            for (int i = 0; i < name.Length; i++)
            {
                nameScore += name[i];
            }
        }


        public int CalculateSocial()
        {
            long value = 0;

            value += nameScore + Tday + BDay + Tmonth + BMonth * BYear + Tday + Tmonth * Tyear;

            return (int)value%100;
        }

        public int CalculateRelationships()
        {
            long value = 0;
            value += nameScore + Tday * BDay * BMonth + BYear + Tmonth + Tday + Tmonth / Tyear;
            return (int)value%100;
        }

        public int CalculateWork()
        {
            long value = 0;
            value += Tmonth + Tday * BMonth * Tday + Tmonth + Tyear*Tday;
            return (int)value%100;
        }

        public int CalculatePersonal()
        {
            long value = 0;
            value += Tday * BMonth + Tday * BYear + nameScore * Tday + Tmonth + Tyear + Tday * Tmonth + Tyear;
            return (int)value%100;
        }

        public int CalculateFinance()
        {
            long value = 0;
            value += nameScore * Tmonth + nameScore * Tday + nameScore * Tyear+Tday+Tmonth*Tyear;
            return (int)value%100;
        }

        public int CalculateEntertainment()
        {
            long value = 0;
            value += nameScore * BMonth + nameScore * Tday + nameScore * BYear + Tday + Tmonth * Tyear;
            return (int)value%100;
        }

        


    }
}
