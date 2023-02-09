using Microsoft.AspNetCore.Components;
using OpalaBlazor.Models.Dtos;
using System.ComponentModel.DataAnnotations;

namespace OpalaBlazor.Server.Pages
{
    public class InspecaoDataBase : ComponentBase
    {


        public class Model : InspecaoDto
        {

        }

        public Model inspecao = new Model();

    }
}
