using DayOfTheWeekApp.Core;

namespace DayOfTheWeekApp
{
    public static class EnumExtension
    {
        public static string ToPolishString(this DayOfTheWeek dayOfTheWeek)
        {
            switch (dayOfTheWeek)
            {
                case DayOfTheWeek.Monday:
                    return "Poneidzialek";
                case DayOfTheWeek.Tuesday:
                    return "Wtorek"; ;
                case DayOfTheWeek.Wensday:
                    return "Środa"; ;
                case DayOfTheWeek.Thursday:
                    return "Czwartek"; ;
                case DayOfTheWeek.Friday:
                    return "Piątek"; ;
                case DayOfTheWeek.Saturday:
                    return "Sobota"; ;
                case DayOfTheWeek.Sunday:
                    return "Niedziela"; ;
                default:
                    return "Poniedzialek";
            }
        }
    }
}
