using System.ComponentModel.DataAnnotations;

namespace Blazorchik.Model
{
    public class ChatMessage
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string MovieId { get; set; } // Идентификатор фильма

        [Required]
        public string UserId { get; set; } // Идентификатор пользователя (ключ)

        [Required]
        public string UserName { get; set; } // Имя пользователя

        [Required]
        public string Message { get; set; } // Текст сообщения

        [Required]
        public DateTime Timestamp { get; set; } // Время отправки сообщения
    }
}