namespace virutalandoverrideexample
{
    public class Sphere : Shape
    {
        public Sphere(double r) : base(r, 0)
        {

        }
        public override double Area()
        {
            return 4 * PI * x * x;
        }
    }
}