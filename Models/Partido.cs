namespace TPAhorcado;

public static class Partido
{
 
        public static string palabra { get; private set; }
        public static List<char> letrasAdivinadas { get; private set; }
        public static List<char> intentosLetra { get; private set; }
        public static string palabraActual { get; private set; }
        public static char[] palabraActualVector { get; set; }
        public static int intentos { get; set; }


    public static void InicializarPartido()
    {
         palabra = "Procesador"; // Palabra a adivinar
            intentos = 0;
            letrasAdivinadas = new List<char>();
            intentosLetra = new List<char>();
            palabraActualVector = new char[palabra.Length];
            palabraActual = "";
            inicializarPalabraActual();
    }
    public static void inicializarPalabraActual()
    {
        letrasAdivinadas = new List<char>();
        for(int i = 0; i < palabra.Length; i++){
            palabraActualVector[i] =  '_';
            palabraActual += palabraActualVector[i];
        }
    }

    public static void ActualizarIntento(char letraIngresada)
    {
        intentosLetra.Add(letraIngresada);

        if (palabra.Contains(letraIngresada))
        {
            letrasAdivinadas.Add(letraIngresada);
            actualizarPalabra(letraIngresada);
        }
    }


    private static void actualizarPalabra(char letraIngresada)
    {
        palabraActual = "";
        for (int i = 0; i < palabra.Length; i++)
        {
            if (palabra[i] == letraIngresada)
            {
                palabraActualVector[i] = letraIngresada; // Reemplazar guión bajo con la letra acertada
               
            }
            palabraActual += palabraActualVector[i];
        }
    }

   
         public static bool ArriesgarPalabra(string palabraIngresada)
        {
            if (palabraIngresada == palabra)
            {
                palabraActual = palabra;
                return true;
            }
            else
            {
              
                return false;
            }
        }
    
}