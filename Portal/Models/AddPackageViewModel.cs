﻿using Domain;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Portal.Models
{
    public class AddPackageViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Vul een naam in")]
        [MaxLength(60), StringLength(60, ErrorMessage = "Pakket naam mag niet langer zijn dan 60 characters")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Vul een beschrijving in")]
        [MaxLength(255), StringLength(255, ErrorMessage = "Pakket beschrijving mag niet langer zijn dan 255 characters")]
        public string Description { get; set; }
        public ICollection<int> SelectedProducts { get; set; }
        [Required]
        public int? CanteenId { get; set; }
        //public Canteen? Canteen { get; set; }
        [Required(ErrorMessage = "Kies een ophaal datum")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime PickupTime { get; set; }
        [Required(ErrorMessage = "Kies een beschikbaar tot datum")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime AvailableTill { get; set; }
        [Required(ErrorMessage = "Vul een prijs in")]
        [Column(TypeName = "smallmoney")]
        public decimal Price { get; set; }
        [Required(ErrorMessage = "Kies een categorie")]
        public int Category { get; set; }
    }
}
