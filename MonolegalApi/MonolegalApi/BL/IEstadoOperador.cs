
﻿using MonolegalApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonolegalApi.BL
{
    public interface IEstadoOperador
    {
        OperadorFactura Operator { get; }
        bool ValidateEstado(Cliente cliente);
    }
}
