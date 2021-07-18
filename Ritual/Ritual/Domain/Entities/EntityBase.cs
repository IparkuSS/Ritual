using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ritual.Domain.Entities
{
    public abstract class EntityBase
    {
        protected EntityBase() => DateAdded = DateTime.UtcNow;
        [Required]
        public Guid Id { get; set; }

        [Display(Name = "Название (заголовок)")]
        public virtual string Title { get; set; }

        [Display(Name = "Краткое описание услуги")]
        public virtual string Subtitle { get; set; }
        
        [Display(Name = "Титульная картинка")]
        public string TitleImagePath { get; set; }
         

        [DataType(DataType.Time)]
        public DateTime DateAdded { get; set; }
        

    }
}

