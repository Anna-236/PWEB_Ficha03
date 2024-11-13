using Microsoft.VisualBasic;
using RCLUtilidades.Data.DTO;
using RCLUtilidades.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCLUtilidades.Data.Services;

public class EnergiaService : IEnergiaService
{
    //Colocar async para não bloquear 
    //Colocar Task para correr numa nova Tarefa (Semelhante a Thread)
    //Colocar o await para esperar pela base de dados
    public async Task<IEnumerable<Energia>> LoadEnergiasAsync()
    {
        //Sleep de 1s
        await Task.Delay(1000);

        var energias = new[]
        {
            new Energia("Gasóleo", "1,68€", "lt"),
            new Energia("Gasolina", "1,85€", "lt"),
            new Energia("Gas", "18,5€", "gf"),
            new Energia("Eletricidade", "0,16728€", "kw")
        };

        return energias;
    }
}
