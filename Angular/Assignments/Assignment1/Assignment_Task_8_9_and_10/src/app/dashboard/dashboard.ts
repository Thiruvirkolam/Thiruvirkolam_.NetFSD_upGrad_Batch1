import { Component } from '@angular/core';

@Component({
  selector: 'app-dashboard',
  imports: [],
  template: `
    <section class="active-section">
      <h2>Dashboard</h2>
      <p>This section uses inline template and styles.</p>
    </section>
  `,
  styles: [`
    .active-section {
      background-color: lightyellow;
      border: 2px solid orange;
      padding: 20px;
      margin: 20px;
    }

    h2 {
      color: darkorange;
    }
  `]
})
export class Dashboard {
}