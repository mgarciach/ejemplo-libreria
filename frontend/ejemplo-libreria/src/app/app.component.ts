import { Component, OnInit } from '@angular/core';
import { LibroService } from './libro.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit {

  title = 'ejemplo-libreria';

  libros: any[] = [];

  displayedColumns: string[] = ['idLibro', 'titulo', 'autor', 'genero', 'fechaPublicacion', 'dimension', 'precio'];


  loading: boolean = false;

  id: number = 0;

  precio: number = 0;

  constructor(private libroService: LibroService) {
  }

  ngOnInit(): void {


  }

  listarLibros() {
    if (this.loading) {
      return;
    }

    this.loading = true;
    this.libroService.listarLibros().subscribe((data) => {
      this.libros = data;
      this.loading = false;
    });
  }

  actualizarLibro() {
    this.libroService.actualizarPrecio(this.id, this.precio).subscribe((data) => {
      this.listarLibros();
    });
  }




}
