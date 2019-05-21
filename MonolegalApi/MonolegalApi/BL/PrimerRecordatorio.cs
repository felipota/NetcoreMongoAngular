<<<<<<< HEAD
﻿using System;
using MonolegalApi.Models;
using MonolegalApi.Services;

namespace MonolegalApi.BL
{
    public class PrimerRecordatorio : IEstadoOperador
    {
        public OperadorFactura Operator => OperadorFactura.PrimerRecordatorio;
        private readonly IClienteService _ICLienteService;
        private readonly IEmailSender _EmailSender;
        private string emailSubject = "Estimado cliente : ";
        private string emailBody = "Tiene una deuda de :";
        public PrimerRecordatorio(IClienteService CLienteService, IEmailSender EmailSender)
        {
            _ICLienteService = CLienteService;
            _EmailSender = EmailSender;
        }
        public bool ValidateEstado(Cliente cliente)
        {
            decimal totalFacturas = 0;
            cliente.Facturas.ForEach(factura =>
            {
                if(!factura.Pagada && factura.estado == EstadosFactura.PrimerRecordatorio)
                {
                    factura.estado = EstadosFactura.SegundoRecordatorio;
                    totalFacturas += factura.Total;
                }
            });
            _ICLienteService.Update(cliente.Id.ToString(), cliente);
            emailSubject = $"{emailSubject} {cliente.Nombre}";
            emailBody = $"{emailBody} {totalFacturas} sus facturas cambian a estado {EstadosFactura.SegundoRecordatorio}";
            _EmailSender.SendEmailAsync(cliente.Correo, emailSubject, emailBody);
            return false;
        }
    }
}
=======
﻿using System;
using MonolegalApi.Models;
using MonolegalApi.Services;

namespace MonolegalApi.BL
{
    public class PrimerRecordatorio : IEstadoOperador
    {
        public OperadorFactura Operator => OperadorFactura.PrimerRecordatorio;
        private readonly IClienteService _ICLienteService;
        private readonly IEmailSender _EmailSender;
        private string emailSubject = "Estimado cliente : ";
        private string emailBody = "Tiene una deuda de :";
        public PrimerRecordatorio(IClienteService CLienteService, IEmailSender EmailSender)
        {
            _ICLienteService = CLienteService;
            _EmailSender = EmailSender;
        }
        public bool ValidateEstado(Cliente cliente)
        {
            decimal totalFacturas = 0;
            cliente.Facturas.ForEach(factura =>
            {
                if(!factura.Pagada && factura.estado == EstadosFactura.PrimerRecordatorio)
                {
                    factura.estado = EstadosFactura.SegundoRecordatorio;
                    totalFacturas += factura.Total;
                }
            });
            _ICLienteService.Update(cliente.Id.ToString(), cliente);
            emailSubject = $"{emailSubject} {cliente.Nombre}";
            emailBody = $"{emailBody} {totalFacturas} sus facturas cambian a estado {EstadosFactura.SegundoRecordatorio}";
            _EmailSender.SendEmailAsync(cliente.Correo, emailSubject, emailBody);
            return false;
        }
    }
}
>>>>>>> 9bd5cb3e33341e4627f0d1eab90da82dc9784e56
