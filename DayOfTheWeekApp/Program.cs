using DayOfTheWeekApp.Core;
using System;

namespace DayOfTheWeekApp
{
    class Program
    {
        static void Main(string[] args)
        {

            var guesser = new DayGuesser();
            guesser.IntroduceTheApplication();
            guesser.AskUserForTheirDateOfBrith();
            guesser.CalculateDayOfTheWeek();
            guesser.PrintDayOfTheWeek();
        }
    }
}
