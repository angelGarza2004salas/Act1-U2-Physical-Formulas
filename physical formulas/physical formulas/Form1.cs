using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace physical_formulas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalculateVelocity_Click(object sender, EventArgs e)
        {
            try
            {
                if (double.TryParse(TxtDistance.Text, out double distancia) && double.TryParse(TxtTime.Text, out double tiempo))
                {
                    if (tiempo > 0)
                    {
                        Velocity velocidad = new Velocity(distancia, tiempo);
                        LblResultVelocity.Text = $"Velocidad: {velocidad.Calculate()} m/s";
                    }
                    else
                    {
                        MessageBox.Show("El tiempo debe ser mayor que 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese valores numéricos válidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtnCalculateAceleration_Click(object sender, EventArgs e)
        {
            try
            {
                if (double.TryParse(TxtInitialVelocity.Text, out double velocidadInicial) &&
                    double.TryParse(TxtFinalVelocity.Text, out double velocidadFinal) &&
                    double.TryParse(TxtAccelerationTime.Text, out double tiempo))
                {
                    if (tiempo > 0)
                    {
                        Aceleration aceleracion = new Aceleration(velocidadInicial, velocidadFinal, tiempo);
                        LblResultAceleration.Text = $"Aceleración: {aceleracion.Calculate()} m/s²";
                    }
                    else
                    {
                        MessageBox.Show("El tiempo debe ser mayor que 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese valores numéricos válidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCalculateKineticEnergy_Click(object sender, EventArgs e)
        {
            try
            {
                if (double.TryParse(TxtMass.Text, out double masa) && double.TryParse(TxtVelocity.Text, out double velocidad))
                {
                    Kinetic_energy energiaCinetica = new Kinetic_energy (masa, velocidad);
                    LblResultKineticEnergy.Text = $"Energía Cinética: {energiaCinetica.Calculate()} J";
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese valores numéricos válidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
