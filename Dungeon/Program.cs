namespace Dungeon
{
    internal class Program
    {
        //svm > tab > tab creats a static void main
        static void Main(string[] args)
        {
            //Title & Introduction 
            #region Title & Introduction
            Console.Title = "Dungeon of Big Doom";

            Console.WriteLine("Your journey begins...\n");
            #endregion

            //Variable to track players score
            int score = 0;

            //TODO Weapon object to be created

            //TODO Player object creation


            //create main game loop

            #region Main Game Loop
            //counter variable - used in the condition of the loop
            bool exit = false;
            do
            {

                //TODO Generate a random room the player will enter


                //TODO Select a random monster to inhabit the room


                // create gameplay menu loop


                #region Gameplay menu loop
                bool reload = false;
                do
                {
                    //TODO Create main gameplay menu
                    #region MENU

                    //Prompt the user 
                    Console.Write("\nPlease choose an action:\n" +
                        "A) Attack\n" +
                        "R) Run Away\n" +
                        "P) Player Information\n" +
                        "M) Monster Information\n" +
                        "X) Exit\n");
                    //Capture the users mmenu selection
                    ConsoleKey userChoice = Console.ReadKey(true).Key;//Capture the pressed key, hide the key from the console, and execute immediatly

                    //clear the console
                    Console.Clear();

                    //use branching logic to act upon the users selection
                    switch (userChoice)
                    {
                        case ConsoleKey.A:
                            //TODO Combat
                            Console.WriteLine("Attack");

                            break;
                        case ConsoleKey.R:
                            //TODO Run Away - Attack of opportunity
                            Console.WriteLine("Run away");

                            break;
                        case ConsoleKey.P:
                            //TODO Display Player Stats
                            Console.WriteLine("Player Info");
                            break;
                        case ConsoleKey.M:
                            //TODO Monster Stats
                            Console.WriteLine("Montser Info");

                            break;
                        case ConsoleKey.X:
                        case ConsoleKey.E:
                            //Exit
                            Console.WriteLine("If I was as unskilled as you I'd quit too...");
                            exit = true;
                            break;

                        default:
                            Console.WriteLine("Thou hast chosen an improper option. Triest thou again...");
                            break;
                    }//end switch

                    #region Check players life total
                    //TODO Check players life


                    #endregion


                    #endregion

                } while (!reload && !exit);

                #endregion

            } while (!exit);//end do while - also saying keep looping as long as exit = false

            #endregion
            //TODO Output the final score
            
            Console.WriteLine($"You defeated {score} monster{(score == 1 ? "." : "s.")}");


            //Added to preserve Console.Title
            Console.ReadKey(true);
        } //end main()
    }//end class
}//end namespace