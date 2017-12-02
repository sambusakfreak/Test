using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Test.Models
{
    public class Workout
    {
        public DateTime Date { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Set> Sets { get; set; }
    }

    public class Set
    {
        public int Id { get; set; }
        public int ExerciseId { get; set; }
        public int WorkoutId { get; set; }
        public decimal Weight { get; set; }
        public int Reps { get; set; }

        public virtual Exercise Exercise { get; set; }
        public virtual Workout Workout { get; set; }
    }

    public class Exercise
    {
        public List<SelectListItem> ExerciseList { get; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "ID_", Text = "ID" },
            new SelectListItem { Value = "FNAME_", Text = "First name" },
            new SelectListItem { Value = "LNAME_", Text = "Last name"  },
        };
    }
}
