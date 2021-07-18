using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ritual.Domain.Entities
{
    public class ServiceItem : EntityBase

    {
        [Required(ErrorMessage = "Заполните название услуги")]
        [Display(Name = "Название услуги")]
        public override string Title { get; set; }

        [Display(Name = "Краткое описание услуги")]
        public override string Subtitle { get; set; }



    }
}
