using System.ComponentModel.DataAnnotations;

namespace AgVantis.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}