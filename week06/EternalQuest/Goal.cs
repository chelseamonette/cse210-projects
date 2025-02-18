using System;
public abstract class Goal{
    private string _shortName;
    private string _description;
    private int _points;
    public Goal(string name, string description, int points){
        _shortName = name;
        _description = description;
        _points = points;
    }
    public abstract void RecordEvent();
    public abstract bool IsComplete();
    // This method should return the details of a goal that could 
    // be shown in a list. It should include the checkbox, the short 
    // name, and description. Then in the case of the ChecklistGoal 
    // class, it should be overridden to shown the number of times 
    // the goal has been accomplished so far.
    public string GetDetailsString(){
        string checkbox = "[ ]";
        if (IsComplete()){
            checkbox = "[√]";
        }
        else{
            return checkbox;
        }
        return $"1. {checkbox} {_shortName} ({_description})";
    }
    public abstract string GetStringRepresentation();
}