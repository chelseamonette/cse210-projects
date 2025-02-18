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
    public override void RecordEvent()
    {
        if (_amountCompleted < _target){
            _amountCompleted++;
            Console.WriteLine($"Congratulations! You have scored {_points} points!");
            if (_amountCompleted == _target){
                Console.WriteLine($"Congratulations! You have scored {_points + _bonus} points!");
                
            }
        }
    }
    public override bool IsComplete()
    {
        return true;
    }
    public override string GetDetailsString(){
        string checkbox = "[ ]";
        if (IsComplete()){
            checkbox = "[√]";
        }
        else{
            return checkbox;
        }
        return $"{checkbox} {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
    }
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{_shortName}|{_description}|{_points}|{_target}|{_bonus}";
    }
}