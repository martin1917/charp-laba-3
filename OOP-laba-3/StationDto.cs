using System;
using System.Text.RegularExpressions;

namespace OOP_laba_3
{
    public class StationDto
    {
        public string Name { get; set; }
        public string Director { get; set; }
        public string SeatsNumber { get; set; }
        public string WaysNumber { get; set; }
        public string Area { get; set; }
        public string PassagersAtStation { get; set; }
        public string EmployeesAtStation { get; set; }

        public StationDto(string name, string director, string seatsNumber, string waysNumber, string area, string passagersAtStation, string employeesAtStation)
        {
            Name = name;
            Director = director;
            SeatsNumber = seatsNumber;
            WaysNumber = waysNumber;
            Area = area;
            PassagersAtStation = passagersAtStation;
            EmployeesAtStation = employeesAtStation;
        }

        public RailwayStation ToStation()
        {
            try
            {
                Validate();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return new RailwayStation(
                Name,
                int.Parse(SeatsNumber),
                int.Parse(WaysNumber),
                double.Parse(Area.Replace('.', ',')),
                int.Parse(PassagersAtStation),
                int.Parse(EmployeesAtStation),
                Director
            );
        }

        public void Validate()
        {
            string errorMessage = "";

            string regexForInt = "^\\d{1,5}$";
            string regexForDouble = "^\\d{1,5}(|[\\,\\.]\\d+)$";

            if (string.IsNullOrEmpty(Name.Trim()))
                errorMessage += "• Поле Имя не может быть пустым\n";

            if (string.IsNullOrEmpty(Director.Trim()))
                errorMessage += "• Поле Директор не может быть пустым\n";

            if (!Regex.IsMatch(SeatsNumber, regexForInt))
                errorMessage += "• Кол-во мест должно быть целым числом\n";

            if (!Regex.IsMatch(WaysNumber, regexForInt))
                errorMessage += "• Кол-во путей должно быть целым числом\n";

            if (!Regex.IsMatch(Area, regexForDouble))
                errorMessage += "• Площадь должна быть вещественным числом\n";

            if (!Regex.IsMatch(PassagersAtStation, regexForInt))
                errorMessage += "• Кол-во пассажиров должно быть целым числом\n";

            if (!Regex.IsMatch(EmployeesAtStation, regexForInt))
                errorMessage += "• Кол-во персонала должно быть целым числом\n";

            if (!string.IsNullOrEmpty(errorMessage))
            {
                throw new Exception(errorMessage);
            }
        }
    }
}
