using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Showcase.WPF.DragDrop.Models
{
    public class Class
    {
        public Class (string name)
        {
            Name = name;
        }

        public Class (string name, IEnumerable<Pupil> pupils) : this(name)
        {
            foreach (var pupil in pupils)
            {
                Pupils.Add(pupil);
            }
        }

        public string Name { get; set; }

        public ObservableCollection<Pupil> Pupils { get; } = new ObservableCollection<Pupil>();
    }
}
