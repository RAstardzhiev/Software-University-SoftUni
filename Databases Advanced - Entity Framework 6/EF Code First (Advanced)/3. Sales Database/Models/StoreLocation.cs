namespace _3.Sales_Database.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.Collections.Generic;
    using Helpers;

    public class StoreLocation
    {
        private const int LocationNameMaxLength = 255;

        private string locationName;
        private DataValidator dataValidator;

        private StoreLocation()
        {
            this.dataValidator = new DataValidator();
            this.Sales = new HashSet<Sale>();
        }

        public StoreLocation(string locationName) 
            : this()
        {
            this.LocationName = locationName;
        }

        public int Id { get; set; }

        [Required]
        [StringLength(LocationNameMaxLength)]
        [Display(Name = "Location Name")]
        public string LocationName
        {
            get
            {
                return this.locationName;
            }

            set
            {
                this.dataValidator.StringExistenceValidation(value, nameof(StoreLocation), nameof(this.LocationName));
                this.dataValidator.StringMaxLengthValidator(value, LocationNameMaxLength, nameof(this.LocationName));
                this.locationName = value;
            }
        }

        public virtual ICollection<Sale> Sales { get; set; }
    }
}
