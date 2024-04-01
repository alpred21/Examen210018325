namespace SistemasVentas.VISTA.InterfazGerenteVista
{
    partial class InterfazGerenteMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InterfazGerenteMenu));
            panel1 = new Panel();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            button3 = new Button();
            panelmenu = new Panel();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel5 = new Panel();
            buttonrol = new Button();
            buttonventa = new Button();
            buttoning = new Button();
            buttonprod = new Button();
            buttonpersona = new Button();
            panelcargarform = new Panel();
            pictureBox3 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelmenu.SuspendLayout();
            panel5.SuspendLayout();
            panelcargarform.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(984, 130);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Magneto", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(279, 4);
            label4.Name = "label4";
            label4.Padding = new Padding(60, 35, 50, 30);
            label4.Size = new Size(473, 123);
            label4.TabIndex = 17;
            label4.Text = "PREDSHOP";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Dock = DockStyle.Left;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Padding = new Padding(20);
            pictureBox2.Size = new Size(152, 130);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.BackgroundImageLayout = ImageLayout.None;
            button3.FlatAppearance.BorderColor = Color.White;
            button3.FlatAppearance.BorderSize = 2;
            button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            button3.FlatAppearance.MouseOverBackColor = Color.Red;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.Red;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(9, 8);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Size = new Size(93, 33);
            button3.TabIndex = 2;
            button3.Text = "SALIR";
            button3.TextAlign = ContentAlignment.MiddleRight;
            button3.UseVisualStyleBackColor = false;
            button3.Click += buttonsalir;
            // 
            // panelmenu
            // 
            panelmenu.AutoScroll = true;
            panelmenu.BackColor = Color.Black;
            panelmenu.BackgroundImageLayout = ImageLayout.None;
            panelmenu.Controls.Add(button6);
            panelmenu.Controls.Add(button5);
            panelmenu.Controls.Add(button4);
            panelmenu.Controls.Add(button2);
            panelmenu.Controls.Add(button1);
            panelmenu.Controls.Add(panel5);
            panelmenu.Controls.Add(buttonrol);
            panelmenu.Controls.Add(buttonventa);
            panelmenu.Controls.Add(buttoning);
            panelmenu.Controls.Add(buttonprod);
            panelmenu.Controls.Add(buttonpersona);
            panelmenu.Dock = DockStyle.Left;
            panelmenu.Location = new Point(0, 130);
            panelmenu.Name = "panelmenu";
            panelmenu.Size = new Size(220, 531);
            panelmenu.TabIndex = 1;
            // 
            // button6
            // 
            button6.BackColor = Color.Black;
            button6.BackgroundImageLayout = ImageLayout.Zoom;
            button6.Cursor = Cursors.Hand;
            button6.Dock = DockStyle.Top;
            button6.FlatAppearance.BorderColor = Color.FromArgb(94, 142, 62);
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatAppearance.CheckedBackColor = Color.FromArgb(10, 44, 1);
            button6.FlatAppearance.MouseDownBackColor = Color.FromArgb(10, 44, 1);
            button6.FlatAppearance.MouseOverBackColor = Color.FromArgb(10, 44, 1);
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button6.ForeColor = Color.White;
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(0, 405);
            button6.Name = "button6";
            button6.Size = new Size(220, 45);
            button6.TabIndex = 24;
            button6.Text = "ROLES";
            button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.Black;
            button5.BackgroundImageLayout = ImageLayout.Zoom;
            button5.Cursor = Cursors.Hand;
            button5.Dock = DockStyle.Top;
            button5.FlatAppearance.BorderColor = Color.FromArgb(94, 142, 62);
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.CheckedBackColor = Color.FromArgb(10, 44, 1);
            button5.FlatAppearance.MouseDownBackColor = Color.FromArgb(10, 44, 1);
            button5.FlatAppearance.MouseOverBackColor = Color.FromArgb(10, 44, 1);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = Color.White;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(0, 360);
            button5.Name = "button5";
            button5.Size = new Size(220, 45);
            button5.TabIndex = 23;
            button5.Text = "ROLES";
            button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Black;
            button4.BackgroundImageLayout = ImageLayout.Zoom;
            button4.Cursor = Cursors.Hand;
            button4.Dock = DockStyle.Top;
            button4.FlatAppearance.BorderColor = Color.FromArgb(94, 142, 62);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.CheckedBackColor = Color.FromArgb(10, 44, 1);
            button4.FlatAppearance.MouseDownBackColor = Color.FromArgb(10, 44, 1);
            button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(10, 44, 1);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(0, 315);
            button4.Name = "button4";
            button4.Size = new Size(220, 45);
            button4.TabIndex = 22;
            button4.Text = "ROLES";
            button4.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.Cursor = Cursors.Hand;
            button2.Dock = DockStyle.Top;
            button2.FlatAppearance.BorderColor = Color.FromArgb(94, 142, 62);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.CheckedBackColor = Color.FromArgb(10, 44, 1);
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(10, 44, 1);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(10, 44, 1);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(0, 270);
            button2.Name = "button2";
            button2.Size = new Size(220, 45);
            button2.TabIndex = 21;
            button2.Text = "ROLES";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Cursor = Cursors.Hand;
            button1.Dock = DockStyle.Top;
            button1.FlatAppearance.BorderColor = Color.FromArgb(94, 142, 62);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.CheckedBackColor = Color.FromArgb(10, 44, 1);
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(10, 44, 1);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(10, 44, 1);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(0, 225);
            button1.Name = "button1";
            button1.Size = new Size(220, 45);
            button1.TabIndex = 20;
            button1.Text = "ROLES";
            button1.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            panel5.Controls.Add(button3);
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(0, 481);
            panel5.Name = "panel5";
            panel5.Size = new Size(220, 50);
            panel5.TabIndex = 19;
            // 
            // buttonrol
            // 
            buttonrol.BackColor = Color.Black;
            buttonrol.BackgroundImageLayout = ImageLayout.Zoom;
            buttonrol.Cursor = Cursors.Hand;
            buttonrol.Dock = DockStyle.Top;
            buttonrol.FlatAppearance.BorderColor = Color.FromArgb(94, 142, 62);
            buttonrol.FlatAppearance.BorderSize = 0;
            buttonrol.FlatAppearance.CheckedBackColor = Color.FromArgb(10, 44, 1);
            buttonrol.FlatAppearance.MouseDownBackColor = Color.FromArgb(10, 44, 1);
            buttonrol.FlatAppearance.MouseOverBackColor = Color.FromArgb(10, 44, 1);
            buttonrol.FlatStyle = FlatStyle.Flat;
            buttonrol.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonrol.ForeColor = Color.White;
            buttonrol.Image = (Image)resources.GetObject("buttonrol.Image");
            buttonrol.ImageAlign = ContentAlignment.MiddleLeft;
            buttonrol.Location = new Point(0, 180);
            buttonrol.Name = "buttonrol";
            buttonrol.Size = new Size(220, 45);
            buttonrol.TabIndex = 18;
            buttonrol.Text = "ROLES";
            buttonrol.UseVisualStyleBackColor = false;
            // 
            // buttonventa
            // 
            buttonventa.BackColor = Color.Black;
            buttonventa.BackgroundImageLayout = ImageLayout.Zoom;
            buttonventa.Cursor = Cursors.Hand;
            buttonventa.Dock = DockStyle.Top;
            buttonventa.FlatAppearance.BorderColor = Color.FromArgb(94, 142, 62);
            buttonventa.FlatAppearance.BorderSize = 0;
            buttonventa.FlatAppearance.CheckedBackColor = Color.FromArgb(10, 44, 1);
            buttonventa.FlatAppearance.MouseDownBackColor = Color.FromArgb(10, 44, 1);
            buttonventa.FlatAppearance.MouseOverBackColor = Color.FromArgb(10, 44, 1);
            buttonventa.FlatStyle = FlatStyle.Flat;
            buttonventa.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonventa.ForeColor = Color.White;
            buttonventa.Image = (Image)resources.GetObject("buttonventa.Image");
            buttonventa.ImageAlign = ContentAlignment.MiddleLeft;
            buttonventa.Location = new Point(0, 135);
            buttonventa.Name = "buttonventa";
            buttonventa.Size = new Size(220, 45);
            buttonventa.TabIndex = 16;
            buttonventa.Text = "VENTAS";
            buttonventa.UseVisualStyleBackColor = false;
            // 
            // buttoning
            // 
            buttoning.BackColor = Color.Black;
            buttoning.BackgroundImageLayout = ImageLayout.Zoom;
            buttoning.Cursor = Cursors.Hand;
            buttoning.Dock = DockStyle.Top;
            buttoning.FlatAppearance.BorderColor = Color.FromArgb(94, 142, 62);
            buttoning.FlatAppearance.BorderSize = 0;
            buttoning.FlatAppearance.CheckedBackColor = Color.FromArgb(10, 44, 1);
            buttoning.FlatAppearance.MouseDownBackColor = Color.FromArgb(10, 44, 1);
            buttoning.FlatAppearance.MouseOverBackColor = Color.FromArgb(10, 44, 1);
            buttoning.FlatStyle = FlatStyle.Flat;
            buttoning.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttoning.ForeColor = Color.White;
            buttoning.Image = (Image)resources.GetObject("buttoning.Image");
            buttoning.ImageAlign = ContentAlignment.MiddleLeft;
            buttoning.Location = new Point(0, 90);
            buttoning.Name = "buttoning";
            buttoning.Size = new Size(220, 45);
            buttoning.TabIndex = 14;
            buttoning.Text = "INGRESOS";
            buttoning.UseVisualStyleBackColor = false;
            // 
            // buttonprod
            // 
            buttonprod.BackColor = Color.Black;
            buttonprod.BackgroundImageLayout = ImageLayout.Zoom;
            buttonprod.Cursor = Cursors.Hand;
            buttonprod.Dock = DockStyle.Top;
            buttonprod.FlatAppearance.BorderColor = Color.FromArgb(94, 142, 62);
            buttonprod.FlatAppearance.BorderSize = 0;
            buttonprod.FlatAppearance.CheckedBackColor = Color.FromArgb(10, 44, 1);
            buttonprod.FlatAppearance.MouseDownBackColor = Color.FromArgb(10, 44, 1);
            buttonprod.FlatAppearance.MouseOverBackColor = Color.FromArgb(10, 44, 1);
            buttonprod.FlatStyle = FlatStyle.Flat;
            buttonprod.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonprod.ForeColor = Color.White;
            buttonprod.Image = (Image)resources.GetObject("buttonprod.Image");
            buttonprod.ImageAlign = ContentAlignment.MiddleLeft;
            buttonprod.Location = new Point(0, 45);
            buttonprod.Name = "buttonprod";
            buttonprod.Size = new Size(220, 45);
            buttonprod.TabIndex = 12;
            buttonprod.Text = "PRODUCTOS";
            buttonprod.UseVisualStyleBackColor = false;
            // 
            // buttonpersona
            // 
            buttonpersona.BackColor = Color.Black;
            buttonpersona.BackgroundImageLayout = ImageLayout.Zoom;
            buttonpersona.Cursor = Cursors.Hand;
            buttonpersona.Dock = DockStyle.Top;
            buttonpersona.FlatAppearance.BorderColor = Color.FromArgb(94, 142, 62);
            buttonpersona.FlatAppearance.BorderSize = 0;
            buttonpersona.FlatAppearance.CheckedBackColor = Color.FromArgb(10, 44, 1);
            buttonpersona.FlatAppearance.MouseDownBackColor = Color.FromArgb(10, 44, 1);
            buttonpersona.FlatAppearance.MouseOverBackColor = Color.FromArgb(10, 44, 1);
            buttonpersona.FlatStyle = FlatStyle.Flat;
            buttonpersona.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonpersona.ForeColor = Color.White;
            buttonpersona.Image = (Image)resources.GetObject("buttonpersona.Image");
            buttonpersona.ImageAlign = ContentAlignment.MiddleLeft;
            buttonpersona.Location = new Point(0, 0);
            buttonpersona.Name = "buttonpersona";
            buttonpersona.Size = new Size(220, 45);
            buttonpersona.TabIndex = 5;
            buttonpersona.Text = "PERSONAS";
            buttonpersona.UseVisualStyleBackColor = false;
            buttonpersona.Click += buttonpersona_Click;
            // 
            // panelcargarform
            // 
            panelcargarform.BackColor = Color.FromArgb(40, 40, 40);
            panelcargarform.Controls.Add(pictureBox3);
            panelcargarform.Dock = DockStyle.Fill;
            panelcargarform.Location = new Point(220, 130);
            panelcargarform.Name = "panelcargarform";
            panelcargarform.Size = new Size(764, 531);
            panelcargarform.TabIndex = 2;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.None;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(257, 150);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Padding = new Padding(20);
            pictureBox3.Size = new Size(285, 259);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 18;
            pictureBox3.TabStop = false;
            // 
            // InterfazGerenteMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(984, 661);
            Controls.Add(panelcargarform);
            Controls.Add(panelmenu);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "InterfazGerenteMenu";
            StartPosition = FormStartPosition.Manual;
            Text = "InterfazGerenteMenu";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelmenu.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panelcargarform.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panelmenu;
        private Panel panelcargarform;
        private PictureBox pictureBox2;
        private Label label4;
        private Button button3;
        private Panel panelpersona;
        private Button buttonpersona;
        private PictureBox pictureBox1;
        private Label label7;
        private Button buttonprod;
        private Panel panelRol;
        private Label label12;
        private PictureBox pictureBox7;
        private Button buttonrol;
        private Button buttonventa;
        private Button buttoning;
        private Panel panel5;
        private PictureBox pictureBox3;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button2;
        private Button button1;
    }
}