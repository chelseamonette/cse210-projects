using System;
public class StationaryBicycles: Activity{
    private double _speed;
    public StationaryBicycles(string date, double length, double speed) : base(date, length){
        _speed = speed;

    }
    public override double Distance()
    {
        return _length;
    }
    public override double Speed()
    {
        return _speed;
    }
    public override double Pace()
    {
        return 60 / _speed;
    }
     public override string GetSummary()
    {
         return $"{_date} Stationary Bike ({_length} min) - Distance: {Distance()} miles, Speed: {Speed()} mph, Pace: {Pace()} min per mile";
    }
}