namespace CompuertasLogicasTarea;

class Program
{
    static void Main(string[] args)
    {
        /*CompuertaAND and1 = new CompuertaAND("AND-1");
        
        and1.AgregarEntrada("Entrada-1", 1);
        and1.AgregarEntrada("Entrada-2", 1);
        
        and1.Calcular();
        Console.WriteLine(and1.Salida);
        
        CompuertaOR or1 = new CompuertaOR("OR-1");
        
        or1.AgregarEntrada("Entrada-1", 0);
        or1.AgregarEntrada("Entrada-2", 0);
        
        or1.Calcular();
        Console.WriteLine(or1.Salida);
        
        CompuertaNOT not1 = new CompuertaNOT("NOT-1");
        
        not1.AgregarEntrada("Entrada-1", 0);
        not1.Calcular();
        
        Console.WriteLine(not1.Salida);*/

        CompuertaAND and1 = new CompuertaAND("AND-1");
        CompuertaOR or2 = new CompuertaOR("OR-2");
        CompuertaNOT not3 = new CompuertaNOT("NOT-3");
        
        and1.AgregarEntrada("A", 1);
        and1.AgregarEntrada("B", 1);
        and1.Calcular();
        
        Console.WriteLine(and1.Salida);
        
        or2.AgregarEntrada("C", 1);
        or2.AgregarEntrada("ResultAND-1", and1.Salida);
        or2.Calcular();
        
        Console.WriteLine(or2.Salida);
        
        not3.AgregarEntrada("ResultFinal", or2.Salida);
        not3.Calcular();
            
        Console.WriteLine(not3.Salida);
        
    }
}