# Piramide
Bisogna scrivere un programma che calcoli l'altezza massima di una piramide (in piani) dato un certo numero di cubi di pietra.

Ipotizzando che:

- i piani della piramide siano quadrati
- la piramide da costruire sia compatta, cioè non ci siano cavità al suo interno. 
- ogni piano è quadrato, con una lunghezza laterale inferiore di due rispetto a quella sottostante.
- il primo piano è sempre di un mattone

```c#
using System;

namespace Piramide{
public class Piramide{
    public static int Piani(int mattoni) {
        int piani = 0;
        while (mattoni >= (2 * piani + 1) * (2 * piani + 1)) {
            piani++;
            mattoni -= (2 * piani - 1) * (2 * piani - 1);
        }
        return piani;
    }

    public static int Rimanenti(int mattoni) {
        int piani = Piani(mattoni);
        int mattoniUsati = 0;
        for (int i = 1; i <= piani; i++) {
            mattoniUsati += (2 * i - 1) * (2 * i - 1);
        }
        return mattoni - mattoniUsati;
    }
    }
}
