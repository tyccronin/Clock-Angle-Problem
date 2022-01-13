using System;

namespace CLOCKANGLE{
    class program{
        static void Main(string[] args){
            Console.WriteLine("This program will calculate the shorter angle between the hour and minute hand in an analog clock." + "\n");
            Console.WriteLine("If you make an error, you'll have to close the program and start all over from the beginning." + "\n");
            program.GetClockAngleFunction();
        }

        public static int findAngle(int hh, int mm)
        {
            // Handle 24 hour notation
            hh = hh % 12;

            // Find the position of the hour hand
            int h = (hh * 360) / 12 + (mm * 360) / (12 * 60);

            // Find the position of the minute's hand
            int m = (mm * 360) / (60);

            // Calculate the angle difference
            int angle = Math.Abs(h - m);

            // Consider the shorter angle and return it
            if (angle > 180) {
                angle = 360 - angle;
            }

            return angle;
            
        }

        public static void GetClockAngleFunction()
        {
            // Prompt user to enter the first number
            Console.WriteLine("Please Enter A Number Between 1 and 12 Inclusive (Hour Hand): ");
            string inputOne = Console.ReadLine();
            char[] clockNumOne = inputOne.ToCharArray();
            int a;
            for(int i = 0; i < clockNumOne.Length; i++) {
                if(!Char.IsLetterOrDigit(clockNumOne[i])){
                  Console.WriteLine("Your entry contains special characters!" + "\n" + "Hit any key to close the program, and try again.");
                  Console.ReadKey();
                  return;
                }
                if (!int.TryParse(inputOne, out a)) {
                    Console.WriteLine("That's not a number!");
                    Console.WriteLine("You are an Ape." + "\n" + "Hit any key to close the program, and try again.");
                    Console.ReadKey();
                    return;
                } else if (string.IsNullOrWhiteSpace(inputOne)) {
                    Console.WriteLine("You didn't type anything!" + "\n" + "Hit any key to close the program, and try again.");
                    Console.ReadKey();
                    return;
                } else if ((Convert.ToInt32(inputOne) < 1) || (Convert.ToInt32(inputOne) > 12)) {
                    Console.WriteLine("Number is not between 1 and 12 inclusive!" + "\n" + "Hit any key to close the program, and try again.");
                    Console.ReadKey();
                    return;
                }   
            }

            // Prompt user to enter the second number
            Console.WriteLine("Please Enter A Number Between 1 and 60 Inclusive (Minute Hand): ");
            string inputTwo = Console.ReadLine();
            char[] clockNumTwo = inputTwo.ToCharArray();
            int b;
            for(int j = 0; j < clockNumTwo.Length; j++) {
                if(!Char.IsLetterOrDigit(clockNumTwo[j])){
                Console.WriteLine("Your entry contains special characters!" + "\n" + "Hit any key to close the program, and try again.");
                Console.ReadKey();
                return;
                }
            }
            if (!int.TryParse(inputTwo, out b)){
                Console.WriteLine("That's not a number!");  
            } else if (string.IsNullOrWhiteSpace(inputTwo)) {
                    Console.WriteLine("You didn't type anything!" + "\n" + "Hit any key to close the program, and try again.");
                    Console.ReadKey();
                    return;
            } else if ((Convert.ToInt32(inputTwo) < 1) || (Convert.ToInt32(inputTwo) > 60)) {
                    Console.WriteLine("Number is not between 1 and 60 inclusive!" + "\n" + "Hit any key to close the program, and try again.");
                    Console.ReadKey();
                    return;
            } 
                    
            if(int.TryParse(inputOne, out a) && int.TryParse(inputTwo, out b)){
                Console.WriteLine("Answer: " + program.findAngle(a, b) + " Degrees" + "\n");
            }
            else {
                Console.WriteLine("You are an Ape." + "\n" + "Hit any key to close the program, and try again.");
                Console.ReadKey();
                return;
            }
        }
    }
}
