import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterLink, RouterLinkActive } from '@angular/router';

@Component({
  selector: 'app-sidebar',
  standalone: true,
  imports: [CommonModule, RouterLink, RouterLinkActive],
  template: `
    <aside class="sidebar">
      <div class="sidebar-header">
        <h1>Cobranza</h1>
      </div>
      <nav class="sidebar-nav">
        <a routerLink="/" 
           routerLinkActive="active" 
           [routerLinkActiveOptions]="{exact: true}" 
           class="nav-item">
          <span class="icon">📝</span>
          <span class="label">Registrar Intención</span>
        </a>
        <a routerLink="/historial" 
           routerLinkActive="active" 
           class="nav-item">
          <span class="icon">📊</span>
          <span class="label">Historial</span>
        </a>
      </nav>
      <div class="sidebar-footer">
        <p>v1.0.0</p>
      </div>
    </aside>
  `,
  styles: [`
    .sidebar {
      width: 240px;
      height: 100vh;
      background-color: #1e293b;
      color: #f8fafc;
      display: flex;
      flex-direction: column;
      position: fixed;
      left: 0;
      top: 0;
      box-shadow: 4px 0 10px rgba(0,0,0,0.1);
    }

    .sidebar-header {
      padding: 2rem 1.5rem;
      border-bottom: 1px solid #334155;
    }

    .sidebar-header h1 {
      margin: 0;
      font-size: 1.25rem;
      font-weight: 700;
      letter-spacing: 0.05em;
      color: #38bdf8;
    }

    .sidebar-nav {
      flex: 1;
      padding: 1.5rem 0.75rem;
      display: flex;
      flex-direction: column;
      gap: 0.5rem;
    }

    .nav-item {
      display: flex;
      align-items: center;
      gap: 0.75rem;
      padding: 0.75rem 1rem;
      color: #94a3b8;
      text-decoration: none;
      border-radius: 8px;
      font-weight: 500;
      transition: all 0.2s ease;
    }

    .nav-item:hover {
      background-color: #334155;
      color: #f8fafc;
    }

    .nav-item.active {
      background-color: #2563eb;
      color: #ffffff;
    }

    .icon {
      font-size: 1.1rem;
    }

    .sidebar-footer {
      padding: 1rem 1.5rem;
      border-top: 1px solid #334155;
      font-size: 0.75rem;
      color: #64748b;
    }
  `]
})
export class SidebarComponent { }
