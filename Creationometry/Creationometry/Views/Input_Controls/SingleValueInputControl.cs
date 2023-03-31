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
    public partial class SingleValueInputControl : UserControl
    {
        public event EventHandler<FloatValueEventArgs> RInputChanged;

        private string rInputCurrent;

        public SingleValueInputControl()
        {
            InitializeComponent();
        }

        //------------------------------------------------------------------
        // Methods
        //------------------------------------------------------------------
        public void setValueNameLabelText(string text)
        {
            valueNameLabel.Text = text;
        }

        public void setUnitLabelText(string text)
        {
            unitLabel.Text = text;
        }

        public void setRInputValue(float value)
        {
            rInput.Text = value.ToString("0.0000");
        }

        //------------------------------------------------------------------
        // Event Raisers
        //------------------------------------------------------------------
        protected virtual void OnRInputChanged(FloatValueEventArgs e)
        {
            EventHandler<FloatValueEventArgs> handler = RInputChanged;
            handler?.Invoke(this, e);
        }

        //------------------------------------------------------------------
        // Event Handlers
        //------------------------------------------------------------------
        private void rInput_Leave(object sender, EventArgs e)
        {
            // Ensure that value has changed (memento shouldn't be stored if nothing changed)
            if (rInputCurrent != rInput.Text)
            {
                // Prevent input that can't be parsed as a float
                // If input is invalid, revert it to current text
                float value;
                if (float.TryParse(rInput.Text, out value))
                {
                    rInputCurrent = rInput.Text; // Prevents unnecessary mementos and allows revert
                    FloatValueEventArgs args = new FloatValueEventArgs();
                    args.Value = value;
                    OnRInputChanged(args);
                }
                else
                {
                    rInput.Text = rInputCurrent; // Reject and revert input
                }
            }
        }
    }
}
