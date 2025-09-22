namespace CompuertasLogicasTarea;

public class GarageGate
{
    public int EntradaA {get;set;}
    public int EntradaB {get;set;}
    public int EntradaC {get;set;}
    
    public CompuertaAND and1AB {get;set;}
    public CompuertaNOT notA {get;set;}
    public CompuertaNOT notB {get;set;}
    public CompuertaAND and2notAB {get;set;}
    public CompuertaOR or3 {get;set;}
    public CompuertaAND and4result {get;set;}
    
    public bool GarageAbierto {get;set;}

    public GarageGate(int entradaC, int entradaB, int entradaA)
    {
        EntradaA = entradaA;
        EntradaB = entradaB;
        EntradaC = entradaC;
        
        and1AB = new CompuertaAND("AND1-AB");
        notA = new CompuertaNOT("NOT-A");
        notB = new CompuertaNOT("NOT-B");
        and2notAB = new CompuertaAND("AND2-!AB");
        or3 = new CompuertaOR("OR3");
        and4result = new CompuertaAND("AND4-Result");
    }

    public void AbrirGarage()
    {
        // Calcular el primer AND (A*B)
        and1AB.AgregarEntrada("In-A",EntradaA);
        and1AB.AgregarEntrada("In-B",EntradaB);
        and1AB.Calcular();
        
        // Calcular valores negados (/A y /B)
        notA.AgregarEntrada("Not-A", EntradaA);
        notA.Calcular();
        notB.AgregarEntrada("Not-B", EntradaB);
        notB.Calcular();
        
        // Calcular el segundo AND (/A*/B)
        and2notAB.AgregarEntrada("Not-A", notA.Salida);
        and2notAB.AgregarEntrada("Not-B", notB.Salida);
        and2notAB.Calcular();
        
        // Calcular el OR (A*B + /A*/B)
        or3.AgregarEntrada("A*B", and1AB.Salida);
        or3.AgregarEntrada("/A*/B", and2notAB.Salida);
        or3.Calcular();
        
        // Calcular último and [(A*B + /A*/B) * C)]
        and4result.AgregarEntrada("A*B + /A*/B", or3.Salida);
        and4result.AgregarEntrada("C", EntradaC);
        and4result.Calcular();
        
        if (and4result.Salida == 1)
        {
            GarageAbierto = true;
        }
        else if (and4result.Salida == 0)
        {
            GarageAbierto = false;
        }
    }
}