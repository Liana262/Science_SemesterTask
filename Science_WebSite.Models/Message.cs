using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;


namespace Science_WebSite.Models
{
    public class Message
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(200)]
        public string TextMessage { get; set; }
        [Required]
        public int UserId { get; set; }
        [Required]
        public int ArticleId { get; set; }
    }
}
