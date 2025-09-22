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

        /*CompuertaAND and1 = new CompuertaAND("AND-1");
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
            
        Console.WriteLine(not3.Salida);*/

        GarageGate garage0 = new GarageGate(0, 0, 0);
        garage0.AbrirGarage();
        Console.WriteLine(garage0.GarageAbierto);
        
        GarageGate garage1 = new GarageGate(0, 0, 1);
        garage1.AbrirGarage();
        Console.WriteLine(garage1.GarageAbierto);
        
        GarageGate garage2 = new GarageGate(0, 1, 0);
        garage2.AbrirGarage();
        Console.WriteLine(garage2.GarageAbierto);

        GarageGate garage3 = new GarageGate(0, 1, 1);
        garage3.AbrirGarage();
        Console.WriteLine(garage3.GarageAbierto);

        GarageGate garage4 = new GarageGate(1, 0, 0);
        garage4.AbrirGarage();
        Console.WriteLine(garage4.GarageAbierto);

        GarageGate garage5 = new GarageGate(1, 0, 1);
        garage5.AbrirGarage();
        Console.WriteLine(garage5.GarageAbierto);

        GarageGate garage6 = new GarageGate(1, 1, 0);
        garage6.AbrirGarage();
        Console.WriteLine(garage6.GarageAbierto);

        GarageGate garage7 = new GarageGate(1, 1, 1);
        garage7.AbrirGarage();
        Console.WriteLine(garage7.GarageAbierto);



    }
}