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
    

    public partial class frmReservation : Form
    {
        private ReservationDetailsDTO _reservationDetails;
        public frmReservation(ReservationDetailsDTO reservationDetails)
        {
            InitializeComponent();
            _reservationDetails = reservationDetails;
            lblCinemaNom.Text = reservationDetails.CinemaNom;
            lblSalle.Text = "salle " + reservationDetails.SalleDetails.sa_numeroSalle.ToString();
        }
    }
}
