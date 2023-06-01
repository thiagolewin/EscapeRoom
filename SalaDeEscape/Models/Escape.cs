static public class Escape {
    public static string[] incognitasSalas {get; private set;} = new string[5];
    public static int estadoJuego {get; private set;} = 1;

    private static void InicializarJuego() {
        incognitasSalas[0] = "Celda";
        incognitasSalas[1] = "Puente";
        incognitasSalas[2] = "Cadena";
        incognitasSalas[3] = "Llave";
        incognitasSalas[4] = "Muro";
    }
    public static int GetEstadoJuego() {
        return estadoJuego;
    }
    public static bool ResolverSala(int sala, string incognita) {
        int salaActual = GetEstadoJuego();
        if (sala> salaActual) {
            return false;
        } else {
            if (incognita.ToLower() == incognitasSalas[sala-1].ToLower()) {
                estadoJuego++;
                return true;
            } else {
                return false;
            }
        }
    }
}