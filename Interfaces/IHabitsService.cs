using System;
using System.Collections.Generic;
using habitsWebapi.Models;

namespace habitsWebapi.Interfaces
{
  public interface IHabitsService
  {
    IEnumerable<Habit> getHabits();
    Habit getHabitById(int id);
  }
}