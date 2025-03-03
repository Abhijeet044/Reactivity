using System;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers;

public class ActivitiesController(AppDbContext context) : BaseAPIController
{
[HttpGet]
public async Task<ActionResult<List<Activity>>> GetActivities()
{
    return await context.Activities.ToListAsync();
}

[HttpGet("{id}")]
public async Task<ActionResult<Activity>> GetActivityById(Guid id)
{
    var returnid = await context.Activities.FindAsync(id);
    if(returnid == null) return NotFound();
    return returnid;
}
}
