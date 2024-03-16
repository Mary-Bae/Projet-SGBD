using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIAdmin
{
    public static class Utils
    {
        public static int CalculerPlacesParRangee(int totalPlaces, int totalRangees, out string message)
        {
            if (totalPlaces % totalRangees == 0)
            {
                message = totalPlaces / totalRangees + " places par rangée";
                return totalPlaces / totalRangees;
            }
            else
            {
                message = "Erreur : Le total des places doit être divisible par le nombre de rangées";
                return 0;
            }
        }

        public static void InitialiserQteRangees(ComboBox comboBox)
        {
            for (int i = 1; i <= 5; i++)
            {
                comboBox.Items.Add(i);
            }
        }

        public static void InitialiserQtePlaces(ComboBox comboBox)
        {
            for (int i = 5; i <= 50; i++)
            {
                comboBox.Items.Add(i);
            }
        }

        public static void InitialiserNumSalle(ComboBox comboBox)
        {
            for (int i = 1; i <= 20; i++)
            {
                comboBox.Items.Add(i);
            }
        }

    }
}
