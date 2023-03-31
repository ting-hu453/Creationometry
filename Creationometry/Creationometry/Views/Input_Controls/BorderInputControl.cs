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
    public partial class BorderInputControl : UserControl
    {
        public event EventHandler<ColorEventArgs> ColorInputChanged;
        public event EventHandler<ByteEventArgs> OpacityInputChanged;
        public event EventHandler<FloatValueEventArgs> WidthInputChanged;

        // Current values for TextBoxes. They help prevent unnecessary mementos
        // and allow the TextBoxes to revert to previous values in the case of
        // invalid input.
        private Color colorInputCurrent;
        private string opacityInputCurrent;
        private string widthInputCurrent;

        public BorderInputControl()
        {
            InitializeComponent();
            colorInputCurrent = Color.FromArgb(255, 0, 0, 0);
            opacityInputCurrent = "";
            widthInputCurrent = "";
        }

        //------------------------------------------------------------------
        // Methods
        //------------------------------------------------------------------
        public void setColorInputBackColor(Color color)
        {
            colorInputBox.BackColor = color;
        }

        public void setOpacityInputValue(float value)
        {
            opacityInputCurrent = opacityInput.Text;
            opacityInput.Text = value.ToString();
        }

        public void setWidthInputValue(float value)
        {
            widthInputCurrent = widthInput.Text;
            widthInput.Text = value.ToString();
        }

        //------------------------------------------------------------------
        // Event Raisers
        //------------------------------------------------------------------
        protected virtual void OnColorInputChanged(ColorEventArgs e)
        {
            EventHandler<ColorEventArgs> handler = ColorInputChanged;
            handler?.Invoke(this, e);
        }

        protected virtual void OnOpacityInputChanged(ByteEventArgs e)
        {
            EventHandler<ByteEventArgs> handler = OpacityInputChanged;
            handler?.Invoke(this, e);
        }

        protected virtual void OnWidthInputChanged(FloatValueEventArgs e)
        {
            EventHandler<FloatValueEventArgs> handler = WidthInputChanged;
            handler?.Invoke(this, e);
        }

        //------------------------------------------------------------------
        // Event Handlers
        //------------------------------------------------------------------
        private void opacityInput_Leave(object sender, EventArgs e)
        {
            // Ensure that value has changed (memento shouldn't be stored if nothing changed)
            if (opacityInputCurrent != opacityInput.Text)
            {
                // Prevent input that can't be parsed as a float
                // If input is invalid, revert it to current text
                byte value;
                if (byte.TryParse(opacityInput.Text, out value))
                {
                    opacityInputCurrent = opacityInput.Text; // Prevents unnecessary mementos and allows revert
                    ByteEventArgs args = new ByteEventArgs();
                    args.Value = value;
                    OnOpacityInputChanged(args);
                }
                else
                {
                    opacityInput.Text = opacityInputCurrent; // Reject and revert input
                }
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            // Ensure that value has changed (memento shouldn't be stored if nothing changed)
            if (widthInputCurrent != widthInput.Text)
            {
                // Prevent input that can't be parsed as a float
                // If input is invalid, revert it to current text
                float value;
                if (float.TryParse(widthInput.Text, out value))
                {
                    widthInputCurrent = widthInput.Text; // Prevents unnecessary mementos and allows revert
                    FloatValueEventArgs args = new FloatValueEventArgs();
                    args.Value = value;
                    OnWidthInputChanged(args);
                }
                else
                {
                    widthInput.Text = widthInputCurrent; // Reject and revert input
                }
            }
        }

        private void colorInputBox_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                colorInputBox.BackColor = colorDialog1.Color;
                if (colorInputCurrent != colorDialog1.Color)
                {
                    colorInputCurrent = colorDialog1.Color;
                    // Raise color changed event
                    ColorEventArgs args = new ColorEventArgs();
                    args.Color = colorDialog1.Color;
                    OnColorInputChanged(args);
                }
            }
        }
    }
}
