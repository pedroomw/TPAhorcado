namespace TPAhorcado;

public static class Palabra
{
    public string palabra {get; private set;}
    public List <char> letras {get; private set;}

    public Palabra(string palabra, List <char> letras)
    {
        this.palabra = "Procesador";
        this.letras = letras;
    }
}