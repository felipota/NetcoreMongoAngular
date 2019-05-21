import { IFactura } from "./ifactura";

export interface ICliente {
	
	id : string;
	nombre : string;
	
	ciudad: string;
	
	correo: string;
	
	nit : string;
	
	facturas : IFactura[];
}
