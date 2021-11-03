using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WardrobeTracker.Models
{
    public class WardrobeItem
    {
        [Key]
        [Column("ItemId")]
        public int ID { get; set; }

        [Required]
        [Column("ItemName")]
        public string Name { get; set; }

        [Column("ItemType")]
        public string Type { get; set; }

        [Display(Name = "Lifestyle Category")]
        public string LifestyleCategory { get; set; }

        public string Store { get; set; }

        public string Secondhand { get; set; }

        public string Brand { get; set; }

        [Display(Name = "Price Paid")]
        public decimal? PricePaid { get; set; }

        [Display(Name = "Retail Price")]
        public decimal? RetailPrice { get; set; }

        public string Fabric { get; set; }

        [Display(Name = "Primary Color")]
        public string PrimaryColor { get; set; }

        [Display(Name = "Date Bought")]
        public DateTime? DateBought { get; set; }

        [ScaffoldColumn(false)]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreateDate { get; set; }

        [ScaffoldColumn(false)]
        public DateTime? ModifyDate { get; set; }
    }
}
