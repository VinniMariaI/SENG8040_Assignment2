using System;

namespace TriangleSolver
{
    class Program
    {
        
        public static int InputValidation(string UserEnteredValue)
    {
        int ValidInt = 0;
        bool InputValueValidation = int.TryParse(UserEnteredValue, out ValidInt);
        if (InputValueValidation == true)
            return ValidInt;
        else
            return ValidInt;
    }

        static void Main(string[] args)
        {
            string side1, side2, side3, TriangleType;
            int UserInputValidation;
           

            UserInputValidation = UserMenuSelection();
                while (UserInputValidation == 1)
                { 

                    Console.WriteLine("Enter three values:");
            side1 = Console.ReadLine();
            side2 = Console.ReadLine();
            side3 = Console.ReadLine();
                if (InputValidation(side1) != 0 && InputValidation(side2) != 0 && InputValidation(side3) != 0)
                {
                    TriangleType = TraiangleSolver.Analyze(Convert.ToInt32(side1), Convert.ToInt32(side2), Convert.ToInt32(side3));
                    Console.WriteLine("The given dimensions " + TriangleType);
                }
           UserInputValidation = UserMenuSelection();
        }

            Console.WriteLine("Exiting the Program");
       
            int UserMenuSelection()
            {
                int MenuSelect;
                string selectedOption;
                Console.WriteLine("1.Enter Traiangle dimensions \n 2.Exit ");
              MenuSelect = InputValidation( selectedOption = Console.ReadLine());
                if (MenuSelect != 0)
                {
                 if (MenuSelect == 1 || MenuSelect == 2)
                        return MenuSelect;
                    else
                    {
                        UserMenuSelection();
                        return 0;
                    }
                }
                return 0;               
            }
           
           
        }
    }
}
