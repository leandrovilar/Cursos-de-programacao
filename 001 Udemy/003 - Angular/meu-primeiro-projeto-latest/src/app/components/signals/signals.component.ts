import { CommonModule } from '@angular/common';
import { Component, computed, effect, signal } from '@angular/core';


@Component({
  selector: 'app-signals',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './signals.component.html',
  styleUrl: './signals.component.scss'
})
export class SignalsComponent {

  public firstName = signal('Leandro ');
  public lastName = signal ('Braga');

  // public fullName = this.firstName() + this.lastName()
  public fullName = computed(() => {
    return this.firstName() + this.lastName()
  })
//Array
  public array = signal([1]);

  constructor() {
    effect(() => {
console.log(this.fullName())
    })
  }
  //Update name
  public updateName() {
    return this.firstName.set("Lindao ")
  }
  
  //Update Array
  public updateArray() {
    this.array.update((oldvalue:Array<number>) => {
      return [...oldvalue, oldvalue.length + 1]
    })
  }
}
