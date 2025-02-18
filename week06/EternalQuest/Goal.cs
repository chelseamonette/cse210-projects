using System;
public abstract class Goal{
    protected string _shortName;
    protected string _description;
    protected int _points;
    public Goal(string name, string description, int points){
        _shortName = name;
        _description = description;
        _points = points;
    }
    public abstract int RecordEvent();
    public abstract bool IsComplete();
    // This method should return the details of a goal that could 
    // be shown in a list. It should include the checkbox, the short 
    // name, and description. Then in the case of the ChecklistGoal 
    // class, it should be overridden to shown the number of times 
    // the goal has been accomplished so far.
    public virtual string GetDetailsString(){
        string checkbox;
        if (IsComplete()){
            checkbox = "[√]";
        }
        else{
            checkbox = "[ ]";
        }
        return $"{checkbox} {_shortName} ({_description})";
    }
    public abstract string GetStringRepresentation();
}