using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace GestaoIso.Data
{
    [Index(nameof(Cargo), IsUnique = true)]//sem duplicidade

    public class Funcao
    {
        [Key]
        public int FuncaoId { get; set; }

        [Display(Name = "Função")]
        [Required(ErrorMessage = "O Campo {0} é Obrigatório!")]
        [MaxLength(50, ErrorMessage = "Máximo 50 caracteres")]
        public string Cargo { get; set; }

        [Display(Name = "Experiência")]
        public string Experiencia { get; set; }

        [Display(Name = "Educação")]
        public int DominioIdEducacao { get; set; }
        public Dominio? DominioEducacao { get; set; }

        [Display(Name = "Treinamento")]
        public string Treinamento { get; set; }

        [Display(Name = "Cadastrado por")]
        public string? CadastroResp { get; set; }

        [Display(Name = "Cadastrado em")]
        public DateTime? CadastroData { get; set; }

        [Display(Name = "Revisado por")]
        public string? RevisaoResp { get; set; }

        [Display(Name = "Revisado em")]
        public DateTime? RevisaoData { get; set; }

        [Display(Name = "Aprovado")]
        public bool AprovacaoStatus { get; set; }

        [Display(Name = "Aprovado por")]
        public string? AprovacaoResp { get; set; }

        [Display(Name = "Aprovado em")]
        public DateTime? AprovacaoData { get; set; }

        [Display(Name = "Status")]
        public string? Status { get; set; }

        [Display(Name = "Comentário")]
        [DataType(DataType.MultilineText)]
        public string? Comentario { get; set; }


        //public virtual ICollection<Funcionario>? Funcionario { get; set; }

    }
}
