
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

using Web.ej5;


public class Ej5Controller : ControllerBase
{
    static List<Character> charactersList = new List<Character>();
    static List<Enemy> enemiesList = new List<Enemy>();

    [HttpPost("[action]")]
    public IActionResult StrengthCharacter(string name, float agility, float magic)
    {
        StrengthCharacter character1 = new StrengthCharacter(name, agility, magic);
        charactersList.Add(character1);
        return Ok(character1);
    }

    [HttpPost("[action]")]
    public IActionResult AgilityCharacter(string name, float strength, float agility, float magic)
    {
        AgilityCharacter character1 = new AgilityCharacter(name, strength, magic, agility);
        charactersList.Add(character1);
        return Ok(character1);
    }

    [HttpPost("[action]")]
    public IActionResult MagicCharacter(string name, float strength, float agility, float? magic = null)
    {
        MagicCharacter character1 = magic.HasValue ? new MagicCharacter(name, strength, agility, magic.Value) : new MagicCharacter(name, strength, agility);
        charactersList.Add(character1);
        return Ok(character1);
    }

    [HttpPost("[action]")]
    public IActionResult Enemy(float life, int level)
    {
        Enemy enemy1 = new Enemy(life, level);
        enemiesList.Add(enemy1);
        return Ok(enemy1);
    }

    [HttpPost("[action]")]
    public IActionResult StartBattle()
    {
        string summaryAttacks = string.Join(", ", Turn.AttackEachOther(charactersList));
        string resultText;
        if (charactersList.Count() != enemiesList.Count() || charactersList.Count() + enemiesList.Count() == 0)
        {
            return BadRequest("Tiene que haber la misma cantidad de enemigos, que de personajes");
        }
        else
        {

            float accumDamage = charactersList.Sum((character) => character.EstimateDamage());
            float accumLife = enemiesList.Sum((enemy) => enemy.Life);
            if (accumDamage >= accumLife)
            {
                resultText = $"Los personajes salieron victoriosos realizando {accumDamage} de daño";
            }
            else
            {
                resultText = $"Los enemigos ganaron, la proxima deberás hacer más daño...";
            }

            return Ok($"El resumen de los ataques son [{summaryAttacks}], y como resultado de la batalla: {resultText}");
        }
    }
}