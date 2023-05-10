# Piramide
Bisogna scrivere un programma che calcoli l'altezza massima di una piramide (in piani) dato un certo numero di cubi di pietra.

Ipotizzando che:

- i piani della piramide siano quadrati
- la piramide da costruire sia compatta, cioè non ci siano cavità al suo interno. 
- ogni piano è quadrato, con una lunghezza laterale inferiore di due rispetto a quella sottostante.
- il primo piano è sempre di un mattone

### Il programma si divide in due parti:
<details>
<summary>Piani</summary>

```c#
public static int Piani(int mattoni) {
        int piani = 0;
        while (mattoni >= (2 * piani + 1) * (2 * piani + 1)) {
            piani++;
            mattoni -= (2 * piani - 1) * (2 * piani - 1);
        }
        return piani;
    }   
```

La prima parte, chiamata "Piani", prende in input un intero "mattoni" che rappresenta il numero totale di mattoni disponibili. Questa parte utilizza un ciclo while per incrementare il numero di piani finché ci sono abbastanza mattoni per costruire il prossimo livello di piani. Il numero di mattoni necessari per costruire un livello di piani è calcolato con la formula (2 * piani + 1) * (2 * piani + 1), dove "piani" rappresenta il numero di piani già costruiti. Quando non ci sono abbastanza mattoni per costruire il prossimo livello di piani, il metodo restituisce il numero di piani costruiti finora.
</details>

<details>
<summary>Rimanenti</summary>


```c#
public static int Rimanenti(int mattoni) {
        int piani = Piani(mattoni);
        int mattoniUsati = 0;
        for (int i = 1; i <= piani; i++) {
            mattoniUsati += (2 * i - 1) * (2 * i - 1);
        }
        return mattoni - mattoniUsati;
    }
```

La seconda parte, chiamata "Rimanenti", prende in input lo stesso intero "mattoni" del metodo precedente e utilizza il metodo "Piani" per calcolare il numero di piani costruiti. Successivamente, viene calcolato il numero di mattoni usati per costruire la piramide, sommando il numero di mattoni necessari per costruire ogni livello di piani fino al numero di piani calcolato. Il metodo restituisce la differenza tra il numero totale di mattoni e il numero di mattoni utilizzati per costruire la piramide.
</details>
