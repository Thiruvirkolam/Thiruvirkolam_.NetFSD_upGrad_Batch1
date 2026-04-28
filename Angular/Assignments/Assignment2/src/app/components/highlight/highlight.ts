import { Directive, HostBinding, HostListener } from '@angular/core';

@Directive({
  selector: '[appHighlight]',
  standalone: true
})
export class Highlight {
  @HostBinding('style.backgroundColor') backgroundColor: string = '';

  @HostListener('mouseenter')
  onMouseEnter() {
    this.backgroundColor = 'yellow';
  }

  @HostListener('mouseleave')
  onMouseLeave() {
    this.backgroundColor = '';
  }
}