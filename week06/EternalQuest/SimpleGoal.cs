using System;
public class SimpleGoal : Goal{
    private bool _isComplete;
    public SimpleGoal(string name, string description, int points) : base(name, description, points){
        _isComplete = false;
    }
    // This method should do whatever is necessary for each 
    // specific kind of goal, such as marking a simple goal 
    // complete and adding to the number of times a checklist 
    // goal has been completed. It should return the point value 
    // associated with recording the event (keep in mind that it 
    // may contain a bonus in some cases if a checklist goal was 
    // just finished, for example).
    public override int RecordEvent(){
        _isComplete = true;
        Console.WriteLine($"Congratulations! You have earned {_points} points");
        Console.WriteLine($"You have earned {_points} points.");
        return _points;

    }
    // This method should return true if the goal is completed. 
    // The way you determine if a goal is complete is different 
    // for each type of goal.
    public override bool IsComplete()
    {
       return _isComplete;
    }
    // This method should provide all of the details of a goal in 
    // a way that is easy to save to a file, and then load later.
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal|{_shortName}|{_description}|{_points}";
    }
}