using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShovelSurgeryBlog.Domain.Entities
{
    public class ServiceItem : EntityBase
    {
        [Required(ErrorMessage = "Заполните заголовок публикации")]
        [Display(Name = "Название публикации")]
        public override string Title { get; set; }

        [Display(Name = "Подзаголовок публикации")]
        public override string Subtitle { get; set; }

        [Display(Name = "Текст публикации")]
        public override string Text { get; set; }
    }
}
