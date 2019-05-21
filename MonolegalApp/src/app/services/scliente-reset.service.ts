
import { Injectable,Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class SClienteResetService {

  urlWS: string;
  constructor(private httpClient: HttpClient, @Inject('BASE_URL') baseUrl: string) { 
    this.urlWS = baseUrl;
  }

  getList(){
    return this.httpClient.get<boolean>(this.urlWS + '/Values');
  }
}