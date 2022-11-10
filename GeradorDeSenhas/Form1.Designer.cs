namespace GeradorDeSenhas
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelPictureBox = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelMainOptions = new System.Windows.Forms.Panel();
            this.panelOptions = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnClearForm = new System.Windows.Forms.Button();
            this.btnCreatePassword = new System.Windows.Forms.Button();
            this.checkBoxResetPortuguese = new System.Windows.Forms.CheckBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.checkBoxCreatePortuguese = new System.Windows.Forms.CheckBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBoxCreateSpanish = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.checkBoxSpecial = new System.Windows.Forms.CheckBox();
            this.checkBoxResetSpanish = new System.Windows.Forms.CheckBox();
            this.nudViewsToExpire = new System.Windows.Forms.NumericUpDown();
            this.nudDaysToExpire = new System.Windows.Forms.NumericUpDown();
            this.nudCharactersQuantity = new System.Windows.Forms.NumericUpDown();
            this.nudPasswordQuantity = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelTextBox = new System.Windows.Forms.Panel();
            this.textBoxValues = new System.Windows.Forms.TextBox();
            this.panelPictureBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelMainOptions.SuspendLayout();
            this.panelOptions.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudViewsToExpire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDaysToExpire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCharactersQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPasswordQuantity)).BeginInit();
            this.panelTextBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPictureBox
            // 
            this.panelPictureBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.panelPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPictureBox.Controls.Add(this.pictureBoxLogo);
            this.panelPictureBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPictureBox.Location = new System.Drawing.Point(0, 0);
            this.panelPictureBox.Name = "panelPictureBox";
            this.panelPictureBox.Size = new System.Drawing.Size(1280, 200);
            this.panelPictureBox.TabIndex = 0;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(1278, 198);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // panelMainOptions
            // 
            this.panelMainOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelMainOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelMainOptions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMainOptions.Controls.Add(this.panelOptions);
            this.panelMainOptions.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMainOptions.Location = new System.Drawing.Point(0, 200);
            this.panelMainOptions.Name = "panelMainOptions";
            this.panelMainOptions.Size = new System.Drawing.Size(745, 520);
            this.panelMainOptions.TabIndex = 1;
            // 
            // panelOptions
            // 
            this.panelOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelOptions.Controls.Add(this.panel1);
            this.panelOptions.Controls.Add(this.checkBoxResetPortuguese);
            this.panelOptions.Controls.Add(this.pictureBox4);
            this.panelOptions.Controls.Add(this.checkBoxCreatePortuguese);
            this.panelOptions.Controls.Add(this.pictureBox3);
            this.panelOptions.Controls.Add(this.pictureBox1);
            this.panelOptions.Controls.Add(this.label8);
            this.panelOptions.Controls.Add(this.checkBoxCreateSpanish);
            this.panelOptions.Controls.Add(this.label7);
            this.panelOptions.Controls.Add(this.pictureBox2);
            this.panelOptions.Controls.Add(this.checkBoxSpecial);
            this.panelOptions.Controls.Add(this.checkBoxResetSpanish);
            this.panelOptions.Controls.Add(this.nudViewsToExpire);
            this.panelOptions.Controls.Add(this.nudDaysToExpire);
            this.panelOptions.Controls.Add(this.nudCharactersQuantity);
            this.panelOptions.Controls.Add(this.nudPasswordQuantity);
            this.panelOptions.Controls.Add(this.label1);
            this.panelOptions.Controls.Add(this.label6);
            this.panelOptions.Controls.Add(this.label2);
            this.panelOptions.Controls.Add(this.label5);
            this.panelOptions.Controls.Add(this.label4);
            this.panelOptions.Location = new System.Drawing.Point(3, 3);
            this.panelOptions.Name = "panelOptions";
            this.panelOptions.Size = new System.Drawing.Size(737, 512);
            this.panelOptions.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.linkLabel2);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.btnCopy);
            this.panel1.Controls.Add(this.btnClearForm);
            this.panel1.Controls.Add(this.btnCreatePassword);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 385);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(737, 127);
            this.panel1.TabIndex = 26;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel2.LinkColor = System.Drawing.Color.DodgerBlue;
            this.linkLabel2.Location = new System.Drawing.Point(102, 104);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(43, 15);
            this.linkLabel2.TabIndex = 26;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Github";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1.LinkColor = System.Drawing.Color.DodgerBlue;
            this.linkLabel1.Location = new System.Drawing.Point(28, 104);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(52, 15);
            this.linkLabel1.TabIndex = 25;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Linkedin";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnCopy
            // 
            this.btnCopy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCopy.Enabled = false;
            this.btnCopy.Location = new System.Drawing.Point(506, 31);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(150, 40);
            this.btnCopy.TabIndex = 12;
            this.btnCopy.Text = "Copiar";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnClearForm
            // 
            this.btnClearForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearForm.Enabled = false;
            this.btnClearForm.Location = new System.Drawing.Point(271, 31);
            this.btnClearForm.Name = "btnClearForm";
            this.btnClearForm.Size = new System.Drawing.Size(150, 40);
            this.btnClearForm.TabIndex = 11;
            this.btnClearForm.Text = "Limpar";
            this.btnClearForm.UseVisualStyleBackColor = true;
            this.btnClearForm.Click += new System.EventHandler(this.btnClearForm_Click);
            // 
            // btnCreatePassword
            // 
            this.btnCreatePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreatePassword.Location = new System.Drawing.Point(28, 31);
            this.btnCreatePassword.Name = "btnCreatePassword";
            this.btnCreatePassword.Size = new System.Drawing.Size(150, 40);
            this.btnCreatePassword.TabIndex = 10;
            this.btnCreatePassword.Text = "Gerar";
            this.btnCreatePassword.UseVisualStyleBackColor = true;
            this.btnCreatePassword.Click += new System.EventHandler(this.btnCreatePassword_Click);
            // 
            // checkBoxResetPortuguese
            // 
            this.checkBoxResetPortuguese.AutoSize = true;
            this.checkBoxResetPortuguese.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxResetPortuguese.Location = new System.Drawing.Point(534, 292);
            this.checkBoxResetPortuguese.Name = "checkBoxResetPortuguese";
            this.checkBoxResetPortuguese.Size = new System.Drawing.Size(15, 14);
            this.checkBoxResetPortuguese.TabIndex = 6;
            this.checkBoxResetPortuguese.UseVisualStyleBackColor = true;
            this.checkBoxResetPortuguese.CheckedChanged += new System.EventHandler(this.checkBoxResetPortuguese_CheckedChanged);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(629, 320);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(25, 14);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 24;
            this.pictureBox4.TabStop = false;
            // 
            // checkBoxCreatePortuguese
            // 
            this.checkBoxCreatePortuguese.AutoSize = true;
            this.checkBoxCreatePortuguese.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxCreatePortuguese.Location = new System.Drawing.Point(534, 320);
            this.checkBoxCreatePortuguese.Name = "checkBoxCreatePortuguese";
            this.checkBoxCreatePortuguese.Size = new System.Drawing.Size(15, 14);
            this.checkBoxCreatePortuguese.TabIndex = 8;
            this.checkBoxCreatePortuguese.UseVisualStyleBackColor = true;
            this.checkBoxCreatePortuguese.CheckedChanged += new System.EventHandler(this.checkBoxCreatePortuguese_CheckedChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(629, 291);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 14);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 23;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(555, 291);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 14);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(28, 312);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(291, 23);
            this.label8.TabIndex = 16;
            this.label8.Text = "Ticket - Cadastro de Usuário:";
            // 
            // checkBoxCreateSpanish
            // 
            this.checkBoxCreateSpanish.AutoSize = true;
            this.checkBoxCreateSpanish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxCreateSpanish.Location = new System.Drawing.Point(608, 320);
            this.checkBoxCreateSpanish.Name = "checkBoxCreateSpanish";
            this.checkBoxCreateSpanish.Size = new System.Drawing.Size(15, 14);
            this.checkBoxCreateSpanish.TabIndex = 9;
            this.checkBoxCreateSpanish.UseVisualStyleBackColor = true;
            this.checkBoxCreateSpanish.CheckedChanged += new System.EventHandler(this.checkBoxCreateSpanish_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(28, 283);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(246, 23);
            this.label7.TabIndex = 15;
            this.label7.Text = "Ticket - Reset de Senha:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(555, 320);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 14);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // checkBoxSpecial
            // 
            this.checkBoxSpecial.AutoSize = true;
            this.checkBoxSpecial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxSpecial.Location = new System.Drawing.Point(537, 146);
            this.checkBoxSpecial.Name = "checkBoxSpecial";
            this.checkBoxSpecial.Size = new System.Drawing.Size(15, 14);
            this.checkBoxSpecial.TabIndex = 3;
            this.checkBoxSpecial.UseVisualStyleBackColor = true;
            // 
            // checkBoxResetSpanish
            // 
            this.checkBoxResetSpanish.AutoSize = true;
            this.checkBoxResetSpanish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxResetSpanish.Location = new System.Drawing.Point(608, 291);
            this.checkBoxResetSpanish.Name = "checkBoxResetSpanish";
            this.checkBoxResetSpanish.Size = new System.Drawing.Size(15, 14);
            this.checkBoxResetSpanish.TabIndex = 7;
            this.checkBoxResetSpanish.UseVisualStyleBackColor = true;
            this.checkBoxResetSpanish.CheckedChanged += new System.EventHandler(this.checkBoxResetSpanish_CheckedChanged);
            // 
            // nudViewsToExpire
            // 
            this.nudViewsToExpire.Location = new System.Drawing.Point(537, 236);
            this.nudViewsToExpire.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudViewsToExpire.Name = "nudViewsToExpire";
            this.nudViewsToExpire.Size = new System.Drawing.Size(120, 23);
            this.nudViewsToExpire.TabIndex = 5;
            this.nudViewsToExpire.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // nudDaysToExpire
            // 
            this.nudDaysToExpire.Location = new System.Drawing.Point(537, 185);
            this.nudDaysToExpire.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDaysToExpire.Name = "nudDaysToExpire";
            this.nudDaysToExpire.Size = new System.Drawing.Size(120, 23);
            this.nudDaysToExpire.TabIndex = 4;
            this.nudDaysToExpire.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // nudCharactersQuantity
            // 
            this.nudCharactersQuantity.Location = new System.Drawing.Point(537, 86);
            this.nudCharactersQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCharactersQuantity.Name = "nudCharactersQuantity";
            this.nudCharactersQuantity.Size = new System.Drawing.Size(120, 23);
            this.nudCharactersQuantity.TabIndex = 2;
            this.nudCharactersQuantity.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // nudPasswordQuantity
            // 
            this.nudPasswordQuantity.Location = new System.Drawing.Point(537, 37);
            this.nudPasswordQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPasswordQuantity.Name = "nudPasswordQuantity";
            this.nudPasswordQuantity.Size = new System.Drawing.Size(120, 23);
            this.nudPasswordQuantity.TabIndex = 1;
            this.nudPasswordQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(28, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quantidade de senhas:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(28, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(341, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Visualizações após criação do link:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(28, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(355, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quantidade de characters da senha:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(28, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(326, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Dias para expirar após a criação:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(28, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(379, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gerar senha com characters especiais:";
            // 
            // panelTextBox
            // 
            this.panelTextBox.AutoSize = true;
            this.panelTextBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelTextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTextBox.Controls.Add(this.textBoxValues);
            this.panelTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTextBox.Location = new System.Drawing.Point(745, 200);
            this.panelTextBox.Name = "panelTextBox";
            this.panelTextBox.Size = new System.Drawing.Size(535, 520);
            this.panelTextBox.TabIndex = 2;
            // 
            // textBoxValues
            // 
            this.textBoxValues.BackColor = System.Drawing.Color.White;
            this.textBoxValues.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxValues.Cursor = System.Windows.Forms.Cursors.No;
            this.textBoxValues.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxValues.ForeColor = System.Drawing.Color.Black;
            this.textBoxValues.Location = new System.Drawing.Point(0, 0);
            this.textBoxValues.Multiline = true;
            this.textBoxValues.Name = "textBoxValues";
            this.textBoxValues.ReadOnly = true;
            this.textBoxValues.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxValues.Size = new System.Drawing.Size(533, 518);
            this.textBoxValues.TabIndex = 13;
            this.textBoxValues.TextChanged += new System.EventHandler(this.textBoxValues_TextChanged);
            this.textBoxValues.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.textBoxValues_MouseDoubleClick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panelTextBox);
            this.Controls.Add(this.panelMainOptions);
            this.Controls.Add(this.panelPictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerador de senha";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelPictureBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelMainOptions.ResumeLayout(false);
            this.panelOptions.ResumeLayout(false);
            this.panelOptions.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudViewsToExpire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDaysToExpire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCharactersQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPasswordQuantity)).EndInit();
            this.panelTextBox.ResumeLayout(false);
            this.panelTextBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panelImage;
        private Panel panelPictureBox;
        private Panel panelMainOptions;
        private Panel panelTextBox;
        private Label label6;
        private Label label5;
        private Label label2;
        private Label label1;
        private Panel panelOptions;
        private TextBox textBoxValues;
        private Button btnCreatePassword;
        private NumericUpDown nudPasswordQuantity;
        private NumericUpDown nudCharactersQuantity;
        private NumericUpDown nudViewsToExpire;
        private NumericUpDown nudDaysToExpire;
        private Label label8;
        private Label label7;
        private CheckBox checkBoxCreatePortuguese;
        private CheckBox checkBoxResetPortuguese;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private CheckBox checkBoxCreateSpanish;
        private CheckBox checkBoxResetSpanish;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private CheckBox checkBoxSpecial;
        private Label label4;
        private Button btnClearForm;
        private Button btnCopy;
        private LinkLabel linkLabel1;
        private Panel panel1;
        private LinkLabel linkLabel2;
        private PictureBox pictureBoxLogo;
    }
}