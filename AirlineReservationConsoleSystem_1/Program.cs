namespace AirlineReservationConsoleSystem_1
{
    internal class Program
    {

        static int Max_Flight = 3;
        static int FlightCounter = 0;
        static string[] flightCode_A = new string[Max_Flight];
        static string[] fromCity_A = new string[Max_Flight];
        static string[] toCity_A = new string[Max_Flight];
        static DateTime[] departureTime_A = new DateTime[Max_Flight];
        static int[] duration_A = new int[Max_Flight];
        static int[] SeatsNum_A = new int[Max_Flight];
        static int[] SeatReserved_A = new int[Max_Flight];


        static bool isValid = false;

        //                                =====================Startup & Navigation=============

        // 1. display welcome message method....
        public static void DisplayWelcomeMessage()
        {
            Console.WriteLine("Welcome to Airline Reservation System");
        }
        // 2. show main menu method
        public static int ShowMainMenu()
        {
            int option = 0;
            do
            {

                Console.Clear();

                Console.WriteLine("Airline Reservation System");
                Console.WriteLine("1. Add Flight");
                Console.WriteLine("2. Display All Flights");
                Console.WriteLine("3. Find Flight By Code");
                Console.WriteLine("4. Update Flight Departure");
                Console.WriteLine("5. Cancel Flight Booking");
                Console.WriteLine("0. Exit");
                Console.WriteLine("Enter the option: ");
                string input = Console.ReadLine();
                try
                {
                    option = int.Parse(input);
                    isValid = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a number between 0 and 5.");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    isValid = false;
                }
            } while (!isValid);

            return option;
        }

        // 3. Exit Application method
        public static void ExitApplication()
        {
            Console.WriteLine("Thanks! Have Happy Day!");
        }



        // 4. Add Flight method

        public static void AddFlight(string flightCode, string fromCity, string toCity, DateTime departureTime, int duration, int SeatsNum)
        {
            if (FlightCounter < Max_Flight)
            {
                flightCode_A[FlightCounter] = flightCode;
                fromCity_A[FlightCounter] = fromCity;
                toCity_A[FlightCounter] = toCity;
                departureTime_A[FlightCounter] = departureTime;
                duration_A[FlightCounter] = duration;
                SeatsNum_A[FlightCounter] = SeatsNum;
                SeatReserved_A[FlightCounter] = 0;
                FlightCounter++;
                Console.WriteLine("Flight added successfully.");
            }
            else
            {
                Console.WriteLine("Cannot add more flights. Maximum limit reached.");
            }



        }





    }

}
