using System.ComponentModel.DataAnnotations;

namespace SignalRChat.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}