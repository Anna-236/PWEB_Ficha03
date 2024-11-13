using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RCLUtilidades.Pages
{
    public partial class HomeComponent
    {

        //Formas de Receber dados num Componente
        [Parameter]
        //ByForm
        //ByQuery


        public String? MensagemBody { get; set; }
    }
}
