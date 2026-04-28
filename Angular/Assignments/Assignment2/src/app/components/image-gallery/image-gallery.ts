import { Component } from '@angular/core';

@Component({
  selector: 'app-image-gallery',
  imports: [],
  standalone: true,
  templateUrl: './image-gallery.html',
  styleUrl: './image-gallery.css',
})
export class ImageGallery {
  image : string = "https://fujiframe.com/assets/images/_3000x2000_fit_center-center_85_none/10085/xhs2-fuji-70-300-Amazilia-Hummingbird.webp";
  width : number = 300;
  height : number = 200;
}
