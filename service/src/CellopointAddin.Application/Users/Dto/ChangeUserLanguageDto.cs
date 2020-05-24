using System.ComponentModel.DataAnnotations;

namespace CellopointAddin.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}