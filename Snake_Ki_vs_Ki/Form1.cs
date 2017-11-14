using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;


namespace Pong_KivKi
{

    public partial class Form1 : Form
    {
        //Eingabe durch tasten
        Input input = new Input();
        bool KB_ctrl_state_last=false;
        bool KB_F_state_last=false;

        //Eigabe durch exe
        Process player_right = new Process();
        Process player_left = new Process();
        StreamWriter sw_player_left;
        StreamReader sr_player_left; 
        StreamWriter sw_player_right;
        StreamReader sr_player_right;
        String s_player_left_return;
        String s_player_right_return;

        //Player
        int player_left_lenght;
        int player_right_lenght;
        int player_left_max_lenght;
        int player_right_max_lenght;
        List<Point> player_right_snake;
        List<Point> player_left_snake;
        List<Point> wall_list;
        Point egg;

        //Map
        Graphics g;
        int[,] map;
        String s_map;

        int map_length = 10;
        int map_height = 10;

        readonly int mo_player_left_head = 1;
        readonly int mo_player_left_body = 2;
        readonly int mo_player_right_head = 3;
        readonly int mo_player_right_body = 4;
        readonly int mo_wall = 9;
        readonly int mo_nothing = 0;
        readonly int mo_egg = 8;

        Random myrandom = new Random();
        const int snake_minimul_length=0;

        public Form1()
        {
            InitializeComponent();
            //Player Right initialisieren
            player_right.StartInfo.Arguments = "";
            player_right.StartInfo.RedirectStandardInput = true;
            player_right.StartInfo.RedirectStandardOutput = true;
            player_right.StartInfo.UseShellExecute = false;
            player_right.StartInfo.CreateNoWindow = true;

            //Player Left initialisieren
            player_left.StartInfo.Arguments = "";
            player_left.StartInfo.RedirectStandardInput = true;
            player_left.StartInfo.RedirectStandardOutput = true;
            player_left.StartInfo.UseShellExecute = false;
            player_left.StartInfo.CreateNoWindow = true;

            //Grafik Instanz erzeugen
            g = p_pong.CreateGraphics();

            //Array erzeugen
            map = new int[map_length, map_height];
        }
        

        private void B_start_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                timer1.Enabled = false;
                B_start.Text = "Start";
            }
            else
            {
                player_left.StartInfo.FileName = tb_player_left_path.Text;
                player_right.StartInfo.FileName = tb_player_right_path.Text;
                map_height = (int)nud_map_height.Value;
                map_length = (int)nud_map_width.Value;
                timer1.Interval = (int)nud_speed.Value;

                initial_game();

                timer1.Enabled = true;
                B_start.Text = "Stop";
            }
        }

        private void initial_game()
        {
            g = p_pong.CreateGraphics();
            g.Clear(Color.Black);
            richTextBox1.Clear();
            map = new int[map_length, map_height];

            player_left_lenght = 0;
            player_right_lenght = 0;
            player_left_max_lenght = snake_minimul_length;
            player_right_max_lenght = snake_minimul_length;

            player_left_snake = new List<Point>();
            player_left_snake.Add(new Point(1, 1));

            player_right_snake = new List<Point>();
            player_right_snake.Add(new Point(map_length - 2, map_height - 2));

            wall_list = new List<Point>();
            for (int y = 0; y < map_height; y++)
            {
                for (int x = 0; x < map_length; x++)
                {
                    if (x == 0 || y == 0 || x == (map_length - 1) || y == (map_height - 1)) wall_list.Add(new Point(x, y));
                }
            }

            AddEgg();


            if (cb_ki_left.Checked == true)
            {
                player_left.Start();
                sw_player_left = player_left.StandardInput;
                sr_player_left = player_left.StandardOutput;
            }
            if (cb_ki_right.Checked == true)
            {
                player_right.Start();
                sw_player_right = player_right.StandardInput;
                sr_player_right = player_right.StandardOutput;
            }
            s_player_left_return = "right";
            s_player_right_return = "left";
            draw_array();
        }


        private void b_player_left_brows_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == openFileDialog1.ShowDialog())
            {
                tb_player_left_path.Text = openFileDialog1.FileName;
            }
        }

        private void b_player_right_brows_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == openFileDialog1.ShowDialog())
            {
                tb_player_right_path.Text = openFileDialog1.FileName;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            map_array_to_string();
            if (cb_ki_left.Checked == true)
            {
                sw_player_left.WriteLine(mo_player_left_head.ToString("D2") + s_map);
                s_player_left_return = sr_player_left.ReadLine();
            }
            if (cb_ki_right.Checked == true)
            {
                sw_player_right.WriteLine(mo_player_right_head.ToString("D2") + s_map);
                s_player_right_return = sr_player_right.ReadLine();
            }
            richTextBox1.Text = "Left:" +s_player_left_return + "\tRight:" +s_player_right_return + "\n";
            richTextBox1.Text += "Left Length:" + player_left_lenght.ToString() + "\tRight Length:" + player_right_lenght.ToString() + "\n";

            timer2.Enabled = false;
            move_player();
            timer2.Enabled = true;

            draw_array();
            draw_map();
        }

        private void move_player()
        {
            Point playeer_left_next;
            playeer_left_next = player_left_snake[player_left_lenght];
            switch (s_player_left_return)
            {
                case "left":
                    playeer_left_next.X--;
                    break;
                case "right":
                    playeer_left_next.X++;
                    break;
                case "up":
                    playeer_left_next.Y--;
                    break;
                case "down":
                    playeer_left_next.Y++;
                    break;
            }
            Point player_right_next;
            player_right_next = player_right_snake[player_right_lenght];
            switch (s_player_right_return)
            {
                case "left":
                    player_right_next.X--;
                    break;
                case "right":
                    player_right_next.X++;
                    break;
                case "up":
                    player_right_next.Y--;
                    break;
                case "down":
                    player_right_next.Y++;
                    break;
            }

            //Spieler kollision
            
            if (playeer_left_next == player_right_next)
            {
                if (cb_ki_left.Checked == cb_ki_right.Checked == true)
                {
                    wall_list.Add(player_right_next);
                    if (player_right_next == egg) AddEgg();
                    draw_array();
                    timer1_Tick(new Object(), new EventArgs());
                    wall_list.Remove(player_right_next);
                    return;
                }
                richTextBox1.Text += "Player right and left died\n";
                timer1.Enabled = false;
                if (cb_ki_left.Checked == true) sw_player_left.WriteLine("end");
                if (cb_ki_right.Checked == true) sw_player_right.WriteLine("end");
                B_start.Text = "Start";
                return;
            }
            
            //Player Left --------------------------
            if (playeer_left_next == egg)
            {
                player_left_max_lenght++;
                AddEgg();
            }
            if ((!wall_list.Contains(playeer_left_next)) && (!player_left_snake.Contains(playeer_left_next)) && (!player_right_snake.Contains(playeer_left_next)))
            {
                player_left_snake.Add(playeer_left_next);
                if (player_left_lenght == player_left_max_lenght) player_left_snake.RemoveAt(0);
                else player_left_lenght++;
            }
            else
            {
                richTextBox1.Text += "Player left died\n";
                timer1.Enabled = false;
                if (cb_ki_left.Checked == true) sw_player_left.WriteLine("end");
                if (cb_ki_right.Checked == true) sw_player_right.WriteLine("end");
                B_start.Text = "Start";
            }
            //Player Right ----------------------------------------------
            if (player_right_next == egg)
            {
                player_right_max_lenght++;
                AddEgg();
            }
            if ((!wall_list.Contains(player_right_next)) && (!player_left_snake.Contains(player_right_next)) && (!player_right_snake.Contains(player_right_next)))
            {
                player_right_snake.Add(player_right_next);
                if (player_right_lenght == player_right_max_lenght) player_right_snake.RemoveAt(0);
                else player_right_lenght++;
            }
            else
            {
                richTextBox1.Text += "Player right died\n";
                timer1.Enabled = false;
                if (cb_ki_left.Checked == true) sw_player_left.WriteLine("end");
                if (cb_ki_right.Checked == true) sw_player_right.WriteLine("end");
                B_start.Text = "Start";
            }

        }
        private void AddEgg()
        {
            do
            {
                egg = new Point(myrandom.Next(map_length), myrandom.Next(map_height));
            }
            while ((player_left_snake.Contains(egg)) || (player_right_snake.Contains(egg)) || (wall_list.Contains(egg)));
        }
        private void map_array_to_string()
        {
            s_map = " " + map_length.ToString("D2") + " " + map_height.ToString("D2") + " ";
            for (int y = 0; y < map_height; y++)
            {
                for (int x = 0; x < map_length; x++)
                {
                    s_map += map[x, y].ToString("D2") + ",";
                }
            }
        }
        private void draw_array()
        {
            //Array löschen
            for (int y = 0; y < map_height; y++)
            {
                for (int x = 0; x < map_length; x++)
                {
                    map[x, y] = mo_nothing;
                }
            }
            //Player left zeichnen
            for (int p = 0; p <= player_left_lenght; p++)
            {
                map[player_left_snake[p].X, player_left_snake[p].Y] = mo_player_left_body;
            }
            map[player_left_snake[player_left_lenght].X, player_left_snake[player_left_lenght].Y] = mo_player_left_head;
            //Player right zeichnen
            for (int p = 0; p <= player_right_lenght; p++)
            {
                map[player_right_snake[p].X, player_right_snake[p].Y] = mo_player_right_body;
            }
            map[player_right_snake[player_right_lenght].X, player_right_snake[player_right_lenght].Y] = mo_player_right_head;
            //Wall zeichnen
            foreach (Point p in wall_list)
            {
                map[p.X, p.Y] = mo_wall;
            }
            //Ei zeichnen
            map[egg.X, egg.Y] = mo_egg;
        }
        private void draw_map()
        {
            
            for (int y = 0; y < map_height; y++)
            {
                for (int x = 0; x < map_length; x++)
                {
                    if (map[x, y] == mo_wall) g.FillRectangle(Brushes.Brown, x * (p_pong.Size.Width / map_length), y * (p_pong.Size.Height / map_height), (p_pong.Size.Width / map_length), (p_pong.Size.Height / map_height));
                    if (map[x, y] == mo_nothing) g.FillRectangle(Brushes.Green, x * (p_pong.Size.Width / map_length), y * (p_pong.Size.Height / map_height), (p_pong.Size.Width / map_length), (p_pong.Size.Height / map_height));
                    if (map[x, y] == mo_player_left_head) g.FillRectangle(Brushes.Red, x * (p_pong.Size.Width / map_length), y * (p_pong.Size.Height / map_height), (p_pong.Size.Width / map_length), (p_pong.Size.Height / map_height));
                    if (map[x, y] == mo_player_left_body) g.FillRectangle(Brushes.OrangeRed, x * (p_pong.Size.Width / map_length), y * (p_pong.Size.Height / map_height), (p_pong.Size.Width / map_length), (p_pong.Size.Height / map_height));
                    if (map[x, y] == mo_player_right_head) g.FillRectangle(Brushes.Blue, x * (p_pong.Size.Width / map_length), y * (p_pong.Size.Height / map_height), (p_pong.Size.Width / map_length), (p_pong.Size.Height / map_height));
                    if (map[x, y] == mo_player_right_body) g.FillRectangle(Brushes.BlueViolet, x * (p_pong.Size.Width / map_length), y * (p_pong.Size.Height / map_height), (p_pong.Size.Width / map_length), (p_pong.Size.Height / map_height));
                    if (map[x, y] == mo_egg) g.FillRectangle(Brushes.White, x * (p_pong.Size.Width / map_length), y * (p_pong.Size.Height / map_height), (p_pong.Size.Width / map_length), (p_pong.Size.Height / map_height));
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            input.Update();
            
            if (cb_ki_right.Checked == false)
            {
                if (input.KB_Left_state == true) s_player_right_return = "left";
                if (input.KB_Right_state == true) s_player_right_return = "right";
                if (input.KB_Up_state == true) s_player_right_return = "up";
                if (input.KB_Down_state == true) s_player_right_return = "down";

                if ((input.KB_ctrl_state == true) && (input.KB_ctrl_state != KB_ctrl_state_last))
                {

                    if (player_right_lenght > snake_minimul_length)
                    {
                        player_right_lenght--;
                        player_right_max_lenght--;
                        wall_list.Add(player_right_snake[0]);
                        player_right_snake.RemoveAt(0);
                    }
                }
                KB_ctrl_state_last = input.KB_ctrl_state;
            }
            if (cb_ki_left.Checked == false)
            {
                if (input.KB_A_state == true) s_player_left_return = "left";
                if (input.KB_D_state == true) s_player_left_return = "right";
                if (input.KB_W_state == true) s_player_left_return = "up";
                if (input.KB_S_state == true) s_player_left_return = "down";

                if ((input.KB_F_state == true) && (input.KB_F_state != KB_F_state_last))
                {

                    if (player_left_lenght > snake_minimul_length)
                    {
                        player_left_lenght--;
                        player_left_max_lenght--;
                        wall_list.Add(player_left_snake[0]);
                        player_left_snake.RemoveAt(0);
                    }
                }
                KB_F_state_last = input.KB_F_state;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cb_ki_left.Checked == true) sw_player_left.WriteLine("end");
            if (cb_ki_right.Checked == true) sw_player_right.WriteLine("end");
        }
        
    }
}
