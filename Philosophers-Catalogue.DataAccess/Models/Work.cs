using System.ComponentModel.DataAnnotations.Schema;
using JetBrains.Annotations;
using NodaTime;
using NpgsqlTypes;
using Philosophers_Catalogue.Models.Enums;

namespace Philosophers_Catalogue.Models;

[PublicAPI]
public class Work
{
    public Guid Id { get; set; }

    [Column("varchar(128)")]
    public required string Title { get; set; }

    [Column(TypeName = "text")]
    public string? Description { get; set; }

    public int? PublicationYear { get; set; }
    public Guid? PrimaryAuthorId { get; set; }
    public Uri? ExternalUrl { get; set; }
    public required NpgsqlTsVector Embeddings { get; set; } 

    public Instant CreatedAt { get; set; }
    public Instant UpdatedAt { get; set; }

    [Column(TypeName = "varchar(100)")]
    public WorkTypes Type { get; set; }

    [ForeignKey(nameof(PrimaryAuthorId))]
    public Philosopher? PrimaryAuthor { get; set; }

    public ICollection<ItemBranch> Branches { get; set; } = new List<ItemBranch>();
    public ICollection<CategorySchool> CategoriesSchools { get; set; } = new List<CategorySchool>();
    public ICollection<Notion> Notions { get; set; } = new List<Notion>();
}