import { Component } from '@angular/core';
import * as $ from 'jquery';

import { Data } from '../Models/Data';
import { LeftComponentDTO } from './DTOs/left.componentDTO';


@Component({
    selector: 'left-part',
    templateUrl: './left.component.html',
    styleUrls: ['./left.component.css']
})
export class LeftComponent {
    articles: LeftComponentDTO[] = Data.books.map(b => new LeftComponentDTO(b));
    showImage = "Show image";
    hideImage = "Hide image";
    minDescriptionFontSize = 10;
    currentDescriptionFontSize = 14;
    msxDescriptionFontSize = 22;
    descriptionColor = '#000';
    descriptionBackgroundColor = '#e0ffff';

    showDescriptionPartially(index: number) {
        if (this.articles[index].isDescriptionShown) {
            this.articles[index].isDescriptionShown = false;
        } else {
            this.articles.map((a, i) => {
                a.isDescriptionShown = i == index
                a.isImageVisible = false;
            })
        }
    }

    showHideImage(currentArticle: LeftComponentDTO) {
        currentArticle.isImageVisible = !currentArticle.isImageVisible;
    }

    readMore(currentArticle: LeftComponentDTO) {
        if (currentArticle.isReadMoreAllowed) {
            currentArticle.readMore()
        }
    }

    descriptionFontSizeUp() {
        this.currentDescriptionFontSize = this.currentDescriptionFontSize < this.msxDescriptionFontSize 
            ? this.currentDescriptionFontSize + 1 
            : this.currentDescriptionFontSize
    }

    descriptionFontSizeDown() {
        this.currentDescriptionFontSize = this.currentDescriptionFontSize > this.minDescriptionFontSize 
            ? this.currentDescriptionFontSize - 1 
            : this.currentDescriptionFontSize
    }

    fontColorChanged(event) {
        this.descriptionColor = event.target.value
    }

    descriptionBackgroundColorChanged(event) {
        this.descriptionBackgroundColor = event.target.value
    }
}