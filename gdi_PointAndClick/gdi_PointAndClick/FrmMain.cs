using System.Collections.Generic; // benötigt für Listen

namespace gdi_PointAndClick
{
    public partial class FrmMain : Form
    {
        // Todo: Geeignete Datenstrukturen finden.

        public FrmMain()
        {
            InitializeComponent();
            ResizeRedraw = true;
        }

        private void FrmMain_Paint(object sender, PaintEventArgs e)
        {
            // Hilfsvarablen
            Graphics g = e.Graphics;
            int w = this.ClientSize.Width;
            int h = this.ClientSize.Height;

            // Zeichenmittel
            Pen schwarz = new Pen(Color.Black);
            Brush b = new SolidBrush(Color.Lavender);




        }

        private void FrmMain_MouseClick(object sender, MouseEventArgs e)
        {
            Point mausposition = e.Location;


            Refresh();
        }

        private void FrmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
 
                Refresh();
            }
        }
    }
}