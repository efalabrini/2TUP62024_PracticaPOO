using System;
using Microsoft.AspNetCore.Mvc;
using Web.Ej5;

namespace Web.Controllers;

[ApiController]
[Route("api/[controller]")]
public class Ej5Controlador : ControllerBase
{
    static List<Personaje> listaPersonajes = new List<Personaje>();
    static List<Enemigo> listaEnemigos = new List<Enemigo>();

    [HttpPost("crear-personaje-fuerza")]
    public IActionResult CrearPersonajeFuerza([FromBody] CrearPersonajeDeFuerzaRequest individuo)
    {
        var personaje =  new PersonajeDeFuerza(individuo.Nombre, individuo.Magia,individuo.Agilidad);

        listaPersonajes.Add(personaje);

        var response = new PersonajeDeFuerzaResponse
            {
                Nombre = personaje.Nombre,
                Agilidad = personaje.Agilidad,
                Magia = personaje.Magia,
                Fuerza = personaje.Fuerza
            };

        return Ok($"El personaje de fuerza se ha creado correctamente.Sus estadisticas son Agilidad:{personaje.Agilidad}, Magia: {personaje.Magia}, Fuerza: {personaje.Fuerza}");

    }

    

    [HttpPost("crear-Personaje-Agilidad")]

    public IActionResult CrearPersonajeAgilidad([FromBody] CrearPersonajeDeAgilidadRequest individuo)
    {
        var personaje =  new PersonajeDeAgilidad(individuo.Nombre, individuo.Magia, individuo.Agilidad, individuo.Fuerza);

        listaPersonajes.Add(personaje);

        var response = new PersonajeDeAgilidadResponse
            {
                Nombre = personaje.Nombre,
                Agilidad = personaje.Agilidad,
                Magia = personaje.Magia,
                Fuerza = personaje.Fuerza
            };


        return Ok($"El personaje de agilidad ha sido creado correctamente.Sus estadisticas son Agilidad:{personaje.Agilidad}, Magia: {personaje.Magia}, Fuerza: {personaje.Fuerza}");
    }

     

    [HttpPost("crear-Personaje-Magia")]

    public IActionResult CrearPersonajeMagia([FromBody] CrearPersonajeDeMagiaRequest individuo)
    {
        var personaje =  new PersonajeDeMagia(individuo.Nombre,individuo.Agilidad,  individuo.Fuerza); 

        listaPersonajes.Add(personaje);

         var response = new PersonajeDeMagiaResponse
            {
                Nombre = personaje.Nombre,
                Agilidad = personaje.Agilidad,
                Magia = personaje.Magia,
                Fuerza = personaje.Fuerza
            };

        return Ok($"El personaje de magia ha sido creado correctamente.Sus estadisticas son Agilidad:{personaje.Agilidad}, Magia: {personaje.Magia}, Fuerza: {personaje.Fuerza}");
    }

     
    [HttpPost("crear-enemigo")]

    public IActionResult CrearEnemigo([FromBody] CrearEnemigoRequest individuo)
    {
        var enemigo = new Enemigo(individuo.Vida, individuo.Nivel);
        listaEnemigos.Add(enemigo);

        var response = new EnemigoResponse
            {
                Vida = enemigo.Vida,
                Nivel = enemigo.Nivel,

            };

        return Ok("El enemigo ha sido creado con exito.");
    }

    

    [HttpGet("Creacion-de-batalla")]
    public IActionResult Batalla()
    {
        string descripcionDeBatalla = "";
       foreach (var enemigo in listaEnemigos.ToList()) //sirve para hacer una copia para que no haya modificaciones durante la batalla
       {
            while (enemigo.Vida > 0 && listaPersonajes.Any()) 
                {
                    foreach (var personaje in listaPersonajes.ToList())
                        {
                            personaje.MoverseEjeX(5);
                            personaje.MoverseEjeY(3);
                            enemigo.MoverseEjeX(4);
                            enemigo.MoverseEjeY(3);

                            descripcionDeBatalla += $"{personaje.Nombre} se movió para esquivar el ataque del enemigo." + Environment.NewLine;  // + Environment.NewLine sirve para hacer saltos de linea
                            descripcionDeBatalla += $"El enemigo se movió para contraatacar al {personaje.Nombre}." + Environment.NewLine;
                            
                            int danioPersonaje = personaje.CalcularDanio();
                            enemigo.Vida -= danioPersonaje;
                            if(danioPersonaje > 0)
                            {
                                descripcionDeBatalla += $"{personaje.DescripcionBatalla()}\n {personaje.Atacar()}.\n El personaje {personaje.Nombre} atacó al enemigo generandole  {danioPersonaje} de daño.La vida del enemigo ahora es de {enemigo.Vida}." + Environment.NewLine;

                            }else if(danioPersonaje == 0)
                            {
                            descripcionDeBatalla += $"El personaje {personaje.Nombre}falló su oportunidad de hacerle daño al enemigo!." + Environment.NewLine;
                            }

                            if (enemigo.Vida <= 0)
                            {
                                descripcionDeBatalla += $"¡El enemigo ha sido derrotado!{personaje.Nombre} ha salvado al poblado." + Environment.NewLine;
                                listaEnemigos.Remove(enemigo);
                                break;
                            }
                            else
                            {
                                descripcionDeBatalla += $"El enemigo contraataca, pero {personaje.Nombre} sigue en pie." + Environment.NewLine;
                            }
                        }
            }
            

        }

         if (!listaPersonajes.Any())
        {
           descripcionDeBatalla += "No hay personajes disponibles para luchar." + Environment.NewLine;
        }
        if (!listaEnemigos.Any())
        {
           descripcionDeBatalla += "No hay enemigos disponibles para luchar." + Environment.NewLine;
        } 

        return Ok(descripcionDeBatalla); 
                 

            
    }

    public class CrearPersonajeDeFuerzaRequest
    {
        public string Nombre { get; set; }
        public int Agilidad { get; set; }
        public int Magia {get; set;}
    }

    public class PersonajeDeFuerzaResponse
        {
            public string Nombre { get; set; }
            public int Agilidad { get; set; }
            public int Magia { get; set; }
            public int Fuerza { get; set; }
        }
/*---------------------------------------------------------------------------------------*/
    public class CrearPersonajeDeAgilidadRequest
    {
        public string Nombre { get; set; }
        public int Agilidad { get; set; }
        public int Magia {get; set;}

        public int Fuerza {get; set;}
    }

    public class PersonajeDeAgilidadResponse
        {
            public string Nombre { get; set; }
            public int Agilidad { get; set; }
            public int Magia { get; set; }
            public int Fuerza { get; set; }
        }
/*---------------------------------------------------------------------------------------*/

    public class CrearPersonajeDeMagiaRequest
    {
        public string Nombre { get; set; }
        public int Agilidad { get; set; }
        public int Magia {get; set;}

        public int Fuerza {get; set;}
    }

    public class PersonajeDeMagiaResponse
        {
            public string Nombre { get; set; }
            public int Agilidad { get; set; }
            public int Magia { get; set; }
            public int Fuerza { get; set; }
        }
/*---------------------------------------------------------------------------------------*/

    public class CrearEnemigoRequest
    {
        public int Vida {get; set;}
        public int Nivel { get; set; }

    }

    public class EnemigoResponse
    {
        public int Vida {get; set;}
        public int Nivel { get; set; }
    }




    

    
}    

    





