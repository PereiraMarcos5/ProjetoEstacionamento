using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoBenner
{
    public partial class HorarioSaida : Form
    {
        EstacionamentoEntities db = new EstacionamentoEntities();
        public HorarioSaida()
        {
            InitializeComponent();
            dtpSaida.Format = DateTimePickerFormat.Custom;
            dtpSaida.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            dtpSaida.ShowUpDown = true;


        }


        public void btnSaida_Click(object sender, EventArgs e)
        {
            MarcarSaida();
        }

        public void MarcarSaida()
        {
            Estacionamentos estacionamentos = new Estacionamentos();
            DateTime saida = Convert.ToDateTime(dtpSaida.Text);
            Estacionamentos destino = new Estacionamentos(saida);
            destino.Show();

            this.Dispose();


        }

        private void HorarioSaida_FormClosed(object sender, FormClosedEventArgs e)
        {
            HorarioSaida horarioSaida = new HorarioSaida();
            horarioSaida.Dispose();
        }
    }
}

