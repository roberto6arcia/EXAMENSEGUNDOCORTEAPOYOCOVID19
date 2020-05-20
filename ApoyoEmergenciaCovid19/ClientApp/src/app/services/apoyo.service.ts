import { Injectable, Inject } from '@angular/core';
import { Apoyo } from '../ApoyoPersona/models/apoyo';
import { Observable } from 'rxjs';
import { tap, catchError } from 'rxjs/operators';
import { HttpClient } from '@angular/common/http';
import { HandleHttpErrorService } from '../@base/handle-http-error.service';

@Injectable({
  providedIn: 'root'
})
export class ApoyoService {

  baseUrl: string;
  constructor(private http: HttpClient,
    @Inject('BASE_URL') baseUrl: string,
    private handleErrorService: HandleHttpErrorService) {this.baseUrl = baseUrl;}

    post(apoyo: Apoyo): Observable<Apoyo> {
      return this.http.post<Apoyo>(this.baseUrl + 'api/Apoyo', apoyo)
        .pipe(
            tap(_ => this.handleErrorService.log('datos enviados')),
            catchError(this.handleErrorService.handleError<Apoyo>('Registrar apoyo', null))
        );
    }
}

