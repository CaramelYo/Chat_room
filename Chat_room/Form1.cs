using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Chat_room
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            creator = null;
            listeners = new List<Form1>();

            // create another form1 automatically
            Form1 f = new Form1("B", this, listeners);
            someone_enter(f);
            f.Show();

            timer1.Interval = 1000;

            open_file = new OpenFileDialog();
            //open_file.InitialDirectory = Application.StartupPath;
            open_file.InitialDirectory = Path.GetFullPath(Path.Combine(Application.StartupPath, img_path));
            open_file.Filter = "Image Files(*.png;*.jpg;*.gif)|*.png;*.jpg;*.gif";
        }

        public Form1(string name, Form1 creator, List<Form1> listeners)
        {
            InitializeComponent();

            this.name = name;

            this.creator = creator;

            this.listeners = new List<Form1>(listeners);
            foreach (Form1 f in this.listeners)
                f.someone_enter(this);

            this.listeners.Insert(0, this.creator);

            timer1.Interval = 1000;

            open_file = new OpenFileDialog();
            //open_file.InitialDirectory = Application.StartupPath;
            open_file.InitialDirectory = Path.GetFullPath(Path.Combine(Application.StartupPath, img_path));
            open_file.Filter = "Image Files(*.png;*.jpg;*.gif)|*.png;*.jpg;*.gif";
        }

        public void receive_conversation(string name, string conversation)
        {
            chat_room_textbox.Text += name + " : " + conversation + Environment.NewLine;
        }

        public void receive_img(string name, Image img, long file_size)
        {
            // simulate file transmission
            // 20KB/s
            img_progressbar.Maximum = (int)(file_size / 2000);
            send_pic_btn.Enabled = false;

            timer1.Start();

            // non-visible
            picbox.Image = img;
            picbox.Visible = false;
        }
        public void someone_enter(Form1 f)
        {
            listeners.Add(f);
            chat_room_textbox.Text += "user " + f.name + " entered" + Environment.NewLine;
        }

        public void someone_exit(Form1 f)
        {
            for (int i = 0; i < listeners.Count; ++i)
                if (listeners[i] == f)
                {
                    listeners.RemoveAt(i);
                    chat_room_textbox.Text += "user " + f.name + " exited" + Environment.NewLine;
                }

            if (creator == f)
                creator = null;
        }

        private void send_btn_Click(object sender, EventArgs e)
        {
            foreach (Form1 f in listeners)
                f.receive_conversation(name, typing_textbox.Text);

            receive_conversation(name, typing_textbox.Text);

            typing_textbox.Text = "";
        }

        private void typing_textbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                send_btn_Click(this, null);
        }

        private void send_pic_btn_Click(object sender, EventArgs e)
        {
            if (open_file.ShowDialog() == DialogResult.OK)
            {
                Image img = Image.FromFile(open_file.FileName);
                picbox.Image = img;

                long file_size = new FileInfo(open_file.FileName).Length;

                foreach (Form1 f in listeners)
                    f.receive_img(name, img, file_size);

                receive_img(name, img, file_size);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            img_progressbar.PerformStep();

            if (img_progressbar.Value >= img_progressbar.Maximum)
            {
                img_progressbar.Value = 0;
                picbox.Visible = true;
                send_pic_btn.Enabled = true;
                timer1.Stop();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // remove this form from other listeners
            foreach (Form1 f in listeners)
                f.someone_exit(this);

            //Application.Exit();
            Close();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog font_dialog = new FontDialog();
            if (font_dialog.ShowDialog() == DialogResult.OK)
                chat_room_textbox.Font = font_dialog.Font;
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog color_dialog = new ColorDialog();
            if (color_dialog.ShowDialog() == DialogResult.OK)
            {
                chat_room_textbox.BackColor = chat_room_textbox.BackColor;
                chat_room_textbox.ForeColor = color_dialog.Color;
            }
        }
        
        private void new_chat_room_btn_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1(new_name_textbox.Text, this, listeners);
            someone_enter(f);
            f.Show();
        }

        List<Form1> listeners;

        Form1 creator;
        OpenFileDialog open_file;

        string img_path = @"imgs", name = "A";
    }
}
