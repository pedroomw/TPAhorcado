namespace TPAhorcado;

public static class Partido
{
    public Palabra palabra {get; private set;}
    public int intentos {get; private set;}
    public bool resultado {get; private set;}

    public InicializarPartido( Palabra palabra, List <char> letras)
    {
        List<char> letras = new List<char>();
        letras.Add(new char("P"));
        letras.Add(new char("R"));
        letras.Add(new char("O"));
        letras.Add(new char("C"));
        letras.Add(new char("E"));
        letras.Add(new char("S"));
        letras.Add(new char("A"));
        letras.Add(new char("D"));
    


        palabra = new Palabra ("Procesador", letras);
        this.intentos = 0;
        this.resultado = false;
    }
}