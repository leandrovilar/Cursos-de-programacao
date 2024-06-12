import { Component, signal } from '@angular/core';
import { Title } from '@angular/platform-browser';
//Interface
import { IProjects } from '../../interface/IProjects.interface';

@Component({
  selector: 'app-projects',
  standalone: true,
  imports: [],
  templateUrl: './projects.component.html',
  styleUrl: './projects.component.scss',
})
export class ProjectsComponent {
  public arrayProjects = signal<IProjects[]>([
    {
      src: 'assets/img/projects/vfull.png',
      alt: 'Projeto Vida FullStack',
      title: 'Vida FullStack',
      with: '100px',
      height: '51px',
      description: ' Explore o meu munde de programador',
      links: [
        {
          name: 'Conheça o Blog',
          href: 'https://vidafullstack.com.br',
        }
      ]
    },
  ]);
}
