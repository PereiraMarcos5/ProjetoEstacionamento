using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity.Migrations;
using System.Runtime.CompilerServices;

namespace ProjetoBenner
{
    public partial class Estacionamentos : Form
    {
        EstacionamentoEntities db = new EstacionamentoEntities();
        public  int idCliente = 0;
        DateTime Marcarsaida;
        cliente clienteSelecionado;
        public bool podeFinalizar;
        
        public Estacionamentos()
        {
            InitializeComponent();
            
        }
        public double valor_pagar;
        public Estacionamentos(DateTime saida)
        {
            
            InitializeComponent();
            //btnFinalizar_Click += Saida(saida);
            Marcarsaida = saida;
            if (Convert.ToString(Marcarsaida) != ("01/01/0001 00:00:00"))
            {
                podeFinalizar = true;
            }
            else
            {
                podeFinalizar = false;
            }

        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            HorarioEntrada horario = new HorarioEntrada();
            horario.Show();
        }

        public void btnSaida_Click(object sender, EventArgs e)
        {
           HorarioSaida saida1 = new HorarioSaida();
            
            
            Estacionamentos estacionamentos = new Estacionamentos();
            saida1.Show();
            this.Hide();
            //Saida();
        }

        public void Saida()
        {
            int idCliente = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            cliente c = db.cliente.Find(idCliente);
            
            TimeSpan duration = DateTime.Parse(Convert.ToString(c.horario_saida)).Subtract(DateTime.Parse(Convert.ToString(c.horario_entrada)));          
            TimeSpan duracaopagar = (c.horario_saida).Subtract(c.horario_entrada);

            if (duracaopagar >= new TimeSpan(0, 0, 0) & duracaopagar <= new TimeSpan(0, 30, 0))
            {
                valor_pagar = 1.00;
            }
            if (duracaopagar >= new TimeSpan(0, 30, 0) & duracaopagar <= new TimeSpan(1, 10, 0))
            {
                valor_pagar = 2.00;
            }
            if (duracaopagar >= new TimeSpan(1, 10, 0)  & duracaopagar <= new TimeSpan(2, 10, 0))
            {
                valor_pagar = 3.00;
            }
            if (duracaopagar >= new TimeSpan(2, 10, 0) & duracaopagar <= new TimeSpan(3, 10, 0))
            {
                valor_pagar = 4.00;
            }
            if (duracaopagar >= new TimeSpan(3, 10, 00) &  duracaopagar <= new TimeSpan(4, 10, 0))
            {
                valor_pagar = 5.00;
            }
            if (duracaopagar >= new TimeSpan(4, 10, 00) & duracaopagar <= new TimeSpan(5, 10, 0))
            {
                valor_pagar = 6.00;
            }
            if (duracaopagar >= new TimeSpan(5, 10, 00) & duracaopagar <= new TimeSpan(6, 10, 0))
            {
                valor_pagar = 7.00;
            }
            if (duracaopagar >= new TimeSpan(6, 10, 00) & duracaopagar <= new TimeSpan(7, 10, 0))
            {
                valor_pagar = 8.00;
            }
            if (duracaopagar >= new TimeSpan(7, 10, 00) & duracaopagar <= new TimeSpan(8, 10, 0))
            {
                valor_pagar = 9.00;
            }
            if (duracaopagar >= new TimeSpan(8, 10, 00) & duracaopagar <= new TimeSpan(9, 10, 0))
            {
                valor_pagar = 10.00;
            }
            if (duracaopagar >= new TimeSpan(9, 10, 00) & duracaopagar <= new TimeSpan(10, 10, 0))
            {
                valor_pagar = 11.00;
            }
            if (duracaopagar >= new TimeSpan(10, 10, 00) & duracaopagar <= new TimeSpan(11, 10, 0))
            {
                valor_pagar = 12.00;
            }
            if (duracaopagar >= new TimeSpan(11, 10, 00) & duracaopagar <= new TimeSpan(12, 10, 0))
            {
                valor_pagar = 13.00;
            }
            if (duracaopagar >= new TimeSpan(12, 10, 00))
            {
                MessageBox.Show("Maximo de 12 horas permitidas");
            }
            cliente novo = new cliente()
            {
                id_cliente = c.id_cliente,
                valor_a_pagar = valor_pagar,
                duracao = Convert.ToString(duration),
                horario_entrada = c.horario_entrada,
                horario_saida = Marcarsaida,
                placa = c.placa
            };   
            db.cliente.AddOrUpdate(novo);
           // db.Entry(novo).State = EntityState.Modified;
            db.SaveChanges();
            
        }
        

        private void Estacionamentos_Load(object sender, EventArgs e)
        {
            this.clienteTableAdapter2.Fill(this.estacionamentoDataSet3.cliente);
        }

        public void MontarTabela()
        { 
            
            dataGridView1.DataSource = db.cliente.Select(c => new
            {
                c.id_cliente,
                c.placa,
                c.duracao,
                c.horario_entrada,
                c.horario_saida,
                c.valor_a_pagar

            }).ToList();
            dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0];
        }

        public void Listar()
        {
            Saida();
            MessageBox.Show("Finalizado com Sucesso");
            dataGridView1.DataSource = db.cliente.Select(c => new
            {
                c.id_cliente,
                c.placa,
                c.duracao,
                c.horario_entrada,
                c.horario_saida,
                c.valor_a_pagar

            }).ToList();
            dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0];
        }

        private void Estacionamentos_Activated(object sender, EventArgs e)
        {
            //Listar();
            MontarTabela();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (podeFinalizar == true)
            {
            Saida();
            Listar();
            }
            else if(podeFinalizar == false)
            {
                MessageBox.Show("Marque a Saída para Finalizar");
            }
        }

        private void Estacionamentos_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

        private void Estacionamentos_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Estacionamentos_Leave(object sender, EventArgs e)
        {
            
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.cliente.Where(c=> c.placa.Contains(txtPesquisa.Text)).ToList();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());

            if (id > 0)
            {
                clienteSelecionado = db.cliente.Find(id);
                db.cliente.Remove(clienteSelecionado);
                db.SaveChanges();
                MessageBox.Show("Cliente Excluido");
                MontarTabela();

            }
            else
            {
                MessageBox.Show("Selecione o cliente que voce quer remover");
            }
        }
    }
}
