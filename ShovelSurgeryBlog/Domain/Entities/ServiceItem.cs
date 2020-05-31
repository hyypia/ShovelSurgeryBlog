using System.ComponentModel.DataAnnotations;

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
