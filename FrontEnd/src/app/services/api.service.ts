import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ApiService {
  private baseUrl = 'http://localhost:7071/api';

  constructor(private http: HttpClient) {}

  cadastrar(dados: { parcelas: number; valorParcela: number }): Observable<any> {
    return this.http.post(`${this.baseUrl}/CalculationFunction`, dados);
  }

  consultar(numero: number): Observable<any> {
    return this.http.get(`${this.baseUrl}/query/${numero}`);
  }
}
