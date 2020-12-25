using System;
using System.Collections.Generic;
using System.Text;
using Presentation.IModel;
using Presentation.Entities;


namespace Presentation
{
    class NewBuildingPresenter
    {
        private INewBuilding _view;
        private IBeginWithConfiguration _service;
        public NewBuildingPresenter(INewBuilding view, IBeginWithConfiguration service)
        {
            _view = view;
            _view.NewB += NewB;

            _service = service;
            _service.BuildingUpdated += HandleBuildingUpdated;
        }

        private void NewB()
        {
            if (_view.FloorsNumber < 21 && _view.LiftsNumber < 6)
            {
                BeginningConfiguration[] beginningConfiguration = new BeginningConfiguration[2] { _view.FloorsNumber, _view.LiftsNumber };
                _service.Begin(beginningConfiguration);
            }
            else
            {
                _view.ShowError("Invalid 'Initiative' value");
            }
        }
    }
}
