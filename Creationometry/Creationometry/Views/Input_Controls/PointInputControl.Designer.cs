
namespace Creationometry.Views.Input_Controls
{
    partial class PointInputControl
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
            this.pointNameLabel = new System.Windows.Forms.Label();
            this.xLabel = new System.Windows.Forms.Label();
            this.xInput = new System.Windows.Forms.TextBox();
            this.yLabel = new System.Windows.Forms.Label();
            this.yInput = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pointNameLabel
            // 
            this.pointNameLabel.AutoSize = true;
            this.pointNameLabel.Location = new System.Drawing.Point(3, 0);
            this.pointNameLabel.Name = "pointNameLabel";
            this.pointNameLabel.Size = new System.Drawing.Size(47, 32);
            this.pointNameLabel.TabIndex = 0;
            this.pointNameLabel.Text = "p1";
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Location = new System.Drawing.Point(83, 0);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(43, 32);
            this.xLabel.TabIndex = 3;
            this.xLabel.Text = "  x";
            // 
            // xInput
            // 
            this.xInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xInput.Location = new System.Drawing.Point(133, 3);
            this.xInput.Name = "xInput";
            this.xInput.Size = new System.Drawing.Size(119, 38);
            this.xInput.TabIndex = 1;
            this.xInput.Leave += new System.EventHandler(this.xInput_Leave);
            // 
            // yLabel
            // 
            this.yLabel.AutoSize = true;
            this.yLabel.Location = new System.Drawing.Point(258, 0);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(43, 32);
            this.yLabel.TabIndex = 4;
            this.yLabel.Text = "  y";
            // 
            // yInput
            // 
            this.yInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.yInput.Location = new System.Drawing.Point(308, 3);
            this.yInput.Name = "yInput";
            this.yInput.Size = new System.Drawing.Size(119, 38);
            this.yInput.TabIndex = 2;
            this.yInput.Leave += new System.EventHandler(this.yInput_Leave);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.yLabel, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.xInput, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.yInput, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.xLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pointNameLabel, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(450, 50);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // PointInputControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PointInputControl";
            this.Size = new System.Drawing.Size(450, 50);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label pointNameLabel;
        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.TextBox xInput;
        private System.Windows.Forms.Label yLabel;
        private System.Windows.Forms.TextBox yInput;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
