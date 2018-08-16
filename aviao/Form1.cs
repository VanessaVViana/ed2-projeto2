using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aviao
{
    public partial class Form1 : Form
    {
        //dia, fila, poltrona [31, 4, 25]
        private ComboBox dia;
        private Button confirmaDia;
        private Button[,] assentos;
        private Button reservar;
        private Array[,,] total;
        public void iniciarComponentes()
        {
            total = new Array[31, 4, 25];
            dia = new ComboBox();
            confirmaDia = new Button();
            reservar = new Button();
            //total = new object[dia, j, i];

            dia.Parent = this;
            dia.Top = 100;
            dia.Left = 25;
            for (int k = 0; k < 31; ++k)
            {
                dia.Items.Add((k + 1).ToString());
            }

            confirmaDia.Parent = this;
            confirmaDia.Top = 100;
            confirmaDia.Left = 150;
            confirmaDia.Text = "OK";
            confirmaDia.Click += new EventHandler(confirmouDia);

            reservar.Parent = this;
            reservar.Top = 100;
            reservar.Left = 400;
            reservar.Text = "RESERVAR";
            reservar.Click += new EventHandler(reservou);

            assentos = new Button[4, 25];
            
            for (int j = 0; j < 4; ++j)
            {
                Top = 25;

                for (int i = 0; i < 25; ++i)
                {
                    //L - Livre, X - Marcado, R - Reservado
                    assentos[j,i] = new Button();
                    assentos[j,i].Parent = this;
                    assentos[j,i].Left = 50 * i;
                    assentos[j,i].Top = 200;
                    assentos[j,i].Text = "L";
                    assentos[j,i].Click += new EventHandler(marcouAssento);
                }
            }
            
        }

        public void marcouAssento(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            clickedButton.Text = "X";
            clickedButton.Enabled = false;

            assentos[4,25].Visible = true;
        }
        public void confirmouDia(object sender, EventArgs e)
        {
            
        }
        public void reservou(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            clickedButton.Text = "R";
        }


        public Form1()
        {
            InitializeComponent();
            iniciarComponentes();
        }

    }
}
