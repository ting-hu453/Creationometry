
namespace EMMenuControls
{
    partial class PointInput
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
            this.pointName = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.inputX = new System.Windows.Forms.TextBox();
            this.labelY = new System.Windows.Forms.Label();
            this.inputY = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pointName
            // 
            this.pointName.AutoSize = true;
            this.pointName.Location = new System.Drawing.Point(3, 0);
            this.pointName.Name = "pointName";
            this.pointName.Size = new System.Drawing.Size(86, 32);
            this.pointName.TabIndex = 0;
            this.pointName.Text = "name";
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(95, 0);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(29, 32);
            this.labelX.TabIndex = 1;
            this.labelX.Text = "x";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.pointName);
            this.flowLayoutPanel1.Controls.Add(this.labelX);
            this.flowLayoutPanel1.Controls.Add(this.inputX);
            this.flowLayoutPanel1.Controls.Add(this.labelY);
            this.flowLayoutPanel1.Controls.Add(this.inputY);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(541, 64);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // inputX
            // 
            this.inputX.Location = new System.Drawing.Point(130, 3);
            this.inputX.Name = "inputX";
            this.inputX.Size = new System.Drawing.Size(100, 38);
            this.inputX.TabIndex = 2;
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Location = new System.Drawing.Point(236, 0);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(29, 32);
            this.labelY.TabIndex = 3;
            this.labelY.Text = "y";
            // 
            // inputY
            // 
            this.inputY.Location = new System.Drawing.Point(271, 3);
            this.inputY.Name = "inputY";
            this.inputY.Size = new System.Drawing.Size(100, 38);
            this.inputY.TabIndex = 4;
            // 
            // PointInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "PointInput";
            this.Size = new System.Drawing.Size(541, 64);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label pointName;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox inputX;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.TextBox inputY;
    }
}
