using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Creationometry.Views.Input_Controls;

namespace Creationometry.Views.EMMenu
{
    public interface IEllipseModMenuView
    {
        event EventHandler<FloatValueEventArgs> P0XInputChanged;
        event EventHandler<FloatValueEventArgs> P0YInputChanged;
        event EventHandler<FloatValueEventArgs> P1XInputChanged;
        event EventHandler<FloatValueEventArgs> P1YInputChanged;
        event EventHandler<FloatValueEventArgs> P2XInputChanged;
        event EventHandler<FloatValueEventArgs> P2YInputChanged;
        event EventHandler<FloatValueEventArgs> R1InputChanged;
        event EventHandler<FloatValueEventArgs> R2InputChanged;
        event EventHandler<FloatValueEventArgs> A1InputChanged;
        event EventHandler<ColorEventArgs> BorderColorInputChanged;
        event EventHandler<ByteEventArgs> BorderOpacityInputChanged;
        event EventHandler<FloatValueEventArgs> BorderWidthInputChanged;
        void showView();
        void hideView();
        void setP0XInputValue(float value);
        void setP0YInputValue(float value);
        void setP1XInputValue(float value);
        void setP1YInputValue(float value);
        void setP2XInputValue(float value);
        void setP2YInputValue(float value);
        void setR1InputValue(float value);
        void setR2InputValue(float value);
        void setA1InputValue(float value);
        void setBorderColorInputBackColor(Color color);
        void setBorderOpacityInputValue(float value);
        void setBorderWidthInputValue(float value);
    }
}
