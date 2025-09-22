namespace CompuertasLogicasTarea;

class Program
{
    static void Main(string[] args)
    {
        CompuertaAND and1 = new CompuertaAND("AND-1");
        
        and1.AgregarEntrada("Entrada-1", 1);
        and1.AgregarEntrada("Entrada-2", 1);
        
        and1.Calcular();
        Console.WriteLine(and1.Salida);
    }
}