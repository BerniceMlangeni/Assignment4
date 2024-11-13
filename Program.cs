namespace Assignment4
{
    using System;

        public class Weather
        {
            // Private members for storing weather details
            private double temperature;
            private int humidity;
            private double windSpeed;

            // Public property for the location this can be read and also changed
            public string Location { get; set; }

            // Public read-only properties to access weather details
            public double Temperature => temperature;
            public int Humidity => humidity;
            public double WindSpeed => windSpeed;

            // Constructor to initialize location with default weather values that i assign myself
            public Weather(string location)
            {
                Location = location;
                temperature = 20.0; 
                humidity = 50;      
                windSpeed = 20.0;   
            }

            // Method to simulate a weather forecast with random adjustments
            public void DisplayForecast()
            {
                Random random = new Random();
                Console.WriteLine($" Weather Forecast for {Location}:");
                Console.WriteLine($"Temperature: {temperature + random.Next(-3, 4)}°C"); // +/-3 degrees difference
                Console.WriteLine($"Humidity: {humidity + random.Next(-10, 11)}%");
                Console.WriteLine($"Wind Speed: {windSpeed + random.NextDouble() * 5} km/h\n");
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                // Creating a new Weather object with only the location
                Weather currentWeather = new Weather("Polokwane, University of Limpopo");

                // Display weather
                currentWeather.DisplayForecast();
            }
        }

}
