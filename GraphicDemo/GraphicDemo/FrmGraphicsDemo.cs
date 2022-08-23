namespace GraphicDemo
{
    public partial class FrmGraphicsDemo : Form
    {
        public FrmGraphicsDemo()
        {
            InitializeComponent();
        }
        private void FrmGraphicsDemo_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            //Create a font
            Font f = new Font("Verdana", 30);
            //Create a brush
            SolidBrush b = new SolidBrush(Color.Blue);
            //Draw a string
            g.DrawString("Hello", f, b, 40, 40);
            //Create a pen
            Pen p = new Pen(Color.Red, 2);
            //Draw a line
            g.DrawLine(p, 0, 0, 140, 140);
            //Draw more
            for (int j = 0; j < 100; j++)
            {
                for (int i = 0; i < 500; i++)
                {
                    g.DrawLine(p, i, (int)(Math.Sin((i+j) / 50.0 * 3.14) * 50) + 200, i+1, (int)(Math.Sin((i+j+1)/50.0*3.14)*50) +200);
                }
                g.Clear(Color.White);
                Thread.Sleep(100);
            }

        }

        private void FrmGraphicsDemo_Load(object sender, EventArgs e)
        {

        }
    }
}