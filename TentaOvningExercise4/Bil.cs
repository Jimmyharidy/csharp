using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TentaOvningExercise4
{
    class Bil
    {
        private string typ;
        private string color;
        private int antalVaxlar;
        private string mark;
        

        public string Typ
        {
            get { return typ; }
            set
            {
                if (value.ToLower() == "kupe" || value.ToLower() == "kombi")
                    typ = value.ToLower();
                else
                
                    throw new Exception("Not a valid input!");
                
            }
        }



        public string Color
        {
            get { return color; }
            set { color = value; }
        }



        public int AntalVaxlar
        {
            get { return antalVaxlar; }
            set { antalVaxlar = value; }
        }


        public string Mark
        {
            get { return mark; }
            set { mark = value; }
        }

        public Bil()
        {
            Typ = "kombi";
            Color = "black";
            AntalVaxlar = 5;
            Mark = "BMW";
        }

        public Bil(string typ, string color, int antalVaxlar, string mark)
        {
            Typ = typ;
            Color = color;
            AntalVaxlar = antalVaxlar;
            Mark = mark;
        }

        public override string ToString() => $"Typ: {Typ}\r\nColor: {Color}\r\nAntalet Växlar: {AntalVaxlar}\r\nMark: {Mark}";
    }
}
