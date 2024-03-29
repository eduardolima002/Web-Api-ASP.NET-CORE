﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace APICatalogo1.Models;

public class Produto
{
    [Key]
    public int ProdutoId { get; set; }

    [Required]
    [StringLength(120)]
    public string? Nome { get; set; }

    [Required]
    [StringLength(300)]
    public string? Descricao { get; set; }
    [Column(TypeName = "decimal(10,2)")]
    [Required]
    public decimal Preco { get; set; }
    [Required]
    [StringLength(120)]
    public string? ImagemUrl { get; set; }
    [Required]

    public float Estoque { get; set; }
    public DateTime DataCadastro { get; set; }

    public int CategoriaId { get; set; }
    [JsonIgnore]
    public Categoria? Categoria { get; set; }

}
