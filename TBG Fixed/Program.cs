﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBG_Fixed
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("You found yourself trapped in a virtual world controlled by HTech, a company famous for its technology.");
            Console.WriteLine("You are allowed to leave if you survive two months in the virtual world.");
            Console.WriteLine("Noticing that you are awake, the HTech staff gave you a gift to get started.");            
            Console.WriteLine();
            int health = 10;
            int actionPts = 0;
            int skill = 10;
            int knowledge = 5;
            double armor = 0;
            double attack = 5;
            double weaponstrength = 0;
            double weaponcondition = 0;
            ChangeStats(ref health, ref actionPts, ref skill, ref knowledge, ref armor, ref attack, ref weaponstrength, ref weaponcondition);
            Console.WriteLine("health = " + health);
            Console.WriteLine("actionPts = " + actionPts);
            Console.WriteLine("skill = " + skill);
            Console.WriteLine("armor = " + armor);
            Console.WriteLine("attack = " + attack);
            Console.WriteLine("weaponstrength = " + weaponstrength);
            Console.WriteLine("weaponcondition = " + weaponcondition);
            Console.ReadLine();
        }
        static void ChangeStats(ref int health, ref int actionPts, ref int skill, ref int knowledge, ref double armor, ref double attack, ref double weaponstrength, ref double weaponcondition)
        {
            Console.WriteLine("\n A wooden chest spawns in front of you. You open it and found \n One Steel Splitting Axe \n One Steel Sword \n One Skinning Knife \n A Book On Gutting And Skinning Animals \n they are now stashed in to your inventory\n");
            health = health + 0;
            actionPts = actionPts + 1;
            skill = skill + 10;
            knowledge = knowledge + 0;
            armor = armor + 0;
            attack = attack + 10;
            weaponstrength = weaponstrength + 10;
            weaponcondition = weaponcondition + 100;
            Console.WriteLine();  // remember to create an inventory so that the player can go into their inventory anytime, in or out of battle
            
            
                Console.WriteLine("You have spent over a hour wandering around and spots a bear off in a distance, Do you want to battle the bear? \n yes \n no");
                Console.WriteLine();
                string choice = Console.ReadLine();
                if (choice == "yes")
                {
                    Console.WriteLine();
                    Console.WriteLine("Slowly sneaking up behind the bear, you pull out your sword and slashed at its back");
                    Console.WriteLine();
                    Console.WriteLine("Crying out in pain, bear quickly spins around at attemps to maul you \n Dodge \n Stay");
                    Console.WriteLine();
                    string move = Console.ReadLine();
                    if (move == "Dodge")
                    {
                        Console.WriteLine();
                        Console.WriteLine("You dodged and is now on the right side of the bear and you aim for the head, Do you want to attack it? \n yes \n no");
                        Console.WriteLine();
                        string attacks = Console.ReadLine();
                        if (attacks == "yes")
                        {
                            skill = skill + 5;
                            actionPts = actionPts + 5;
                            Console.WriteLine();
                            Console.WriteLine("Good Job, you got your first kill. However, this was a very weak level bear, other enemies will be much harder");
                            Console.WriteLine("\n your skill increased by 5, your skill is now: " + skill + "\n your actionPts increased by 5, your actionPts is now: " + actionPts);
                            Console.WriteLine();
                            
                        }
                        else if (attacks == "no")
                        {
                            health = health - 5;
                            Console.WriteLine();
                            Console.WriteLine("The bear turned around an attacked you \n you are now hurt, your health decreased by 5, your health is now: " + health);
                            Console.WriteLine();
                            Console.WriteLine("The bear runs at you preparing to finish you off, Do you \n Dodge and attack \n Do nothing");
                            Console.WriteLine();
                            string attacks1 = Console.ReadLine();
                            if (attacks1 == "Dodge and attack")
                            {
                                skill = skill + 2;
                                actionPts = actionPts + 2;
                                Console.WriteLine();
                                Console.WriteLine("Good Job, you got your first kill. However, this was a very weak level bear, other enemies will be much harder");
                                Console.WriteLine("\n your skill increased by 2 your skill is now: " + skill + "\n your actionPts increased by 2, your actionPts is now: " + actionPts);
                                Console.WriteLine();
                                
                            }
                            else if (attacks1 == "Do nothing")
                            {
                                health = health - 5;
                                Console.WriteLine();
                                Console.WriteLine("The bear's attempt was successful \n you are dying, your health decreased by 5, your health is now: " + health);
                                Console.WriteLine();
                                Console.WriteLine("\n You are now dead \n Game Over\n");
                                Console.WriteLine();
                                
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine("\n That is not a valid command, please follow the directions");
                                Console.WriteLine();
                                
                            }
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("\n That is not a valid command, please follow the directions");
                            Console.WriteLine();
                            
                        }
                    }
                    else if (move == "Stay")
                    {
                        health = health - 5;
                        Console.WriteLine();
                        Console.WriteLine("The bear's attempt was successful, however, you push the bear off before it can go for the kill \n you are now hurt, your health decreased by 5, your health is now: " + health);
                        Console.WriteLine();
                        Console.WriteLine("Getting back on his feet, the bear runs at you preparing to finish you off, Do you \n Dodge and attack \n Do nothing");
                        Console.WriteLine();
                        string attacks = Console.ReadLine();
                        if (attacks == "Dodge and attack")
                        {
                            skill = skill + 2;
                            actionPts = actionPts + 2;
                            Console.WriteLine();
                            Console.WriteLine("Good Job, you got your first kill. However, this was a very weak level bear, other enemies will be much harder");
                            Console.WriteLine("\n your skill increased by 2 your skill is now: " + skill + "\n your actionPts increased by 2, your actionPts is now: " + actionPts);
                            Console.WriteLine();
                            
                        }
                        else if (attacks == "Do nothing")
                        {
                            health = health - 5;
                            Console.WriteLine();
                            Console.WriteLine("The bear's attempt was successful \n you are dying, your health decreased by 5, your health is now: " + health);
                            Console.WriteLine();
                            Console.WriteLine("\n You are now dead \n Game Over\n");
                            Console.WriteLine();
                            
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("\n That is not a valid command, please follow the directions");
                            Console.WriteLine();
                            
                        }
                    }
                    
                }
                else if (choice == "no")
                {
                    Console.WriteLine();
                    Console.WriteLine("Wanting to avoid the incoming danger, you turned to the left and cotinued on walking only to come face to face with a hungry cougar");
                    Console.WriteLine();
                    Console.WriteLine("With a snarl, the cougar leaps at you, preparing to kill you with a single bite to the throat, Do you \n Dodge \n Stay");
                    Console.WriteLine();
                    string move = Console.ReadLine();
                    if (move == "Dodge")
                    {
                        Console.WriteLine();
                        Console.WriteLine("You dodged and is now on the right side of the cougar and you aim for the head, Do you want to attack it? \n yes \n no");
                        Console.WriteLine();
                        string attacks = Console.ReadLine();
                        if (attacks == "yes")
                        {
                            skill = skill + 5;
                            actionPts = actionPts + 5;
                            Console.WriteLine();
                            Console.WriteLine("Good Job, you got your first kill. However, this was a very weak level cougar, other enemies will be much harder");
                            Console.WriteLine("\n your skill increased by 5, your skill is now: " + skill + "\n your actionPts increased by 5, your actionPts is now: " + actionPts);
                            Console.WriteLine();
                            
                        }
                        else if (attacks == "no")
                        {
                            health = health - 5;
                            Console.WriteLine();
                            Console.WriteLine("The cougar turned around an attacked you \n you are now hurt, your health decreased by 5, your health is now: " + health);
                            Console.WriteLine();
                            Console.WriteLine("The cougar runs at you preparing to finish you off, Do you \n Dodge and attack \n Do nothing");
                            Console.WriteLine();
                            string attacks1 = Console.ReadLine();
                            if (attacks1 == "Dodge and attack")
                            {
                                skill = skill + 2;
                                actionPts = actionPts + 2;
                                Console.WriteLine();
                                Console.WriteLine("Good Job, you got your first kill. However, this was a very weak level cougar other enemies will be much harder");
                                Console.WriteLine("\n your skill increased by 2 your skill is now: " + skill + "\n your actionPts increased by 2, your actionPts is now: " + actionPts);
                                Console.WriteLine();
                                
                            }
                            else if (attacks1 == "Do nothing")
                            {
                                health = health - 5;
                                Console.WriteLine();
                                Console.WriteLine("The cougar's attempt was successful \n you are dying, your health decreased by 5, your health is now: " + health);
                                Console.WriteLine();
                                Console.WriteLine("\n You are now dead \n Game Over\n");
                                Console.WriteLine();
                                
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine("\n That is not a valid command, please follow the directions");
                                Console.WriteLine();
                               
                            }
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("\n That is not a valid command, please follow the directions");
                            Console.WriteLine();
                            
                        }
                    }
                    else if (move == "Stay")
                    {
                        health = health - 5;
                        Console.WriteLine();
                        Console.WriteLine("The cougar's attempt was a successful, however, you push him off before it can go for the kill \n you are now hurt, your health decreased by 5, your health is now: " + health);
                        Console.WriteLine();
                        Console.WriteLine("Getting back on his feet, the cougar runs at you preparing to finish you off, Do you \n Dodge and attack \n Do nothing");
                        Console.WriteLine();
                        string attacks = Console.ReadLine();
                        if (attacks == "Dodge and attack")
                        {
                            skill = skill + 2;
                            actionPts = actionPts + 2;
                            Console.WriteLine();
                            Console.WriteLine("Good Job, you got your first kill. However, this was a very weak level cougar, other enemies will be much harder");
                            Console.WriteLine("\n your skill increased by 2 your skill is now: " + skill + "\n your actionPts increased by 2, your actionPts is now: " + actionPts);
                            Console.WriteLine();
                           
                        }
                        else if (attacks == "Do nothing")
                        {
                            health = health - 5;
                            Console.WriteLine();
                            Console.WriteLine("The cougar's attempt was successful \n you are dying, your health decreased by 5, your health is now: " + health);
                            Console.WriteLine();
                            Console.WriteLine("\n You are now dead \n Game Over\n");
                            Console.WriteLine();
                           
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("\n That is not a valid command, please follow the directions");
                            Console.WriteLine();
                            
                        }
                    }
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("\n That is not a valid command, please follow the directions");
                    Console.WriteLine();
                    
                }
            // end of first while loop 

            if (health > 0)
            {
                Console.WriteLine();
                Console.WriteLine("The animal is now dead, you need to remove everything of value in the dead animal so you can use it for later");
                Console.WriteLine();
                Console.WriteLine("Type: Read Gutting And Skinning Book to gain the knowledge in the book");
                Console.WriteLine();
                string choice2 = Console.ReadLine();
                if (choice2 == "Read Gutting And Skinning Book")
                {
                    knowledge = knowledge + 10;
                    actionPts = actionPts + 10;
                    Console.WriteLine();
                    Console.WriteLine("....");
                    Console.WriteLine();
                    Console.WriteLine("Congratulations, You gain the knowledge of: Gutting And Skinning Animals \n your knowledge increase by 10, your knowledge is now: " + knowledge + "\n your actionPts increased by 10 , your actionPts is now: " + actionPts);
                    Console.WriteLine();
                }
            }
            
                
            
        }        
    }
}
