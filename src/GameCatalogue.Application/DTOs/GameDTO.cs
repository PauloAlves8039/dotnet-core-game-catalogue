using GameCatalogue.Domain.Entities;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GameCatalogue.Application.DTOs
{
    public class GameDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The Name is Required")]
        [MinLength(3)]
        [MaxLength(100)]
        [DisplayName("Name")]
        public string Name { get; private set; }

        [Required(ErrorMessage = "The Producer is Required")]
        [MinLength(5)]
        [MaxLength(50)]
        [DisplayName("Producer")]
        public string Producer { get; private set; }

        [Required(ErrorMessage = "The Gender is Required")]
        [MinLength(5)]
        [MaxLength(100)]
        [DisplayName("Gender")]
        public string Gender { get; private set; }

        [Required(ErrorMessage = "The Quantity is Required")]
        [DisplayName("Quantity")]
        public int Quantity { get; private set; }

        [MaxLength(250)]
        [DisplayName("Game Image")]
        public string Image { get; private set; }

        [DisplayName("Platforms")]
        public int PlatformId { get; set; }

        public Platform Platform { get; set; }
    }
}
