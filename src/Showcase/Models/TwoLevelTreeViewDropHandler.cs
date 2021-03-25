using GongSolutions.Wpf.DragDrop;
using System;
using System.Collections.Generic;
using System.Text;

namespace Showcase.WPF.DragDrop.Models
{
    public class TwoLevelTreeViewDropHandler : IDropTarget
    {
        // This can be bound to from anywhere. 
        public static TwoLevelTreeViewDropHandler Instance { get; } = new TwoLevelTreeViewDropHandler();

        public void DragOver(IDropInfo dropInfo)
        {
            // Perform some checks here. 
            if (dropInfo.Data is Pupil pupil && (dropInfo.TargetItem is Class || !dropInfo.InsertPosition.HasFlag(RelativeInsertPosition.TargetItemCenter)))
            {
                GongSolutions.Wpf.DragDrop.DragDrop.DefaultDropHandler.DragOver(dropInfo);
            }
        }

        public void Drop(IDropInfo dropInfo)
        {
            GongSolutions.Wpf.DragDrop.DragDrop.DefaultDropHandler.Drop(dropInfo);
        }
    }
}
