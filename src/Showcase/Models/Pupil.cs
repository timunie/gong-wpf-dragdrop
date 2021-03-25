using System;
using System.Collections.Generic;
using System.Text;

namespace Showcase.WPF.DragDrop.Models
{
    public class Pupil
    {
        public Pupil (string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
