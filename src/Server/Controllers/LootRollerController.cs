using Microsoft.AspNetCore.Mvc;
using Server.Dto;
using Server.Services;

namespace Server.Controllers;

[ApiController]
[Route("[controller]")]
public class LootRollerController : ControllerBase
{

    private readonly ILogger<LootRollerController> _logger;
    private readonly LootRollerService _service;

    public LootRollerController(ILogger<LootRollerController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "Loot")]
    public Loot Get(int level)
    {
        return _service.GetLoot(level);
    }
}