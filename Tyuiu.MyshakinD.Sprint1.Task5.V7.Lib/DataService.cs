﻿using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.MyshakinD.Sprint1.Task5.V7.Lib
{
    public class DataService : ISprint1Task5V7
    {
        public int AngleToHoursMinutes(double f)
        {
            return ((int)(f / 60.0));
        }
    }
}
