export interface IFactura {
	
        codigoFactura : string;

		fechaCreacion : string;

        fechaPago : string;

        pagada : boolean;

        estado : string;

        subTotal : number;

        iva : number;

        retencion : number;

        total : number;
}
