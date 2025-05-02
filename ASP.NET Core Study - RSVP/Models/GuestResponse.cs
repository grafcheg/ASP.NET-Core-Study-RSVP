using System.ComponentModel.DataAnnotations;

namespace ASP.NET_Core_Study___RSVP.Models;

public class GuestResponse
{
    [Required(ErrorMessage = "Пожалуйста, введите своё имя")]
    public string Name { get; set; }
    [Required(ErrorMessage = "Пожалуйста, введите свой email")]
    [EmailAddress]
    public string Email { get; set; }
    [Required(ErrorMessage = "Пожалуйста, введите свой номер телефона")]
    public string Phone { get; set; }
    [Required(ErrorMessage = "Пожалуйста, укажите, примети ли участие")]
    public bool? WillAttend { get; set; }
}