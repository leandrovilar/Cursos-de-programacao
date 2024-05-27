import { Component, signal } from '@angular/core';

@Component({
  selector: 'app-knowledge',
  standalone: true,
  imports: [],
  templateUrl: './knowledge.component.html',
  styleUrl: './knowledge.component.scss'
})
export class KnowledgeComponent {
public arrayknowledge = signal([
  {
    src: 'assets/icon.knowledge/html5.svg',
    alt: 'Ícone de conhecimento de html5',
  },
  {
    src: 'assets/icon.knowledge/css3.svg',
    alt: 'Ícone de conhecimento de css3',
  }, 
  {
    src: 'assets/icon.knowledge/javascript.svg',
    alt: 'Ícone de conhecimento de javascript',
  },  
  {
    src: 'assets/icon.knowledge/angular.svg',
    alt: 'Ícone de conhecimento de Angular',
  }, 
   {
    src: 'assets/icon.knowledge/nodejs.svg',
    alt: 'Ícone de conhecimento de nodejs',
  },  
  {
    src: 'assets/icon.knowledge/html5.svg',
    alt: 'Ícone de conhecimento de html%',
  },
])
}
