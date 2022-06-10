import { Ability } from "../game/ability";
import Card from "./card";

export default class Deck {
    public cards: Card[] = [];

    public constructor(cards: Card[]) {
        this.cards = cards;
    }

    public getCard(index: number): Card {
        return this.cards[index];
    }

    public shuffle(): void {
        let currentIndex = this.cards.length;
        let temporaryValue;
        let randomIndex;

        // While there remain elements to shuffle...
        while (0 !== currentIndex) {
            // Pick a remaining element...
            randomIndex = Math.floor(Math.random() * currentIndex);
            currentIndex -= 1;

            // And swap it with the current element.
            temporaryValue = this.cards[currentIndex];
            this.cards[currentIndex] = this.cards[randomIndex];
            this.cards[randomIndex] = temporaryValue;
        }
    }

    public createAbilityDeck(abilities: Ability[]): Deck {
        var cardList: Card[] = [];
        abilities.forEach(ability => {
            let card = new Card(ability);
            cardList.push(card);
        });
        let deck = new Deck(cardList);
        return deck;
    }
}