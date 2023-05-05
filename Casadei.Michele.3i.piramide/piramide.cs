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