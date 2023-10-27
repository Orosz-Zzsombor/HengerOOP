using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp2
{
    public class Henger
    {
        private double magassag;
        private double sugar;
        private static int szuletesSzamlalo = 0;

        public Henger(double magassag, double sugar)
        {
            this.magassag = magassag;
            this.sugar = sugar;
            szuletesSzamlalo++;


        }

        public double GetMagassag
        {
            get => magassag;

        }

        public double GetSugar
        {
            get => sugar;
 
        }

        public static int SzuletesSzamlalo
        {
            get => Henger.szuletesSzamlalo;
        }

        public double Terfogat()
        {
            return Math.Pow(sugar, 2) * magassag;
        }

        public override string ToString()
        {
            return ($"Jellemzők >> térfogat{Terfogat()}; sugár {sugar}; magasság:{magassag};"); ;
        }
    }
}