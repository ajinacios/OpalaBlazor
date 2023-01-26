using Microsoft.AspNetCore.Components;
using System.ComponentModel.DataAnnotations;

namespace OpalaBlazor.Server.Pages
{
    public class NumInspecaoBase:ComponentBase
    {
        public Model model = new Model();
        public class Model
        {
            [Required(ErrorMessage = "Entre com um número de inspeção.")]
            public string Numero { get; set; }

        }
    }
}
