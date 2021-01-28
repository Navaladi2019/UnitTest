using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{


    public class DegreeConverter
    {
        public double ToFarenheit(int degree)
        {
            double farenheir = 32;
            if(degree > 0)
            {
                farenheir = farenheir * degree;
            }
            return farenheir;
        }

        public double ToCelsius(int v)
        {
            return 0;
        }
    }
}
