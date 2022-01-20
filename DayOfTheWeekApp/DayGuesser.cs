using DayOfTheWeekApp.Core;
using System;

namespace DayOfTheWeekApp
{
    public class DayGuesser
    {
        public DayCalculator Calculator { get; set; }

        public DateTimeOffset UserDateOfBrith { get; set; }
        public DayOfTheWeek UserDayOfTheWeek { get; set; }

        public void IntroduceTheApplication()
        {
           Console.WriteLine("Hey,jestem botem który wyliczy Ci dzien tygodnia po Twojej dacie urodzenia.");
            Calculator = new DayCalculator();
        }

        public void AskUserForTheirDateOfBrith()
        {
            Console.WriteLine("Podam mi proszę date urodzenia:");
            var userDate = Console.ReadLine();
            
            var succeded = DateTimeOffset.TryParse(userDate, out var date);
            if (succeded)
            {
                UserDateOfBrith = date;
                return;
            }
            Console.WriteLine("Format day byl zly!.Prosze podac go w dd/mm/yyyy");
            AskUserForTheirDateOfBrith();
        }
        public void CalculateDayOfTheWeek()
        {
            if(UserDateOfBrith == null)
            {
                Console.WriteLine("Musisz podac date urodzenia!");
                return;
            }

            UserDayOfTheWeek = Calculator.CalculateDayOfTheWeek(UserDateOfBrith);
        }
        public void PrintDayOfTheWeek()
        {
            Console.WriteLine("Obliczony dzień tygodnia to: " + UserDayOfTheWeek.ToPolishString());
            Console.ReadLine();
        }
    }
}
