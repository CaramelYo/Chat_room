namespace Chat_room
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.WordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chat_room_textbox = new System.Windows.Forms.TextBox();
            this.typing_textbox = new System.Windows.Forms.TextBox();
            this.img_progressbar = new System.Windows.Forms.ProgressBar();
            this.send_btn = new System.Windows.Forms.Button();
            this.send_pic_btn = new System.Windows.Forms.Button();
            this.picbox = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.new_chat_room_btn = new System.Windows.Forms.Button();
            this.new_name_textbox = new System.Windows.Forms.TextBox();
            this.new_name_label = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.WordToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(883, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // WordToolStripMenuItem
            // 
            this.WordToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontToolStripMenuItem,
            this.colorToolStripMenuItem});
            this.WordToolStripMenuItem.Name = "WordToolStripMenuItem";
            this.WordToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.WordToolStripMenuItem.Text = "Word";
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.fontToolStripMenuItem.Text = "Font";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.colorToolStripMenuItem.Text = "Color";
            this.colorToolStripMenuItem.Click += new System.EventHandler(this.colorToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // chat_room_textbox
            // 
            this.chat_room_textbox.Location = new System.Drawing.Point(13, 28);
            this.chat_room_textbox.Multiline = true;
            this.chat_room_textbox.Name = "chat_room_textbox";
            this.chat_room_textbox.ReadOnly = true;
            this.chat_room_textbox.Size = new System.Drawing.Size(518, 337);
            this.chat_room_textbox.TabIndex = 1;
            // 
            // typing_textbox
            // 
            this.typing_textbox.Location = new System.Drawing.Point(13, 382);
            this.typing_textbox.Name = "typing_textbox";
            this.typing_textbox.Size = new System.Drawing.Size(437, 22);
            this.typing_textbox.TabIndex = 2;
            this.typing_textbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.typing_textbox_KeyDown);
            // 
            // img_progressbar
            // 
            this.img_progressbar.Location = new System.Drawing.Point(537, 342);
            this.img_progressbar.Name = "img_progressbar";
            this.img_progressbar.Size = new System.Drawing.Size(253, 23);
            this.img_progressbar.TabIndex = 3;
            // 
            // send_btn
            // 
            this.send_btn.Location = new System.Drawing.Point(456, 380);
            this.send_btn.Name = "send_btn";
            this.send_btn.Size = new System.Drawing.Size(75, 23);
            this.send_btn.TabIndex = 4;
            this.send_btn.Text = "send";
            this.send_btn.UseVisualStyleBackColor = true;
            this.send_btn.Click += new System.EventHandler(this.send_btn_Click);
            // 
            // send_pic_btn
            // 
            this.send_pic_btn.Location = new System.Drawing.Point(796, 342);
            this.send_pic_btn.Name = "send_pic_btn";
            this.send_pic_btn.Size = new System.Drawing.Size(75, 23);
            this.send_pic_btn.TabIndex = 5;
            this.send_pic_btn.Text = "send_pic";
            this.send_pic_btn.UseVisualStyleBackColor = true;
            this.send_pic_btn.Click += new System.EventHandler(this.send_pic_btn_Click);
            // 
            // picbox
            // 
            this.picbox.Location = new System.Drawing.Point(538, 28);
            this.picbox.Name = "picbox";
            this.picbox.Size = new System.Drawing.Size(333, 308);
            this.picbox.TabIndex = 6;
            this.picbox.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // new_chat_room_btn
            // 
            this.new_chat_room_btn.Location = new System.Drawing.Point(796, 380);
            this.new_chat_room_btn.Name = "new_chat_room_btn";
            this.new_chat_room_btn.Size = new System.Drawing.Size(75, 23);
            this.new_chat_room_btn.TabIndex = 7;
            this.new_chat_room_btn.Text = "new";
            this.new_chat_room_btn.UseVisualStyleBackColor = true;
            this.new_chat_room_btn.Click += new System.EventHandler(this.new_chat_room_btn_Click);
            // 
            // new_name_textbox
            // 
            this.new_name_textbox.Location = new System.Drawing.Point(709, 382);
            this.new_name_textbox.Name = "new_name_textbox";
            this.new_name_textbox.Size = new System.Drawing.Size(81, 22);
            this.new_name_textbox.TabIndex = 8;
            // 
            // new_name_label
            // 
            this.new_name_label.AutoSize = true;
            this.new_name_label.Location = new System.Drawing.Point(648, 385);
            this.new_name_label.Name = "new_name_label";
            this.new_name_label.Size = new System.Drawing.Size(55, 12);
            this.new_name_label.TabIndex = 9;
            this.new_name_label.Text = "new_name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 423);
            this.Controls.Add(this.new_name_label);
            this.Controls.Add(this.new_name_textbox);
            this.Controls.Add(this.new_chat_room_btn);
            this.Controls.Add(this.picbox);
            this.Controls.Add(this.send_pic_btn);
            this.Controls.Add(this.send_btn);
            this.Controls.Add(this.img_progressbar);
            this.Controls.Add(this.typing_textbox);
            this.Controls.Add(this.chat_room_textbox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem WordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TextBox chat_room_textbox;
        private System.Windows.Forms.TextBox typing_textbox;
        private System.Windows.Forms.ProgressBar img_progressbar;
        private System.Windows.Forms.Button send_btn;
        private System.Windows.Forms.Button send_pic_btn;
        private System.Windows.Forms.PictureBox picbox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button new_chat_room_btn;
        private System.Windows.Forms.TextBox new_name_textbox;
        private System.Windows.Forms.Label new_name_label;
    }
}

