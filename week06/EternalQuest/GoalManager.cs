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
            
        }

    }
    // Displays the players current score.
    public void DisplayPlayerInfo(){

    }
    // Lists the names of each of the goals.
    public void ListGoalName(){

    }
    // Lists the details of each goal (including the checkbox 
    // of whether it is complete).
    public void ListGoalDetails(){

    }
    // Asks the user for the information about a new goal. 
    // Then, creates the goal and adds it to the list.
    public void CreateGoal(){

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