using System;
namespace Projecto_JaVi.Models;

	public class Filme
	{
    public int Id { get; set; } //Primary key
    public string? Nome { get; set; }
    public string? Genero { get; set; }
    public string? Comentario { get; set; }
    public bool JaViu { get; set; }
    public int Nota { get; set; }

    //CRUD - Create Read Update Delete
}

