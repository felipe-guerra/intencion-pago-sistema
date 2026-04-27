import { Routes } from '@angular/router';

export const routes: Routes = [
    {
        path: '',
        loadComponent: () =>
            import('./features/intencion-pago/pages/intencion-pago/intencion-pago.component')
                .then(m => m.IntencionPagoComponent)
    },
    {
        path: 'historial',
        loadComponent: () =>
            import('./features/intencion-pago/components/intenciones-list/intenciones-list.component')
                .then(m => m.IntencionesListComponent)
    }
];