using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIClient
{
    public partial class frmCinema : Form
    {
        private CinemasDTO _cinemaDetails;
        private static readonly HttpClient client = new HttpClient();
        public frmCinema(CinemasDTO cinemaDetails)
        {
            InitializeComponent();
            _cinemaDetails = cinemaDetails;
            lblCinemaNom.Text = _cinemaDetails.ci_nom;
        }
    }
}
