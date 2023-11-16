using System.Diagnostics;
using Core.Data.Models;
using DatabaseAccess.Data;
using Microsoft.AspNetCore.Mvc;
using Website.Infrastructure;
using Website.Models;

namespace Website.Controllers;

public class StomiController : BaseController
{
    private readonly Database _database;

    public StomiController(Database database)
    {
        _database = database;
    }

    [Route("Stomi/Add/{name}")]
    public IActionResult Add(int stomigiverId, int stomiejerId)
    {
        var stomigiver = _database.Bruger.SingleOrDefault(x => x.ID == stomigiverId);
        var stomiejer = _database.Bruger.SingleOrDefault(x => x.ID == stomiejerId);
        if (stomigiver == null || stomiejer == null)
            return BadRequest();

        _database.Stomi.Add(new Stomi()
        {
            StomiGiver = stomigiverId,
            StomiEjer = stomiejerId
        });
        _database.SaveChanges();
        
        return Ok();
    }
}