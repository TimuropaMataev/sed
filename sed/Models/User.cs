using System.ComponentModel.DataAnnotations;

namespace sed.Models;

public class User
{
    public int Id { get; set; }

    public int? CompanyId { get; set; }

    [Required(ErrorMessage = "Имя не указано")]
    [StringLength(40, MinimumLength = 3, ErrorMessage = "Диапазон от 3 до 40")]
    public string? Name { get; set; }

    [Required(ErrorMessage = "Возраст не указан")]
    [Range(1, 110, ErrorMessage = "Возраст от 1 до 110")]
    public int Age { get; set; }

    [Required(ErrorMessage = "Адрес не указан")]
    [StringLength(70, MinimumLength = 6, ErrorMessage = "Диапазон от 6 до 70")]
    [EmailAddress]
    public string? Email { get; set; }

    public Company? Company { get; set; }
}