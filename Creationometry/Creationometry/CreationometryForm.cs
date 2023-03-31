using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Creationometry.Presenters;


namespace Creationometry
{
    public partial class CreationometryForm : System.Windows.Forms.Form
    {
        // EMMenu Presenter Manager
        EMMenuPresenterManager eMMenuPresenterManager;
        
        // List declaration (Command Pattern: Receiver)
        CanvasElementList elementList;

        // CommandSelector declaration (Command Pattern: Invoker)
        CommandSelector commandSelector;

        // Command declarations (Command Pattern: Concrete Command)
        ICommand canvasColorCommand;
        ICommand addCommand;
        ICommand removeCommand;
        ICommand duplicateCommand;
        ICommand modifyElementCommand;
        ICommand rotateElementCommand;

        // Manager declaration
        DrawManager drawManager;

        // Button visiblity
        private bool circleSublistVisible = false;
        private bool regPolySublistVisible = false;

        bool Move;
        bool Drag;
        System.Drawing.Point lastMouseUp;

        public CreationometryForm()
        {
            InitializeComponent();
            DoubleBuffered = true;
            menuTLP.Parent = backgroundBox;
            resizeObjectToolbox();

            // Instantiate the command selector for the command pattern
            commandSelector = new CommandSelector(undoLabel, redoLabel);

            // Instantiate EMMenu Presenter Manager and Canvas Element List
            eMMenuPresenterManager = new EMMenuPresenterManager(ellipseModMenuView1,
                Canvas, commandSelector);

            // Instantiate the elementList with a reference to the EMMenuPresenterManager and borderPanel
            elementList = new CanvasElementList(eMMenuPresenterManager, borderPanel);

            // Instantiate Command Pattern components
            canvasColorCommand = new CanvasColorCommand(Canvas);
            addCommand = new AddCommand(elementList);
            removeCommand = new RemoveCommand(elementList);
            duplicateCommand = new DuplicateCommand(elementList);
            modifyElementCommand = new ModifyElementCommand(elementList);
            rotateElementCommand = new RotateElementCommand(elementList, inputRotateAngle);

            drawManager = new DrawManager();

            eMMenuPresenterManager.setModifyElementCommand(modifyElementCommand);

            WindowState = FormWindowState.Maximized; // Start program in fullscreen
            ellipseModMenuView1.Height = 800;

            Move = false;
            Drag = false;
            lastMouseUp = new System.Drawing.Point();
        }

        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
            if (Move)
            {
                DesignElement tempElement = elementList.getSelectedElement();
                if (tempElement != null)
                    tempElement.move(lastMouseUp.X, lastMouseUp.Y);
                Move = false;
                Drag = false;
            }
            elementList.showList(e);
        }

        private void CreationometryForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '/')
            {
                if (FormBorderStyle == FormBorderStyle.Sizable)
                {
                    FormBorderStyle = FormBorderStyle.None;
                    WindowState = FormWindowState.Maximized;
                    resizeObjectToolbox();
                }
                else
                {
                    FormBorderStyle = FormBorderStyle.Sizable;
                    WindowState = FormWindowState.Normal;
                    resizeObjectToolbox();
                }
            }
        }

        private void CreationometryForm_ResizeEnd(object sender, EventArgs e)
        {
            resizeObjectToolbox();
        }

        private void resizeObjectToolbox()
        {
            threePanelTLP.ColumnStyles[0].Width = (int)(objectToolboxTLP.Height * 720 / 2000.0);
            // Removed because EMM does not resize --->
            //threePanelTLP.ColumnStyles[2].Width = (int)(objectToolboxTLP.Height * 720 / 2000.0);
            threePanelTLP.PerformLayout();
        }

        private void objectToolboxTLP_MouseLeave(object sender, EventArgs e)
        {
            ellipseButton.Visible = false;
            triangleButton.Visible = false;
            squareButton.Visible = false;
        }

        // OBJECT TOOLBOX VISUALS
        private void hideObjectSublists()
        {
            circleSublistVisible = false;
            regPolySublistVisible = false;
            ellipseButton.Image = Properties.Resources.ot_blank;
            triangleButton.Image = Properties.Resources.ot_blank;
            squareButton.Image = Properties.Resources.ot_blank;
        }

        private void objectToolboxTLP_MouseClick(object sender, MouseEventArgs e)
        {
            hideObjectSublists();
        }

        private void lineButton_MouseEnter(object sender, EventArgs e)
        {
            hideObjectSublists();
            lineButton.Image = Properties.Resources.ot_line_green;
        }

        private void lineButton_MouseLeave(object sender, EventArgs e)
        {
            lineButton.Image = Properties.Resources.ot_line_blue;
        }

        private void circleButton_MouseEnter(object sender, EventArgs e)
        {
            hideObjectSublists();
            circleButton.Image = Properties.Resources.ot_circle_green;
            circleSublistVisible = true;
            ellipseButton.Image = Properties.Resources.ot_ellipse_blue;
        }

        private void circleButton_MouseLeave(object sender, EventArgs e)
        {
            circleButton.Image = Properties.Resources.ot_circle_blue;
        }

        private void regPolyButton_MouseEnter(object sender, EventArgs e)
        {
            hideObjectSublists();
            regPolyButton.Image = Properties.Resources.ot_regpoly_green;
            regPolySublistVisible = true;
            triangleButton.Image = Properties.Resources.ot_triangle_blue;
            squareButton.Image = Properties.Resources.ot_square_blue;
        }

        private void regPolyButton_MouseLeave(object sender, EventArgs e)
        {
            regPolyButton.Image = Properties.Resources.ot_regpoly_blue;
        }

        private void ellipseButton_MouseEnter(object sender, EventArgs e)
        {
            if (circleSublistVisible)
                ellipseButton.Image = Properties.Resources.ot_ellipse_green;
        }

        private void ellipseButton_MouseLeave(object sender, EventArgs e)
        {
            if (circleSublistVisible)
                ellipseButton.Image = Properties.Resources.ot_ellipse_blue;
        }

        private void triangleButton_MouseEnter(object sender, EventArgs e)
        {
            if (regPolySublistVisible)
                triangleButton.Image = Properties.Resources.ot_triangle_green;
        }

        private void triangleButton_MouseLeave(object sender, EventArgs e)
        {
            if (regPolySublistVisible)
                triangleButton.Image = Properties.Resources.ot_triangle_blue;
        }

        private void squareButton_MouseEnter(object sender, EventArgs e)
        {
            if (regPolySublistVisible)
                squareButton.Image = Properties.Resources.ot_square_green;
        }

        private void squareButton_MouseLeave(object sender, EventArgs e)
        {
            if (regPolySublistVisible)
                squareButton.Image = Properties.Resources.ot_square_blue;
        }

        private void fdPolyButton_MouseEnter(object sender, EventArgs e)
        {
            hideObjectSublists();
            fdPolyButton.Image = Properties.Resources.ot_fdpoly_green;
        }

        private void fdPolyButton_MouseLeave(object sender, EventArgs e)
        {
            fdPolyButton.Image = Properties.Resources.ot_fdpoly_blue;
        }

        private void rectilButton_MouseEnter(object sender, EventArgs e)
        {
            hideObjectSublists();
            rectilButton.Image = Properties.Resources.ot_rectil_green;
        }

        private void rectilButton_MouseLeave(object sender, EventArgs e)
        {
            rectilButton.Image = Properties.Resources.ot_rectil_blue;
        }

        private void radialButton_MouseEnter(object sender, EventArgs e)
        {
            hideObjectSublists();
            radialButton.Image = Properties.Resources.ot_radial_green;
        }

        private void radialButton_MouseLeave(object sender, EventArgs e)
        {
            radialButton.Image = Properties.Resources.ot_radial_blue;
        }

        private void textButton_MouseEnter(object sender, EventArgs e)
        {
            hideObjectSublists();
            textButton.Image = Properties.Resources.ot_text_green;
        }

        private void textButton_MouseLeave(object sender, EventArgs e)
        {
            textButton.Image = Properties.Resources.ot_text_blue;
        }

        private void imageButton_MouseEnter(object sender, EventArgs e)
        {
            hideObjectSublists();
            imageButton.Image = Properties.Resources.ot_image_green;
        }

        private void imageButton_MouseLeave(object sender, EventArgs e)
        {
            imageButton.Image = Properties.Resources.ot_image_blue;
        }

        //----------------------------------------------------------------------------------------
        //
        //---------------------------- Start of Event Hanlders -----------------------------------
        //
        //----------------------------------------------------------------------------------------

        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            // Hide the error message after clicking off the element
            errorMessageForWeight.Visible = false;

            // Update the boolean for moving an element
            if (elementList.getSelectedElement() != null)
                Drag = true;

            // Clear the previous selection and try to select a new element
            elementList.clearSelection();
            elementList.selectElement(e.X, e.Y);

            // Add a point for free drawing
            drawManager.addPoint(e.X, e.Y);
            Canvas.Refresh();
        }

        private void canvasColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Update the canvas background color
            commandSelector.setCommand(canvasColorCommand);
            commandSelector.doAction();
            Canvas.Refresh();
        }

        private void circleButton_Click(object sender, EventArgs e)
        {
            // Create a circle
            commandSelector.setCommand(addCommand);
            commandSelector.doAction(DesignElementTypes.CIRCLE);
            Canvas.Refresh();
        }

        private void ellipseButton_Click(object sender, EventArgs e)
        {
            // Create an ellipse
            commandSelector.setCommand(addCommand);
            commandSelector.doAction(DesignElementTypes.ELLIPSE);
            Canvas.Refresh();
        }

        private void lineButton_MouseClick(object sender, MouseEventArgs e)
        {
            // Create a Line
            commandSelector.setCommand(addCommand);
            commandSelector.doAction(DesignElementTypes.LINE);
            Canvas.Refresh();
        }

        private void regPolyButton_Click(object sender, EventArgs e)
        {
            // Create a Polygon
            commandSelector.setCommand(addCommand);
            commandSelector.doAction(DesignElementTypes.REG_POLYGON);
            Canvas.Refresh();
        }

        private void triangleButton_Click_1(object sender, EventArgs e)
        {
            // Create a Triangle
            commandSelector.setCommand(addCommand);
            commandSelector.doAction(DesignElementTypes.TRIANGLE);
            Canvas.Refresh();
        }

        private void squareButton_Click(object sender, EventArgs e)
        {
            // Create a Square
            commandSelector.setCommand(addCommand);
            commandSelector.doAction(DesignElementTypes.RECTANGLE);
            Canvas.Refresh();
        }

        private void duplicateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Duplicate the element if it is selected
            if (elementList.getSelectedElement() != null)
            {
                commandSelector.setCommand(duplicateCommand);
                commandSelector.doAction();
            }
            Canvas.Refresh();
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Remove an element
            commandSelector.setCommand(removeCommand);
            commandSelector.doAction();
            elementList.clearSelection();
            Canvas.Refresh();
        }

        private void deselectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Deselect all elements
            elementList.clearSelection();
            Canvas.Refresh();
        }

        private void fdPolyButton_Click(object sender, EventArgs e)
        {
            drawManager.drawPolygon();
            if (!drawManager.getIsDrawing())
            {
                // Create the free drawn poloygon after all points have been determined
                commandSelector.setCommand(addCommand);
                commandSelector.doAction(DesignElementTypes.DRAWN_POLYGON, drawManager.getPoints());
            }
            Canvas.Refresh();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Undo the previous action
            commandSelector.undoAction();
            Canvas.Refresh();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Redo the previous action
            commandSelector.redoAction();
            Canvas.Refresh();
        }

        private void CreationometryForm_KeyDown(object sender, KeyEventArgs e)
        {
            // Keyboard Shortcuts for calling specific event handlers
            if (e.Control && e.KeyCode == Keys.X)
                removeToolStripMenuItem_Click(sender, e);
            else if (e.Control && e.KeyCode == Keys.D)
                duplicateToolStripMenuItem_Click(sender, e);
            else if (e.Control && e.KeyCode == Keys.Z)
                undoToolStripMenuItem_Click(sender, e);
            else if (e.Control && e.KeyCode == Keys.Y)
            {
                // Eliminate "Ding" sound when pressing shortcut for redo
                e.SuppressKeyPress = true;
                redoToolStripMenuItem_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                // Eliminate "Ding" sound when pressing shortcut for escape
                e.SuppressKeyPress = true;
                deselectToolStripMenuItem_Click(sender, e);
                rotatePanel.Visible = false;
            }
        }

        private void changeColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorPicker = new ColorDialog();
            if (colorPicker.ShowDialog() == DialogResult.OK)
            {
                DesignElement temp = elementList.getSelectedElement();
                if (temp != null)
                    temp.changeColor(colorPicker.Color);
            }
            elementList.clearSelection();
            Canvas.Refresh();
        }

        private void changeWeight_Click(object sender, EventArgs e)
        {
            DesignElement temp = elementList.getSelectedElement();
            if (temp != null)
                if (temp.changeWeight(inputChangeWeight, errorMessageForWeight))
                    elementList.clearSelection();
            Canvas.Refresh();
        }

        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            // Displays the X and Y Coordinates of the Mouse as it moves on the Canvas
            label3.Text = "X:" + e.X;
            label4.Text = "Y:" + e.Y;
        }

        private void rotateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rotatePanel.Visible = true;
        }

        private void changeRotation_Click(object sender, EventArgs e)
        {
            rotatePanel.Visible = false;
         
            // Rotate an element
            commandSelector.setCommand(rotateElementCommand);
            commandSelector.doAction();
            elementList.clearSelection();
            Canvas.Refresh();
        }

        private void Canvas_MouseUp(object sender, MouseEventArgs e)
        {
            rotatePanel.Visible = false;

            if (Drag)
            {
                Move = true;
                lastMouseUp.X = e.X;
                lastMouseUp.Y = e.Y;
                Drag = false;
                Canvas.Invalidate();
            }
        }

        private void inputRotateAngle_KeyPress(object sender, KeyPressEventArgs e)
        {
            // The user is only able to input digit, period, minus,
            // and backward keyboard.
            char ch = e.KeyChar;
            if (ch == 46 && inputChangeWeight.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }

            if (!Char.IsDigit(ch) && ch != 8 && ch != 45 && ch != 46)
                e.Handled = true;
        }

        private void inputChangeWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            // The user is only able to input digit, period, and backward keyboard.
            char ch = e.KeyChar;
            if (ch == 46 && inputChangeWeight.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
                e.Handled = true;
        }
    }
}