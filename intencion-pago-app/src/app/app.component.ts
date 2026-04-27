import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { SidebarComponent } from './shared/components/sidebar/sidebar.component';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, SidebarComponent],
  template: `
    <div class="layout">
      <app-sidebar></app-sidebar>
      <main class="content">
        <router-outlet></router-outlet>
      </main>
    </div>
  `,
  styles: [`
    .layout {
      display: flex;
      min-height: 100vh;
      background-color: #f1f5f9;
    }

    .content {
      flex: 1;
      margin-left: 240px; /* Igual al ancho del sidebar */
      padding: 1rem;
      min-height: 100vh;
      box-sizing: border-box;
    }

    @media (max-width: 768px) {
      .content {
        margin-left: 0;
        padding: 1rem 0.5rem;
      }
    }
  `]
})
export class AppComponent { }