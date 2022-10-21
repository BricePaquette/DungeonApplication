using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Player : Character 
    {
        
        public Race CharacterRace { get; set; }
        public Weapon EquipedWeapon { get; set; }

        public Player(int maxLife, int life, string name, int hitChance, int block, Race characterRace, Weapon equipedWeapon)
            :base(maxLife, life, name, hitChance, block)
        {
            CharacterRace = characterRace;
            EquipedWeapon = equipedWeapon;

            //Add extra balancing and functionality because why not
            switch (CharacterRace)
            {
                case Race.Tiefling:
                    MaxLife += 5;
                    break;
                case Race.Elf:
                    Block += 2;
                    break;
                case Race.Dragonborne:
                    HitChance += 3;

                    break;
                case Race.Human:
                    break;
                case Race.Orc:
                    MaxLife += 5;
                    HitChance -= 1;
                    break;
                case Race.Dwarf:
                    Block += 2;
                    MaxLife -= 4;
                    break;
                case Race.Gnome:
                    hitChance -= 3;
                    EquipedWeapon.MaxDamge += 3;
                    break;
                case Race.Khajit:
                    Block += 3;
                    MaxLife -= 3;
                    break;
                case Race.Halfling:
                    MaxLife -= 4;
                    EquipedWeapon.MinDamge += 1;
                    EquipedWeapon.MaxDamge -= 1;
                    break;
                case Race.Aasimar:
                    HitChance += 5;
                    EquipedWeapon.MaxDamge -= 2;
                    break;
                case Race.Drow:
                    HitChance += 2;
                    break;
                default:
                    break;
            }
        }


        public override string ToString()
        {
          
        string description = "";
            //Added below for descriptions so they can make a better choice based on preference
            switch (CharacterRace)
            {
                case Race.Tiefling:
                    description = "All tieflings possess large thick horns of various styles on their heads, prehensile tails approximately 4 to 5 feet in length, sharply pointed teeth, and their eyes are solid orbs of red, black, white, silver, or gold.";
                    break;
                case Race.Elf: 
                    description = "a supernatural creature of folk tales, typically represented as a small, elusive figure in human form with pointed ears, magical powers, and a capricious nature.";
                    break;
                case Race.Dragonborne:
                    description = "Descendants of dragons, these draconic humanoids live in clans who they value more than their life itself";
                    break;
                case Race.Human:
                    description = "Humans are the most adaptable and ambitious people among the common races. They have widely varying tastes, morals, and customs in the many different lands where they have settled. When they settle, though, they stay: they build cities to last for the ages, and great kingdoms that can persist for long centuries.";
                    break;
                case Race.Orc:
                    description = "Orcs are a brutish, aggressive, ugly, and malevolent race of monsters, contrasting with the benevolent Elves and serving an evil power, though they share a human sense of morality. ";
                    break;
                case Race.Dwarf:
                    description = "Stout, short and hardworking. Those might be the best words to describe a dwarf. Having their race forged by the god Moradin, they were taught of the benefits of hard labor, perfection in their works, and the importance of their clans.";
                    break;
                case Race.Gnome:
                    description = "dwarfish, subterranean goblin or earth spirit who guards mines of precious treasures hidden in the earth. they are small and physically deformed";
                    break;
                case Race.Khajit:
                    description = "Khajiit are a race of cat-like creatures whose stealth and agility make them accomplished thieves and warriors";
                    break;
                case Race.Halfling:
                    description = "They are similar to humans except about half as tall, and are not quite as stocky as the similarly-sized dwarves";
                    break;
                case Race.Aasimar:
                    description = "humans with a significant amount of celestial or other good outsider blood in their ancestry";
                    break;
                case Race.Drow:
                    description = "A member of a race of elves that is evil, has a dark (often greyish or bluish) skin and/or lives in dark places";
                    break;
                default:
                    Console.WriteLine("Dont see how youd hit this");
                    break;
            }
            return base.ToString() + $"\nRace: {CharacterRace.ToString().Replace('_', ' ')}\nWeapon:\n{EquipedWeapon}\nBlock: {Block}\n";
            
        }

        

        public override int CalcHitChance()
        {
            return HitChance + EquipedWeapon.BonusHitChance;
        }


       
        
        public override int CalcDamage()//Random value between weapons min - max damage
        {
            Random rand = new Random();
            int randomDamage = rand.Next(EquipedWeapon.MinDamge, EquipedWeapon.MaxDamge + 1);

            return randomDamage;
        }
    }
}
