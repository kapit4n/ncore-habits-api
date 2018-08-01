using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using habitsWebapi.Models;
using habitsWebapi.Services;
using habitsWebapi.Interfaces;

namespace habitsWebapi.Controllers
{
  [Route("api/[controller]")]
  public class HabitsController : Controller
  {

    private readonly IHabitsService _habitsService;

    public HabitsController(IHabitsService habitsService)
    {
      _habitsService = habitsService;
    }

    // GET api/habits
    [HttpGet]
    public IEnumerable<Habit> Get()
    {
      return _habitsService.getHabits();
    }

    // GET api/habits/5
    [HttpGet("{id}")]
    public Habit Get(int id)
    {
      return _habitsService.getHabitById(id);
    }

    // POST api/habits
    [HttpPost]
    public void Post([FromBody]Habit value)
    {
    }

    // PUT api/habits/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody]Habit value)
    {
    }

    // DELETE api/habits/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
  }
}
