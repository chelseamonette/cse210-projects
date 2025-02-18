using System;
public abstract class Activity{
    protected string _date;
    protected double _length;
    public Activity(string date, double length){
        _date = date;
        _length = length;

    }
    public abstract double Distance();
    public abstract double Speed();
    public abstract double Pace();
    public abstract string GetSummary();
}