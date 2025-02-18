using System;
public class Running : Activity{
    private double _distance;
    public Running(string date, double length, double distance) : base(date, length){
        _distance = distance;

    }
    public override double Distance()
    {
        return _distance;
    }
    public override double Speed()
    {
        return (_distance / _length) * 60;
    }
    public override double Pace()
    {
        return _length / _distance;
    }
    public override string GetSummary()
    {
         return $"{_date} Running ({_length} min) - Distance: {Distance()} miles, Speed: {Speed()} mph, Pace: {Pace()} min per mile";
    }
}