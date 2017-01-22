using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Input;


namespace ObjectMoving
{
    public partial class FormView : Form
    {

     

        private int _x;
        private int _y;
       


        public FormView()
        {

            InitializeComponent();
            _x = 50;
            _y = 50;
           

            //zquanghoangz@gmail.com
        }

        private void FormView_Paint(object sender, PaintEventArgs e)
        {
            //e.Graphics.FillRectangle(Brushes.BlueViolet, _x, _y, 100, 100);
            e.Graphics.DrawImage(new Bitmap("mushroom.png"), _x, _y, 64, 64);
        }

        private void tmrMoving_Tick(object sender, EventArgs e)
        {
            if (Keyboard.IsKeyDown(Key.Right))
            {
                _x += 20;
            }
             if (Keyboard.IsKeyDown(Key.Left))
            {
                _x -= 20;
            }
             if (Keyboard.IsKeyDown(Key.Up))
            {
                _y -= 20;
            }
             if (Keyboard.IsKeyDown(Key.Down))
            {
                _y += 20;
            }

            Invalidate();
        }

        private void FormView_KeyDown(object sender, EventArgs e)
        {
           
        }

        private void FormView_Load(object sender, EventArgs e)
        {

        }
    }
}
