using System;
using System.Globalization;

namespace Learn
{
    public class Settlement
    {
        public void Run()
        {
            var getCurrentHour = DateTime.Now.Hour;

            if (getCurrentHour >= 0 & getCurrentHour <= 5)
            {
                this.SleepDude();
                return;
            }
            else if (getCurrentHour >= 5 & getCurrentHour <= 11)
            {
                this.GoodMorning();
                return;
            }
            else if (getCurrentHour >= 12 & getCurrentHour <= 18)
            {
                this.GoodEvening();
                return;
            }


            this.GoodNight();
            return;
        }
        private void SleepDude()
        {
            Console.Write("Hey dude! You need to SLEEP!!! GO... \nI'm still see you");
        }
        private void GoodMorning()
        {
            Console.Write("Good Morning :D");
        }
        private void GoodEvening()
        {
            Console.Write("Good Evening :(");
        }

        private void GoodNight()
        {
            Console.Write("Good Night :P");
        }
    }
}