import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators, ReactiveFormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';
import { RouterLink } from '@angular/router';
import { IntencionPagoService } from '../../services/intencion-pago.service';
import { finalize } from 'rxjs/operators';

@Component({
  selector: 'app-intencion-pago',
  standalone: true,
  imports: [CommonModule, ReactiveFormsModule, RouterLink],
  templateUrl: './intencion-pago.component.html',
  styleUrl: './intencion-pago.component.css'
})
export class IntencionPagoComponent {

  form: FormGroup;
  loading = false;
  response: any = null;
  error: string | null = null;

  constructor(
    private fb: FormBuilder,
    private service: IntencionPagoService
  ) {
    this.form = this.fb.group({
      codigoCliente: ['', Validators.required],
      montoPropuesto: ['', [Validators.required, Validators.min(1)]],
      comentario: ['', Validators.required]
    });
  }

  enviar() {
    if (this.form.invalid) {
      this.form.markAllAsTouched();
      return;
    }

    this.loading = true;
    this.response = null;
    this.error = null;

    this.service.registrarIntencion(this.form.value)
      .pipe(finalize(() => this.loading = false))
      .subscribe({
        next: (res) => {
          if (res.exito) {
            this.response = res.data;
            this.form.reset();
          } else {
            this.error = res.mensaje;
          }
        },
        error: (err) => {
          this.loading = false;

          // Si el backend respondió con mensaje (error de negocio)
          if (err?.error?.mensaje) {
            this.error = err.error.mensaje;
          }
          // Si no hay respuesta (backend caído, CORS, red)
          else {
            this.error = 'Error al conectar con el servicio';
          }
        }
      });
  }
}