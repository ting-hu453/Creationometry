using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Creationometry.Views.EMMenu;
using Creationometry.Views.Input_Controls;

namespace Creationometry.Presenters
{
    class EllipseModMenuPresenter
    {
        private IEllipseModMenuView ellipseModMenuView;
        private CommandSelector commandSelector;
        private ICommand modifyElementCommand;
        private EMMenuPresenterManager manager;
        private Ellipses selectedElement;

        public EllipseModMenuPresenter(IEllipseModMenuView ellipseModMenuView,
            CommandSelector commandSelector, EMMenuPresenterManager manager)
        {
            this.ellipseModMenuView = ellipseModMenuView;
            this.commandSelector = commandSelector;
            this.manager = manager;
            selectedElement = null;

            // Event subscriptions
            ellipseModMenuView.P0XInputChanged += EllipseModMenuView_P0XInputChanged;
            ellipseModMenuView.P0YInputChanged += EllipseModMenuView_P0YInputChanged;
            ellipseModMenuView.P1XInputChanged += EllipseModMenuView_P1XInputChanged;
            ellipseModMenuView.P1YInputChanged += EllipseModMenuView_P1YInputChanged;
            ellipseModMenuView.P2XInputChanged += EllipseModMenuView_P2XInputChanged;
            ellipseModMenuView.P2YInputChanged += EllipseModMenuView_P2YInputChanged;
            ellipseModMenuView.R1InputChanged += EllipseModMenuView_R1InputChanged;
            ellipseModMenuView.R2InputChanged += EllipseModMenuView_R2InputChanged;
            ellipseModMenuView.A1InputChanged += EllipseModMenuView_A1InputChanged;
            ellipseModMenuView.BorderColorInputChanged += EllipseModMenuView_BorderColorInputChanged;
            ellipseModMenuView.BorderOpacityInputChanged += EllipseModMenuView_BorderOpacityInputChanged;
            ellipseModMenuView.BorderWidthInputChanged += EllipseModMenuView_BorderWidthInputChanged;
        }

        //------------------------------------------------------------------
        // Event Handlers
        //------------------------------------------------------------------
        //The following event handlers call the set methods on the selected object,
        //then they repopulate the menu in case other values were updated by the shape
        //as a result of the set method call.
        private void EllipseModMenuView_P0XInputChanged(object sender, FloatValueEventArgs e)
        {
            commandSelector.setCommand(modifyElementCommand);
            commandSelector.doAction(selectedElement);
            selectedElement.setP0X(e.Value);
            manager.refreshCanvas();
        }

        private void EllipseModMenuView_P0YInputChanged(object sender, FloatValueEventArgs e)
        {
            //if (selectedElement != null)
            //    selectedElement.setP0Y(e.Value);
            //manager.refreshCanvas();
        }

        private void EllipseModMenuView_P1XInputChanged(object sender, FloatValueEventArgs e)
        {
            //if (selectedElement != null)
            //    selectedElement.setP1X(e.Value);
            //manager.refreshCanvas();
        }

        private void EllipseModMenuView_P1YInputChanged(object sender, FloatValueEventArgs e)
        {
            //if (selectedElement != null)
            //    selectedElement.setP1Y(e.Value);
            //manager.refreshCanvas();
        }

        private void EllipseModMenuView_P2XInputChanged(object sender, FloatValueEventArgs e)
        {
            //if (selectedElement != null)
            //    selectedElement.setP2X(e.Value);
            //manager.refreshCanvas();
        }

        private void EllipseModMenuView_P2YInputChanged(object sender, FloatValueEventArgs e)
        {
            //if (selectedElement != null)
            //    selectedElement.setP2Y(e.Value);
            //manager.refreshCanvas();
        }

        private void EllipseModMenuView_R1InputChanged(object sender, FloatValueEventArgs e)
        {
            //if (selectedElement != null)
            //    selectedElement.setR1(e.Value);
            //manager.refreshCanvas();
        }

        private void EllipseModMenuView_R2InputChanged(object sender, FloatValueEventArgs e)
        {
            //if (selectedElement != null)
            //    selectedElement.setR2(e.Value);
            //manager.refreshCanvas();
        }

        private void EllipseModMenuView_A1InputChanged(object sender, FloatValueEventArgs e)
        {
            //if (selectedElement != null)
            //    selectedElement.setA1(e.Value);
            //manager.refreshCanvas();
        }

        private void EllipseModMenuView_BorderColorInputChanged(object sender, ColorEventArgs e)
        {
            commandSelector.setCommand(modifyElementCommand);
            commandSelector.doAction(selectedElement);
            Color previousColor = selectedElement.getBorderColor();
            Color newColor = Color.FromArgb(previousColor.A, e.Color.R, e.Color.G, e.Color.B);
            selectedElement.setBorderColor(newColor);
            selectedElement.setBorder(new Pen(newColor, selectedElement.getLineWeight()));
            manager.refreshCanvas();
        }

        private void EllipseModMenuView_BorderOpacityInputChanged(object sender, ByteEventArgs e)
        {
            commandSelector.setCommand(modifyElementCommand);
            commandSelector.doAction(selectedElement);
            Color previousColor = selectedElement.getBorderColor();
            Color newColor = Color.FromArgb(e.Value, previousColor.R, previousColor.G, previousColor.B);
            selectedElement.setBorderColor(newColor);
            selectedElement.setBorder(new Pen(newColor, selectedElement.getLineWeight()));
            manager.refreshCanvas();
        }

        private void EllipseModMenuView_BorderWidthInputChanged(object sender, FloatValueEventArgs e)
        {
            commandSelector.setCommand(modifyElementCommand);
            commandSelector.doAction(selectedElement);
            selectedElement.setLineWeight(e.Value);
            selectedElement.setBorder(new Pen(selectedElement.getBorderColor(), e.Value));
            manager.refreshCanvas();
        }

        //------------------------------------------------------------------
        // Methods
        //------------------------------------------------------------------

        public void setModifyElementCommand(ICommand modifyElementCommand)
        {
            this.modifyElementCommand = modifyElementCommand;
        }

        public void setSelectedElement(Ellipses selectedElement)
        {
            this.selectedElement = selectedElement;
        }

        public void populateEMMenuView()
        {
            ellipseModMenuView.setP0XInputValue(selectedElement.centerXPos());
            ellipseModMenuView.setP0YInputValue(selectedElement.centerYPos());

            //ellipseModMenuView.setP0XInputValue(selectedElement.getP0X());
            //ellipseModMenuView.setP0YInputValue(selectedElement.getP0Y());
            //ellipseModMenuView.setP1XInputValue(selectedElement.getP1X());
            //ellipseModMenuView.setP1YInputValue(selectedElement.getP1Y());
            //ellipseModMenuView.setP2XInputValue(selectedElement.getP2X());
            //ellipseModMenuView.setP2YInputValue(selectedElement.getP2Y());
            //ellipseModMenuView.setR1InputValue(selectedElement.getR1());
            //ellipseModMenuView.setR2InputValue(selectedElement.getR2());
            //ellipseModMenuView.setA1InputValue(selectedElement.getA1());
            ellipseModMenuView.setBorderColorInputBackColor(selectedElement.getBorderColor());
            ellipseModMenuView.setBorderOpacityInputValue(selectedElement.getBorderColor().A);
            ellipseModMenuView.setBorderWidthInputValue(selectedElement.getLineWeight());
        }

        public void showView()
        {
            ellipseModMenuView.showView();
        }

        public void hideView()
        {
            ellipseModMenuView.hideView();
        }
    }
}
