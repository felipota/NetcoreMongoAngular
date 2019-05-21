import { Injectable,Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import {ICliente} from '../interfaces/icliente'

@Injectable({
  providedIn: 'root'
})
export class SClienteService {

  urlWS: string;
  constructor(private httpClient: HttpClient, @Inject('BASE_URL') baseUrl: string) { 
    this.urlWS = baseUrl;
  }

  getList(){
    return this.httpClient.get<ICliente[]>(this.urlWS + '/Clientes');
  }
}
