namespace CompuertasLogicasTarea;

public class CompuertaNOT : ICompuerta
{
    public string Nombre { get; set; }
    public int Entrada {get; set;}
    public int Salida { get; set; }

    public CompuertaNOT(string nombre)
    {
        Nombre = nombre;
    }
    public void AgregarEntrada(string nombre, int estado)
    {
        this.Entrada = estado;
    }

    public void Calcular()
    {
        if (this.Entrada == 1)
        {
            this.Salida = 0;
        }
        else
        {
            this.Salida = 1;
        }
    }
}