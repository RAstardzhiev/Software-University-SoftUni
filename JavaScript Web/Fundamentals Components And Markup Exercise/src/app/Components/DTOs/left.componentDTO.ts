import { Article } from "src/app/Models/Article";

export class LeftComponentDTO extends Article {
    private readonly descriptionSize: number = 50;
    private readonly initialdescriptionSizeMultiplyer = 1;

    private descriptionSizeMultiplyer: number = 1;
    private _isDescriptionShown: boolean = false;
    private _isReadMoreAllowed: boolean = this.description.length > this.descriptionSize;

    shortDescription: string = this.getDescription();
    isImageVisible: boolean = false;

    constructor(article: Article) {
        super(article.title, article.description, article.author, article.imageURL);
    }

    // Properties
    public get isDescriptionShown(): boolean {
        return this._isDescriptionShown;
    }
    public set isDescriptionShown(v: boolean) {
        if (!v) {
            this.reInitDescriptionSize();
        }

        this._isDescriptionShown = v;
    }

    public get isReadMoreAllowed(): boolean {
        return this._isReadMoreAllowed;
    }
    public set isReadMoreAllowed(v: boolean) {
        if (!v) {
            console.log("isReadMoreAllowed = " + v)
            this.reInitDescriptionSize();
        }

        this._isReadMoreAllowed = v;
    }

    // Functions
    readMore() {
        this.descriptionSizeMultiplyer++;
        this.shortDescription = this.getDescription();
    }

    private getDescription(): string {
        var currentDescriptionSymbolsCount = this.descriptionSize * this.descriptionSizeMultiplyer;
        if (currentDescriptionSymbolsCount > this.description.length) {
            this.isReadMoreAllowed = false;
            return this.description
        }

        return this.description.substring(0, currentDescriptionSymbolsCount) + '...';
    }

    private reInitDescriptionSize() {
        this.descriptionSizeMultiplyer = this.initialdescriptionSizeMultiplyer;
        this.shortDescription = this.getDescription();
        this._isReadMoreAllowed = this.description.length > this.descriptionSize;
    }
}