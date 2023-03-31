using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Creationometry.Views.Input_Controls
{
    public partial class PointInputControl : UserControl
    {
        public event EventHandler<FloatValueEventArgs> XInputChanged;
        public event EventHandler<FloatValueEventArgs> YInputChanged;

        // Current values for TextBoxes. They help prevent unnecessary mementos
        // and allow the TextBoxes to revert to previous values in the case of
        // invalid input.
        private string xInputCurrent;
        private string yInputCurrent;

        public PointInputControl()
        {
            InitializeComponent();
            xInputCurrent = xInput.Text;
            yInputCurrent = yInput.Text;
        }

        //------------------------------------------------------------------
        // Methods
        //------------------------------------------------------------------
        public void setPointNameLabelText(string text)
        {
            pointNameLabel.Text = text;
        }

        public void setXInputValue(float value)
        {
            xInputCurrent = xInput.Text;
            xInput.Text = value.ToString("0.0000");
        }

        public void setYInputValue(float value)
        {
            yInputCurrent = yInput.Text;
            yInput.Text = value.ToString("0.0000");
        }

        //------------------------------------------------------------------
        // Event Raisers
        //------------------------------------------------------------------
        protected virtual void OnXInputChanged(FloatValueEventArgs e)
        {
            EventHandler<FloatValueEventArgs> handler = XInputChanged;
            handler?.Invoke(this, e);
        }

        protected virtual void OnYInputChanged(FloatValueEventArgs e)
        {
            EventHandler<FloatValueEventArgs> handler = YInputChanged;
            handler?.Invoke(this, e);
        }

        //------------------------------------------------------------------
        // Event Handlers
        //------------------------------------------------------------------
        private void xInput_Leave(object sender, EventArgs e)
        {
            // Ensure that value has changed (memento shouldn't be stored if nothing changed)
            if (xInputCurrent != xInput.Text)
            {
                // Prevent input that can't be parsed as a float
                // If input is invalid, revert it to current text
                float value;
                if (float.TryParse(xInput.Text, out value))
                {
                    xInputCurrent = xInput.Text; // Prevents unnecessary mementos and allows revert
                    FloatValueEventArgs args = new FloatValueEventArgs();
                    args.Value = value;
                    OnXInputChanged(args);
                }
                else
                {
                    xInput.Text = xInputCurrent; // Reject and revert input
                }
            }
        }

        private void yInput_Leave(object sender, EventArgs e)
        {
            // Ensure that value has changed (memento shouldn't be stored if nothing changed)
            if (yInputCurrent != yInput.Text)
            {
                // Prevent input that can't be parsed as a float
                // If input is invalid, revert it to current text
                float value;
                if (float.TryParse(yInput.Text, out value))
                {
                    yInputCurrent = yInput.Text; // Prevents unnecessary mementos and allows revert
                    FloatValueEventArgs args = new FloatValueEventArgs();
                    args.Value = value;
                    OnYInputChanged(args);
                }
                else
                {
                    yInput.Text = yInputCurrent; // Reject and revert input
                }
            }
        }
    }
}
