using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace ClientDev.Models {
    [Serializable]
    [DataContract]
    public class Product {

        public int ProductID { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 5)]
        public string Name { get; set; }

        public string Description { get; set; }

        [Required]
        [Range(typeof(Decimal), "1", "100000")]
        [DataMember(IsRequired = true)]
        public decimal Price { get; set; }

        [Required]
        public string Category { get; set; }
    }
}
