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
                RoomGenerator();

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

        private static void RoomGenerator()
        {
            string[] rooms = { "The door is made of pinewood planks, it has a bone handle and a small hole at eye level. This room has a smoothly hewn natural stone floor that have been polished smooth. Arranged in concentric rectangles, the floor has been inscribed with arcane runes. Investigation indicates no pattern or intent and it seems likely that no two are the same and that it may serve some instructional purpose. The ceiling is a barrel vaulted with ribs (regular rounded ribs support this barrel vault ceiling) and is intricately carved with a repeating pattern of angular geometric shapes.\r\n\r\nCrudely drawn on the walls are several profane symbols. From the stench and appearance, it appears as if blood and feces were used to draw them. A lit oil lantern sits on the floor in the middle of this room. Investigation reveals that it has half an hour of oil remaining.\r\n\r\nThe air in the room is hazy and humid. The room smells of Manure. A faint drumming noise can be heard.",

                "The door is made of sandstone, it has a double-sided iron bolt and a black 'X' is drawn across the inside of the door, it appears to have been done with tar. This room has a square marble tile floor. A section of the floor about ten feet across and shaped like a hex is a smooth blue stone that gives off a faint glow. Several places around the edge show signs of damage. The ceiling is a barrel vaulted with ribs (regular rounded ribs support this barrel vault ceiling) and with arm thick tendrils of viscous brown goo that hangs down to the floor in half a dozen places. It gives off a putrid stench, but appears otherwise harmless.\r\n\r\nAll the walls of this room are painted with one continuous scene, divided by a horizontal line of fire, with flying demons above, and celestial creatures below. The stump of a once large tree protrudes from the broken floor near the center of the room. It has been hacked down to only a few inches remaining and is darkened from age or liquid stains.\r\n\r\nThe air in the room is hazy and humid. The room smells of Chlorine. A loud slamming noise can be heard.",

            "The door is made of basalt, it has a double-sided iron bolt with keyed lock and three green horizontal lines are drawn across the outside. This room has a black granite tile floor. There are numerous scorch marks and signs of fire along the floor of this room. The ceiling is a flat with wooden planks reinforced with regular wooden beams and appears to have once been tiled in a mosaic, but all of the precious stones have been picked from the ceiling.\r\n\r\nAll the walls of this room are painted with one continuous scene, divided by a horizontal line of fire, with flying demons above, and celestial creatures below. A desiccated naked human male corpse lies in one corner.\r\n\r\nThe air in the room is foggy. The room smells earthy. A loud bellowing noise can be heard.",

            "The door is made of slate, it has a double-sided iron bolt with keyed lock and a figure of an elven archer is etched into the door. This room has a smoothly hewn natural stone floor that have been polished smooth. There are numerous scorch marks and signs of fire along the floor of this room. The ceiling is a flat ceiling with coved edges and with an eight-foot diameter semi-circle in the center with a foot-long broken chain hanging down from a hook in the center.\r\n\r\nCrudely chiseled into the wall are several geometric shapes. They don't seem to be runes or symbols of any known type. About a dozen rusting climbing spikes protrude from the walls in seemingly in random places.\r\n\r\nThe air in the room is clear, with mist covering the floor. The room smells putrid. A loud clicking noise can be heard.",

            "The door is made of brass, it has a carved wooden handle and a large, old blood stain starting at mid-height and running down stain the door. This room has a roughly hewn stone floor that has small gravel and dirt strewn around. The floor is plain and bare. The ceiling is a barrel vaulted with ribs (regular rounded ribs support this barrel vault ceiling) and has dozens of regular small holes apparently drilled into it. They are about two fingers wide and straight up for as far as you can see.\r\n\r\nThe walls of this room are covered in rude graffiti and sayings in common. Scratched in one wall is the word \"worimeloni\".\r\n\r\nThe air in the room is hazy and humid. The room smells of Urine. A faint banging noise can be heard.",

            "The door is made of granite, it has a double-sided iron bolt with keyed lock and the door is covered in frost and is icy cold to the touch. This room has a hard-packed dirt floor. A five-foot circle of white marble is centered in the floor of this room. It is flush with the rest of the floor and shows no signs of stains or wear. The ceiling is a coffered (flat ceiling with sunken rectangular recessed panels) and covered in a heavy dark soot.\r\n\r\nScorched into the wall is the silhouette outline of a five-foot-high figure that is holding a sword, shield and wearing a knight's helmet. Sitting in the middle of the room are the remains of a small fire; ash and the few parts of incompletely burned wood remains.\r\n\r\nThe air in the room is clear, with mist covering the floor. The room smells of Manure. A faint footsteps noise can be heard.",

            "The door is made of granite, it has a double-sided iron bolt with keyed lock and the door is covered in frost and is icy cold to the touch. This room has a hard-packed dirt floor. A five-foot circle of white marble is centered in the floor of this room. It is flush with the rest of the floor and shows no signs of stains or wear. The ceiling is a coffered (flat ceiling with sunken rectangular recessed panels) and covered in a heavy dark soot.\r\n\r\nScorched into the wall is the silhouette outline of a five-foot-high figure that is holding a sword, shield and wearing a knight's helmet. Sitting in the middle of the room are the remains of a small fire; ash and the few parts of incompletely burned wood remains.\r\n\r\nThe air in the room is clear, with mist covering the floor. The room smells of Manure. A faint footsteps noise can be heard.",

            "The door is made of mithril, it has a wood bolt on the inside and a crudely painted arcane eye is painted in blue. This room has a hexagonal slate tile floor. The floor of this room has a channel or groove cut into it. It is about a hand's width wide and runs directly at the entryway. It appears to be several feet deep, and the glint of what might be metal can be seen deep within it. The ceiling is a flat reinforced with stone beam with regular rectangular shaped beams and with four \"X\"s carved into the stone evenly spaced about the room.\r\n\r\nThe walls are decorated with thousands of red handprints. Many have faded and are hard to distinguish, but some are new. They seem to represent the size and shapes of all types of humanoids. The air of this room is filled with wood smoke that gently drifts out the entrance you came in.\r\n\r\nThe air in the room is clear, with smoke covering the ceiling. The room smells of Ozone. A faint banging noise can be heard.",

            "The door is made of mithril, it has a carved wooden knob and a tree is carved in relief on this door. This room has a square marble tile floor. A pit has been carved into the stone of the floor near one wall. It is about two feet wide, five feet long and three feet wide. The ceiling is a coffered (flat ceiling with sunken rectangular recessed panels) and that has numerous wrist sized ribs that are patterned like a spiderweb.\r\n\r\nThe walls all show signs of severe damage. Numerous cracks and divots have been gouged into them. Several fist sized stones sit in the middle of the room, each appears to have been roughly carved into a rotund humanoid.\r\n\r\nThe air in the room is misty and cold. The room smells of Urine. A faint chiming noise can be heard.",

            "The door is made of leather over a wooden frame, it has a no handle and on the inside of the door a chalk arrow points to the lower hinge. This room has an irregular flagstone tile floor. Almost two inches of fine silt covers the floor of this room. The ceiling is a coffered (flat ceiling with sunken rectangular recessed panels) and covered with a network of cracks that are no more than a finger's width wide.\r\n\r\nDark oil that smells of sulfur coats most of one wall. It seems to seep from the stone and may be flammable. Several large clumps of brown mold grow in the corners of the room.\r\n\r\nThe air in the room is clear, with mist covering the floor. The room smells sulfurous. A faint footsteps noise can be heard.",

            "The door is made of a beaded string curtain, it has a wood bolt on the inside and a sign was once carved in high relief on this door, but most of the letters have been scraped off, leaving only \" o N nt \". This room has a hard-packed dirt floor. A pit has been carved into the stone of the floor near one wall. It is about two feet wide, five feet long and three feet wide. The ceiling is a domed (entire ceiling is gently rounded) and covered with moist dark green moss.\r\n\r\nTwo of the walls are covered in mushrooms. Investigation shows that they are made of stone. Five bodies lay fallen in a pile near one corner; two human males, one female, a male dwarf, and a female elf. They appear to have died in the last hour and have been thoroughly looted except for their clothes.\r\n\r\nThe air in the room is clear but cold. The room smells acrid. A loud coughing noise can be heard."};

            Random rand = new Random();
            int randomIndex = rand.Next(rooms.Length);

            Console.WriteLine($"You enter a room...\n{rooms[randomIndex]}");

        }
    }//end class
}//end namespace