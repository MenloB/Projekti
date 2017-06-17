using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Source
{
    public partial class EditPredmet : Form
    {
        public DTPredmet predmet;

        public EditPredmet()
        {
            InitializeComponent();
        }

        public EditPredmet(DTPredmet predmet)
        {
            this.predmet = predmet;
            InitializeComponent();
            LoadPredmetInfo();
        }

        private void LoadPredmetInfo()
        {

        }
    }
}
