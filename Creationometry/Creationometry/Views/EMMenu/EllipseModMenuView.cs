using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Creationometry.Views.Input_Controls;

namespace Creationometry.Views.EMMenu
{
    public partial class EllipseModMenuView : UserControl, IEllipseModMenuView
    {
        public event EventHandler<FloatValueEventArgs> P0XInputChanged;
        public event EventHandler<FloatValueEventArgs> P0YInputChanged;
        public event EventHandler<FloatValueEventArgs> P1XInputChanged;
        public event EventHandler<FloatValueEventArgs> P1YInputChanged;
        public event EventHandler<FloatValueEventArgs> P2XInputChanged;
        public event EventHandler<FloatValueEventArgs> P2YInputChanged;
        public event EventHandler<FloatValueEventArgs> R1InputChanged;
        public event EventHandler<FloatValueEventArgs> R2InputChanged;
        public event EventHandler<FloatValueEventArgs> A1InputChanged;
        public event EventHandler<ColorEventArgs> BorderColorInputChanged;
        public event EventHandler<ByteEventArgs> BorderOpacityInputChanged;
        public event EventHandler<FloatValueEventArgs> BorderWidthInputChanged;

        public EllipseModMenuView()
        {
            InitializeComponent();
            
            // Set name and unit labels
            pointInputControlP0.setPointNameLabelText("p0");
            pointInputControlP1.setPointNameLabelText("p1");
            pointInputControlP2.setPointNameLabelText("p2");
            distanceInputControlR1.setValueNameLabelText("r1");
            distanceInputControlR1.setUnitLabelText("px");
            distanceInputControlR2.setValueNameLabelText("r2");
            distanceInputControlR2.setUnitLabelText("px");
            angleInputControlA1.setValueNameLabelText("a1");
            angleInputControlA1.setUnitLabelText("\x00B0");

            // Event subscriptions handled by designer
        }

        //------------------------------------------------------------------
        // Methods
        //------------------------------------------------------------------
        
        public void showView()
        {
            this.Visible = true;
        }

        public void hideView()
        {
            this.Visible = false;
        }

        public void setP0XInputValue(float value)
        {
            pointInputControlP0.setXInputValue(value);
        }

        public void setP0YInputValue(float value)
        {
            pointInputControlP0.setYInputValue(value);
        }

        public void setP1XInputValue(float value)
        {
            pointInputControlP1.setXInputValue(value);
        }

        public void setP1YInputValue(float value)
        {
            pointInputControlP1.setYInputValue(value);
        }

        public void setP2XInputValue(float value)
        {
            pointInputControlP2.setXInputValue(value);
        }

        public void setP2YInputValue(float value)
        {
            pointInputControlP2.setYInputValue(value);
        }

        public void setR1InputValue(float value)
        {
            distanceInputControlR1.setRInputValue(value);
        }

        public void setR2InputValue(float value)
        {
            distanceInputControlR2.setRInputValue(value);
        }

        public void setA1InputValue(float value)
        {
            angleInputControlA1.setRInputValue(value);
        }

        public void setBorderColorInputBackColor(Color color)
        {
            borderInputControl.setColorInputBackColor(color);
        }

        public void setBorderOpacityInputValue(float value)
        {
            borderInputControl.setOpacityInputValue(value);
        }

        public void setBorderWidthInputValue(float value)
        {
            borderInputControl.setWidthInputValue(value);
        }

        //------------------------------------------------------------------
        // Event Raisers
        //------------------------------------------------------------------
        protected virtual void OnP0XInputChanged(FloatValueEventArgs e)
        {
            EventHandler<FloatValueEventArgs> handler = P0XInputChanged;
            handler?.Invoke(this, e);
        }

        protected virtual void OnP0YInputChanged(FloatValueEventArgs e)
        {
            EventHandler<FloatValueEventArgs> handler = P0YInputChanged;
            handler?.Invoke(this, e);
        }

        protected virtual void OnP1XInputChanged(FloatValueEventArgs e)
        {
            EventHandler<FloatValueEventArgs> handler = P1XInputChanged;
            handler?.Invoke(this, e);
        }

        protected virtual void OnP1YInputChanged(FloatValueEventArgs e)
        {
            EventHandler<FloatValueEventArgs> handler = P1YInputChanged;
            handler?.Invoke(this, e);
        }

        protected virtual void OnP2XInputChanged(FloatValueEventArgs e)
        {
            EventHandler<FloatValueEventArgs> handler = P2XInputChanged;
            handler?.Invoke(this, e);
        }

        protected virtual void OnP2YInputChanged(FloatValueEventArgs e)
        {
            EventHandler<FloatValueEventArgs> handler = P2YInputChanged;
            handler?.Invoke(this, e);
        }
        
        protected virtual void OnR1InputChanged(FloatValueEventArgs e)
        {
            EventHandler<FloatValueEventArgs> handler = R1InputChanged;
            handler?.Invoke(this, e);
        }

        protected virtual void OnR2InputChanged(FloatValueEventArgs e)
        {
            EventHandler<FloatValueEventArgs> handler = R2InputChanged;
            handler?.Invoke(this, e);
        }

        protected virtual void OnA1InputChanged(FloatValueEventArgs e)
        {
            EventHandler<FloatValueEventArgs> handler = A1InputChanged;
            handler?.Invoke(this, e);
        }

        protected virtual void OnBorderColorInputChanged(ColorEventArgs e)
        {
            EventHandler<ColorEventArgs> handler = BorderColorInputChanged;
            handler?.Invoke(this, e);
        }

        protected virtual void OnBorderOpacityInputChanged(ByteEventArgs e)
        {
            EventHandler<ByteEventArgs> handler = BorderOpacityInputChanged;
            handler?.Invoke(this, e);
        }

        protected virtual void OnBorderWidthInputChanged(FloatValueEventArgs e)
        {
            EventHandler<FloatValueEventArgs> handler = BorderWidthInputChanged;
            handler?.Invoke(this, e);
        }

        //------------------------------------------------------------------
        // Event Handlers
        //------------------------------------------------------------------
        //-----------p0-----------
        private void pointInputControlP0_XInputChanged(object sender, FloatValueEventArgs e)
        {
            OnP0XInputChanged(e);
        }

        private void pointInputControlP0_YInputChanged(object sender, FloatValueEventArgs e)
        {
            OnP0YInputChanged(e);
        }

        //-----------p1-----------
        private void pointInputControlP1_XInputChanged(object sender, FloatValueEventArgs e)
        {
            OnP1XInputChanged(e);
        }

        private void pointInputControlP1_YInputChanged(object sender, FloatValueEventArgs e)
        {
            OnP1YInputChanged(e);
        }

        //-----------p2-----------
        private void pointInputControlP2_XInputChanged(object sender, FloatValueEventArgs e)
        {
            OnP2XInputChanged(e);
        }

        private void pointInputControlP2_YInputChanged(object sender, FloatValueEventArgs e)
        {
            OnP2YInputChanged(e);
        }

        //-----------r1-----------
        private void distanceInputControlR1_RInputChanged(object sender, FloatValueEventArgs e)
        {
            OnR1InputChanged(e);
        }

        //-----------r2-----------
        private void distanceInputControlR2_RInputChanged(object sender, FloatValueEventArgs e)
        {
            OnR2InputChanged(e);
        }
        //-----------a1-----------
        private void angleInputControlA1_RInputChanged(object sender, FloatValueEventArgs e)
        {
            OnA1InputChanged(e);
        }
        //---------Border---------
        private void borderInputControl_ColorInputChanged(object sender, ColorEventArgs e)
        {
            OnBorderColorInputChanged(e);
        }

        private void borderInputControl_OpacityInputChanged(object sender, ByteEventArgs e)
        {
            OnBorderOpacityInputChanged(e);
        }

        private void borderInputControl_WidthInputChanged(object sender, FloatValueEventArgs e)
        {
            OnBorderWidthInputChanged(e);
        }
    }
}
