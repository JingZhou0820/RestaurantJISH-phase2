namespace RestaurantJISH_phase21.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OrderItem
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderItemId { get; set; }

        public int OrderId { get; set; }

        [Required]
        public string RestaurantName { get; set; }

        [Required]
        public string FoodName { get; set; }

        public double Price { get; set; }

        public virtual order order { get; set; }
    }
}
