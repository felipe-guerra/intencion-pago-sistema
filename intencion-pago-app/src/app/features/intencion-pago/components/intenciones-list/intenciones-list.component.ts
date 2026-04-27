import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterLink } from '@angular/router';
import { IntencionPagoService } from '../../services/intencion-pago.service';
import { IntencionPago } from '../../models/intencion-pago';
import { finalize } from 'rxjs/operators';

@Component({
  selector: 'app-intenciones-list',
  standalone: true,
  imports: [CommonModule, RouterLink],
  templateUrl: './intenciones-list.component.html',
  styleUrl: './intenciones-list.component.css'
})
export class IntencionesListComponent implements OnInit {

  intenciones: IntencionPago[] = [];
  loading = false;
  error: string | null = null;

  constructor(private service: IntencionPagoService) { }

  ngOnInit(): void {
    this.cargarIntenciones();
  }

  cargarIntenciones(): void {
    this.loading = true;
    this.error = null;

    this.service.obtenerIntenciones()
      .pipe(finalize(() => this.loading = false))
      .subscribe({
        next: (res) => {
          if (res.exito) {
            this.intenciones = res.data ?? [];
          } else {
            this.error = res.mensaje;
          }
        },
        error: () => {
          this.error = 'No se pudo conectar con el servidor.';
        }
      });
  }
}
