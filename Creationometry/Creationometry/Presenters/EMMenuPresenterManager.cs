using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Creationometry.Views.EMMenu;

namespace Creationometry.Presenters
{
    public class EMMenuPresenterManager
    {
        private DesignElement selectedElement;
        private Panel canvas;
        private CommandSelector commandSelector;
        private ICommand modifyElementCommand;

        // EMMenu Presenter Instances
        EllipseModMenuPresenter ellipseModMenuPresenter;

        public EMMenuPresenterManager(IEllipseModMenuView ellipseModMenuView, Panel canvas,
            CommandSelector commandSelector)
        {
            selectedElement = null;
            this.canvas = canvas;
            this.commandSelector = commandSelector;

            // Instantiate EMMenu Presenter instances
            ellipseModMenuPresenter = new EllipseModMenuPresenter(ellipseModMenuView, commandSelector, this);

            // Hide EMMenu when program starts
            hideEMMenu();
        }

        public void setModifyElementCommand(ICommand modifyElementCommand)
        {
            this.modifyElementCommand = modifyElementCommand;
            ellipseModMenuPresenter.setModifyElementCommand(modifyElementCommand);
        }

        public void setSelectedElement(DesignElement selectedElement)
        {
            this.selectedElement = selectedElement;
            // Add switch case to send to appropriate presenter
            if (selectedElement != null && selectedElement.GetType() == typeof(Ellipses))
                ellipseModMenuPresenter.setSelectedElement((Ellipses)selectedElement);
        }

        public void showEMMenu()
        {
            // Add switch case
            if (selectedElement != null && selectedElement.GetType() == typeof(Ellipses))
            {
                ellipseModMenuPresenter.showView();
                ellipseModMenuPresenter.populateEMMenuView();
            }
        }

        public void hideEMMenu()
        {
            // Add switch case, or just hide all
            ellipseModMenuPresenter.hideView();
        }

        public void refreshCanvas()
        {
            canvas.Refresh();
        }
    }
}
