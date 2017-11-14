using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;


namespace Pong_KivKi
{
    class Input
    {
        [DllImport("User32.dll")]
        public static extern ushort GetAsyncKeyState(System.Windows.Forms.Keys vKey);

        public bool KB_Left_state;
        public bool KB_Right_state;
        public bool KB_Up_state;
        public bool KB_Down_state;
        public bool KB_ctrl_state;

        public bool KB_A_state;
        public bool KB_D_state;
        public bool KB_W_state;
        public bool KB_S_state;
        public bool KB_F_state;

        public bool KB_Space_state;
        public bool KB_Control_state;
        public bool M_Left_state;
        public bool M_Right_state;
        public int M_Position_X;
        public int M_Position_Y;


        public Input()
        {
            this.Update();
        }

        public bool Update()
        {
            try
            {
                M_Position_X = Control.MousePosition.X;
                M_Position_Y = Control.MousePosition.Y;
                if (GetAsyncKeyState(Keys.LButton) != 0) M_Left_state = true;
                else M_Left_state = false;
                if (GetAsyncKeyState(Keys.RButton) != 0) M_Right_state = true;
                else M_Right_state = false;
                if (GetAsyncKeyState(Keys.Left) != 0) KB_Left_state = true;
                else KB_Left_state = false;
                if (GetAsyncKeyState(Keys.Right) != 0) KB_Right_state = true;
                else KB_Right_state = false;
                if (GetAsyncKeyState(Keys.Up) != 0) KB_Up_state = true;
                else KB_Up_state = false;
                if (GetAsyncKeyState(Keys.Down) != 0) KB_Down_state = true;
                else KB_Down_state = false;
                if (GetAsyncKeyState(Keys.ControlKey) != 0) KB_ctrl_state = true;
                else KB_ctrl_state = false;

                if (GetAsyncKeyState(Keys.A) != 0) KB_A_state = true;
                else KB_A_state = false;
                if (GetAsyncKeyState(Keys.D) != 0) KB_D_state = true;
                else KB_D_state = false;
                if (GetAsyncKeyState(Keys.W) != 0) KB_W_state = true;
                else KB_W_state = false;
                if (GetAsyncKeyState(Keys.S) != 0) KB_S_state = true;
                else KB_S_state = false;
                if (GetAsyncKeyState(Keys.F) != 0) KB_F_state = true;
                else KB_F_state = false;

                if (GetAsyncKeyState(Keys.Space) != 0) KB_Space_state = true;
                else KB_Space_state = false;
                if (GetAsyncKeyState(Keys.ControlKey) != 0) KB_Control_state = true;
                else KB_Control_state = false;
                return true;
            }
            catch
            {
                return false;
            }

        }
    }
}
