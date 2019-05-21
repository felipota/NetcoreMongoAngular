
using MonolegalApi.Models;
using MonolegalApi.Services;

namespace MonolegalApi.BL
{
    public class SegundoRecordatorio : IEstadoOperador
    {
        public OperadorFactura Operator => OperadorFactura.SegundoRecordatorio;
        private readonly IClienteService _ICLienteService;
        private readonly IEmailSender _EmailSender;
        private string emailSubject = "Estimado cliente : ";
        private string emailBody = "Tiene una deuda de :";

        public SegundoRecordatorio(IClienteService CLienteService, IEmailSender EmailSender)
        {
            _ICLienteService = CLienteService;
            _EmailSender = EmailSender;
        }

        public bool ValidateEstado(Cliente cliente)
        {
            decimal totalFacturas = 0;
            int cantFacturas = 0;
            cliente.Facturas.ForEach(factura =>
            {
                if (!factura.Pagada)
                {
                    cantFacturas++;
                    totalFacturas += factura.Total;
                }
            });
            if (cantFacturas > 2 && totalFacturas >= 10000)
            {
                cliente.Facturas.ForEach(factura =>
                {
                    if (!factura.Pagada && factura.estado == EstadosFactura.SegundoRecordatorio)
                    {
                        factura.estado = EstadosFactura.Desactivado;
                    }
                });
                _ICLienteService.Update(cliente.Id.ToString(), cliente);
                emailSubject = $"{emailSubject} {cliente.Nombre}";
                emailBody = $"{emailBody} {totalFacturas} sus facturas cambian a estado {EstadosFactura.Desactivado}";
                _EmailSender.SendEmailAsync(cliente.Correo, emailSubject, emailBody);
            }
            
            return false;
        }
    }
}
