using Ninject;
using System;
using System.Collections.Generic;
using System.Text;

namespace Presentation
{
    class StartFormPresenter
    {

        private IStartForm _view;

        public StartFormPresenter(IStartForm view)
        {
            _view = view;
            _view.ShowAddWorker += ShowAddWorker;
        }

        private void ShowAddWorker()
        {
            
        }
    }
}
