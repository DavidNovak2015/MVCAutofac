using System.ComponentModel.DataAnnotations;

namespace TestovaciAutofac.Models.Entities
{
    public class VersionEntity
    {
        [Display(Name ="Název")]
        [StringLength(50,ErrorMessage ="Překročen limit 50 znaků")]
        [Required(ErrorMessage ="Poviné pole")]
        public string Name { get; set; }

        // zobrazeni dnesnich verze
        public VersionEntity(string name)
        {
            Name = name;
        }

        // zalozeni nove verze, labely a objekt pro ulozeni dat z formulare
        public VersionEntity()
        { }
    }
}