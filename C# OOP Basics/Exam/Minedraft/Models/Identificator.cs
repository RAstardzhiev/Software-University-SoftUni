namespace Minedraft.Models
{
    public abstract class Identificator
    {
        private string id;

        protected Identificator(string id)
        {
            this.Id = id;
        }

        public string Id
        {
            get
            {
                return this.id;
            }

            protected set
            {
                this.id = value;
            }
        }
    }
}
