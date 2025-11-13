namespace CustomTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int dayOfWeek = 6;
           // WeekDays day = WeekDays.Wednesday;
           WeekDays day = (WeekDays)dayOfWeek;
            System.Console.WriteLine($"Enum day of week: {day} ({(int)day})");
        }
    }

    // Custom type representing days of the week
    enum WeekDays : ulong
    {
        Sunday = 1,
        Monday = 2,
        Tuesday = 4,
        Wednesday = 7,
        Thursday = 8,
        Friday = 16,
        Saturday = 32
    }
}
