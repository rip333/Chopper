import Card from "../card/card";
import Deck from "../card/deck";

export class Hero {
    public name: string = "";
    public description: string = "";
    public imageUrl: string = "";
    public health: number = 0;
    public move: string = "1";
    public attack: string = "1";
    public defense: string = "1";
    public backImageUrl: string = "";
    public deck: Card[];

    public constructor(json: string) { 
        let hero = JSON.parse(json);
        this.name = hero.name;
        this.description = hero.description;
        this.imageUrl = hero.imageUrl;
        this.health = hero.health;
        this.move = hero.move;
        this.attack = hero.attack;
        this.defense = hero.defense;
        this.backImageUrl = hero.backImageUrl;
        this.deck = hero.deck;
        this.handleCopies();
    }

    public handleCopies(): void {
        this.deck.forEach(card => {
            if(card.copies > 1) {
                for(let i = 1; i < card.copies; i++) {
                    let copy = new Card(card.name, card.description, card.frontImageUrl, this.backImageUrl);
                    this.deck.push(copy);
                }
                card.copies = 1;
            }
        });
    }
}