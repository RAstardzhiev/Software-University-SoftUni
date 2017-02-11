namespace Circles_Intersection
{
    public class Circle
    {
        public Point Center;

        public double Radius { get; set; }

        public bool Intersect(Circle circle)
        {
            return this.Center.Distance(circle.Center) <= circle.Radius + this.Radius;
        }
    }
}
