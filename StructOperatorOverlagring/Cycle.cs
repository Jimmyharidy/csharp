using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace StructOperatorOverlagring
{
    struct Cycle
    {
        private int val, min, max;
        // Växlar vald, lägst och högst...

        public Cycle(int min, int max)
        {
            val = min;
            this.min = min;
            this.max = max;
        }

        public int Val
        {
            get { return val; }
            set
            {
                if(value >= min && value <= max)
                    val = value;
                val = min;
            }
            
        }

        public static Cycle operator +(Cycle cycle, int tal)
        {
            // Om klass gör vi såhär.
            /* om vi skapat referenstyp / class måste vi skapa en
                kopia som vi returnerar så att inte det object som skickas 
                in pekas på från 2 eller fler ställen.
           */
            cycle.max += tal;
            return cycle;
        }

        public static Cycle operator -(Cycle cycle, int tal)
        {
            cycle.max -= tal;
            return cycle;
        }

        public static int operator +(int tal, Cycle cycle)
        {
            tal += cycle.max;
            return tal;
        }

        public static int operator -(int tal, Cycle cycle)
        {
            tal -= cycle.max;
            return tal;
        }

        public static Cycle operator /(Cycle cycle, int tal)
        {
            cycle.max /= tal;
            return cycle;
        }
        public static int operator /(int tal, Cycle cycle)
        {
            tal /= cycle.max;
            return tal;
        }

        public static Cycle operator *(Cycle cycle, int tal)
        {
            cycle.max *= tal;
            return cycle;
        }

        public static int operator *(int tal, Cycle cycle)
        {
            tal *= cycle.max;
            return tal;
        }

      

        public override string ToString()
        {
            return $"Val: {Val}, Min: {min}, Max: {max}";
        }
    }
}
