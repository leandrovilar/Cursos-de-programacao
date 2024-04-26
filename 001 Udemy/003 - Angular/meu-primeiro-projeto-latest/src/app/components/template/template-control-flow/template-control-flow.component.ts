import { AsyncPipe, CommonModule, NgFor, NgIf } from '@angular/common';
import { Component } from '@angular/core';
import { Observable, delay, of } from 'rxjs';

@Component({
  selector: 'app-template-control-flow',
  standalone: true,
  imports: [AsyncPipe, NgIf, NgFor, CommonModule],
  templateUrl: './template-control-flow.component.html',
  styleUrl: './template-control-flow.component.scss',
})
export class TemplateControlFlowComponent {
  public isTrue = true;

  // public itens = [{ name: 'Leandro Braga' }];
  public itens: Array<{name: string}> = [{ name: 'Leandro Braga' }]
  public loadingData$: Observable<string[]> = of([
    'item 1',
    'item 2',
    'item 3',
  ]).pipe(delay(3000));

//  @For e seus valores
  public trackByFn(index: number) {
    return index;
  }
public addNewName(value: string){
  return this.itens.push({name: value});
}
}

