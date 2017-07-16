namespace VstoEx.Geometry
{
    using System;

    public class Segment
    {
        public float Start { get; }
        public float End { get; }

        public Segment(float start, float end)
        {
            if (end < start + float.Epsilon) throw new InvalidOperationException("Segment cannot have negative or zero length.");
            Start = start;
            End = end;
        }
        
        public float DistanceTo(Segment other)
            => other.Start >= End ? other.Start - End
                : End >= other.Start ? End - other.Start
                    : -1;
    }
}