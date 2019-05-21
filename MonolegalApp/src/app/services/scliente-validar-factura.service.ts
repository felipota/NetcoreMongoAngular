
import { Injectable,Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class SClienteValidarFacturaService {

  urlWS: string;
  constructor(private httpClient: HttpClient, @Inject('BASE_URL') baseUrl: string) { 
    this.urlWS = baseUrl;
  }

  validate(){
    return this.httpClient.post<void>(this.urlWS + '/Values',{});
  }
}