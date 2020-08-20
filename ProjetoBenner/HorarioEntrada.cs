using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace ProjetoBenner
{
    public partial class HorarioEntrada : Form
    {
         EstacionamentoEntities db = new EstacionamentoEntities();

       
        public HorarioEntrada()
        {
            InitializeComponent();
            dtpEntrada.Format = DateTimePickerFormat.Custom;
            dtpEntrada.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            dtpEntrada.ShowUpDown = true;
            //dtpSaida.Format = DateTimePickerFormat.Time;
            //dtpSaida.ShowUpDown = true;


        }

        private void HorarioEntrada_Load(object sender, EventArgs e)
        {

        }

        public void btnInicio_Click(object sender, EventArgs e)
        {
            string placaMaiuscula = mtxtPlaca.Text.ToUpper();
            cliente novo = new cliente()
            {
                
                placa = placaMaiuscula,
                horario_entrada = Convert.ToDateTime(dtpEntrada.Text),
                duracao = ("00:00:00"),
                horario_saida = Convert.ToDateTime(dtpEntrada.Text),
                valor_a_pagar = 0,
            };
            db.cliente.Add(novo);
            db.Entry(novo).State = EntityState.Added;
            db.SaveChanges();
            MessageBox.Show("Salvo com sucesso");
            this.Dispose();
        }

        private void HorarioEntrada_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

        private void HorarioEntrada_FormClosed(object sender, FormClosedEventArgs e)
        {
            HorarioSaida horarioSaida = new HorarioSaida();
            horarioSaida.Close();
        }

        private void mtxtPlaca_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void dtpEntrada_CursorChanged(object sender, EventArgs e)
        {
           
        }
    }
}


