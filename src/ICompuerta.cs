namespace CompuertasLogicasTarea;

public interface ICompuerta
{
    public string Nombre { get; set; }
    
    public int Salida { get; set; }

    public void AgregarEntrada(string nombre, int estado);
    public void Calcular();
}