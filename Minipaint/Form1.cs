namespace Minipaint
{

    public partial class Form1 : Form
    {
        int[] xy = new int[2] {-1,-1};
        public Graphics graphics { get; set; }
        public Pen Pen { get; set; }
        public bool Fill { get; set; } = false;
        public Brush Brush { get; set; }
        public Form1()
        {
            InitializeComponent();
            sizes.SelectedIndex = 2;
            graphics = CreateGraphics();
            Pen = new Pen(Color.Red, 7);
            Brush = new SolidBrush(Color.Red);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            xy[0] = e.X; xy[1] = e.Y;
        }
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            
            Brush = new SolidBrush(colorDialog1.Color);
            Pen = new Pen (colorDialog1.Color,sizes.SelectedIndex);
            if (pencil.Checked) Fill = true;
            else Fill = false;
            foreach (Guna.UI2.WinForms.Guna2ImageRadioButton item in panel1.Controls)
            {
                if (item.Checked)
                {
                    switch (item.Name)
                    {
                        case "Rec":
                            Rectangle(e.Location);
                            break;
                        case "Circle":
                            Cricle(e.Location);
                            break;
                        case "Triangl":
                            FillTriangle(new Point(xy[0], xy[1]), e.Y - xy[1]);
                            break;
                        default:
                            break;
                    }
                }
            }

        }

        public  void FillTriangle(Point p, int size)
        {
            if (Fill)
            {
                graphics.DrawPolygon(Pen, new Point[] { p, new Point(p.X - size, p.Y + (int)(size * Math.Sqrt(3))), new Point(p.X + size, p.Y + (int)(size * Math.Sqrt(3))) });
            }
            else
                graphics.FillPolygon(Brush, new Point[] { p, new Point(p.X - size, p.Y + (int)(size * Math.Sqrt(3))), new Point(p.X + size, p.Y + (int)(size * Math.Sqrt(3)))});
        }
     
        public void Cricle(Point Location)
        {

            if (Location.X - xy[0] < 0)
            {
                if (Fill)
                    graphics.DrawEllipse(Pen, Location.X, Location.Y, xy[0] - Location.X, xy[1] - Location.Y);
                else
                    graphics.FillEllipse(Brush, Location.X, Location.Y, xy[0] - Location.X, xy[1] - Location.Y);
            }
            else
            {
                if (Fill)
                    graphics.DrawEllipse(Pen, xy[0], xy[1], Location.X - xy[0], Location.Y - xy[1]);
                else
                    graphics.FillEllipse(Brush, xy[0], xy[1], Location.X - xy[0], Location.Y - xy[1]);
            }
        }
        public void Rectangle(Point Location)
        {

            if (Location.X - xy[0] < 0)
            {
                if (Fill)
                    graphics.DrawRectangle(Pen, Location.X, Location.Y, xy[0] - Location.X, xy[1] - Location.Y);
                else
                    graphics.FillRectangle(Brush, Location.X, Location.Y, xy[0] - Location.X, xy[1] - Location.Y);
            }
            else
            {
                if (Fill)
                    graphics.DrawRectangle(Pen, xy[0], xy[1], Location.X - xy[0], Location.Y - xy[1]);
                else
                    graphics.FillRectangle(Brush, xy[0], xy[1], Location.X - xy[0], Location.Y - xy[1]);
            }
        }

    }
}