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
        private void LoadSeats()
        {
            // Suppression de tous les contrôles existants pour éviter les doublons
            tblPanelSeats.Controls.Clear();
            tblPanelSeats.RowStyles.Clear();
            tblPanelSeats.ColumnStyles.Clear();

            // Configuration du TableLayoutPanel
            tblPanelSeats.RowCount = _reservationDetails.SalleDetails.sa_qteRangees;
            tblPanelSeats.ColumnCount = _reservationDetails.SalleDetails.sa_qtePlace_Rangee;

            // Ajout dynamique des sièges (boutons) au TableLayoutPanel
            for (int row = 0; row < _reservationDetails.SalleDetails.sa_qteRangees; row++)
            {
                // Définition du style de rangée pour chaque rangée
                tblPanelSeats.RowStyles.Add(new RowStyle(SizeType.Absolute, 40));

                for (int seat = 0; seat < _reservationDetails.SalleDetails.sa_qtePlace_Rangee; seat++)
                {
                    // Définition du style de colonne pour la première rangée
                    if (row == 0)
                    {
                        tblPanelSeats.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40));
                    }

                    Button seatButton = new Button
                    {
                        Text = $"{row + 1}-{seat + 1}",
                        Size = new Size(40, 40),
                        Margin = new Padding(0),
                        BackColor = Color.LightGreen,
                        Tag = new SeatTag { Row = row, Seat = seat } // Utilisation d'une classe personnalisée pour stocker les données de chaque siège
                    };
                    seatButton.Click += SeatButton_Click;

                    // Ajout du bouton au TableLayoutPanel
                    tblPanelSeats.Controls.Add(seatButton, seat, row);
                }
            }
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
                Sieges = sieges
            };
            SaveReservation(reservation);
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
                    MessageBox.Show("Réservation enregistrée avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
    // Une classe qui sert à stocker les informations sur les sièges
    public class SeatTag
    {
        public int Row { get; set; }
        public int Seat { get; set; }
    }
}
