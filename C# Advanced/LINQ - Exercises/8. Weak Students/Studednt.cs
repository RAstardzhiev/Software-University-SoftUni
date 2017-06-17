namespace _8.Weak_Students
{
    using System;
    using System.Collections.Generic;

    public class Studednt : IEquatable<Studednt>
    {
        public string Name { get; set; }

        public List<double> Evaluations { get; set; }

        public bool Equals(Studednt other)
        {
            return other.Name == this.Name;
        }
    }
}
