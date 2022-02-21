using System;

namespace OOP_laba_3
{
    public class RailwayStation
    {
        public string Name { get; set; }
        public int SeatsNumber { get; set; }
        public int WaysNumber { get; set; }
        public double Area { get; set; }
        public int EmployeesAtStation { get; set; }
        public int PassagersAtStation { get; set; }
        public string Director { get; set; }

        public RailwayStation(string name, int seatsNumber, int waysNumber, double area, int passagersAtStation, int employeesAtStation, string director)
        {
            Name = name;
            SeatsNumber = seatsNumber;
            WaysNumber = waysNumber;
            Area = area;
            PassagersAtStation = passagersAtStation;
            EmployeesAtStation = employeesAtStation;
            Director = director;
        }

        public RailwayStation(string name) : this(name, 10, 3, 100.0, 0, 0, "Не назначен") { }

        public RailwayStation(string name, string director) : this(name, 10, 3, 100.0, 0, 0, director) { }

        public RailwayStation() : this("Не назначено", 10, 3, 100.0, 0, 0, "Не назначен") { }

        public override string ToString()
        {
            return $"Название вокзала: {Name}\n" +
                $"Начальник вокзала: {Director}\n" +
                $"Количество сидячих мест: {SeatsNumber}\n" +
                $"Количсетво путей: {WaysNumber}\n" +
                $"Площадь: {Area}\n" +
                $"Количество пассажиров на вокзале: {PassagersAtStation}\n" +
                $"Количество персонала на вокзале: {EmployeesAtStation}\n";
        }

        public void printName()
        {
            Console.WriteLine($"Название вокзала: {Name}\n");
        }
    }
}
