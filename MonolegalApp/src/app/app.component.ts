import { Component } from '@angular/core';
import {SClienteService} from './services/scliente.service';
import {SClienteResetService} from './services/scliente-reset.service';
import {ICliente} from './interfaces/icliente'
import {SClienteValidarFacturaService} from './services/scliente-validar-factura.service';
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'MonolegalApp';
  listaClientes : ICliente[];
  Facturas :  [];
  constructor(private clientesService: SClienteService,
              private clienteResetService: SClienteResetService,
              private clienteValidarFacturaService: SClienteValidarFacturaService){
    this.GetCliente();
  }

  public GetCliente() : void {
    
    this.clientesService.getList().subscribe(
      response => {

        this.listaClientes = response;
        this.Facturas=this.BuildListaFactura(this.listaClientes);
      },
      error => {
        alert("error");
      }
    );
  }

  private BuildListaFactura (Clientes : ICliente []) : any{
    let facturasResult = [];
    Clientes.forEach(cliente => {
      cliente.facturas.forEach(factura => {
          let fact = {CodigoFactura : factura.codigoFactura,Cliente:cliente.nombre,Ciudad:cliente.ciudad,Nit:cliente.nit,TotalFactura:factura.total,
                      SubTotal:factura.subTotal,Iva:factura.iva,Retencion:factura.retencion,FechaCreacion:factura.fechaCreacion,Estado:factura.estado,
                      Pagada:factura.pagada};
          facturasResult.push(fact);
      });
    });
    return facturasResult
  }
  ValidarFacturacion () : any {
    this.clienteValidarFacturaService.validate().subscribe(
      response => {
        console.log(response);
        this.GetCliente()
      },
      error => {
        console.log(error);
      }
      
    );
  }

  ResetFacturacion () : any {
    debugger;
        this.clienteResetService.getList().subscribe(
          response => {
            console.log(response);
            this.GetCliente()
          },
          error => {
            console.log(error);
          }
          
        );
      }
}
