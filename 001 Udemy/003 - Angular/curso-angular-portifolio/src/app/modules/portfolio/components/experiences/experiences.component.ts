import { Component, signal } from '@angular/core';
import { IExperiences } from '../../interface/IExperiences.interface';

@Component({
  selector: 'app-experiences',
  standalone: true,
  imports: [],
  templateUrl: './experiences.component.html',
  styleUrl: './experiences.component.scss'
})
export class ExperiencesComponent {
public arrayExperiences = signal <IExperiences[]>([
  {
    summary: {
      strong: 'Front-end junior',
      p: 'Freelancer',
      },
      text: "Desde janeiro estou focado",
  }
])
}
