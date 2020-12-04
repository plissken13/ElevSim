using System;
using System.Collections.Generic;
using System.Text;

namespace Presentation
{
    interface IChangeRules : IView
    {
        string WorkerName { get; }
        int StartFloor { get; }
        int EndFloor { get; }
       
        event Action AddW;

        int Strategy { get; }
        event Action AddStrategy;

        int Wait { get; }
        event Action AddWait;

        int StartAlarm { get; }
        int EndAlarm { get; }
        event Action AddAlarm;

    }
}
