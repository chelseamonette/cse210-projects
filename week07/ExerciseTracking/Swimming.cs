using System;
public class Swimming : Activity{
    private double _numLaps;
    public Swimming(string date, double length, double numLaps) : base(date, length){
        _numLaps = numLaps;
    }
    public override double Distance()
    {
        return ((_numLaps * 50) / (1000 * 0.62));
    }
    public override double Speed()
    {
        return (Distance()/ _length) * 60;
    }
    public override double Pace()
    {
        return 60 / Speed();
    }
     public override string GetSummary()
    {
         return $"{_date} Swimming ({_length} min) - Distance: {Distance().ToString("F1")} miles, Speed: {Speed().ToString("F1")} mph, Pace: {Pace().ToString("F1")} min per mile";
    }
}