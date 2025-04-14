using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Recipe
    {
        private int levels;

        // Name
        public string Name { get; set; }

        // Category
        public string Category { get; set; }

        // Level
        public int Level
        {
            get { return levels; }
            set
            {
                if (value > 0)
                {
                    levels = value;
                }
                else
                {
                    levels = 1;
                }
            }
        }

        // Specialty property
        public string Specialty { get; set; }

        // Is the character an adventurer boolean
        public bool IsAdventurer { get; set; }

        // SubmittedBy property 
        public string SubmittedBy { get; set; }

        // Constructor
        public Recipe(string name, string category, int level, string specialty, bool isAdventurer, string submittedBy)
        {
            Name = name;
            Category = category;
            Level = level;
            Specialty = specialty;
            IsAdventurer = isAdventurer;
            SubmittedBy = submittedBy;
        }

        public string GetDetails()
        {
            return Name + " (" + Category + ")";
        }

        public void UpdateLevels(int newLevel)
        {
            Level = newLevel;
        }
    }
}
