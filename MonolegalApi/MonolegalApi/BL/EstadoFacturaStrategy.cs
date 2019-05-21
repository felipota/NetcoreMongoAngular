
﻿using System;
using System.Collections.Generic;
using System.Linq;
using MonolegalApi.Models;

namespace MonolegalApi.BL
{
    public class EstadoFacturaStrategy : IEstadoFacturaStrategy
    {
        private readonly IEnumerable<IEstadoOperador> _operators;
        public EstadoFacturaStrategy(IEnumerable<IEstadoOperador> operators)
        {
            _operators = operators;
        }
        public bool Validar(Cliente cliente ,OperadorFactura op)
        {
            try
            {
                return _operators.FirstOrDefault(x => x.Operator == op)?.ValidateEstado(cliente) ?? throw new ArgumentNullException(nameof(op));
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
