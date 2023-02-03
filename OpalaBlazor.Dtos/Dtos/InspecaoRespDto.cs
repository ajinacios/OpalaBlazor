namespace OpalaBlazor.Models.Dtos
{
    public class InspecaoRespDto
    {
        public int InspecaoId { get; set; }
        public string Numero { get; set; }
        public int PessoaFisId { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Cargo { get; set; }
        public string Resp { get; set; }
    }
}
