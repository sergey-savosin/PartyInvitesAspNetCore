using System.ComponentModel.DataAnnotations;

namespace PartyInvitesAspNetCore.Models
{
	public class GuestResponse
	{
		[Required(ErrorMessage = "Укажите Имя")]
		public string Name { get; set; }
		
		[Required(ErrorMessage = "Укажите Email")]
		public string Email { get; set; }
		
		[Required(ErrorMessage = "Укажите номер телефона")]
		public string Phone { get; set; }
		
		[Required(ErrorMessage = "Укажите ваше решение о песещении мероприятия")]
		public bool? WillAttend { get; set; }
	}
}
