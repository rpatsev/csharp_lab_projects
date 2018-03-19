using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockFunctional
{
    public class Clock
    {

        public Clock()
        {

        }

        private const int SecondsInMinute = 60;
        private const int MunutesInHour = 60;
        private const int HoursInDay = 24;

        public event EventHandler<>;

        private void OnTicked()
        {
            if(Ticked != null)
            {
                Ticked(this, new TimeEventArgs(_hour, _minute, _second));
            }
        }

        
 
    }
}
