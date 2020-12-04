using System;
using System.Collections.Generic;
using System.Text;

namespace Presentation
{
    public interface IAddWorker : IView
    {
        string WorkerName { get; }
        string StartFloor { get; }
        string EndFloor { get; }

        event Action AddW;

        void ShowError(string message);
    }
}
