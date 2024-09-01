using System;

namespace Web.Ej4;

public class Coche : IVehiculo
{
    private int CantidadCombustible {get;set;}
    public Coche(int _CantidadCombustible){
        CantidadCombustible=_CantidadCombustible;
    }

    public string Conducir(){
        return CantidadCombustible>0 ? "El coche está siendo manejado": "El coche no tiene combustible";
    }
    public bool CargarCombustible(int cantCombustible){
        CantidadCombustible+=cantCombustible;
        return true;
    }
}
