using System;
using System.Collections.Generic;
using System.Text;

namespace Presentation
{
    public interface INewBuilding
    {
        int FloorsNumber { get; }
        int LiftsNumber { get; }

      
        event Action NewB;
    }
}
