using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp2
{
    public class Cso : Henger
    {
        private double falVastagsag;

        public Cso(double sugar, double magassag, double falVastagsag):base(sugar,magassag)
        {
            this.falVastagsag = falVastagsag;
        }

        public double FalVastagsag
        {
            get => falVastagsag;

        }

        public double Terfogat()
        {
            return Terfogat()- Math.Pow(GetSugar-falVastagsag, 2) * Math.PI * GetMagassag;
        }

        public override string ToString()
        {
           return ($"Jellemzők >> térfogat{Terfogat()}; sugár {GetSugar}; magasság:{GetMagassag}; falvastagsag{FalVastagsag}"); ;
        }
    }
}