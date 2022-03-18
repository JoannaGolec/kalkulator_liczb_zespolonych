using System;
using System.Collections.Generic;
using System.Text;

namespace kalkulator_liczb_zespolonych
{
    public class Liczba
    {
        string name;
        float xr;
        float xi;
    
    
        public Liczba( string name, float X, float Y)
        {
            this.name = name;
            this.xr = X;
            this.xi = Y;
        }

        public Liczba()

        {

            Random rnd = new Random();

            this.name = "z1";
            this.xr = rnd.Next(-101, 101);
            this.xi = rnd.Next(-101, 101);
            
        }
        
        public string ShowCoordinats()
        {
            return name +": " + xr + " + " + xi + "i";

        }

        public string Add(Liczba a, Liczba b)
        {
            float aa = (a.xr + b.xr);
            float bb = (a.xi + b.xi);
            aa.ToString("0.00");
            bb.ToString("0.00");
            return "addiction " + aa + " + " + bb + "i";                
        }

        public string Subtract(Liczba a, Liczba b)
        {
            float aa = (a.xr - b.xr);
            float bb = (a.xi - b.xi);
            aa.ToString("0.00");
            bb.ToString("0.00");
            return "subtraction: " + aa + " + " + bb + "i";
        }
/*
        public string Multiplicate(Liczba a, Liczba b)
        {
            float aa = (a.xr * b.xr);
            float bb = (a.xr * b.xi);
            float cc = (b.xr * a.xi);
            float dd = (a.xi * b.xi);
            float ee = bb + cc;
            float ff = aa + dd;
            ee.ToString("0.00");
            ff.ToString("0.00");

            return ff + " + " + ee + "i";
        }
        */

        public string Multiplicate(Liczba a, Liczba b)
        {
            float aa = a.xr * b.xr + a.xi * b.xi * -1;
            float bb = a.xr * b.xi + b.xr * a.xi;
            aa.ToString("0.00");
            bb.ToString("0.00");

            return "multilication: " + aa + " + " + bb + "i";
        }
        public string Divide(Liczba a, Liczba b)
        {
            float aa = a.xr * b.xr + a.xi * b.xi;
            float bb = b.xr*b.xr +  b.xi*b.xi;
            float cc = a.xi*b.xr - a.xr*b.xi;
            
            aa.ToString("0.00");
            bb.ToString("0.00");
            cc.ToString("0.00");

            return "division: " + aa + "/" + bb + " + " + cc + "/" + bb + "i" + " = " + aa / bb + " + " + cc / bb + "i";
        }

    }
}
