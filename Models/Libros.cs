using System.ComponentModel.DataAnnotations;

namespace GestionBiblioMVC.Models;

public class Libros
{
    public int Id {get; set;}
    
    
    [Required]
    public string Titulo {get; set;}
    
    public string Autor {get; set;}
    
    [Required]
    public string Codigo {get; set;}
    public int EjemplaresDisponibles {get; set;}

    public List<Prestamos> Prestamos { get; set; } = new List<Prestamos>(); 
}