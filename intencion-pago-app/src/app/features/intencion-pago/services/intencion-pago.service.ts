import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { IntencionPagoRequest } from '../models/intencion-pago-request';
import { ApiResponse } from '../models/api-response';
import { IntencionPagoData } from '../models/intencion-pago-response';
import { IntencionPago } from '../models/intencion-pago';

@Injectable({
  providedIn: 'root'
})
export class IntencionPagoService {

  private apiUrl = 'http://localhost:5151/api/IntencionPago';

  constructor(private http: HttpClient) { }

  registrarIntencion(request: IntencionPagoRequest): Observable<ApiResponse<IntencionPagoData>> {
    return this.http.post<ApiResponse<IntencionPagoData>>(this.apiUrl, request);
  }

  obtenerIntenciones(): Observable<ApiResponse<IntencionPago[]>> {
    return this.http.get<ApiResponse<IntencionPago[]>>(this.apiUrl);
  }
}