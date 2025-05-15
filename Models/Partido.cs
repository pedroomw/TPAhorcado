namespace TPAhorcado;

public class Partido
{
    public string palabra { get; private set; }
    public bool resultado { get; private set; }
    public List<char> letrasAdivinadas { get; private set; }
    public string palabraActual { get; private set; }
    public char[] palabraActualVector { get; set; }
    public int intentos{get; set;}


    public void InicializarPartido()
    {
        palabra = "Procesador"; // Palabra a adivinar
        this.intentos = 0;
        this.resultado = false;
        inializarPalabraActual();

    }
    public void inializarPalabraActual()
    {
        letrasAdivinadas = new List<char>();
        for(int i = 0; i < palabra.Length; i++){
            palabraActualVector[i] =  '_';
            palabraActual += palabraActualVector[i];
        }
    }

    public void ActualizarIntento(char letraIngresada)
    {
        intentosLetra.Add(letraIngresada);

        if (palabra.Contains(letraIngresada))
        {
            letrasAdivinadas.Add(letraIngresada);
            actualizarPalabra(letraIngresada);
        }
    }


    private void actualizarPalabra(char letraIngresada)
    {
        palabraActual = "";
        for (int i = 0; i < palabra.Length; i++)
        {
            if (palabra[i] == letraIngresada)
            {
                palabraActualVector[i] = letraIngresada; // Reemplazar guión bajo con la letra acertada
                letrasAdivinadas.Add(letraIngresada);
            }
            palabraActual += palabraActualVector[i];
        }
    }