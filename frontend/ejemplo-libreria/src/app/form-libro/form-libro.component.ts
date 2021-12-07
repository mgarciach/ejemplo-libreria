import { Component, OnInit } from '@angular/core';
import { MatDialogRef } from '@angular/material/dialog';
import { LibroService } from '../libro.service';

@Component({
  templateUrl: './form-libro.component.html',
  styleUrls: ['./form-libro.component.scss']
})
export class FormLibroComponent implements OnInit {

  loading: boolean = false;
  titulo: string = '';
  autor: string = '';
  genero: string = '';
  fechaPublicacion: string = '';
  dimension: string = '';
  precio: string = '';

  constructor(public dialogRef: MatDialogRef<FormLibroComponent>, private libroService: LibroService) { 

  }
  
  ngOnInit(): void {
  }
  Cancelar() {
    this.dialogRef.close('Pizza!');  
  }
  Guardar() {
    this.libroService.guardarLibro({
      titulo: this.titulo, 
      autor: this.autor,
      genero: this.genero,
      fechaPublicacion: this.fechaPublicacion,
      dimension: this.dimension,
      precio: parseFloat(this.precio)
    }).subscribe (function(){
      alert("Se guardó correctamente.");
    })

    console.log(this.titulo)
    console.log(this.autor)
    console.log(this.genero)
    console.log(this.fechaPublicacion)
    console.log(this.dimension)
    console.log(this.precio)
  };
  
}
