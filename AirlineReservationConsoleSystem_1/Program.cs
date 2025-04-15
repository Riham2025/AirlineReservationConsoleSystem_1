using System;
using System.Diagnostics;

namespace AirlineReservationConsoleSystem_1
{
    internal class Program
    {
        // global variables and arraies for flight .

        static int Max_Flight = 3;
        static int FlightCounter = 0;
        static string[] flightCode_A = new string[Max_Flight];
        static string[] fromCity_A = new string[Max_Flight];
        static string[] toCity_A = new string[Max_Flight];
        static DateTime[] departureTime_A = new DateTime[Max_Flight];
        static int[] duration_A = new int[Max_Flight];
        static int[] recerved_char = new int[Max_Flight];
        static int[] char_available = new int[Max_Flight];

        // flag to validate the user input 
        static bool isValid = true;

        // check if exist
        static bool isExist = false;


        // variables and arraies Passenger Booking Functions section
        static int BookingCounter = 0;
        static string[] passengerName_A = new string[100];
        static string[] BookingFlightCode_A = new string[100];
        static string[] GenerateBookingID_A = new string[100];
        static int tickets = 0;

        //   =====================Startup & Navigation=============

        // 1. display welcome message method.....
        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to Airline Reservation System");

        }

        // 2. show main menu method
        public static int  ShowMainMenu()
        {
            Console.Clear();// Just to clear the screen
            Console.WriteLine("Airline Reservation System");
            Console.WriteLine("1. Add Flight");
            Console.WriteLine("2. Display All Flights");
            Console.WriteLine("3. Find Flight By Code");
            Console.WriteLine("4. Update Flight Departure");
            Console.WriteLine("5. Cancel Flight Booking");
            Console.WriteLine("6. Book Flight");
            Console.WriteLine("7. Validate Flight Code");
            Console.WriteLine("8. Display Flight Details");
            Console.WriteLine("9.Search Bookings By Destination");
            Console.WriteLine("10. Calculate Fare");
            Console.WriteLine("0. Exit");
            Console.WriteLine("Enter the option: ");
            string input = Console.ReadLine();
            int choice = 0;
            do
            {
                
                
                
                try
                {
                    choice = int.Parse(input);// Attempt to parse the input
                    isValid = true; // Set to true if parsing is successful
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();// Wait for user to acknowledge the message
                    isValid = false; // Keep isValid false to repeat the loop

                }
            } while (!isValid); // Repeat until a valid choice is made
            return choice;

        }

        // 3. Exit Application method
        public static void ExitApplication()
        {
            Console.WriteLine("Thank you for using the Airline Reservation System. Goodbye!");

        }

        //4. Add Flight method
        public static void AddFlight(string flightCode, string fromCity, string toCity, DateTime departureTime, int duration)
        {
            //if all validations are passed
            flightCode_A[FlightCounter] = flightCode;
            fromCity_A[FlightCounter] = fromCity;
            toCity_A[FlightCounter] = toCity;
            departureTime_A[FlightCounter] = departureTime;
            duration_A[FlightCounter] = duration;
            FlightCounter++;

        }

        //5. Display All Flights..

        public static void DisplayAllFlights()
        {
            // Loop through all flights.
            for (int i = 0;  i < FlightCounter; i++ )
            {
                Console.WriteLine("fligh tCode : " + flightCode_A[i]);
                Console.WriteLine("from City : " + fromCity_A[i]);
                Console.WriteLine("to City : " + toCity_A[i]);
                Console.WriteLine("departure Time : " + departureTime_A[i]);
                Console.WriteLine("duration : " + duration_A[i]);

               

            }

        }

        // 6. Find Flight By Code

        public static bool FindFlightByCode(string code)
        {

            int index = 0;
            bool isFound = false;
            for (int i=0; i< FlightCounter; i++  )
            {
                if (flightCode_A[i] == code)
                {
                    isFound = true;
                    index = i;
                    break;
                }
                //else
                //{
                //    isFound = false;
                //}
            }
            if (isFound)
            {
                Console.WriteLine("flight Code : " + flightCode_A[index]);
                Console.WriteLine("from City : " + fromCity_A[index]);
                Console.WriteLine("to City : " + toCity_A[index]);
                Console.WriteLine("departure Time : " + departureTime_A[index]);
                Console.WriteLine("duration : " + duration_A[index]);
            }
            else
            {
                Console.WriteLine("not found");
            }

            return false;

        }

        //7. Update Flight Departure(ref DateTime departure) 

        public static void UpdateFlightDeparture(ref DateTime departure)
        {
            Console.WriteLine("Enter the flight Code ");
            string flightCode_user = Console.ReadLine();

            for (int i = 0; i < FlightCounter; i++)
            {
                if (flightCode_user == flightCode_A[i])
                {
                    departureTime_A[i] = departure;
                }
            }
        }









        //  18. Start System method ..
        public static void StartSystem()
        {
            // calling DisplayWelcomeMessage() function 
            WelcomeMessage();

            // Wait for user to press any key before continuing
            Console.ReadLine();

            // calling ShowMainMenu() function
            
            while (true)
                { 
            int chiose = ShowMainMenu();

                switch (chiose)
                {
                    case 1:
                        // Add Flightfuncation
                        Console.WriteLine("Enter the  flight Code");
                        string flightCode_userInout = Console.ReadLine();

                        Console.WriteLine("Enter the  from city");
                        string fromCity_userInout = Console.ReadLine();

                        Console.WriteLine("Enter the  to city");
                        string toCity_userInout = Console.ReadLine();


                        Console.WriteLine("Enter the  date and time :2025-07-08 12:30");
                        DateTime departureTime_userInout = DateTime.Parse(Console.ReadLine());


                        Console.WriteLine("Enter the  duraion");
                        int duration_userInout = int.Parse(Console.ReadLine());



                        AddFlight(flightCode: flightCode_userInout, fromCity: fromCity_userInout, toCity: toCity_userInout, departureTime: departureTime_userInout, duration: duration_userInout);

                        break;


                    case 2: //Display All Flights

                        DisplayAllFlights();
                        Console.ReadLine();
                        break;

                    case 3: //FindFlightByCode(string code)
                        Console.WriteLine("Enter the  flight Code : ");
                        string flightCode_B = Console.ReadLine();

                        FindFlightByCode(flightCode_B);

                        Console.ReadLine();

                        break;

                    case 4: // Update Flight Departure(ref DateTime departure)
                        Console.WriteLine("Enter the new update Time");
                        DateTime new_dataTime = DateTime.Parse(Console.ReadLine());
                        UpdateFlightDeparture(ref new_dataTime);
                        Console.ReadLine();

                        break;

                }
                    








            }





        }
        static void Main(string[] args)
        {
            StartSystem();
        }
    }


}

