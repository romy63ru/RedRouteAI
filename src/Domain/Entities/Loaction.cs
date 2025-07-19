public record Location(double Latitude, double Longitude)
{
    public double DistanceTo(Location other)
    {
        // Simple distance calculation (conditionally, without geosphere)
        var dx = Latitude - other.Latitude;
        var dy = Longitude - other.Longitude;
        return Math.Sqrt(dx * dx + dy * dy);
    }
}