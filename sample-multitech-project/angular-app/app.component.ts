import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html'
})
export class AppComponent {
  add(a: number, b: number): number {
    return a + b;
  }
}
