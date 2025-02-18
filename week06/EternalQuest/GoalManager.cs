using System;
using System.Runtime.CompilerServices;
public class GoalManager{
    private List<Goal> _goals;
    private int _score;
    public GoalManager(){
        _score = 0;
        _goals = new(); 
    }
    // This is the "main" function for this class. It is called by 
    // Program.cs, and then runs the menu loop.
    public void Start(){
        
        while(true){
            // Display score
            DisplayPlayerInfo();

            // Display Menu 
            ListGoalName();
            string userChoice = Console.ReadLine();

            if (userChoice == "1"){
                CreateGoal();
            }
            else if(userChoice == "2"){
                ListGoalDetails();
            }
            else if(userChoice == "3"){
                SaveGoals();
            }
            else if(userChoice == "4"){
                LoadGoals();
            }
            else if(userChoice == "5"){
                RecordEvent();
            }
            else if(userChoice == "6"){
                break;
            }
            DisplayPlayerInfo();
        }

    }
    // Displays the players current score.
    public void DisplayPlayerInfo(){
        Console.WriteLine($"You have {_score} points.");
    }
    // Lists the names of each of the goals.
    public void ListGoalName(){
        Console.WriteLine("Menu Options: ");
        Console.WriteLine("\t1. Create New Goal");
        Console.WriteLine("\t2. List Goals");
        Console.WriteLine("\t3. Save Goals");
        Console.WriteLine("\t4. Load Goals");
        Console.WriteLine("\t5. Record Event");
        Console.WriteLine("\t6. Quit");
        Console.Write("Select a choice from the menu: ");
    }
    // Lists the details of each goal (including the checkbox 
    // of whether it is complete).
    public void ListGoalDetails(){
        Console.WriteLine("The goals are: ");
        foreach (Goal goal in _goals){
            goal.GetDetailsString();
        }

    }
    // Asks the user for the information about a new goal. 
    // Then, creates the goal and adds it to the list.
    public void CreateGoal(){
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("\t 1. Simple Goal");
        Console.WriteLine("\t 2. Eternal Goal");
        Console.WriteLine("\t 3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string userChoice = Console.ReadLine();

        if (userChoice == "1"){
            Console.Write("What is the name of your goal?");
            string name = Console.ReadLine();
            Console.Write("What is a description of this?");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points that you want associated with this goal? ");
            string input = Console.ReadLine();
            int points = int.Parse(input);
            SimpleGoal simpleGoal = new(name, description, points);
        }   
        else if (userChoice == "2"){
            Console.Write("What is the name of your goal.");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated with the goal? ");
            string input = Console.ReadLine();
            int points = int.Parse(input);
            EternalGoal eternalGoal = new(name, description, points);
        }
        else if (userChoice == "3"){
             Console.Write("What is the name of your goal.");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated with the goal? ");
            string input = Console.ReadLine();
            int points = int.Parse(input);
            Console.Write("How many times does this goal need to be accomplished to earn a bonus? ");
            string targetInput = Console.ReadLine();
            int target = int.Parse(targetInput);
            Console.Write("What is the bonus for accomplishing it that many times? ");
            string bonusInput = Console.ReadLine();
            int bonus = int.Parse(bonusInput);
            ChecklistGoal checklistGoal = new(name, description, points, target, bonus);
        }

    }
   //  Asks the user which goal they have done and then records 
    // the event by calling the RecordEvent method on that goal.
    public void RecordEvent(){

    }
    // Saves the list of goals to a file.
    public void SaveGoals(){
        
    }
    // Loads the list of goals from a file.
    public void LoadGoals(){

    }
}