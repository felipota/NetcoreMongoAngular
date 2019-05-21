
﻿using MonolegalApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonolegalApi.BL
{
    public interface IEstadoFacturaStrategy
    {
        bool Validar(Cliente cliente, OperadorFactura op);
    }
}
