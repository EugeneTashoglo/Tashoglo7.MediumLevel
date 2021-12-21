using System;

namespace Tashoglo7.MediumLevel
{
    class Program
    {
            public struct Cinema
        {
            public string NameFilm;
            public DateTime DateT;
            public int TimeLapse;
            public string Genre;
            public double Budget;
            public Cinema(string NameFilm, DateTime DateT, int TimeLapse, string Genre, double Budget)
            {
                this.NameFilm = NameFilm;
                this.DateT = DateT;
                this.TimeLapse = TimeLapse;
                this.Genre = Genre;
                this.Budget = Budget;
            }
            public void WriteCinema()
            {
                Console.WriteLine("Название фильма {0}, дата и время сеанса: {1:dd/M/yyyy HH:mm}", NameFilm, DateT);
                Console.WriteLine("продолжительность: {0} мин., жанр: {1}, бюджет: {2:C}", TimeLapse, Genre, Budget);
            }
        }
        static void Main(string[] args)
        {

            Cinema info1 = new Cinema("Spieder-Man", new DateTime(2021, 12, 15, 17, 0, 0), 75, "Фантастика", 444444);
            info1.WriteCinema();

            if (info1.DateT.Hour == 18 && info1.DateT.Minute == 0)
            {

            }

        }
    }
}