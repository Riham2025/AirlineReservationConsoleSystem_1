namespace AirlineReservationConsoleSystem_1
{
    internal class Program
    {
        // global variables and arraies for flight ..

        static int Max_Flight = 3;
        static int FlightCounter = 0;
        static string[] flightCode_A = new string[Max_Flight];
        static string[] fromCity_A = new string[Max_Flight];
        static string[] toCity_A = new string[Max_Flight];
        static DateTime[] departureTime_A = new DateTime[Max_Flight];
        static int[] duration_A = new int[Max_Flight];
        static int[] SeatsNum_A = new int[Max_Flight];
        static int[] SeatReserved_A = new int[Max_Flight];
        static int[] price_A = new int[Max_Flight];

        // flag to validate the user input 
        static bool isValid = true;

        // check if exist
        static bool isExist = false;


        // variables and arraies Passenger Booking Functions section
        static int  BookingCounter = 0;
        static string[] passengerName_A = new string[100];
        static string[] BookingFlightCode_A = new string[100];
        static string[]  GenerateBookingID_A = new string[100];
        static int tickets = 0;

        //   =====================Startup & Navigation=============

        // 1. display welcome message method..........
        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to Airline Reservation System");
           
        }






        //  18. Start System method 
        public static void StartSystem()
        {
            // calling DisplayWelcomeMessage() function 
            WelcomeMessage();

            // Wait for user to press any key before continuing
            Console.ReadLine();


        }











        static void Main(string[] args)
        {
            StartSystem();
        }
    }
}




