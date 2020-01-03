﻿using System;

namespace DigitalPiggy
{
    class Program
    {
        static void Main(string[] args)
        {
            // creates the digital Piggy
            Piggy piggy = new Piggy();

            // connects the balanceUpdate event to the action to be done
            piggy.balanceUpdate += balanceUpdateListener;

            // connects the reachedGoal event to the action to be done
            piggy.balanceGoalReached += reachedGoalListener;

            string amount;
            do
            {
                Console.WriteLine("How much to deposit?");
                amount = Console.ReadLine();
                
                if(!amount.Equals("exit"))
                {
                    bool valid = int.TryParse(amount, out int deposit);

                    if (valid)
                        piggy.Balance = deposit;
                    else
                        Console.WriteLine("Please provide a valid amount.");
                }
            } while (!amount.Equals("exit"));
        }

        /// <summary>
        /// Message to be displayed when the balance gets an update
        /// </summary>
        /// <param name="balance"></param>
        static void balanceUpdateListener(int balance)
        {
            Console.WriteLine($"The balance amount is {balance}.");
        }

        /// <summary>
        /// Message to be displayed when the goal is reached
        /// </summary>
        /// <param name="balance"></param>
        static void reachedGoalListener(int balance)
        {
            Console.WriteLine($"You reached your savings goals! You have {balance}");
        }
    }
}
