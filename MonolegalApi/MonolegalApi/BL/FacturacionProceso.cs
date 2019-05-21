
﻿using MonolegalApi.Models;
using MonolegalApi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonolegalApi.BL
{
    public class FacturacionProceso : IFacturacionProceso
    {
        private readonly IClienteService _ICLienteService;
        private readonly IEstadoFacturaStrategy _estadoFacturaStrategy;

        public FacturacionProceso(IClienteService ICLienteService, IEstadoFacturaStrategy estadoFacturaStrategy)
        {
            _ICLienteService = ICLienteService;
            _estadoFacturaStrategy = estadoFacturaStrategy;
        }
        public bool ValidarPagosTodos()
        {
            List<Cliente> clietes = _ICLienteService.Get();
            clietes.ForEach(cliente => {
                int SegundoAvisoCont = 0;
                int PrimerAvisoCont = 0;
                cliente.facturas.ForEach(Factura => {
                    OperadorFactura op = GetPropValue(Factura.estado);
                    switch (op)
                    {
                        case OperadorFactura.PrimerRecordatorio:
                            PrimerAvisoCont++;
                            break;
                        case OperadorFactura.SegundoRecordatorio:
                            SegundoAvisoCont++;
                            break;
                    }

                });
                if(SegundoAvisoCont > 0)
                {
                    _estadoFacturaStrategy.Validar( cliente,  OperadorFactura.SegundoRecordatorio);
                }
                else if(PrimerAvisoCont > 0)
                {
                    _estadoFacturaStrategy.Validar( cliente, OperadorFactura.PrimerRecordatorio);
                }
            });
            return false;
        }

        public bool ReturnToDefault()
        {
            List<Cliente> clietes = _ICLienteService.Get();
            clietes.ForEach(cliente => {
                    cliente.facturas.ForEach(factura => {
                        factura.estado = EstadosFactura.PrimerRecordatorio;
                    });
                _ICLienteService.Update(cliente.Id.ToString(),cliente);
            });
            return true;
        }
        private static OperadorFactura GetPropValue( string estado)
        {
            return (OperadorFactura) Enum.Parse(typeof(OperadorFactura), estado);
        }

    
    }
}
