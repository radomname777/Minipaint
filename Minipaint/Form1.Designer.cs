namespace Minipaint
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Triangl = new Guna.UI2.WinForms.Guna2ImageRadioButton();
            this.Rec = new Guna.UI2.WinForms.Guna2ImageRadioButton();
            this.Circle = new Guna.UI2.WinForms.Guna2ImageRadioButton();
            this.tool_panel = new System.Windows.Forms.Panel();
            this.pencil = new Guna.UI2.WinForms.Guna2ImageRadioButton();
            this.bursh1 = new Guna.UI2.WinForms.Guna2ImageRadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.sizes = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Tool = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.panel1.SuspendLayout();
            this.tool_panel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.Triangl);
            this.panel1.Controls.Add(this.Rec);
            this.panel1.Controls.Add(this.Circle);
            this.panel1.Location = new System.Drawing.Point(84, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(98, 47);
            this.panel1.TabIndex = 2;
            // 
            // Triangl
            // 
            this.Triangl.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.Triangl.Image = global::Minipaint.Properties.Resources.Triangle1;
            this.Triangl.ImageOffset = new System.Drawing.Point(0, 0);
            this.Triangl.ImageRotate = 0F;
            this.Triangl.ImageSize = new System.Drawing.Size(25, 25);
            this.Triangl.Location = new System.Drawing.Point(61, 9);
            this.Triangl.Name = "Triangl";
            this.Triangl.Size = new System.Drawing.Size(27, 25);
            this.Triangl.TabIndex = 5;
            // 
            // Rec
            // 
            this.Rec.BackColor = System.Drawing.Color.Transparent;
            this.Rec.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.Rec.Image = global::Minipaint.Properties.Resources.rectangle;
            this.Rec.ImageOffset = new System.Drawing.Point(0, 0);
            this.Rec.ImageRotate = 0F;
            this.Rec.ImageSize = new System.Drawing.Size(24, 25);
            this.Rec.Location = new System.Drawing.Point(31, 10);
            this.Rec.Name = "Rec";
            this.Rec.Size = new System.Drawing.Size(24, 24);
            this.Rec.TabIndex = 1;
            // 
            // Circle
            // 
            this.Circle.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.Circle.Image = global::Minipaint.Properties.Resources.Cricle1;
            this.Circle.ImageOffset = new System.Drawing.Point(0, 0);
            this.Circle.ImageRotate = 0F;
            this.Circle.Location = new System.Drawing.Point(2, 10);
            this.Circle.Name = "Circle";
            this.Circle.Size = new System.Drawing.Size(24, 24);
            this.Circle.TabIndex = 0;
            // 
            // tool_panel
            // 
            this.tool_panel.BackColor = System.Drawing.Color.Tan;
            this.tool_panel.Controls.Add(this.pencil);
            this.tool_panel.Controls.Add(this.bursh1);
            this.tool_panel.Location = new System.Drawing.Point(3, 4);
            this.tool_panel.Name = "tool_panel";
            this.tool_panel.Size = new System.Drawing.Size(81, 35);
            this.tool_panel.TabIndex = 3;
            // 
            // pencil
            // 
            this.pencil.Checked = true;
            this.pencil.CheckedState.Image = global::Minipaint.Properties.Resources.pencil;
            this.pencil.Image = global::Minipaint.Properties.Resources.pencil;
            this.pencil.ImageOffset = new System.Drawing.Point(0, 0);
            this.pencil.ImageRotate = 0F;
            this.pencil.ImageSize = new System.Drawing.Size(35, 35);
            this.pencil.Location = new System.Drawing.Point(4, 6);
            this.pencil.Name = "pencil";
            this.pencil.Size = new System.Drawing.Size(36, 31);
            this.pencil.TabIndex = 0;
            // 
            // bursh1
            // 
            this.bursh1.CheckedState.Image = global::Minipaint.Properties.Resources.brush1;
            this.bursh1.Image = global::Minipaint.Properties.Resources.brush1;
            this.bursh1.ImageOffset = new System.Drawing.Point(0, 0);
            this.bursh1.ImageRotate = 0F;
            this.bursh1.ImageSize = new System.Drawing.Size(45, 45);
            this.bursh1.Location = new System.Drawing.Point(47, 4);
            this.bursh1.Name = "bursh1";
            this.bursh1.Size = new System.Drawing.Size(32, 31);
            this.bursh1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PapayaWhip;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.sizes);
            this.panel2.Controls.Add(this.tool_panel);
            this.panel2.Controls.Add(this.Tool);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(799, 55);
            this.panel2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(244, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Sizes";
            // 
            // sizes
            // 
            this.sizes.BackColor = System.Drawing.Color.Transparent;
            this.sizes.BorderColor = System.Drawing.Color.Black;
            this.sizes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.sizes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sizes.FillColor = System.Drawing.Color.Tan;
            this.sizes.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sizes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sizes.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sizes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.sizes.ImeMode = System.Windows.Forms.ImeMode.On;
            this.sizes.ItemHeight = 20;
            this.sizes.Items.AddRange(new object[] {
            "4",
            "6",
            "8",
            "10",
            "14",
            "18",
            "20",
            "24",
            "26",
            "28",
            "32",
            "34",
            "40",
            "46"});
            this.sizes.ItemsAppearance.SelectedForeColor = System.Drawing.Color.DeepSkyBlue;
            this.sizes.Location = new System.Drawing.Point(231, 9);
            this.sizes.Name = "sizes";
            this.sizes.Size = new System.Drawing.Size(64, 26);
            this.sizes.TabIndex = 9;
            // 
            // Tool
            // 
            this.Tool.BackColor = System.Drawing.Color.Transparent;
            this.Tool.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Tool.ForeColor = System.Drawing.Color.Black;
            this.Tool.Location = new System.Drawing.Point(25, 39);
            this.Tool.Name = "Tool";
            this.Tool.Size = new System.Drawing.Size(29, 16);
            this.Tool.TabIndex = 8;
            this.Tool.Text = "Tool";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(184, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Color";
            // 
            // button1
            // 
            this.button1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.button1.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.button1.Image = global::Minipaint.Properties.Resources._1024px_Rainbow_gradient_fully_saturated_svg;
            this.button1.ImageFlip = Guna.UI2.WinForms.Enums.FlipOrientation.Horizontal;
            this.button1.ImageOffset = new System.Drawing.Point(0, 0);
            this.button1.ImageRotate = 0F;
            this.button1.ImageSize = new System.Drawing.Size(29, 28);
            this.button1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.button1.Location = new System.Drawing.Point(188, 4);
            this.button1.Name = "button1";
            this.button1.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.button1.Size = new System.Drawing.Size(29, 28);
            this.button1.TabIndex = 6;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Form1";
            this.Text = "MiniPaint";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.panel1.ResumeLayout(false);
            this.tool_panel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private ColorDialog colorDialog1;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2ImageRadioButton Circle;
        private Panel tool_panel;
        private Guna.UI2.WinForms.Guna2ImageRadioButton pencil;
        private Guna.UI2.WinForms.Guna2ImageRadioButton Rec;
        private Guna.UI2.WinForms.Guna2ImageRadioButton Triangl;
        private Guna.UI2.WinForms.Guna2ImageRadioButton bursh1;
        private Panel panel2;
        private Label label1;
        private Guna.UI2.WinForms.Guna2ImageButton button1;
        private Label Tool;
        private Guna.UI2.WinForms.Guna2ComboBox sizes;
        private Label label2;
    }
}