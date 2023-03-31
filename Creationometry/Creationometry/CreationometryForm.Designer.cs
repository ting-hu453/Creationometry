
namespace Creationometry
{
    partial class CreationometryForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreationometryForm));
            this.Canvas = new System.Windows.Forms.Panel();
            this.changeColor = new System.Windows.Forms.Button();
            this.errorMessageForWeight = new System.Windows.Forms.Label();
            this.changeWeight = new System.Windows.Forms.Button();
            this.inputChangeWeight = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.redoLabel = new System.Windows.Forms.Label();
            this.undoLabel = new System.Windows.Forms.Label();
            this.canvasColorSelection = new System.Windows.Forms.ColorDialog();
            this.menuTLP = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetZoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.duplicateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deselectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.canvasColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.threePanelTLP = new System.Windows.Forms.TableLayoutPanel();
            this.objectToolboxTLP = new System.Windows.Forms.TableLayoutPanel();
            this.lineButton = new System.Windows.Forms.PictureBox();
            this.circleButton = new System.Windows.Forms.PictureBox();
            this.ellipseButton = new System.Windows.Forms.PictureBox();
            this.regPolyButton = new System.Windows.Forms.PictureBox();
            this.triangleButton = new System.Windows.Forms.PictureBox();
            this.squareButton = new System.Windows.Forms.PictureBox();
            this.fdPolyButton = new System.Windows.Forms.PictureBox();
            this.rectilButton = new System.Windows.Forms.PictureBox();
            this.radialButton = new System.Windows.Forms.PictureBox();
            this.textButton = new System.Windows.Forms.PictureBox();
            this.imageButton = new System.Windows.Forms.PictureBox();
            this.EMMenuFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ellipseModMenuView1 = new Creationometry.Views.EMMenu.EllipseModMenuView();
            this.rotatePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.inputRotateAngle = new System.Windows.Forms.TextBox();
            this.changeRotation = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.borderPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.backgroundBox = new System.Windows.Forms.PictureBox();
            this.scaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTLP.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.threePanelTLP.SuspendLayout();
            this.objectToolboxTLP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lineButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circleButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ellipseButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regPolyButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.triangleButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.squareButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fdPolyButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rectilButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radialButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageButton)).BeginInit();
            this.EMMenuFlowLayoutPanel.SuspendLayout();
            this.rotatePanel.SuspendLayout();
            this.borderPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Canvas
            // 
            this.Canvas.BackColor = System.Drawing.Color.White;
            this.Canvas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Canvas.Location = new System.Drawing.Point(138, 5);
            this.Canvas.Margin = new System.Windows.Forms.Padding(5);
            this.Canvas.Name = "Canvas";
            this.Canvas.Size = new System.Drawing.Size(1053, 590);
            this.Canvas.TabIndex = 1;
            this.Canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.Canvas_Paint);
            this.Canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseDown);
            this.Canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseMove);
            this.Canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseUp);
            // 
            // changeColor
            // 
            this.changeColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.changeColor.Location = new System.Drawing.Point(4, 98);
            this.changeColor.Margin = new System.Windows.Forms.Padding(4);
            this.changeColor.Name = "changeColor";
            this.changeColor.Size = new System.Drawing.Size(136, 28);
            this.changeColor.TabIndex = 0;
            this.changeColor.Text = "Change Color";
            this.changeColor.UseVisualStyleBackColor = true;
            this.changeColor.Click += new System.EventHandler(this.changeColor_Click);
            // 
            // errorMessageForWeight
            // 
            this.errorMessageForWeight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.errorMessageForWeight.AutoSize = true;
            this.errorMessageForWeight.Location = new System.Drawing.Point(4, 30);
            this.errorMessageForWeight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.errorMessageForWeight.Name = "errorMessageForWeight";
            this.errorMessageForWeight.Size = new System.Drawing.Size(205, 17);
            this.errorMessageForWeight.TabIndex = 4;
            this.errorMessageForWeight.Text = "Please input a positive number!";
            this.errorMessageForWeight.Visible = false;
            // 
            // changeWeight
            // 
            this.changeWeight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.changeWeight.Location = new System.Drawing.Point(4, 51);
            this.changeWeight.Margin = new System.Windows.Forms.Padding(4);
            this.changeWeight.Name = "changeWeight";
            this.changeWeight.Size = new System.Drawing.Size(169, 39);
            this.changeWeight.TabIndex = 3;
            this.changeWeight.Text = "Change Border Weight";
            this.changeWeight.UseVisualStyleBackColor = true;
            this.changeWeight.Click += new System.EventHandler(this.changeWeight_Click);
            // 
            // inputChangeWeight
            // 
            this.inputChangeWeight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.inputChangeWeight.Location = new System.Drawing.Point(4, 4);
            this.inputChangeWeight.Margin = new System.Windows.Forms.Padding(4);
            this.inputChangeWeight.Name = "inputChangeWeight";
            this.inputChangeWeight.Size = new System.Drawing.Size(68, 22);
            this.inputChangeWeight.TabIndex = 2;
            this.inputChangeWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputChangeWeight_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "X:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Y:";
            // 
            // redoLabel
            // 
            this.redoLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.redoLabel.AutoSize = true;
            this.redoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redoLabel.Location = new System.Drawing.Point(4, 0);
            this.redoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.redoLabel.Name = "redoLabel";
            this.redoLabel.Size = new System.Drawing.Size(126, 17);
            this.redoLabel.TabIndex = 1;
            this.redoLabel.Text = "Redo: No Action";
            // 
            // undoLabel
            // 
            this.undoLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.undoLabel.AutoSize = true;
            this.undoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.undoLabel.Location = new System.Drawing.Point(392, 0);
            this.undoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.undoLabel.Name = "undoLabel";
            this.undoLabel.Size = new System.Drawing.Size(126, 17);
            this.undoLabel.TabIndex = 0;
            this.undoLabel.Text = "Undo: No Action";
            // 
            // canvasColorSelection
            // 
            this.canvasColorSelection.Color = System.Drawing.Color.White;
            // 
            // menuTLP
            // 
            this.menuTLP.BackColor = System.Drawing.Color.Transparent;
            this.menuTLP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuTLP.ColumnCount = 1;
            this.menuTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.menuTLP.Controls.Add(this.menuStrip1, 0, 0);
            this.menuTLP.Controls.Add(this.threePanelTLP, 0, 1);
            this.menuTLP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuTLP.Location = new System.Drawing.Point(0, 0);
            this.menuTLP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.menuTLP.Name = "menuTLP";
            this.menuTLP.RowCount = 3;
            this.menuTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.menuTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.menuTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.menuTLP.Size = new System.Drawing.Size(1429, 694);
            this.menuTLP.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.canvasColorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1429, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.importImageToolStripMenuItem,
            this.exportToolStripMenuItem});
            this.fileToolStripMenuItem.Enabled = false;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // importImageToolStripMenuItem
            // 
            this.importImageToolStripMenuItem.Name = "importImageToolStripMenuItem";
            this.importImageToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.importImageToolStripMenuItem.Text = "Import Image";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.undoToolStripMenuItem.Text = "Undo (Ctrl + z)";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.redoToolStripMenuItem.Text = "Redo (Ctrl+ y)";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetZoomToolStripMenuItem,
            this.scaleToolStripMenuItem});
            this.viewToolStripMenuItem.Enabled = false;
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // resetZoomToolStripMenuItem
            // 
            this.resetZoomToolStripMenuItem.Name = "resetZoomToolStripMenuItem";
            this.resetZoomToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.resetZoomToolStripMenuItem.Text = "Reset Zoom";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeToolStripMenuItem,
            this.duplicateToolStripMenuItem,
            this.deselectToolStripMenuItem,
            this.rotateToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.removeToolStripMenuItem.Text = "Remove (Ctrl + x)";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // duplicateToolStripMenuItem
            // 
            this.duplicateToolStripMenuItem.Name = "duplicateToolStripMenuItem";
            this.duplicateToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.duplicateToolStripMenuItem.Text = "Duplicate (Ctrl + d)";
            this.duplicateToolStripMenuItem.Click += new System.EventHandler(this.duplicateToolStripMenuItem_Click);
            // 
            // deselectToolStripMenuItem
            // 
            this.deselectToolStripMenuItem.Name = "deselectToolStripMenuItem";
            this.deselectToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.deselectToolStripMenuItem.Text = "Deselect (esc)";
            this.deselectToolStripMenuItem.Click += new System.EventHandler(this.deselectToolStripMenuItem_Click);
            // 
            // rotateToolStripMenuItem
            // 
            this.rotateToolStripMenuItem.Name = "rotateToolStripMenuItem";
            this.rotateToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.rotateToolStripMenuItem.Text = "Rotate";
            this.rotateToolStripMenuItem.Click += new System.EventHandler(this.rotateToolStripMenuItem_Click);
            // 
            // canvasColorToolStripMenuItem
            // 
            this.canvasColorToolStripMenuItem.Name = "canvasColorToolStripMenuItem";
            this.canvasColorToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            this.canvasColorToolStripMenuItem.Text = "Canvas Color";
            this.canvasColorToolStripMenuItem.Click += new System.EventHandler(this.canvasColorToolStripMenuItem_Click);
            // 
            // threePanelTLP
            // 
            this.threePanelTLP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.threePanelTLP.ColumnCount = 3;
            this.threePanelTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 133F));
            this.threePanelTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.threePanelTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 227F));
            this.threePanelTLP.Controls.Add(this.objectToolboxTLP, 0, 0);
            this.threePanelTLP.Controls.Add(this.Canvas, 1, 0);
            this.threePanelTLP.Controls.Add(this.EMMenuFlowLayoutPanel, 2, 0);
            this.threePanelTLP.Controls.Add(this.tableLayoutPanel1, 2, 1);
            this.threePanelTLP.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.threePanelTLP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.threePanelTLP.Location = new System.Drawing.Point(3, 57);
            this.threePanelTLP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.threePanelTLP.Name = "threePanelTLP";
            this.threePanelTLP.RowCount = 2;
            this.threePanelTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.threePanelTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.threePanelTLP.Size = new System.Drawing.Size(1423, 630);
            this.threePanelTLP.TabIndex = 1;
            // 
            // objectToolboxTLP
            // 
            this.objectToolboxTLP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.objectToolboxTLP.ColumnCount = 6;
            this.objectToolboxTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.5F));
            this.objectToolboxTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.8F));
            this.objectToolboxTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.5F));
            this.objectToolboxTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.8F));
            this.objectToolboxTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.5F));
            this.objectToolboxTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.9F));
            this.objectToolboxTLP.Controls.Add(this.lineButton, 1, 1);
            this.objectToolboxTLP.Controls.Add(this.circleButton, 1, 3);
            this.objectToolboxTLP.Controls.Add(this.ellipseButton, 3, 3);
            this.objectToolboxTLP.Controls.Add(this.regPolyButton, 1, 5);
            this.objectToolboxTLP.Controls.Add(this.triangleButton, 3, 5);
            this.objectToolboxTLP.Controls.Add(this.squareButton, 5, 5);
            this.objectToolboxTLP.Controls.Add(this.fdPolyButton, 1, 7);
            this.objectToolboxTLP.Controls.Add(this.rectilButton, 1, 9);
            this.objectToolboxTLP.Controls.Add(this.radialButton, 1, 11);
            this.objectToolboxTLP.Controls.Add(this.textButton, 1, 13);
            this.objectToolboxTLP.Controls.Add(this.imageButton, 1, 15);
            this.objectToolboxTLP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.objectToolboxTLP.Location = new System.Drawing.Point(3, 2);
            this.objectToolboxTLP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.objectToolboxTLP.Name = "objectToolboxTLP";
            this.objectToolboxTLP.RowCount = 17;
            this.objectToolboxTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.objectToolboxTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.objectToolboxTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.objectToolboxTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.objectToolboxTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.objectToolboxTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.objectToolboxTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.objectToolboxTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.objectToolboxTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.objectToolboxTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.objectToolboxTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.objectToolboxTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.objectToolboxTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.objectToolboxTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.objectToolboxTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.objectToolboxTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.objectToolboxTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.objectToolboxTLP.Size = new System.Drawing.Size(127, 596);
            this.objectToolboxTLP.TabIndex = 0;
            this.objectToolboxTLP.MouseClick += new System.Windows.Forms.MouseEventHandler(this.objectToolboxTLP_MouseClick);
            // 
            // lineButton
            // 
            this.lineButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.lineButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lineButton.Image = ((System.Drawing.Image)(resources.GetObject("lineButton.Image")));
            this.lineButton.Location = new System.Drawing.Point(6, 17);
            this.lineButton.Margin = new System.Windows.Forms.Padding(0);
            this.lineButton.Name = "lineButton";
            this.lineButton.Size = new System.Drawing.Size(35, 59);
            this.lineButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.lineButton.TabIndex = 0;
            this.lineButton.TabStop = false;
            this.lineButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lineButton_MouseClick);
            this.lineButton.MouseEnter += new System.EventHandler(this.lineButton_MouseEnter);
            this.lineButton.MouseLeave += new System.EventHandler(this.lineButton_MouseLeave);
            // 
            // circleButton
            // 
            this.circleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.circleButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.circleButton.Image = ((System.Drawing.Image)(resources.GetObject("circleButton.Image")));
            this.circleButton.Location = new System.Drawing.Point(6, 87);
            this.circleButton.Margin = new System.Windows.Forms.Padding(0);
            this.circleButton.Name = "circleButton";
            this.circleButton.Size = new System.Drawing.Size(35, 59);
            this.circleButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.circleButton.TabIndex = 1;
            this.circleButton.TabStop = false;
            this.circleButton.Click += new System.EventHandler(this.circleButton_Click);
            this.circleButton.MouseEnter += new System.EventHandler(this.circleButton_MouseEnter);
            this.circleButton.MouseLeave += new System.EventHandler(this.circleButton_MouseLeave);
            // 
            // ellipseButton
            // 
            this.ellipseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ellipseButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ellipseButton.Image = ((System.Drawing.Image)(resources.GetObject("ellipseButton.Image")));
            this.ellipseButton.Location = new System.Drawing.Point(47, 87);
            this.ellipseButton.Margin = new System.Windows.Forms.Padding(0);
            this.ellipseButton.Name = "ellipseButton";
            this.ellipseButton.Size = new System.Drawing.Size(35, 59);
            this.ellipseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ellipseButton.TabIndex = 2;
            this.ellipseButton.TabStop = false;
            this.ellipseButton.Click += new System.EventHandler(this.ellipseButton_Click);
            this.ellipseButton.MouseEnter += new System.EventHandler(this.ellipseButton_MouseEnter);
            this.ellipseButton.MouseLeave += new System.EventHandler(this.ellipseButton_MouseLeave);
            // 
            // regPolyButton
            // 
            this.regPolyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.regPolyButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.regPolyButton.Image = ((System.Drawing.Image)(resources.GetObject("regPolyButton.Image")));
            this.regPolyButton.Location = new System.Drawing.Point(6, 157);
            this.regPolyButton.Margin = new System.Windows.Forms.Padding(0);
            this.regPolyButton.Name = "regPolyButton";
            this.regPolyButton.Size = new System.Drawing.Size(35, 59);
            this.regPolyButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.regPolyButton.TabIndex = 3;
            this.regPolyButton.TabStop = false;
            this.regPolyButton.Click += new System.EventHandler(this.regPolyButton_Click);
            this.regPolyButton.MouseEnter += new System.EventHandler(this.regPolyButton_MouseEnter);
            this.regPolyButton.MouseLeave += new System.EventHandler(this.regPolyButton_MouseLeave);
            // 
            // triangleButton
            // 
            this.triangleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.triangleButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.triangleButton.Image = ((System.Drawing.Image)(resources.GetObject("triangleButton.Image")));
            this.triangleButton.Location = new System.Drawing.Point(47, 157);
            this.triangleButton.Margin = new System.Windows.Forms.Padding(0);
            this.triangleButton.Name = "triangleButton";
            this.triangleButton.Size = new System.Drawing.Size(35, 59);
            this.triangleButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.triangleButton.TabIndex = 4;
            this.triangleButton.TabStop = false;
            this.triangleButton.Click += new System.EventHandler(this.triangleButton_Click_1);
            this.triangleButton.MouseEnter += new System.EventHandler(this.triangleButton_MouseEnter);
            this.triangleButton.MouseLeave += new System.EventHandler(this.triangleButton_MouseLeave);
            // 
            // squareButton
            // 
            this.squareButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.squareButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.squareButton.Image = ((System.Drawing.Image)(resources.GetObject("squareButton.Image")));
            this.squareButton.Location = new System.Drawing.Point(88, 157);
            this.squareButton.Margin = new System.Windows.Forms.Padding(0);
            this.squareButton.Name = "squareButton";
            this.squareButton.Size = new System.Drawing.Size(39, 59);
            this.squareButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.squareButton.TabIndex = 5;
            this.squareButton.TabStop = false;
            this.squareButton.Click += new System.EventHandler(this.squareButton_Click);
            this.squareButton.MouseEnter += new System.EventHandler(this.squareButton_MouseEnter);
            this.squareButton.MouseLeave += new System.EventHandler(this.squareButton_MouseLeave);
            // 
            // fdPolyButton
            // 
            this.fdPolyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.fdPolyButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fdPolyButton.Image = ((System.Drawing.Image)(resources.GetObject("fdPolyButton.Image")));
            this.fdPolyButton.Location = new System.Drawing.Point(6, 227);
            this.fdPolyButton.Margin = new System.Windows.Forms.Padding(0);
            this.fdPolyButton.Name = "fdPolyButton";
            this.fdPolyButton.Size = new System.Drawing.Size(35, 59);
            this.fdPolyButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fdPolyButton.TabIndex = 6;
            this.fdPolyButton.TabStop = false;
            this.fdPolyButton.Click += new System.EventHandler(this.fdPolyButton_Click);
            this.fdPolyButton.MouseEnter += new System.EventHandler(this.fdPolyButton_MouseEnter);
            this.fdPolyButton.MouseLeave += new System.EventHandler(this.fdPolyButton_MouseLeave);
            // 
            // rectilButton
            // 
            this.rectilButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.rectilButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rectilButton.Image = ((System.Drawing.Image)(resources.GetObject("rectilButton.Image")));
            this.rectilButton.Location = new System.Drawing.Point(6, 297);
            this.rectilButton.Margin = new System.Windows.Forms.Padding(0);
            this.rectilButton.Name = "rectilButton";
            this.rectilButton.Size = new System.Drawing.Size(35, 59);
            this.rectilButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rectilButton.TabIndex = 7;
            this.rectilButton.TabStop = false;
            this.rectilButton.MouseEnter += new System.EventHandler(this.rectilButton_MouseEnter);
            this.rectilButton.MouseLeave += new System.EventHandler(this.rectilButton_MouseLeave);
            // 
            // radialButton
            // 
            this.radialButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.radialButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radialButton.Image = ((System.Drawing.Image)(resources.GetObject("radialButton.Image")));
            this.radialButton.Location = new System.Drawing.Point(6, 367);
            this.radialButton.Margin = new System.Windows.Forms.Padding(0);
            this.radialButton.Name = "radialButton";
            this.radialButton.Size = new System.Drawing.Size(35, 59);
            this.radialButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.radialButton.TabIndex = 8;
            this.radialButton.TabStop = false;
            this.radialButton.MouseEnter += new System.EventHandler(this.radialButton_MouseEnter);
            this.radialButton.MouseLeave += new System.EventHandler(this.radialButton_MouseLeave);
            // 
            // textButton
            // 
            this.textButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.textButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textButton.Image = ((System.Drawing.Image)(resources.GetObject("textButton.Image")));
            this.textButton.Location = new System.Drawing.Point(6, 437);
            this.textButton.Margin = new System.Windows.Forms.Padding(0);
            this.textButton.Name = "textButton";
            this.textButton.Size = new System.Drawing.Size(35, 59);
            this.textButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.textButton.TabIndex = 9;
            this.textButton.TabStop = false;
            this.textButton.MouseEnter += new System.EventHandler(this.textButton_MouseEnter);
            this.textButton.MouseLeave += new System.EventHandler(this.textButton_MouseLeave);
            // 
            // imageButton
            // 
            this.imageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.imageButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageButton.Image = ((System.Drawing.Image)(resources.GetObject("imageButton.Image")));
            this.imageButton.Location = new System.Drawing.Point(6, 507);
            this.imageButton.Margin = new System.Windows.Forms.Padding(0);
            this.imageButton.Name = "imageButton";
            this.imageButton.Size = new System.Drawing.Size(35, 59);
            this.imageButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageButton.TabIndex = 10;
            this.imageButton.TabStop = false;
            this.imageButton.MouseEnter += new System.EventHandler(this.imageButton_MouseEnter);
            this.imageButton.MouseLeave += new System.EventHandler(this.imageButton_MouseLeave);
            // 
            // EMMenuFlowLayoutPanel
            // 
            this.EMMenuFlowLayoutPanel.Controls.Add(this.ellipseModMenuView1);
            this.EMMenuFlowLayoutPanel.Controls.Add(this.rotatePanel);
            this.EMMenuFlowLayoutPanel.Controls.Add(this.borderPanel);
            this.EMMenuFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EMMenuFlowLayoutPanel.Location = new System.Drawing.Point(1196, 0);
            this.EMMenuFlowLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.EMMenuFlowLayoutPanel.Name = "EMMenuFlowLayoutPanel";
            this.EMMenuFlowLayoutPanel.Size = new System.Drawing.Size(227, 600);
            this.EMMenuFlowLayoutPanel.TabIndex = 2;
            // 
            // ellipseModMenuView1
            // 
            this.ellipseModMenuView1.BackColor = System.Drawing.SystemColors.Control;
            this.ellipseModMenuView1.Location = new System.Drawing.Point(0, 0);
            this.ellipseModMenuView1.Margin = new System.Windows.Forms.Padding(0);
            this.ellipseModMenuView1.Name = "ellipseModMenuView1";
            this.ellipseModMenuView1.Size = new System.Drawing.Size(221, 258);
            this.ellipseModMenuView1.TabIndex = 0;
            // 
            // rotatePanel
            // 
            this.rotatePanel.Controls.Add(this.inputRotateAngle);
            this.rotatePanel.Controls.Add(this.changeRotation);
            this.rotatePanel.Controls.Add(this.label1);
            this.rotatePanel.Controls.Add(this.panel2);
            this.rotatePanel.Controls.Add(this.panel1);
            this.rotatePanel.Location = new System.Drawing.Point(4, 262);
            this.rotatePanel.Margin = new System.Windows.Forms.Padding(4);
            this.rotatePanel.Name = "rotatePanel";
            this.rotatePanel.Size = new System.Drawing.Size(217, 68);
            this.rotatePanel.TabIndex = 0;
            this.rotatePanel.Visible = false;
            // 
            // inputRotateAngle
            // 
            this.inputRotateAngle.Location = new System.Drawing.Point(4, 4);
            this.inputRotateAngle.Margin = new System.Windows.Forms.Padding(4);
            this.inputRotateAngle.Name = "inputRotateAngle";
            this.inputRotateAngle.Size = new System.Drawing.Size(97, 22);
            this.inputRotateAngle.TabIndex = 1;
            this.inputRotateAngle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputRotateAngle_KeyPress);
            // 
            // changeRotation
            // 
            this.changeRotation.Location = new System.Drawing.Point(109, 4);
            this.changeRotation.Margin = new System.Windows.Forms.Padding(4);
            this.changeRotation.Name = "changeRotation";
            this.changeRotation.Size = new System.Drawing.Size(96, 28);
            this.changeRotation.TabIndex = 2;
            this.changeRotation.Text = "Rotate";
            this.changeRotation.UseVisualStyleBackColor = true;
            this.changeRotation.Click += new System.EventHandler(this.changeRotation_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Please input an integer!";
            this.label1.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(4, 57);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(212, 0);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 65);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(213, 0);
            this.panel1.TabIndex = 0;
            // 
            // borderPanel
            // 
            this.borderPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.borderPanel.Controls.Add(this.inputChangeWeight);
            this.borderPanel.Controls.Add(this.errorMessageForWeight);
            this.borderPanel.Controls.Add(this.changeWeight);
            this.borderPanel.Controls.Add(this.changeColor);
            this.borderPanel.Location = new System.Drawing.Point(4, 338);
            this.borderPanel.Margin = new System.Windows.Forms.Padding(4);
            this.borderPanel.Name = "borderPanel";
            this.borderPanel.Size = new System.Drawing.Size(223, 162);
            this.borderPanel.TabIndex = 1;
            this.borderPanel.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1199, 602);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(219, 25);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 2);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(103, 18);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.label4);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(112, 2);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(104, 18);
            this.flowLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel4, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(136, 602);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1057, 26);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel2.Controls.Add(this.undoLabel);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 2);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(522, 22);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel4.Controls.Add(this.redoLabel);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(531, 2);
            this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(523, 22);
            this.flowLayoutPanel4.TabIndex = 1;
            // 
            // backgroundBox
            // 
            this.backgroundBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backgroundBox.Image = ((System.Drawing.Image)(resources.GetObject("backgroundBox.Image")));
            this.backgroundBox.Location = new System.Drawing.Point(0, 0);
            this.backgroundBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backgroundBox.Name = "backgroundBox";
            this.backgroundBox.Size = new System.Drawing.Size(1429, 694);
            this.backgroundBox.TabIndex = 2;
            this.backgroundBox.TabStop = false;
            // 
            // scaleToolStripMenuItem
            // 
            this.scaleToolStripMenuItem.Name = "scaleToolStripMenuItem";
            this.scaleToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.scaleToolStripMenuItem.Text = "Scale";
            // 
            // CreationometryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1429, 694);
            this.Controls.Add(this.menuTLP);
            this.Controls.Add(this.backgroundBox);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CreationometryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Creationometry";
            this.ResizeEnd += new System.EventHandler(this.CreationometryForm_ResizeEnd);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CreationometryForm_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CreationometryForm_KeyPress);
            this.menuTLP.ResumeLayout(false);
            this.menuTLP.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.threePanelTLP.ResumeLayout(false);
            this.objectToolboxTLP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lineButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circleButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ellipseButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regPolyButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.triangleButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.squareButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fdPolyButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rectilButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radialButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageButton)).EndInit();
            this.EMMenuFlowLayoutPanel.ResumeLayout(false);
            this.rotatePanel.ResumeLayout(false);
            this.rotatePanel.PerformLayout();
            this.borderPanel.ResumeLayout(false);
            this.borderPanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        
        private System.Windows.Forms.Panel Canvas;
        private System.Windows.Forms.ColorDialog canvasColorSelection;
        private System.Windows.Forms.PictureBox backgroundBox;
        private System.Windows.Forms.TableLayoutPanel menuTLP;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel threePanelTLP;
        private System.Windows.Forms.TableLayoutPanel objectToolboxTLP;
        private System.Windows.Forms.PictureBox lineButton;
        private System.Windows.Forms.PictureBox circleButton;
        private System.Windows.Forms.PictureBox ellipseButton;
        private System.Windows.Forms.PictureBox regPolyButton;
        private System.Windows.Forms.PictureBox triangleButton;
        private System.Windows.Forms.PictureBox squareButton;
        private System.Windows.Forms.PictureBox fdPolyButton;
        private System.Windows.Forms.PictureBox rectilButton;
        private System.Windows.Forms.PictureBox radialButton;
        private System.Windows.Forms.PictureBox textButton;
        private System.Windows.Forms.PictureBox imageButton;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetZoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotateToolStripMenuItem;
        private System.Windows.Forms.Label redoLabel;
        private System.Windows.Forms.Label undoLabel;
        private System.Windows.Forms.Label errorMessageForWeight;
        private System.Windows.Forms.Button changeWeight;
        private System.Windows.Forms.TextBox inputChangeWeight;
        private System.Windows.Forms.Button changeColor;
        private System.Windows.Forms.FlowLayoutPanel EMMenuFlowLayoutPanel;
        private Views.EMMenu.EllipseModMenuView ellipseModMenuView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem canvasColorToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.ToolStripMenuItem duplicateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deselectToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel rotatePanel;
        private System.Windows.Forms.TextBox inputRotateAngle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button changeRotation;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel borderPanel;
        private System.Windows.Forms.ToolStripMenuItem scaleToolStripMenuItem;
    }
}

