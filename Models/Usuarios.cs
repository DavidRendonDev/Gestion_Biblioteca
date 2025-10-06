using System.ComponentModel.DataAnnotations;

namespace GestionBiblioMVC.Models;

public class Usuarios
{
    public int Id { get; set; }
    [Required]
    [StringLength(100)]
    public string Nombre { get; set; }
    [Required]
    [StringLength(50)]
    public string Documento { get; set; }
    [EmailAddress]
    public string Correo { get; set; }
    
    public string Telefono { get; set; }
    public List<Prestamos> Prestamos { get; set; } = new List<Prestamos>();
}