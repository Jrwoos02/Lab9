using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
   public class Date
    {
        public int dayhold = 1; // Used To Hold The Day, This value is updated when the user calls the Date.Day Method
        public int monthhold = 1;// Same As Above
        public int yearhold = 2001; // Same As Above
      public int Day(int day)
       {
           if (day >= 1 && day <= 31)
           {
               dayhold = day;
               return day;
           }
           else
           {
               return dayhold;
           }
       }
       public int Month(int Month)
       {

           if (Month >= 1 && Month <= 12)
           {
               monthhold = Month;
               return Month;
           }
           else
           {
               return monthhold;
           }
       }
       public int Year(int Year)
       {

           if (Year >= 0)
           {
               yearhold = Year;
               return Year;
           }
           else
           {
               return yearhold;
           }
       }
       public override string ToString()
       {
           string result;
           result = monthhold.ToString("D2") + "/" + dayhold.ToString("D2") + "/" + yearhold.ToString("D4");
           return result;

       }
       public string CurrentDate()
       {
           return "01/01/2001";
       }
    }
}
