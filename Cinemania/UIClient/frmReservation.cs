using Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIClient
{

    public partial class frmReservation : Form
    {
        private ReservationDetailsDTO _reservationDetails;
        private HashSet<SeatTag> _selectedSeats = new HashSet<SeatTag>();
        private int _numberOfTickets = 0;
        private static readonly HttpClient client = new HttpClient();
        public frmReservation(ReservationDetailsDTO reservationDetails)
        {
            InitializeComponent();
            _reservationDetails = reservationDetails;
            lblCinemaNom.Text = reservationDetails.CinemaNom;
            lblSalle.Text = "salle " + reservationDetails.SalleDetails.sa_numeroSalle.ToString();
            LoadSeats();
        }
        private async void LoadSeats()
        {
            var reservedSeats = await GetReservedSeats();

            tblPanelSeats.Controls.Clear();
            tblPanelSeats.RowStyles.Clear();
            tblPanelSeats.ColumnStyles.Clear();

            tblPanelSeats.RowCount = _reservationDetails.SalleDetails.sa_qteRangees;
            tblPanelSeats.ColumnCount = _reservationDetails.SalleDetails.sa_qtePlace_Rangee;

            for (int row = 0; row < _reservationDetails.SalleDetails.sa_qteRangees; row++)
            {
                tblPanelSeats.RowStyles.Add(new RowStyle(SizeType.Absolute, 40));
                for (int seat = 0; seat < _reservationDetails.SalleDetails.sa_qtePlace_Rangee; seat++)
                {
                    Button seatButton = new Button
                    {
                        Text = $"{row + 1}-{seat + 1}",
                        Size = new Size(40, 40),
                        Margin = new Padding(0),
                        BackColor = Color.LightGreen,
                        Tag = new SeatTag { Row = row, Seat = seat }
                    };

                    if (reservedSeats.Any(s => s.Row == row && s.SeatNumber == seat))
                    {
                        seatButton.Enabled = false; // Désactive le bouton pour les sièges réservés
                        seatButton.BackColor = Color.LightGray; // Change la couleur pour indiquer qu'ils sont pris
                    }
                    else
                    {
                        seatButton.Click += SeatButton_Click;
                    }

                    tblPanelSeats.Controls.Add(seatButton, seat, row);
                }
            }
        }

        private async Task<List<SiegeDTO>> GetReservedSeats()
        {
            // Construisez l'URL pour l'API
            string url = $"https://localhost:7013/Client/Reservation/SiegesReservesByProjection?projectionId={_reservationDetails.SalleDetails.pro_id}&date={_reservationDetails.DateSelectionnee.ToString("yyyy-MM-dd")}";

            var response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var reservedSeats = JsonConvert.DeserializeObject<List<SiegeDTO>>(content);
                return reservedSeats;
            }
            return new List<SiegeDTO>();
            
        }
        private void SeatButton_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            var seatTag = button.Tag as SeatTag;

            if (_selectedSeats.Contains(seatTag))
            {
                // Si le siège est déjà sélectionné, permettre de le désélectionner
                button.BackColor = Color.LightGreen;
                _selectedSeats.Remove(seatTag);
            }
            else if (_selectedSeats.Count < _numberOfTickets)
            {
                // Sélectionner un nouveau siège si le nombre maximum n'est pas atteint
                button.BackColor = Color.Red;
                _selectedSeats.Add(seatTag);
            }
        }

        private void nbrTickets_ValueChanged(object sender, EventArgs e)
        {
            int prix = 10;
            _numberOfTickets = (int)nbrTickets.Value;
            int prixTotal = prix *= _numberOfTickets;
            lblTotal.Text = "Total à payer :" + prixTotal.ToString() + "€";
        }

        private void btReserver_Click(object sender, EventArgs e)
        {
            if (_selectedSeats.Count != _numberOfTickets)
            {
                MessageBox.Show("Veuillez sélectionner le nombre correct de sièges.");
                return;
            }

            var sieges = _selectedSeats.Select(s => new SiegeDTO
            {
                Row = s.Row,
                SeatNumber = s.Seat
            }).ToList();

            ReservationDTO reservation = new ReservationDTO
            {
                ProjectionId = _reservationDetails.SalleDetails.pro_id,
                NbrPersonnes = _numberOfTickets,
                Sieges = sieges,
                DateReservee = _reservationDetails.DateSelectionnee
            };
            if (MessageBox.Show("Voulez-vous confirmer votre réservation ?", "Confirmer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SaveReservation(reservation);

                // Vérifier si le formulaire parent existe et s'il n'est pas déjà fermé
                if (this.Owner != null && !this.Owner.IsDisposed)
                {
                    // Fermer le formulaire parent
                    this.Owner.Close();
                }
                this.Close();
            }
            
        }
        private async void SaveReservation(ReservationDTO reservation)
        {
            try
            {
                var jsonContent = JsonConvert.SerializeObject(reservation);
                var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
                var response = await client.PostAsync("https://localhost:7013/Client/Reservation/AddReservation", content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Nous vous remercions pour votre réservation" , "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erreur lors de l'enregistrement de la réservation.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Une erreur est survenue : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous quitter sans réserver ?", "Confirmer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }
    }
    // Une classe qui sert à stocker les informations sur les sièges
    public class SeatTag
    {
        public int Row { get; set; }
        public int Seat { get; set; }
    }
}
