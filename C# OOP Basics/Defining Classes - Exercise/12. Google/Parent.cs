namespace _12.Google
{
    using System;

    public class Parent
    {
        private string name;
        private string birthday;

        public Parent(string name, string birthday)
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
                    throw new ArgumentException($"{nameof(Parent)}'s name can not be neither empty nor white space!!!");
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
