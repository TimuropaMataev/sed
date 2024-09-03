using System.ComponentModel.DataAnnotations;

namespace sed.Models;

public class Company
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Название не указано")]
    [StringLength(70, MinimumLength = 1, ErrorMessage = "Диапазон от 1 до 70")]
    public string? Name { get; set; }

    public List<User> Users { get; set; } = new List<User>();
}