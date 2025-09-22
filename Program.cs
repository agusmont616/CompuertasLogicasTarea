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
        
        CompuertaOR or1 = new CompuertaOR("OR-1");
        
        or1.AgregarEntrada("Entrada-1", 0);
        or1.AgregarEntrada("Entrada-2", 0);
        
        or1.Calcular();
        Console.WriteLine(or1.Salida);
    }
}