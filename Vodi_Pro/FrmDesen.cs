using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using move_or_copy_a_line;
using Vodi_Pro;

namespace Desen
{
    
    public partial class Form1 : Form
    {
        // şifre 338. satırda, şifreyi liste olarak yollayınca direk çizime geçiyo
        private List<LineList> MyLines = new List<LineList>();
        private List<PictureBox> myNumbers = new List<PictureBox>();
        private List<int> list1 = new List<int>();
        private List<int> list2 = new List<int>();
        private List<int> list3 = new List<int>();
        private List<int> pass = new List<int>();
        bool show = false;
        public Point MouseDownLocation;
        private bool IsMouseDown = false;
        private int m_StartX;
        private int m_StartY;
        private int m_CurX;
        private int m_CurY;
        private int m_CY;
        private int m_CX;
        public static string passwordlast = "";
        public static string  pasw = "";
        MouseEventArgs me; PaintEventArgs tr;
        int num = 1;
        public Form1(List<int> liste = null)
        {
            InitializeComponent();

            list1.Add(1);
            list1.Add(2);
            list1.Add(3);
            list2.Add(4);
            list2.Add(5);
            list2.Add(6);
            list3.Add(7);
            list3.Add(8);
            list3.Add(9);
            myNumbers.Add(pictureBox1);
            myNumbers.Add(pictureBox2);
            myNumbers.Add(pictureBox3);
            myNumbers.Add(pictureBox4);
            myNumbers.Add(pictureBox5);
            myNumbers.Add(pictureBox6);
            myNumbers.Add(pictureBox7);
            myNumbers.Add(pictureBox8);
            myNumbers.Add(pictureBox9);
            foreach (PictureBox o in myNumbers)
            {
                o.Visible = false;
                o.Parent = pictureBoxPattern;
            }
            if (liste != null)
            {
                show = true;
                pass = liste;
                drow(pass);
                btnKaydet.BackColor = Color.Silver;
                btnKaydet.Text = Vodi_Pro.Properties.Languages.S0070;
                btnKaydet.Image = Vodi_Pro.Properties.Resources.synchronize;
            }
        }
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            me = e;
            int mx = 0;
            int my = 0;
            if (e.Y <= 255 && e.Y >= 220)
            {
                m_CY = 239;
                my = 2;
            }
            else if (e.Y <= 150 && e.Y >= 115)
            {
                m_CY = 136;
                my = 1;
            }
            else if (e.Y <= 50 && e.Y >= 15)
            {
                m_CY = 33;
                my = 0;
            }
            else
            {
                return;
            }

            if (e.X <= 260 && e.X >= 225)
            {
                m_CX = 244;
                mx = 2;
            }
            else if (e.X <= 160 && e.X >= 125)
            {
                m_CX = 140;
                mx = 1;
            }
            else if (e.X <= 55 && e.X >= 25)
            {
                m_CX = 37;
                mx = 0;

            }
            else
            {
                return;
            }

            if (my == 0)
            {
                if (myNumbers[list1[mx] - 1].Visible == false)
                {
                    pass.Add(list1[mx] - 1);
                    myNumbers[list1[mx] - 1].Visible = true;
                }
                else
                {
                    return;
                    //myNumbers[list1[mx] - 1].Visible = false;
                }

            }
            else if (my == 1)
            {
                if (myNumbers[list2[mx] - 1].Visible == false)
                {
                    pass.Add(list2[mx] - 1);
                    myNumbers[list2[mx] - 1].Visible = true;
                }
                else
                {
                    return;
                    //  myNumbers[list2[mx] - 1].Visible = false;
                }
            }
            else
            {
                if (myNumbers[list3[mx] - 1].Visible == false)
                {
                    pass.Add(list3[mx] - 1);
                    myNumbers[list3[mx] - 1].Visible = true;
                }
                else
                {
                    // myNumbers[list3[mx] - 1].Visible = false;
                    return;
                }
            }
            if (num == 1)
            {
                MyLines.Clear();
                foreach (PictureBox o in myNumbers)
                {
                    o.Visible = false;
                }
                m_StartX = m_CX;
                m_StartY = m_CY;
                m_CurX = m_CX;
                m_CurY = m_CY;
                num++; IsMouseDown = true;
                pictureBoxPattern.Invalidate();
            }
            else
            {
                IsMouseDown = false;
                string ort = ((m_StartX + m_CurX) / 2).ToString() + ((m_StartY + m_CurY) / 2).ToString();
                if (ort == "14033")
                {

                    if (myNumbers[1].Visible == false)
                    {
                        pass.Add(2);
                        myNumbers[1].Visible = true;
                    }
                }
                else if (ort == "37136")
                {
                    if (myNumbers[3].Visible == false)
                    {
                        pass.Add(4);
                        myNumbers[3].Visible = true;
                    }
                }
                else if (ort == "140136")
                {
                    if (myNumbers[4].Visible == false)
                    {
                        pass.Add(5);
                        myNumbers[4].Visible = true;
                    }
                }
                else if (ort == "244136")
                {
                    if (myNumbers[5].Visible == false)
                    {
                        pass.Add(6);
                        myNumbers[5].Visible = true;
                    }
                }
                else if (ort == "140239")
                {
                    if (myNumbers[7].Visible == false)
                    {
                        pass.Add(8);
                        myNumbers[7].Visible = true;
                    }
                }

                LineList DrawLine = new LineList();
                DrawLine.X1 = m_StartX;
                DrawLine.Y1 = m_StartY;
                DrawLine.X2 = m_CurX;
                DrawLine.Y2 = m_CurY;
                MyLines.Add(DrawLine);
                pictureBoxPattern.Invalidate();
                IsMouseDown = true;
                m_StartX = m_CX;
                m_StartY = m_CY;
                m_CurX = m_CX;
                m_CurY = m_CY;
            }

        }
        int numY(int numb)
        {
            if (numb > 6)
            {
                return 239;
            }
            else if (numb > 3)
                return 136;
            else
                return 33;
        }
        int numX(int numb)
        {
            if (numb % 3 == 0)
            {
                return 244;
            }
            else if (numb % 3 == 2)
                return 140;
            else
                return 37;
        }
        private async void drow(List<int> numberList)
        {
            int startX = numX(numberList[0]);
            int startY = numY(numberList[0]);
            int newX, newY;
            if (myNumbers[numberList[0] - 1].Visible == false)
            {
                myNumbers[numberList[0] - 1].Visible = true;
            }
            for (int i = 1; i < numberList.Count; i++)
            {
                newX = numX(numberList[i]);
                newY = numY(numberList[i]);
                LineList DrawLine = new LineList();
                DrawLine.X1 = startX;
                DrawLine.Y1 = startY;
                DrawLine.X2 = newX;
                DrawLine.Y2 = newY;
                MyLines.Add(DrawLine);
                pictureBoxPattern.Invalidate();
                IsMouseDown = true;
                startX = newX;
                startY = newY;
                if (myNumbers[numberList[i] - 1].Visible == false)
                {
                    myNumbers[numberList[i] - 1].Visible = true;
                }
                await Task.Delay(500);

            }
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (show)
                return;
            Pen dashed_pen = new Pen(Color.Blue, 1);
            dashed_pen.DashStyle = DashStyle.Dash;
            if (IsMouseDown == false) return;
            if (e.Y <= 255 && e.Y >= 220)
            {
                m_CY = 239;
                // return;
            }
            else if (e.Y <= 150 && e.Y >= 115)
            {
                m_CY = 136;

            }
            else if (e.Y <= 50 && e.Y >= 15)
            {
                m_CY = 33;

            }
            else
            {
                m_CY = e.Y;
            }
            if (e.X <= 260 && e.X >= 225)
            {
                m_CX = 244;
                // return;
            }
            else if (e.X <= 160 && e.X >= 125)
            {
                m_CX = 140;

            }
            else if (e.X <= 55 && e.X >= 25)
            {
                m_CX = 37;

            }
            else
            {
                m_CX = e.X;
            }
            m_CurX = m_CX;
            m_CurY = m_CY;
            pictureBoxPattern.Invalidate();
            pictureBox1_MouseDown(this, e);
        }
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            num = 1;
            IsMouseDown = false;
            //Console.WriteLine("count:" + pass.Count.ToString());
            pasw = "";
            foreach (int item in pass)
            {
                pasw += ((item + 1).ToString());
            }
            //Console.WriteLine(pasw.Substring(1));
            if (pasw.Length>1)
                pasw = pasw.Substring(1);
          
            pass.Clear();
    
          //  IsMouseDown = true;
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            tr = e;
            int i, x1, y1, x2, y2;

            for (i = 0; i <= MyLines.Count - 1; i++)
            {
                Pen LinePen = new Pen(Color.Blue, 6);
                x1 = MyLines[i].X1;
                x2 = MyLines[i].X2;
                y1 = MyLines[i].Y1;
                y2 = MyLines[i].Y2;
                e.Graphics.DrawLine(LinePen, x1, y1, x2, y2);
            }
            Pen dashed_pen = new Pen(Color.Blue, 1);
            e.Graphics.DrawLine(dashed_pen, m_StartX, m_StartY, m_CurX, m_CurY);
        }
        private void pictureBox_Click(object sender, EventArgs e)
        {
            if (show)
                return;
            num = 1;
            pasw = "";
            pass.Clear();
            IsMouseDown = false;
            MyLines.Clear();
            foreach (PictureBox o in myNumbers)
            {
                o.Visible = false;
            }
            pictureBoxPattern.Invalidate();
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(pasw.Substring(1));
            if (btnKaydet.Text == Vodi_Pro.Properties.Languages.S0070)
            {
                IsMouseDown = false;
                btnKaydet.Text = Vodi_Pro.Properties.Languages.S0038;
                pasw = "";
                num = 1;
                IsMouseDown = false;
                MyLines.Clear();
                pass.Clear();
                foreach (PictureBox o in myNumbers)
                {
                    o.Visible = false;
                }
                pictureBoxPattern.Invalidate();
                show = false; 
                btnKaydet.BackColor = Color.White;
                btnKaydet.Image = Vodi_Pro.Properties.Resources.checkmark;
            }
            else
            {
                Console.WriteLine(pasw);
                passwordlast = pasw;
                this.Close();
            }
        }
    }
}
