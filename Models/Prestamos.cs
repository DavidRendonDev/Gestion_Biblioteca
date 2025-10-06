namespace GestionBiblioMVC.Models;

public class Prestamos
{
    public int Id { get; set; }
    
    public int UsuarioId { get; set; }
    public Usuarios? Usuario { get; set; }
    
    public int LibrosId { get; set; }
    public Libros? Libros { get; set; }
    
    public DateTime FechaPrestamo { get; set; }
    
    public DateTime? FechaDevolucion { get; set; }
    
    public bool Devuelto { get; set; } =  false;
    
}