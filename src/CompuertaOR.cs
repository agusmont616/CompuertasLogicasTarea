namespace CompuertasLogicasTarea;

public class CompuertaOR : ICompuerta
{
    public string Nombre { get; set; }
    public Dictionary<string, int> Entradas { get; set; }
    public int Salida { get; set; }

    public CompuertaOR(string nombre)
    {
        this.Nombre = nombre;
        this.Entradas = new Dictionary<string, int>();
    }

    public void AgregarEntrada(string nombre, int estado)
    {
        this.Entradas.Add(nombre, estado);
    }

    public void Calcular()
    {
        foreach (int valor in this.Entradas.Values)
        {
            if (valor == 1)
            {
                this.Salida = 1;
                break;
            }
            else
            {
                this.Salida = 0;
            }
        }
    }
}