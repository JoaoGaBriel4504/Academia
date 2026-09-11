using Academia;

namespace AvalicaoFisica;

public class AvaliacaoFisica
{
    public int Id { get; set; }
    public DateTime DataAvaliacao { get; set; }
    public decimal Peso { get; set; }
    public string? Observacoes { get; set; }
    public int AlunoId { get; set; } 
    public Aluno? Aluno { get; set; } 
}