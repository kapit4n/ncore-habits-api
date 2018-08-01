using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using habitsWebapi.Models;


namespace habitsWebapi.Services
{
  public class HabitsService 
  {
    public IEnumerable<Habit> getHabits()
    {
      return new Habit[] {
          new Habit{Id = 1, Name = "Write more source code", Description = "This is the description" },
          new Habit{Id = 2, Name = "Read more source code", Description = "This is the description" }
            };
    }

    public Habit getHabitById(int id) {
      return new Habit { Id = 1, Name = "Write more source code", Description = "This is the description" };
    }
  }
}