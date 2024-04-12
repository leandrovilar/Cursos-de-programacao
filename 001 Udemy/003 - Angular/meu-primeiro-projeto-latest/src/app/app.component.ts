import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterOutlet } from '@angular/router';
//components
import { NewComponent } from './components/new-component/new-component.component';
import { TemplateBindingComponent } from './components/template/template-binding/template-binding.component';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [CommonModule, RouterOutlet, NewComponent, TemplateBindingComponent],
  template: `
  // <router-outlet></router-outlet>
  // <app-new-component />
  <h1>Curso de Angular</h1>
  <app-template-binding />
  `,
})
export class AppComponent {
  title = 'meu-primeiro-projeto-latest';
}
