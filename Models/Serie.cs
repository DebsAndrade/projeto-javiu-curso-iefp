using System;
namespace Projecto_JaVi.Models;

	public class Serie
	{
    public int Id { get; set; }
    public string? Nome { get; set; }
    public string? Genero { get; set; }
    public bool Finalizada { get; set; }
    public string? Comentario { get; set; }
    public int Nota { get; set; }
}

