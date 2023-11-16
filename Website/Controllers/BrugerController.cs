using System.Diagnostics;
using Core.Data.Models;
using DatabaseAccess.Data;
using Microsoft.AspNetCore.Mvc;
using Website.Infrastructure;
using Website.Models;

namespace Website.Controllers;

public class BrugerController : BaseController
{
    private readonly Database _database;

    public BrugerController(Database database)
    {
        _database = database;
    }

    [Route("Bruger/Add/{name}")]
    public IActionResult Add(string name)
    {
        _database.Bruger.Add(new Bruger()
        {
            Navn = name,
        });
        _database.SaveChanges();
        
        return Ok();
    }
    [Route("Bruger/Delete/{name}")]
    public IActionResult Delete(string name)
    {
        var bruger = _database.Bruger.SingleOrDefault(x => x.Navn.ToLower() == name.ToLower());
        
        return Ok(bruger);
    }
}