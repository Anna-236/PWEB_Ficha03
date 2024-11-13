using RCLUtilidades.Data.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCLUtilidades.Data.Interfaces;

public interface IEnergiaService
{
    Task<IEnumerable<Energia>>? LoadEnergiasAsync();

}