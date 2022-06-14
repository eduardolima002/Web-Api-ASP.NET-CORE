using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace APICatalogo1.Models;

public class Categoria
{
    public int CategoriaId { get; set; }
    [Required]
    [StringLength(120)]
    public string? Nome { get; set; }
    [Required]
    [StringLength(120)]
    public string? ImagemUrl { get; set; }
    [JsonIgnore]
    public ICollection<Produto>? Produtos { get; set; }

    public Categoria()
    {
        Produtos = new Collection<Produto>();
    }
}
