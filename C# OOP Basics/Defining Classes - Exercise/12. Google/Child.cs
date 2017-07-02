namespace _12.Google
{
    using System;

    public class Child
    {
        private string name;
        private string birthday;

        public Child(string name, string birthday)
        {
            this.Name = name;
            this.birthday = birthday;
        }

        private string Name
        {
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException($"{nameof(Child)}'s name can not be neither empty nor white space!!!");
                }

                this.name = value;
            }
        }

        public override string ToString()
        {
            return $"{this.name} {this.birthday}";
        }
    }
}
