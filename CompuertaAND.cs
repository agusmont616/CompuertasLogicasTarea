namespace CompuertasLogicasTarea;

public class CompuertaAND : ICompuerta
{
    public string Nombre { get; set; }
    public Dictionary<string, int> Entradas {get; set;}
    public int Salida { get; set; }

    public CompuertaAND(string nombre)
            {
                this.Nombre = nombre;
                Entradas = new Dictionary<string, int>();
            }

    public void AgregarEntrada(string nombre, int estado)
    {
        
        this.Entradas.Add(nombre, estado);
    }

    public void Calcular()
    {
        int prod = 1;
        foreach (var entrada in this.Entradas)
        {
            prod *= entrada.Value;
        }
        this.Salida = prod;
    }
}