using System;
using System.Collections.Generic;
using System.Text;
using Presentation.IModel;
using Presentation.Entities;

namespace Presentation
{
    class AddWorkerPresenter
    {
        private static IAddWorker _view;
        private IEntityAddable _service;

        public AddWorkerPresenter(IAddWorker view, IEntityAddable service)
        {
            _view = view;
            _view.AddW += AddW;

            _service = service;
            
        }

        private void AddW()
        {
             HumanStartingData _data = new HumanStartingData(_view.WorkerName, _view.StartFloor, _view.EndFloor);
             bool success = _service.AddEntity(_data);
            
            if (success == false) 
            {
                _view.ShowError("Invalid 'Initiative' value");
            }
        }


        public void Run()
        {
            _view.Show();
        }
    }
}
