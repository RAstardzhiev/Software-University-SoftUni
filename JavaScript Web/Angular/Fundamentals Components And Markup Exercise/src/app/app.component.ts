import { Component } from '@angular/core';

import { Data } from './Models/Data';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'components-and-markup';
  articles = Data.books
}
