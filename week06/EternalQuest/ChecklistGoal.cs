using System;
public class ChecklistGoal : Goal{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points){
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }
    // This method should do whatever is necessary for each specific 
    // kind of goal, such as marking a simple goal complete and 
    // adding to the number of times a checklist goal has been 
    // completed. It should return the point value associated with 
    // recording the event (keep in mind that it may contain a bonus 
    // in some cases if a checklist goal was just finished, for 
    // example).
    public override int RecordEvent()
    {
        int runningTotal = _points;
        if (_amountCompleted < _target){
            _amountCompleted++;
            Console.WriteLine($"Congratulations! You have scored {_points} points!");
            if (_amountCompleted == _target){
                runningTotal += _bonus;
                Console.WriteLine($"Congratulations! You have scored {_points + _bonus} points!");   
            }
        }
        return runningTotal;
    }
    // This method should return true if the goal is completed. 
    // The way you determine if a goal is complete is different 
    // for each type of goal.
    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }
    // This method should return the details of a goal that could 
    // be shown in a list. It should include the checkbox, the short 
    // name, and description. Then in the case of the ChecklistGoal 
    // class, it should be overridden to shown the number of times 
    // the goal has been accomplished so far.
    public override string GetDetailsString(){
        string checkbox = "[ ]";
        if (IsComplete()){
            checkbox = "[√]";
        }
        return $"{checkbox} {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
    }
    // This method should provide all of the details of a goal in a 
    // way that is easy to save to a file, and then load later.
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{_shortName}|{_description}|{_points}|{_target}|{_bonus}";
    }
}