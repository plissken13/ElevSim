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
            _service.EntityUpdated += HandleEntityUpdated;

        }

        private void AddW()
        {
            if (int.TryParse(_view.StartFloor, out int startFloor) && int.TryParse(_view.EndFloor, out int endFloor))
            {

             HumanStartingData _data = new HumanStartingData(_view.WorkerName, startFloor, endFloor);
             _service.AddEntity(_data);
            }

            else
            {
                _view.ShowError("Invalid 'Initiative' value");
            }
        }

        public event Action AddEntity;

        public event Action EntityUpdated;

        private void HandleEntityUpdated()
        {
            EntityUpdated?.Invoke();
            _view.Close();
        }
    }
}
