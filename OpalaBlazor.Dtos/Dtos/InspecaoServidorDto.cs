namespace OpalaBlazor.Models.Dtos
{
    public class InspecaoServidorDto
    {
        public int InspecaoId { get; set; }
        public string Numero { get; set; }
        public int ServidorId { get; set; }
        public string Nome { get; set; }
        public string Matricula { get; set; }
        public string Setor { get; set; }
        public string Funcao { get; set; }
    }
}
