using System.ComponentModel.DataAnnotations;

namespace PartyInvite.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Please enter yoru name.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter your email address.")]
        [RegularExpression(".+\\@.+\\..+",
        ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter your phone number.")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Please specify weather you I'll attend the party.")]
        public bool? WillAttend { get; set; }
    }
}