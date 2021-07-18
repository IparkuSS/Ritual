using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ritual.Domain.Entities
{
    public class InitMon : EntityBase

    {
        [Display(Name = "Название (заголовок)")]
        public override string Title { get; set; }

        [Display(Name = "Краткое описание услуги")]
        public override string Subtitle { get; set; }

    }
}
