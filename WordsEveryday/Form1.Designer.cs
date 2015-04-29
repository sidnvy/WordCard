namespace WordsEveryday
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.timerColor = new System.Windows.Forms.Timer(this.components);
            this.panel_definition = new System.Windows.Forms.Panel();
            this.definition_label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.WordLabel = new System.Windows.Forms.Label();
            this.Result_label = new System.Windows.Forms.Label();
            this.Counter_label = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.GotItLabel = new System.Windows.Forms.LinkLabel();
            this.ReviewLabel = new System.Windows.Forms.LinkLabel();
            this.CloseButton = new System.Windows.Forms.Button();
            this.hint_label = new System.Windows.Forms.Label();
            this.panel_definition.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerColor
            // 
            this.timerColor.Tick += new System.EventHandler(this.timerColor_Tick);
            // 
            // panel_definition
            // 
            this.panel_definition.Controls.Add(this.definition_label);
            this.panel_definition.Font = new System.Drawing.Font("Microsoft YaHei", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_definition.Location = new System.Drawing.Point(423, 82);
            this.panel_definition.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel_definition.Name = "panel_definition";
            this.panel_definition.Size = new System.Drawing.Size(192, 101);
            this.panel_definition.TabIndex = 36;
            this.panel_definition.Visible = false;
            // 
            // definition_label
            // 
            this.definition_label.AutoSize = true;
            this.definition_label.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.definition_label.Location = new System.Drawing.Point(-4, 16);
            this.definition_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.definition_label.Name = "definition_label";
            this.definition_label.Size = new System.Drawing.Size(75, 21);
            this.definition_label.TabIndex = 0;
            this.definition_label.Text = "defintion";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.WordLabel);
            this.panel1.Location = new System.Drawing.Point(17, 64);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(383, 134);
            this.panel1.TabIndex = 35;
            // 
            // WordLabel
            // 
            this.WordLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WordLabel.Location = new System.Drawing.Point(0, 0);
            this.WordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WordLabel.Name = "WordLabel";
            this.WordLabel.Size = new System.Drawing.Size(383, 134);
            this.WordLabel.TabIndex = 12;
            this.WordLabel.Text = "ExampleWordsTooLong";
            this.WordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Result_label
            // 
            this.Result_label.AutoSize = true;
            this.Result_label.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Result_label.Location = new System.Drawing.Point(419, 97);
            this.Result_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Result_label.Name = "Result_label";
            this.Result_label.Size = new System.Drawing.Size(71, 26);
            this.Result_label.TabIndex = 34;
            this.Result_label.Text = "Result";
            // 
            // Counter_label
            // 
            this.Counter_label.AutoSize = true;
            this.Counter_label.Cursor = System.Windows.Forms.Cursors.Default;
            this.Counter_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Counter_label.Location = new System.Drawing.Point(35, 41);
            this.Counter_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Counter_label.Name = "Counter_label";
            this.Counter_label.Size = new System.Drawing.Size(27, 15);
            this.Counter_label.TabIndex = 33;
            this.Counter_label.Text = "Left";
            // 
            // button4
            // 
            this.button4.AutoEllipsis = true;
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Turquoise;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aquamarine;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft YaHei Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(410, 172);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(225, 34);
            this.button4.TabIndex = 29;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.AutoEllipsis = true;
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Turquoise;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aquamarine;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(410, 136);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(225, 34);
            this.button3.TabIndex = 28;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.AutoEllipsis = true;
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Turquoise;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aquamarine;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(410, 101);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(225, 34);
            this.button2.TabIndex = 27;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.AutoEllipsis = true;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Turquoise;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aquamarine;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(410, 64);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 34);
            this.button1.TabIndex = 26;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GotItLabel
            // 
            this.GotItLabel.ActiveLinkColor = System.Drawing.Color.HotPink;
            this.GotItLabel.AutoSize = true;
            this.GotItLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GotItLabel.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GotItLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.GotItLabel.LinkColor = System.Drawing.Color.Crimson;
            this.GotItLabel.Location = new System.Drawing.Point(419, 185);
            this.GotItLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GotItLabel.Name = "GotItLabel";
            this.GotItLabel.Size = new System.Drawing.Size(73, 25);
            this.GotItLabel.TabIndex = 37;
            this.GotItLabel.TabStop = true;
            this.GotItLabel.Text = "Got It !";
            this.GotItLabel.VisitedLinkColor = System.Drawing.Color.Transparent;
            this.GotItLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GotItLabel_LinkClicked);
            // 
            // ReviewLabel
            // 
            this.ReviewLabel.ActiveLinkColor = System.Drawing.Color.HotPink;
            this.ReviewLabel.AutoSize = true;
            this.ReviewLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReviewLabel.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ReviewLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.ReviewLabel.LinkColor = System.Drawing.Color.Crimson;
            this.ReviewLabel.Location = new System.Drawing.Point(539, 183);
            this.ReviewLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ReviewLabel.Name = "ReviewLabel";
            this.ReviewLabel.Size = new System.Drawing.Size(70, 25);
            this.ReviewLabel.TabIndex = 38;
            this.ReviewLabel.TabStop = true;
            this.ReviewLabel.Text = "Review";
            this.ReviewLabel.VisitedLinkColor = System.Drawing.Color.Transparent;
            this.ReviewLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ReviewLabel1_LinkClicked);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.CloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft YaHei Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CloseButton.Location = new System.Drawing.Point(680, -1);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(37, 22);
            this.CloseButton.TabIndex = 39;
            this.CloseButton.Text = "X";
            this.CloseButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // hint_label
            // 
            this.hint_label.AutoSize = true;
            this.hint_label.Enabled = false;
            this.hint_label.Font = new System.Drawing.Font("Microsoft YaHei Light", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hint_label.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.hint_label.Location = new System.Drawing.Point(415, 14);
            this.hint_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hint_label.Name = "hint_label";
            this.hint_label.Size = new System.Drawing.Size(132, 50);
            this.hint_label.TabIndex = 30;
            this.hint_label.Text = "Bingo!";
            this.hint_label.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(715, 252);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.ReviewLabel);
            this.Controls.Add(this.GotItLabel);
            this.Controls.Add(this.panel_definition);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Result_label);
            this.Controls.Add(this.Counter_label);
            this.Controls.Add(this.hint_label);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_definition.ResumeLayout(false);
            this.panel_definition.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timerColor;
        private System.Windows.Forms.Panel panel_definition;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label WordLabel;
        private System.Windows.Forms.Label Result_label;
        private System.Windows.Forms.Label Counter_label;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label definition_label;
        private System.Windows.Forms.LinkLabel GotItLabel;
        private System.Windows.Forms.LinkLabel ReviewLabel;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label hint_label;
    }
}

