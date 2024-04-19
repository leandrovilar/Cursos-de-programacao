import { CommonModule, NgClass, NgStyle } from '@angular/common';
import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-template-binding',
  standalone: true,
  imports: [CommonModule, FormsModule, NgClass, NgStyle],
  templateUrl: './template-binding.component.html',
  styleUrl: './template-binding.component.scss'
})
export class TemplateBindingComponent {
public name = 'Leandro Vilar';
public age = 42;
public condition = this.age > 1 ? 'Teste' : 'Teste2';

public isDisabled = true;
public srcValue = 'https://blog.logrocket.com/wp-content/uploads/2021/04/Angular-in-memory-web-api-tutorial.jpg'

//codificacao so para teste
// public sum(val1: number, val2: number){
//   return val1 + val2;
// }
public isTextDecoration = this.age >= 44 ? 'underline' : 'none';

public sum(){
  return this.age++;
}

public sub(){
  return this.age--;
}

public onkeyDown(event: Event){
  return console.log(event);
}
public onMouseMove(event:MouseEvent){
  return console.log({
    clietX: event.clientX,
    clietY: event.clientY,
  });
}


}
