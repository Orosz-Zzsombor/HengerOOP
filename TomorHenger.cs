﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp2
{
    public class TomorHenger : Henger
    {
        private double fajsuly;

        public TomorHenger(double sugar, double magassag, double fajsuly = 7.87):base(sugar,magassag)
        {
            this.fajsuly = fajsuly;
        }



        public double GetFajsuly
        {
            get => fajsuly;

        }

        public double Suly
        {
            get => fajsuly*Terfogat();

        }

        public override string ToString()
        {
            return $"Jellemzők >> térfogat{Terfogat()}; sugár {GetSugar}; magasság:{GetMagassag}; fajsúly{fajsuly}"; 
        }
    }
}