import { Ability } from "../game/ability";

export default class Card {
    public name: string = "";
    public description: string = "";
    public frontImageUrl: string = "";
    public backImageUrl: string = "";
    public faceUp: boolean = false;
    public copies: number = 1;

    public constructor(name: string, description: string, frontImageUrl: string, backImageUrl: string) {
        this.name = name;
        this.description = description;
        this.frontImageUrl = frontImageUrl;
        this.backImageUrl = backImageUrl;
    }

    public flip(): void {
        this.faceUp = !this.faceUp;
        console.log("Flipping card");
    }
}