namespace OpalaBlazor.Models.Dtos
{
    public class InspecaoDto
    {
        public int InspecaoId { get; set; }

        public string? Numero { get; set; }

        public string? Ano { get; set; }

        public DateTime Inicio { get; set; }

        public DateTime Final { get; set; }

        public string? Portaria { get; set; }
        public int OrgaoId { get; set; }
    }
}
