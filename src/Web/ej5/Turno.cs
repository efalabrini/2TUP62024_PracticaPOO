
using Web.ej5;

public static class Turno{
    public static void Atacarse(List<Personaje> personajes, List<Enemigo> enemigos){

        double danioTotal = 0;
        foreach (var enemigo in enemigos)
        {
        foreach (var jugador in personajes)
        {
            double danio = jugador.CalcularDanio();
            danioTotal += danio;
            Console.WriteLine(jugador.Atacar());
        }
        
        enemigo.vida -= (int)danioTotal;
        if(enemigo.vida <= 0){
            Console.WriteLine("El enemigo ha sido derrotado");
        }else{
            Console.WriteLine($"Vida restante del enemigo: {enemigo.vida}");
        }
        

        }
    }
    public static void MoverFichas(IMoverse ficha, int ejeX, int ejeY){
        Console.WriteLine(ficha.MoverseEjeX(ejeX));
        Console.WriteLine(ficha.MoverseEjeY(ejeY));
    }
}