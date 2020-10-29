using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Components
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            Update();
        }
        public System.Drawing.Point LocationChanged { get; set; }


        private void mainForm_Load(object sender, EventArgs e)
        {
            //int left = this.DesktopLocation.X;
            //int top = this.DesktopLocation.Y;
           this.Text = ""+ this.LocationChanged.X + "" + this.LocationChanged.Y;
            //this.Text = "" + left + "" + top;
        }
        private void mainForm_LocationChanged(object sender, EventArgs e)
        {
            var x = this.Location.X.ToString();
            var y = this.Location.Y.ToString();

            this.Text = "(" + x + ", " + y + ") Winforms Components - Common Controls";
            throw new NotImplementedException();
        }
    }
}
