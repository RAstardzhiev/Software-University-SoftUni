using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Stations.Models.Enums;

namespace Stations.Models
{
    public class CustomerCard
    {
        public const CardType DefaultType = CardType.Normal;

	    public int Id { get; set; }

		[Required]
		[MaxLength(128)]
	    public string Name { get; set; }

		[Range(0, 120)]
	    public int Age { get; set; }

	    public CardType Type { get; set; }

	    public ICollection<Ticket> BoughtTickets { get; set; }
    }
}
