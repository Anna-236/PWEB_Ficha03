using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

using RCLUtilidades.Data.DTO;
using RCLUtilidades.Pages;
using RCLUtilidades.Data.Services;

namespace RCLUtilidades.Pages
{
    public partial class EnergiaComponent{
        
        private <IEnumerable<Energia>>? energias;
        
        //Especie de construtor chamado automático
        protected override async Task onInitializedAsync()
        {
            energias = await energiaService.LoadEnergiasAsync();
        }
    }
}
