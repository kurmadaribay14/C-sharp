using System;

namespace lesson6
{
    public abstract class Driver
    {
        public string Name {get; set;}

        public abstract void Forward (int distance);
        public abstract void Backward (int distance);
        public abstract void TurnLeft (float angle);
        public abstract void TurnRight (float angle);

        public virtual void Initialize()
        {
            System.Console.WriteLine("Driver initialized");
        }

    }

    public class CarDriver : Driver
    {
        public override void Backward(int distance)
        {
            throw new NotImplementedException();
        }

        public override void Forward(int distance)
        {
            throw new NotImplementedException();
        }

        public override void TurnLeft(float angle)
        {
            throw new NotImplementedException();
        }

        public override void TurnRight(float angle)
        {
            throw new NotImplementedException();
        }
    }
}