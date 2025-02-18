// Your program must do the following:

// Provide for simple goals that can be marked complete and the 
// user gains some value.

// For example, if you run a marathon you get 1000 points.

// Provide for eternal goals that are never complete, but each time 
// the user records them, they gain some value.

// For example, every time you read your scriptures you get 100 
// points.

// Provide for a checklist goal that must be accomplished a certain 
// number of times to be complete. Each time the user records this 
// goal they gain some value, but when they achieve the desired 
// amount, they get an extra bonus.

// For example, if you set a goal to attend the temple 10 times, 
// you might get 50 points each time you go, and then a bonus of 
// 500 points on the 10th time.

// Display the user's score.

// Allow the user to create new goals of any type.

// Allow the user to record an event (meaning they have accomplished 
// a goal and should receive points).

// Show a list of the goals. This list should show indicate whether 
// the goal has been completed or not (for example [ ] compared to 
// [X]), and for checklist goals it should show how many times the 
// goal has been completed (for example Completed 2/5 times).

// Allow the user's goals and their current score to be saved and 
// loaded.

using System;
using System.IO;
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
        Console.WriteLine("The goals are:");
        int goalNumber = 0;
        foreach (Goal goal in _goals){
            Console.WriteLine($"{goalNumber + 1}. {goal.GetDetailsString()}");
            goalNumber ++;
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
            _goals.Add(simpleGoal);
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
            _goals.Add(eternalGoal);
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
            _goals.Add(checklistGoal);
        }

    }
   //  Asks the user which goal they have done and then records 
    // the event by calling the RecordEvent method on that goal.
    public void RecordEvent(){
        ListGoalDetails();
        Console.Write("Which goal did you accomplish? ");
        int goalChoice = int.Parse(Console.ReadLine());
        Goal chosenGoal = _goals[goalChoice - 1];
        int runningTotal = chosenGoal.RecordEvent();
        _score += runningTotal;
        Console.WriteLine($"You have {_score} points");
    }
    // Saves the list of goals to a file.
    public void SaveGoals(){
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach(Goal goal in _goals){
                string goalString = goal.GetStringRepresentation();
                outputFile.WriteLine(goalString);
            }
        }
    }
    // Loads the list of goals from a file.
    public void LoadGoals(){
        Console.Write("What is the filename for the goal file? ");
        string goalFile = Console.ReadLine();

        string [] lines = File.ReadAllLines(goalFile);

        foreach(string line in lines){
        string [] parts = line.Split('|');
        string goalType = parts[0];

            if (goalType == "SimpleGoal"){
                string pointsString = parts[3];
                _goals.Add(new SimpleGoal(parts[1], parts[2], int.Parse(pointsString)));
            }
            else if (goalType == "EternalGoal"){
                string pointsString = parts[3];
                _goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(pointsString)));
            }
            else if (goalType == "ChecklistGoal"){
                string pointsString = parts[3];
                string targetString = parts[4];
                string bonusString = parts[5];
                _goals.Add(new ChecklistGoal(parts[1], parts[2], int.Parse(pointsString), int.Parse(targetString), int.Parse(bonusString)));
            }
        }
    }
}