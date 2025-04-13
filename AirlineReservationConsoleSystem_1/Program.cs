﻿namespace AirlineReservationConsoleSystem_1
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


        // 5. Display All Flights method

        public static void DisplayAllFlights()

        {
            Console.WriteLine("Flight Code\tFrom City\tTo City\tDeparture Time\tDuration\tSeats Available");
            for (int i = 0; i < FlightCounter; i++)
            {
                if (SeatReserved_A[i] < SeatsNum_A[i])
                {
                    Console.WriteLine($"{flightCode_A[i]}\t{fromCity_A[i]}\t{toCity_A[i]}\t{departureTime_A[i]}\t{duration_A[i]} min\t{SeatsNum_A[i] - SeatReserved_A[i]}");
                }
                else
                {
                    Console.WriteLine($"{flightCode_A[i]}\t{fromCity_A[i]}\t{toCity_A[i]}\t{departureTime_A[i]}\t{duration_A[i]} min\tNo Seats Available");
                }
            }
        }
        //                    ========================= System Utilities & Final Flow ===========================

        //  1. Start System method 
        public static void StartSystem()
        {
            // calling DisplayWelcomeMessage() function 
            DisplayWelcomeMessage();

            // Wait for user to press any key before continuing
            Console.ReadLine();

            // use while to repate the ShowMainMenu() to show the menu in every one of the feature in the menu break; 
            while (true)
            {
                int option = ShowMainMenu();

                // Declare variables to store singe value of user input 
                string flight_Code = null;
                string from_City = null;
                string to_City = null;
                DateTime departure_Time;
                int duration_1 = 0;
                int Seats_Num = 0;
                char ChoiceChar = 'y';
                bool AddMore = true;
                int traies = 0;

                switch (option)
                {
                    case 1:
                        while (AddMore && FlightCounter < Max_Flight)
                        {

                            Console.WriteLine($"Enter flight {FlightCounter + 1} Information");

                            // Flight Code Input..
                            // use do while loop to excute the quations of input data for first time befor check the input data if it is valide or no .
                            do
                            {
                                // ask user to input Flight Code data and store this data in flight_Code variable 
                                Console.WriteLine("Enter Flight Code :");
                                flight_Code = Console.ReadLine();

                                // flightCode input validation 
                                // check if the input flight code is not null and display the message to the user to enter the valid valis code input
                                if (string.IsNullOrWhiteSpace(flight_Code))
                                {
                                    Console.WriteLine("Flight code cannot be empty.");
                                    isValid = false;
                                    traies++;
                                }
                                else
                                {
                                    isValid = true;
                                    traies = 0;
                                }

                                // (Optional) Check if flight code already exists
                                for (int i = 0; i < FlightCounter; i++)
                                {
                                    if (flightCode_A[i] == flight_Code)
                                    {
                                        Console.WriteLine("A flight with this code already exists.");
                                        isValid = false;
                                        traies++;
                                    }
                                    else
                                    {
                                        isValid = true;
                                        traies = 0;
                                    }

                                }

                                if (traies > 3)
                                {
                                    Console.WriteLine("Failed to provide a valid flight code after 3 tries.");
                                    return;
                                }

                            } while (!isValid && traies <= 3); // if the input is not vlidate repet ask the user 



                            // From City Input
                            // use do while loop to excute the quations of input data for first time befor check the input data if it is valide or no .
                            do
                            {
                                //Ask user to input the from city data and temprorly store this data in from_city data
                                Console.WriteLine("Enter From City :");
                                from_City = Console.ReadLine();


                                // fromCity input validation 
                                if (string.IsNullOrWhiteSpace(from_City))
                                {
                                    Console.WriteLine("From city names cannot be empty.");
                                    isValid = false;
                                }
                                else
                                {
                                    isValid = true;
                                }
                            } while (!isValid); // if the input is not vlidate repet ask the user 

                            // To City Input
                            // use do while loop to excute the quations of input data for first time befor check the input data if it is valide or no .
                            do
                            {
                                Console.WriteLine("Enter To City :");
                                to_City = Console.ReadLine();

                                // fromCity input validation 
                                if (string.IsNullOrWhiteSpace(to_City))
                                {
                                    Console.WriteLine("Trom city names cannot be empty.");
                                    isValid = false;
                                }
                                else
                                {
                                    isValid = true;
                                }

                            } while (!isValid); // if the input is not vlidate repet ask the user 

                            // Departure time input
                            // use do while loop to excute the quations of input data for first time befor check the input data if it is valide or no .
                            do
                            {
                                Console.WriteLine("Enter the departure time (e.g., 2025-04-12 14:30):");
                                string input = Console.ReadLine();

                                if (DateTime.TryParse(input, out departure_Time))
                                {
                                    isValid = true;
                                }
                                else
                                {
                                    Console.WriteLine("Invalid format! Please enter a valid date and time.");
                                    isValid = false;
                                }

                            } while (!isValid); // if the input is not vlidate repet ask the user 

                            // Duration Input
                            // use do while loop to excute the quations of input data for first time befor check the input data if it is valide or no .
                            do
                            {
                                Console.WriteLine("Enter duration:");
                                string DurationInput = Console.ReadLine();

                                // Duration input validation 
                                if (int.TryParse(DurationInput, out duration_1))
                                {
                                    if (duration_1 <= 0)
                                    {
                                        Console.WriteLine("Duration must be greater than zero.");
                                        isValid = false;
                                    }
                                    else
                                    {
                                        isValid = true;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Invalid input. Please enter a valid number.");
                                    isValid = false;
                                }
                            } while (!isValid); // if the input is not vlidate repet ask the user 


                            // Number of seats input
                            // use do while loop to excute the quations of input data for first time befor check the input data if it is valide or no .
                            do
                            {
                                Console.WriteLine("Enter the Number of seats:");
                                Seats_Num = int.Parse(Console.ReadLine());
                                //seatsNum input validation
                                if (Seats_Num <= 0)
                                {
                                    Console.WriteLine("Number of seats must be greater than zero.");
                                    isValid = false;
                                }
                                else
                                {
                                    isValid = true;
                                }

                            } while (!isValid); // if the input is not vlidate repet ask the user 

                            // check is all inputs data is valid or not 
                            if (isValid)
                            {
                                // store all inputs data in the array 
                                AddFlight(flightCode: flight_Code, fromCity: from_City, toCity: to_City, departureTime: departure_Time, duration: duration_1, SeatsNum: Seats_Num);
                                Console.WriteLine("Flight added successfully!");
                                FlightCounter++;
                            }
                            else
                            {
                                Console.WriteLine("Flight added faild!");
                                break;

                            }
                            //ask user if want to add more flight information 
                            Console.WriteLine("Do you want to add more flight information?! (y/n)");
                            ChoiceChar = Console.ReadKey().KeyChar;
                            Console.WriteLine();
                            // use if statement to deal with ChoiceChar input if y or n
                            if (ChoiceChar == 'Y' || ChoiceChar == 'y')
                            {
                                // use if instead to check also if FlightCounter is equal or not the Max_Flight
                                if (FlightCounter == Max_Flight)
                                {
                                    Console.WriteLine("Can Not Add More Flight Information");
                                    AddMore = false;
                                }
                                else
                                {
                                    AddMore = true; // display AddMore as true if FlightCounter does not equal Max_Flight and it is aable to add more flight information.
                                }
                            }
                            else
                            {
                                AddMore = false; // display AddMore as false is user do not add more flight information 
                            }
                            Console.ReadLine();
                        }

                        break;

                    case 2:
                        DisplayAllFlights();
                        Console.WriteLine("\nPress any key to return to the menu...");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("Enter the code of Flight : ");
                        string code = Console.ReadLine();
                        FindFlightByCode(code);
                        Console.WriteLine("\nPress any key to return to the menu...");
                        Console.ReadKey();
                        break;
                    case 4:

                        break;
                    case 5:

                        break;

                    case 0:
                        //calling ExitApplication() function
                        ExitApplication();
                        //using return to stop the whole method thus, stop whole program 
                        return;

                    default:
                        // // Display an message for invalid user input 
                        Console.WriteLine("Invalid choice! Try again.");
                        break;
                }
            }

        }

        //                    ======================= main method ==============================

        // 1. main method 
        static void Main(string[] args)
        {
            StartSystem();
        }
    }
}





    }

}
