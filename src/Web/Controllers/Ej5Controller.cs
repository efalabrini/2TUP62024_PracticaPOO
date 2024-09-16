using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Web.Classes;

namespace Web.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class Ej5Controller : Controller
    {
        public static List<Character> charactersList = new List<Character>();

        [HttpPost("[action]")]
        public IActionResult createStrengthCharacter([FromQuery] string name, float agility, float magic)
        {
            StrengthCharacter strengthCharacter = new StrengthCharacter(name, agility, magic);
            charactersList.Add(strengthCharacter);

            return Ok(new { message = $"Personaje de FUERZA creado con las propiedades: Nombre: {strengthCharacter.name} Fuerza: {strengthCharacter.strength} Agilidad: {strengthCharacter.agility} Magia: {strengthCharacter.magic}" });
        }

        [HttpPost("[action]")]
        public IActionResult createAgilityCharacter([FromQuery] string name, float strength, float agility, float magic)
        {
            AgilityCharacter agilityCharacter = new AgilityCharacter(name, strength, agility, magic);
            charactersList.Add(agilityCharacter);

            return Ok(new { message = $"Personaje de AGILIDAD creado con las propiedades: Nombre: {agilityCharacter.name} Fuerza: {agilityCharacter.strength} Agilidad: {agilityCharacter.agility} Magia: {agilityCharacter.magic}" });
        }

        [HttpPost("[action]")]
        public IActionResult createMagicCharacter([FromQuery] string name, float strength, float agility, float? magic)
        {
            if (magic.HasValue)
            {
                float magicValue = (float)magic.Value;
                MagicCharacter magicCharacter = new MagicCharacter(name, strength, agility, magicValue);
                charactersList.Add(magicCharacter);
                return Ok(new { message = $"Personaje de MAGIA creado con las propiedades: Nombre: {magicCharacter.name} Fuerza: {magicCharacter.strength} Agilidad: {magicCharacter.agility} Magia: {magicCharacter.magic}" });
            }
            else
            {
                MagicCharacter magicCharacter = new MagicCharacter(name,strength,agility);
                charactersList.Add(magicCharacter);
                return Ok(new { message = $"Personaje de MAGIA creado con las propiedades: Nombre: {magicCharacter.name} Fuerza: {magicCharacter.strength} Agilidad: {magicCharacter.agility} Magia: {magicCharacter.magic}" });
            }
        }

        [HttpPost("[action]")]
        public IActionResult createEnemy([FromQuery] string name,float strength,float agility,float magic,float health,int level)
        {
            Enemy enemy = new Enemy(name, strength, agility, magic, health, level);
            charactersList.Add(enemy);
            return Ok(new { message = $"Enemigo creado con las propiedades: Nombre: {enemy.name} Fuerza: {enemy.strength} Agilidad: {enemy.agility} Magia: {enemy.magic} Salud: {enemy.health} Nivel: {enemy.level}" });
        }

        [HttpGet("[action]")]
        public IActionResult createBattle()
        {
            var moves = Turn.move(10, 15, charactersList[0]);
            var battle = new { move = $"{charactersList[0].name} se movió X {moves["x"]} Y {moves["y"]} " , attacks = Turn.attackEachOther(charactersList) };
            return Ok(battle);
        }
    }
}