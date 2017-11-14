namespace Pong_KivKi
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.p_pong = new System.Windows.Forms.Panel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.B_start = new System.Windows.Forms.Button();
            this.tb_player_left_path = new System.Windows.Forms.TextBox();
            this.tb_player_right_path = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.b_player_left_brows = new System.Windows.Forms.Button();
            this.b_player_right_brows = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.cb_ki_left = new System.Windows.Forms.CheckBox();
            this.cb_ki_right = new System.Windows.Forms.CheckBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nud_map_width = new System.Windows.Forms.NumericUpDown();
            this.nud_map_height = new System.Windows.Forms.NumericUpDown();
            this.nud_speed = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nud_map_width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_map_height)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_speed)).BeginInit();
            this.SuspendLayout();
            // 
            // p_pong
            // 
            this.p_pong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.p_pong.Location = new System.Drawing.Point(12, 12);
            this.p_pong.Name = "p_pong";
            this.p_pong.Size = new System.Drawing.Size(304, 376);
            this.p_pong.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // B_start
            // 
            this.B_start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.B_start.Location = new System.Drawing.Point(547, 122);
            this.B_start.Name = "B_start";
            this.B_start.Size = new System.Drawing.Size(75, 23);
            this.B_start.TabIndex = 1;
            this.B_start.Text = "Start";
            this.B_start.UseVisualStyleBackColor = true;
            this.B_start.Click += new System.EventHandler(this.B_start_Click);
            // 
            // tb_player_left_path
            // 
            this.tb_player_left_path.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_player_left_path.Location = new System.Drawing.Point(474, 41);
            this.tb_player_left_path.Name = "tb_player_left_path";
            this.tb_player_left_path.Size = new System.Drawing.Size(148, 20);
            this.tb_player_left_path.TabIndex = 2;
            this.tb_player_left_path.Text = "C:\\Users\\Daniel\\Dropbox\\Work\\Programmieren\\C#\\Test_Pong_Ki\\bin\\Debug\\Test_Pong_Ki" +
                ".exe";
            // 
            // tb_player_right_path
            // 
            this.tb_player_right_path.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_player_right_path.Location = new System.Drawing.Point(474, 96);
            this.tb_player_right_path.Name = "tb_player_right_path";
            this.tb_player_right_path.Size = new System.Drawing.Size(148, 20);
            this.tb_player_right_path.TabIndex = 3;
            this.tb_player_right_path.Text = "C:\\Users\\Daniel\\Dropbox\\Work\\Programmieren\\C#\\Test_Pong_Ki\\bin\\Debug\\Test_Pong_Ki" +
                ".exe";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(471, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Player Left";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(471, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Player Right";
            // 
            // b_player_left_brows
            // 
            this.b_player_left_brows.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_player_left_brows.Location = new System.Drawing.Point(581, 12);
            this.b_player_left_brows.Name = "b_player_left_brows";
            this.b_player_left_brows.Size = new System.Drawing.Size(41, 23);
            this.b_player_left_brows.TabIndex = 6;
            this.b_player_left_brows.Text = "...";
            this.b_player_left_brows.UseVisualStyleBackColor = true;
            this.b_player_left_brows.Click += new System.EventHandler(this.b_player_left_brows_Click);
            // 
            // b_player_right_brows
            // 
            this.b_player_right_brows.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_player_right_brows.Location = new System.Drawing.Point(581, 67);
            this.b_player_right_brows.Name = "b_player_right_brows";
            this.b_player_right_brows.Size = new System.Drawing.Size(41, 23);
            this.b_player_right_brows.TabIndex = 7;
            this.b_player_right_brows.Text = "...";
            this.b_player_right_brows.UseVisualStyleBackColor = true;
            this.b_player_right_brows.Click += new System.EventHandler(this.b_player_right_brows_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(322, 151);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(300, 237);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // cb_ki_left
            // 
            this.cb_ki_left.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_ki_left.AutoSize = true;
            this.cb_ki_left.Checked = true;
            this.cb_ki_left.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_ki_left.Location = new System.Drawing.Point(539, 16);
            this.cb_ki_left.Name = "cb_ki_left";
            this.cb_ki_left.Size = new System.Drawing.Size(36, 17);
            this.cb_ki_left.TabIndex = 10;
            this.cb_ki_left.Text = "KI";
            this.cb_ki_left.UseVisualStyleBackColor = true;
            // 
            // cb_ki_right
            // 
            this.cb_ki_right.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_ki_right.AutoSize = true;
            this.cb_ki_right.Checked = true;
            this.cb_ki_right.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_ki_right.Location = new System.Drawing.Point(539, 71);
            this.cb_ki_right.Name = "cb_ki_right";
            this.cb_ki_right.Size = new System.Drawing.Size(36, 17);
            this.cb_ki_right.TabIndex = 11;
            this.cb_ki_right.Text = "KI";
            this.cb_ki_right.UseVisualStyleBackColor = true;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(322, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Map Width";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(322, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Map Height";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(322, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Speed";
            // 
            // nud_map_width
            // 
            this.nud_map_width.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.nud_map_width.Location = new System.Drawing.Point(387, 15);
            this.nud_map_width.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.nud_map_width.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nud_map_width.Name = "nud_map_width";
            this.nud_map_width.Size = new System.Drawing.Size(55, 20);
            this.nud_map_width.TabIndex = 15;
            this.nud_map_width.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // nud_map_height
            // 
            this.nud_map_height.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.nud_map_height.Location = new System.Drawing.Point(387, 41);
            this.nud_map_height.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.nud_map_height.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nud_map_height.Name = "nud_map_height";
            this.nud_map_height.Size = new System.Drawing.Size(55, 20);
            this.nud_map_height.TabIndex = 16;
            this.nud_map_height.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // nud_speed
            // 
            this.nud_speed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.nud_speed.Location = new System.Drawing.Point(387, 67);
            this.nud_speed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud_speed.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nud_speed.Name = "nud_speed";
            this.nud_speed.Size = new System.Drawing.Size(55, 20);
            this.nud_speed.TabIndex = 17;
            this.nud_speed.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 400);
            this.Controls.Add(this.nud_speed);
            this.Controls.Add(this.nud_map_height);
            this.Controls.Add(this.nud_map_width);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_ki_right);
            this.Controls.Add(this.cb_ki_left);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.b_player_right_brows);
            this.Controls.Add(this.b_player_left_brows);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_player_right_path);
            this.Controls.Add(this.tb_player_left_path);
            this.Controls.Add(this.B_start);
            this.Controls.Add(this.p_pong);
            this.MaximumSize = new System.Drawing.Size(900, 800);
            this.MinimumSize = new System.Drawing.Size(638, 438);
            this.Name = "Form1";
            this.Text = "Pong_KivKi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.nud_map_width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_map_height)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_speed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel p_pong;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button B_start;
        private System.Windows.Forms.TextBox tb_player_left_path;
        private System.Windows.Forms.TextBox tb_player_right_path;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button b_player_left_brows;
        private System.Windows.Forms.Button b_player_right_brows;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.CheckBox cb_ki_left;
        private System.Windows.Forms.CheckBox cb_ki_right;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nud_map_width;
        private System.Windows.Forms.NumericUpDown nud_map_height;
        private System.Windows.Forms.NumericUpDown nud_speed;
    }
}

