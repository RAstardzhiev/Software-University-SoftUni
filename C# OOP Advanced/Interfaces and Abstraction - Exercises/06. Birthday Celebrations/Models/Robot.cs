namespace _06.Birthday_Celebrations.Models
{
    using Interfaces;

    public class Robot : IIdentifiable
    {
        private string model;

        public Robot(string model, string id)
        {
            this.model = model;
            this.Id = id;
        }

        public string Id { get; private set; }  
    }
}
