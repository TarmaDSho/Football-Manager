//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FootballManager.Models
{
    using Imagens.Models.Validators;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Web;
    
    public partial class Championship
    {
        public Championship()
        {
            this.Journey = new HashSet<Journey>();
            this.Season = new HashSet<Season>();
            this.TeamPoints = new HashSet<TeamPoints>();
        }
    
        public int ID { get; set; }

        [Required]
        [StringLength(150,ErrorMessage="Championship name cannot have more than 150 characters")]
        public string Name { get; set; }

        public string Logo { get; set; }        

        //[Required]
        [NotMapped]
        [DataType(DataType.Upload)]
        //[FileSize(10240)]
        //[FileTypes("jpg,jpeg,png,gif")]
        public HttpPostedFileBase LogoPath { get; set; }

        [DataType(DataType.Date,ErrorMessage="Please enter a valid date")]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime FoudationDate { get; set; }

        [Required]
        public int CountryID { get; set; }

        [Required]
        public int EntityMngID { get; set; }
    
        public virtual EntityManager EntityManager { get; set; }
        public virtual Country Country { get; set; }
        public virtual ICollection<Journey> Journey { get; set; }
        public virtual ICollection<Season> Season { get; set; }
        public virtual ICollection<TeamPoints> TeamPoints { get; set; }
    }
}
