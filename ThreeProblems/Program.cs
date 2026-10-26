/*
* Name: Drew Sturgill
* Course: CSCI 1250, Section 001
* Assignment: Lab 06, Three Short Problems
* Date: October 23, 2026
* Description: A menu that keeps running until the user quits, offering three
* independent exercises or all three at once. Each exercise
* practices decisions and one of the four loops.
*/
using System;
using System.ComponentModel;
class Program
{
    const int RANDOM_SEED = 4000;
    const int NUMBER_OF_SCORES = 5;
    const int PASSING_SCORE = 60;
    const int MENU_OPTION_COUNT = 5;
    const int QUIT_OPTION = 5;
    static void Main()
    {
        Random rng = new Random(RANDOM_SEED);
        int choice = 0;
        //while loop proceeds to permit the menu to keep running until the user chooses to quit.
        while(choice != QUIT_OPTION)
        {
            Console.WriteLine ("CSCI 1210 Lab 06");
            Console.WriteLine ("1. The Grade Checker");
            Console.WriteLine ("2. The Dice Table");
            Console.WriteLine ("3. The Score Report");
            Console.WriteLine ("4. All Three");
            Console.WriteLine ("5. Quit");
;
            choice = Convert.ToInt32(Console.ReadLine());
        }
            // do while loop forces the program to ask for a menu at the minimum of one times.
            do 
          {
            Console.Write("choose 1 through 5: ");
            choice = Convert.ToInt32(Console.ReadLine());
            if (choice < 1 | choice > MENU_OPTION_COUNT)
            {
                Console.WriteLine("Choose a number from 1 to 5.");
            }

        } while(choice < 1 | choice > MENU_OPTION_COUNT);
        switch (choice)
        {
            case 1:
            GradeChecker();
            break;

            case 2:
            DiceTable(rng);
            break;

            case 3: 
            ScoreReport();
            break;

            case 4:
            GradeChecker();
            DiceTable(rng);
            ScoreReport();
            break;

            case 5: 
            Console.WriteLine("Farewell");
            break;
           
        }   
    }

    static void GradeChecker()
    {
        Console.WriteLine();
        Console.WriteLine("The Grade Checker");
        int score;
        Console.Write("Enter a score from 0 to 100: ");
        score = Convert.ToInt32(Console.ReadLine());
        // while loop permits the user to correct a score that is above or below the range.
        while (score < 0 | score > 100)
        {
            Console.WriteLine("Score must be from 0 to 100");
            Console.Write("Enter a score from 0 to 100: ");
            score = Convert.ToInt32(Console.ReadLine());
        }
        if(score >= 90)
        {
            Console.WriteLine($"{score} earns A");
        }
        else if(score >= 80)
        {
            Console.WriteLine($"{score} earns B");
        }
        else if (score >= 70)
        {
            Console.WriteLine($"{score} earns C");
        }
        else if (score >= 60)
        {
            Console.WriteLine($"{score} earns D");
        }
        else
        {
            Console.WriteLine($"{score} earns F");
        }
    }
    static void DiceTable(Random rng)
    {
        Console.WriteLine();
        Console.WriteLine("The Dice Table");
        int winCount = 0;
        int rollCount = 0;
        string answer;
        do
        {
            int die1 = rng.Next(1, 7);
            int die2 = rng.Next(1, 7);
            int total = die1 + die2;
            rollCount++;
            Console.WriteLine($"Roll {rollCount}: {die1} and {die2}, total {total}.");
            if (die1 == 1 && die2 == 1)
            {
                Console.WriteLine("Snake eyes");
            }
            else if (die1 == die2)
            {
                Console.WriteLine("Doubles");
            }
            if (total == 7 | total == 11)
            {
                Console.WriteLine("you win");
                winCount++;
            }
            Console.Write("Roll again? (y/n): ");
            answer = Console.ReadLine().ToLower();
            
        } while (answer  == "y");
        
        Console.WriteLine($"you rolled {rollCount} times");
        Console.WriteLine($"you win {winCount} times");
    } 
    static void ScoreReport()
    {
        Console.WriteLine();
        Console.WriteLine("The Score Report");
        int[] scores = new int[NUMBER_OF_SCORES];
        for (int i = 0; i < scores.Length; i++)
        {
            Console.Write($"enter score {i + 1}: ");
            scores[i] = Convert.ToInt32(Console.ReadLine());
        }
        int total = 0;
        int highest = scores[0];
        int passingCount = 0;
        foreach(int score in scores)
        {
            total += score;
            if (score> highest)
            {
                highest = score;
            }
            if (score >= PASSING_SCORE)
            {
                passingCount++;
            }
        }
        double average = (double)total / scores.Length;
        Console.WriteLine($"total: {total}");
        Console.WriteLine($"average: {average.ToString("F1")}");
        Console.WriteLine($"highest score: {highest}");
        Console.WriteLine($"passing scores: {passingCount} out of {scores.Length}");
    }
}   
    
    
    


