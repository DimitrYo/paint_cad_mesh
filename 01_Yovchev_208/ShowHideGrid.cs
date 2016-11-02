using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _01_Yovchev_208
{
    public partial class ShowHideGrid : Form
    {
        public bool showhide_grid;
        public bool lock_grid;
        public int grid_size; 

        public ShowHideGrid(bool sh , bool lockg, int gsize )
        {
            InitializeComponent();
            showhide_grid = sh;
            lock_grid = lockg;
            grid_size = gsize;
            sizecheck.Value = gsize;
            showhidecheck.Checked = showhide_grid;
            if (showhide_grid) lock_gridcheck.Checked = lock_grid;
            else
            {
                lock_gridcheck.Checked = false;
                lock_gridcheck.Enabled = false;
            };

        }

        private void showhidecheck_CheckedChanged(object sender, EventArgs e)
        {
            if (showhidecheck.Checked)
            {
                showhide_grid = true;
                lock_gridcheck.Enabled = true;
            }
            else
            {
                showhide_grid = lock_grid = false;
                lock_gridcheck.Checked = false;
                lock_gridcheck.Enabled = false;
            }
        }

        private void lock_grid_CheckedChanged(object sender, EventArgs e)
        {
            if (lock_gridcheck.Checked)
            {
                lock_grid = true;
            }
            else
                lock_grid = false;
        }

        private void sizecheck_ValueChanged(object sender, EventArgs e)
        {
            grid_size = (int)sizecheck.Value;
        }

    }
}
