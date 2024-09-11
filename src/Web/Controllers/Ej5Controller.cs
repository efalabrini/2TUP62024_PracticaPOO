using Microsoft.AspNetCore.Mvc;
using Web.Ej5;

namespace Web.Controllers;

[ApiController]
[Route("[controller]/[Action]")]

public class Ej5Controller: ControllerBase{
    static List<Character> charactersList = new List<Character>();
    static List<Enemy> enemiesList = new List<Enemy>();
    [HttpPost]
    public IActionResult StrengthCharacter(string name, float agility, float magic)
    {
        StrengthCharacter strongCharacter = new StrengthCharacter(name, agility, magic);
        charactersList.Add(strongCharacter);
        return Ok(strongCharacter);
    }
    [HttpPost]
    public IActionResult AgilityCharacter(string name,float strength, float agility, float magic)
    {
        AgilityCharacter agilityCharacter = new AgilityCharacter(name, strength, agility, magic);
        charactersList.Add(agilityCharacter);
        return Ok(agilityCharacter);
    }
    [HttpPost]
    public IActionResult MagicCharacter(string name, float strength, float agility, float? magic = null)
    {
        MagicCharacter magicCharacter = magic.HasValue ? new MagicCharacter(name, strength, agility, magic.Value) : new MagicCharacter(name, strength, agility);
        charactersList.Add(magicCharacter);
        return Ok(magicCharacter);
    }
    [HttpPost]
    public IActionResult Enemy(float life, int level)
    {
        Enemy enemy = new Enemy(life, level);
        enemiesList.Add(enemy);
        return Ok(enemy);
    }
    [HttpGet]
    public IActionResult Battle()
    {
        Turn.AttackEachOther(charactersList);
        Turn.MovePieces(charactersList[1], 5, 1, "derecha", "abajo");
        Turn.MovePieces(enemiesList[0], 2, 3, "izquierda", "arriba");
        Turn.AttackEachOther(charactersList);

        return Ok("Movimientos realizados");
        
    }

    


}