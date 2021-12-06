import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { delay } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class LibroService {

  constructor(private http: HttpClient) { }

  public listarLibros() {
    return this.http.get<any[]>('https://localhost:44337/Api/libro/mostrar').pipe(delay(500));
  }


  public actualizarPrecio(id: number, precio: number) {
    return this.http.post<any>('https://localhost:44337/Api/libro/actualizar-precio', null, { params: { id: id, precio: precio } }).pipe(delay(500));
  }

}
