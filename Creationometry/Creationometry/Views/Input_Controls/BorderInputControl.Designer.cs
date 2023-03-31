
namespace Creationometry.Views.Input_Controls
{
    partial class BorderInputControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.borderHeader = new System.Windows.Forms.Label();
            this.colorLabel = new System.Windows.Forms.Label();
            this.colorInputBox = new System.Windows.Forms.PictureBox();
            this.opacityLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.opacityInput = new System.Windows.Forms.TextBox();
            this.opacityUnitLabel = new System.Windows.Forms.Label();
            this.widthInput = new System.Windows.Forms.TextBox();
            this.widthUnitLabel = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.colorInputBox)).BeginInit();
            this.SuspendLayout();
            // 
            // borderHeader
            // 
            this.borderHeader.AutoSize = true;
            this.borderHeader.Location = new System.Drawing.Point(0, 0);
            this.borderHeader.Name = "borderHeader";
            this.borderHeader.Size = new System.Drawing.Size(237, 32);
            this.borderHeader.TabIndex = 0;
            this.borderHeader.Text = "Border Properties";
            // 
            // colorLabel
            // 
            this.colorLabel.AutoSize = true;
            this.colorLabel.Location = new System.Drawing.Point(0, 50);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(83, 32);
            this.colorLabel.TabIndex = 1;
            this.colorLabel.Text = "Color";
            // 
            // colorInputBox
            // 
            this.colorInputBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.colorInputBox.Location = new System.Drawing.Point(133, 50);
            this.colorInputBox.Name = "colorInputBox";
            this.colorInputBox.Size = new System.Drawing.Size(40, 40);
            this.colorInputBox.TabIndex = 2;
            this.colorInputBox.TabStop = false;
            this.colorInputBox.Click += new System.EventHandler(this.colorInputBox_Click);
            // 
            // opacityLabel
            // 
            this.opacityLabel.AutoSize = true;
            this.opacityLabel.Location = new System.Drawing.Point(0, 100);
            this.opacityLabel.Name = "opacityLabel";
            this.opacityLabel.Size = new System.Drawing.Size(112, 32);
            this.opacityLabel.TabIndex = 3;
            this.opacityLabel.Text = "Opacity";
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(0, 150);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(88, 32);
            this.widthLabel.TabIndex = 4;
            this.widthLabel.Text = "Width";
            // 
            // opacityInput
            // 
            this.opacityInput.Location = new System.Drawing.Point(133, 97);
            this.opacityInput.Name = "opacityInput";
            this.opacityInput.Size = new System.Drawing.Size(119, 38);
            this.opacityInput.TabIndex = 5;
            this.opacityInput.Leave += new System.EventHandler(this.opacityInput_Leave);
            // 
            // opacityUnitLabel
            // 
            this.opacityUnitLabel.AutoSize = true;
            this.opacityUnitLabel.Location = new System.Drawing.Point(258, 100);
            this.opacityUnitLabel.Name = "opacityUnitLabel";
            this.opacityUnitLabel.Size = new System.Drawing.Size(40, 32);
            this.opacityUnitLabel.TabIndex = 6;
            this.opacityUnitLabel.Text = "%";
            // 
            // widthInput
            // 
            this.widthInput.Location = new System.Drawing.Point(133, 147);
            this.widthInput.Name = "widthInput";
            this.widthInput.Size = new System.Drawing.Size(119, 38);
            this.widthInput.TabIndex = 7;
            this.widthInput.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // widthUnitLabel
            // 
            this.widthUnitLabel.AutoSize = true;
            this.widthUnitLabel.Location = new System.Drawing.Point(258, 150);
            this.widthUnitLabel.Name = "widthUnitLabel";
            this.widthUnitLabel.Size = new System.Drawing.Size(45, 32);
            this.widthUnitLabel.TabIndex = 8;
            this.widthUnitLabel.Text = "px";
            // 
            // BorderInputControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.widthUnitLabel);
            this.Controls.Add(this.widthInput);
            this.Controls.Add(this.opacityUnitLabel);
            this.Controls.Add(this.opacityInput);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.opacityLabel);
            this.Controls.Add(this.colorInputBox);
            this.Controls.Add(this.colorLabel);
            this.Controls.Add(this.borderHeader);
            this.Name = "BorderInputControl";
            this.Size = new System.Drawing.Size(450, 200);
            ((System.ComponentModel.ISupportInitialize)(this.colorInputBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label borderHeader;
        private System.Windows.Forms.Label colorLabel;
        private System.Windows.Forms.PictureBox colorInputBox;
        private System.Windows.Forms.Label opacityLabel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.TextBox opacityInput;
        private System.Windows.Forms.Label opacityUnitLabel;
        private System.Windows.Forms.TextBox widthInput;
        private System.Windows.Forms.Label widthUnitLabel;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}
