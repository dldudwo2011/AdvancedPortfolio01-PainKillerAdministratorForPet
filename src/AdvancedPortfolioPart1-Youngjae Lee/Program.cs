/*
 * 
 *       Purpose: Write a program that asks the user for a name, age, weight, and type of their pet and allows the user to figure the dosage of pain killer, 
 *                sedative, or both for their pet.
 *                
 *               
 *       Input: Name of the pet (string), age of the pet (int), the weight of the pet (double), type of the pet (char), user answer to confirm (char), user choice to option (int)
 *       
 *       
 *       
 *       Process:  Create 4 methods which are GetSafeDouble(), GetSafeChar(), GetSafeInt(), and GetStringFromUser(). They will all be used to prompt the user to
 *                 enter the value and return the value. GetSafeDouble(), GetSafeChar(), and GetSafeInt() methods will have error-checking logic implemented in their body.
 *                 
 *                 In the main method, create a welcome message using Console.WriteLine() method. Then, declare proper variables to store the name, age, weight, and type of the
 *                 pet. Then declare a while loop that operates while the user-input is 'n'. In the while loop, it will prompt the user to enter the name, age, weight, and the type
 *                 order by order. Then it will display a message that summarizes what the user had entered and another message that asks the user to confirm it by typing 'y' for yes,
 *                 'n' for no. 
 *                 
 *                 Another while loop in this while loop will be declared for prompting the user to type the type of their pet. The only allowed values for the user-input will be
 *                 'd' and 'D' for a dog, 'c' and 'C' for a cat.
 *                 
 *                 If the user entered the values allowed, it will set the type of the pet corresponding to the user-input(d or D for dog, c or C for cat).
 *                 
 *                 Otherwise it will display a message "Invalid input. Please try again" and prompt again (repeat the loop).  
 *                 
 *                 Another while loop will be declared for prompting the user to confirm what they have entered.
 *                 
 *                 If the user enters 'y' or 'Y', the loop won't repeat and moves on to the next section. 
 *                 
 *                 If the user enters 'n' or 'N', it will repeat the original loop from the beginning by starting to ask the name of the pet again.
 *                 
 *                 Else, it means the user had entered a char value that is not 'y' or 'n' so display a message that says "Invalid input. Please try again"
 *                 and simply prompt again (repeat its current loop)
 *                 
 *                 When the user confirms what they had entered to define the pet (If the user types 'y' or 'Y' in the previous while loop). The while loop will
 *                 end. After the while loop, initialize a pet object with the parameters that its values are derived from the user.
 *                 
 *                 Then, display the options that the user can choose by using the Console.WriteLine() method.
 *                 
 *                 Then, create a while loop that operates while the user-input is not 1 or 2 or 3 (invalid). It can be done by setting a bool variable named invalidInput 
 *                 initially to true.
 *                 
 *                 Then, in the while loop, create a switch statement that depends on the value of the user-input.
 *                 
 *                 Case 1 will be the pain killer. If the user chooses this, it will display the dosage of the painkiller (carprofen) in ml by calling the carprofen() method
 *                 from the pet object. The called method will be in string interpolation so that it can be displayed to the user. Finally, it will set the invalidInput variable
 *                 to false so that the loop will end.
 *                 
 *                 Case 2 will be the sedative. If the user chooses this, it will display the dosage of the painkiller the same way how it is done in case 1. Finally, it will 
 *                 set the invalidInput variable to false so that the loop will end.
 *                 
 *                 
 *                 Case 3 will be both. If the user chooses this, it will display both the dosage of the painkiller and the dosage of the sedative. It will display 
 *                 the dosages the same way how it is done in case 1. Finally, it will set the invalid input variable to false so that the loop will end.
 *                 
 *                 If what user had entered does not fall into one of these cases, it means the user entered an int value that is not 1 or 2 or 3 so display a message saying 
 *                 "Invalid input. Please try again". It can be done by setting the default of the switch statement to display the invalid input message.
 *  ------------------------------------------------------------------------------------------------------------------------------------------------------------        
 *       Output: 1. (Welcome message)
 *       
 *               2. Enter the name of your pet:
 *       
 *               3. Enter the age in years of your pet:
 *               
 *               4. Enter the weight in pounds of your pet:
 *               
 *               5. Enter D for Dog, or C for cat:
 *               
 *               6. Name: (petName), Age: (petAge) years, Weight: (petWeight) lbs, Type: (petType)
 *               
 *               7. Is the information above about your pet correct (Y/N):
 *               
 *               8. Enter the service required for your pet:
 *                  1. Pain Killer
 *                  2. Sedative
 *                  3. Both Pain Killer and Sedative
 *                  
 *               9. If the user selects 1 
 *                      1. Your pet requires (dosage)ml of carprofen
 *                      
 *                  If the user selects 2
 *                      1. Your pet requires (dosage)ml of acepromazine
 *                      
 *                  If the user selects 3
 *                      1. Your pet requires (dosage)ml of carprofen
 *                         Your pet requires (dosage)ml of acepromazine
 *                         
 *               If the user causes format exception in any of these steps, the output message will be "Invalid input! You must enter a (correct format) value for the answer"
 *               
 *               If the user types any other values that are considered invalid, the output message will be "Invalid input. Please try again"
 *  ------------------------------------------------------------------------------------------------------------------------------------------------------------     
 *       Test plan
 *       
 *       Test case 1: Painkiller for cat
 *       Test data: "Bella" for name, 10 for age, 55.50 for weight, 'c'for type
 *       Expected result: 1. Name: Bella, Age: 10 years, Weight: 55.5 lbs, Type: cat
 *                        
 *                        2. Your pet requires 0.5245ml of carprofen
 *       
 *       
 *       Test case 2: Painkiller for dog
 *       Test data: "Luna" for name, 7 for age, 110.30 for weight, 'd' for type
 *       Expected result: 1. Name: Luna, Age: 7 years, Weight: 110.3 lbs, Type: dog
 *       
 *                        2.  Your pet requires 2.0846ml of carprofen
 *       
 *      
 *       Test case 3: Sedative for cat
 *       Test data: "Charlie" for name, 11 for age, 40.35 for weight, 'c' for type
 *       Expected result: 1. Name: Charlie, Age: 11 years, Weight: 40.35 lbs, Type: cat
 *       
 *                        2. Your pet requires 0.0037ml of acepromazine
 *       
 *       
 *       Test case 4: Sedative for dog
 *       Test data: "Lucy" for name, 8 for age, 60.78 for weight, 'd' for type
 *       Expected result: 1. Name: Lucy, Age: 8 years, Weight: 60.78 lbs, Type: dog
 *                        
 *                        2. Your pet requires 0.0827ml of acepromazine
 *       
 *       
 *       Test case 5: both sedative and painkiller for cat
 *       Test data: "Cooper" for name, 9 for age, 148 for weight, 'c' for type
 *       Expected result: 1. Name: Cooper, Age: 9 years, Weight: 148 lbs, Type: cat
 *       
 *                        2. Your pet requires 1.3986ml of carprofen
 *                           Your pet requires 0.0134ml of acepromazine
 *       
 *       
 *       Test case 6: both sedative and painkiller for dog
 *       Test data:"Max" for name, 9 for age, 88.30 for weight, 'd' for type
 *       Expected result: 1. Name: Max, Age: 9 years, Weight: 88.3 lbs, Type: dog
 *       
 *                        2. Your pet requires 1.6688ml of carprofen
 *                           Your pet requires 0.1202ml of acepromazine
 *       
 *  ------------------------------------------------------------------------------------------------------------------------------------------------------------         
 *       Author: Youngjae Lee
 *       
 *       Last modified date: 2021 Apr 7
 */


using System;

namespace AdvancedPortfolioPart1_Youngjae_Lee
{
    class Program
    {
        //getting the user-input(double) method
        static double GetSafeDouble(string message)
        {
            double doubleValue = 0;
            bool validInput = false;

            while (!validInput)
            {
                Console.Write(message);
                validInput = double.TryParse(Console.ReadLine(), out doubleValue);
                if (!validInput)
                {
                    Console.WriteLine("  Invalid input! You must enter a double value for the answer");
                    Console.WriteLine();
                }
            }

            return doubleValue;
        }

        //getting the user-input(char) method
        static char GetSafeChar(string message)
        {
            char charValue = '0';
            bool validInput = false;

            while (!validInput)
            {
                Console.Write(message);
                validInput = char.TryParse(Console.ReadLine(), out charValue);
                if (!validInput)
                {
                    Console.WriteLine("  Invalid input! You must enter a char value for the answer");
                    Console.WriteLine();
                }
            }

            return charValue;
        }

        //getting the user-input(int) method
        static int GetSafeInt(string message)
        {
            int intValue = 0;
            bool validInput = false;

            while (!validInput)
            {
                Console.Write(message);
                validInput = int.TryParse(Console.ReadLine(), out intValue);
                if (!validInput)
                {
                    Console.WriteLine("  Invalid input! You must enter an int value for the answer");
                    Console.WriteLine();
                }
            }

            return intValue;
        }

        //prompt for string method
        static string GetStringFromUser(string message)
        {
            Console.Write(message);
            string userInput = Console.ReadLine();

            return userInput;
        }

        static void Main(string[] args)
        {
            //welcome message
            Console.WriteLine("  ***** Welcome to the Pet Medication Calculator *****");
            Console.WriteLine();

            //initializing a pet object
            Pet pet = new Pet();

            //petType variable
            char petType = '0';

            //setting user input to 'n' initially
            char userInput = 'n';

            //setting invalidInput to true initially
            bool invalidInput = true;

            //declaring a while loop
            while (userInput == 'n')
            {

                //prompt the user for the pet name
                pet.Name = GetStringFromUser("              Enter the name of your pet: ");

                //do while loop for age
                do
                {
                    try
                    {
                        //prompt the user for the pet age
                        pet.Age = GetSafeInt("      Enter the age in years of your pet: ");
                        invalidInput = false;
                    }

                    //catches exception that occurs when pet age is not greater than zero
                    catch (Exception ex)
                    {
                        Console.WriteLine($"      {ex.Message}");
                    }
                } while (invalidInput);

                //resetting invalid input to true
                invalidInput = true;

                //do while loop for weight
                do
                {
                    try
                    {
                        //prompt the user for the pet weight
                        pet.Weight = GetSafeDouble("  Enter the weight in pounds of your pet: ");
                        invalidInput = false;
                    }
                    //catches exception that occurs when pet weight is not greater than zero
                    catch (Exception ex)
                    {
                        Console.WriteLine($"      {ex.Message}");
                    }
                } while (invalidInput);

                //resetting invalid input to true
                invalidInput = true;

                //do while loop for pet type
                do
                {
                    //prompt the user for the pet type and store it in the petType variable
                    petType = GetSafeChar("           Enter D for Dog, or C for cat: ");

                    //if it is d or D (dog)
                    if ((petType == 'D') || (petType == 'd'))
                    {
                        //assigning "dog" value to petTypeToString variable and setting invalid input to false
                        pet.PetType = "dog";
                        invalidInput = false;
                    }

                    //if it is c or C (cat)
                    else if ((petType == 'C') || (petType == 'c'))
                    {
                        //assigning "cat" value to petTypeToString variable and setting invalid input to false
                        pet.PetType = "cat";
                        invalidInput = false;
                    }

                    //otherwise invalid input
                    else
                    {
                        Console.WriteLine("  Invalid input. Please try again");
                    }
                } while (invalidInput);

                Console.WriteLine();

                //displaying the summary of what user entered
                Console.WriteLine($"  Name: {pet.Name}, Age: {pet.Age} years, Weight: {pet.Weight} lbs, Type: {pet.PetType}");

                //resetting invalid input to true
                invalidInput = true;


                //do while loop declaration
                do
                {
                    //prompt the user for the char value 
                    userInput = GetSafeChar("  Is the information above about your pet correct (Y/N): ");

                    //if the user confirms it or denies it (y or Y or n or N)
                    if ((userInput == 'y') || (userInput == 'Y') || (userInput == 'n') || (userInput == 'N'))
                    {
                        //setting invalidInput to false
                        invalidInput = false;
                    }

                    //otherwise invalid input
                    else
                    {
                        //displaying invalid input message
                        Console.WriteLine("  Invalid input. Please try again");
                        Console.WriteLine();
                    }
                } while (invalidInput);
            }

            Console.WriteLine();

            //displaying the option
            Console.WriteLine("  Enter the service required for your pet:");
            Console.WriteLine("\t1. Pain Killer");
            Console.WriteLine("\t2. Sedative");
            Console.WriteLine("\t3. Both Pain Killer and Sedative");

            //setting invalid input to true initially
            bool invalidInput2 = true;

            //while loop declaration
            while (invalidInput2)
            {

                //prompt the user for the choice
                int userChoice = GetSafeInt("  Option: ");

                //switch statement
                switch (userChoice)
                {
                    //if the user chooses pain killer
                    case 1:
                        
                        //displaying the dosage and setting the invalidInput2 to false
                        Console.WriteLine($"  Your pet requires {pet.Carprofen()}ml of carprofen.");
                        invalidInput2 = false;
                        break;

                    //if the user chooses sedative
                    case 2:

                        //displaying the dosage and setting the invalidInput2 to false
                        Console.WriteLine($"  Your pet requires {pet.Acepromazine()}ml of acepromazine");
                        invalidInput2 = false;
                        break;

                    //if the user chooses both
                    case 3:

                        //displaying the dosage and setting the invalidInput2 to false
                        Console.WriteLine($"  Your pet requires {pet.Carprofen()}ml of carprofen.");
                        Console.WriteLine($"  Your pet requires {pet.Acepromazine()}ml of acepromazine");
                        invalidInput2 = false;
                        break;

                    //otherwise it's invalid input
                    default:

                        //displaying invalid input message
                        Console.WriteLine("  Invalid choice. Please try again");
                        Console.WriteLine();
                        break;

                }
            }
        }
    }
}
