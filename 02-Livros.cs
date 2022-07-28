using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace livros
{
    public partial class frmLivros : Form
    {
        public frmLivros()
        {
            InitializeComponent();
        }

        private void grpInfo_Enter(object sender, EventArgs e)
        {

        }

        private void grpGenero_Enter(object sender, EventArgs e)
        {

        }

        private void lblLivros_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmLivros_Load(object sender, EventArgs e)
        {
            if (Variaveis.idade >= 18)
            {
                radTerror.Enabled = true;
            }
            else
            {
                radTerror.Enabled = false;
            }
        }

        private void radRomance_CheckedChanged(object sender, EventArgs e)
        {
            lblGenero.Text = "Românce";
            lblGenero1.Text = "Românce 01";
            lblGenero2.Text = "Românce 02";
            lblGenero3.Text = "Românce 03";
            lblGenero4.Text = "Românce 04";

            lblGenero.BackColor = Color.SlateBlue;
            lblGenero.ForeColor = Color.White;


            if (radCapa.Checked == true)
            {
                picImagem01.Image = Properties.Resources.frontRomance01;
                picImagem02.Image = Properties.Resources.frontRomance02;
                picImagem03.Image = Properties.Resources.frontRomance03;
                picImagem04.Image = Properties.Resources.frontRomance04;
            }
            else if (radContraCapa.Checked == true)
            {
                picImagem01.Image = Properties.Resources.backRomance01;
                picImagem02.Image = Properties.Resources.backRomance02;
                picImagem03.Image = Properties.Resources.backRomance03;
                picImagem04.Image = Properties.Resources.backRomance04;
            }
            else
            {
                MessageBox.Show("Selecione qual imagem exibir (capa ou contracapa)");
            }
        }

        private void radTerror_CheckedChanged(object sender, EventArgs e)
        {
            lblGenero.Text = "Terror";
            lblGenero1.Text = "Terror 01";
            lblGenero2.Text = "Terror 02";
            lblGenero3.Text = "Terror 03";
            lblGenero4.Text = "Terror 04";

            lblGenero.BackColor = Color.Black;
            lblGenero.ForeColor = Color.White;


            if (radCapa.Checked == true)
            {
                picImagem01.Image = Properties.Resources.frontTerror01;
                picImagem02.Image = Properties.Resources.frontTerror02;
                picImagem03.Image = Properties.Resources.frontTerror03;
                picImagem04.Image = Properties.Resources.frontTerror04;
            }                                                
            else if (radContraCapa.Checked == true)          
            {                                                
                picImagem01.Image = Properties.Resources.backTerror01;
                picImagem02.Image = Properties.Resources.backTerror02;
                picImagem03.Image = Properties.Resources.backTerror03;
                picImagem04.Image = Properties.Resources.backTerror04;
            }
            else
            {
                MessageBox.Show("Selecione qual imagem exibir (capa ou contracapa)");
            }
        }

        private void radFic_CheckedChanged(object sender, EventArgs e)
        {
            lblGenero.Text = "Ficção Científica";
            lblGenero1.Text = "Sci-fi 01";
            lblGenero2.Text = "Sci-fi 02";
            lblGenero3.Text = "Sci-fi 03";
            lblGenero4.Text = "Sci-fi 04";

            lblGenero.BackColor = Color.Navy;
            lblGenero.ForeColor = Color.White;


            if (radCapa.Checked == true)
            {
                picImagem01.Image = Properties.Resources.frontFic01;
                picImagem02.Image = Properties.Resources.frontFic02;
                picImagem03.Image = Properties.Resources.frontFic03;
                picImagem04.Image = Properties.Resources.frontFic04;
            }                                                
            else if (radContraCapa.Checked == true)          
            {                                                
                picImagem01.Image = Properties.Resources.backFic01;
                picImagem02.Image = Properties.Resources.backFic02;
                picImagem03.Image = Properties.Resources.backFic03;
                picImagem04.Image = Properties.Resources.backFic04;
            }
            else
            {
                MessageBox.Show("Selecione qual imagem exibir (capa ou contracapa)");
            }
        }

        private void radHQ_CheckedChanged(object sender, EventArgs e)
        {
            lblGenero.Text = "HQ";
            lblGenero1.Text = "HQ 01";
            lblGenero2.Text = "HQ 02";
            lblGenero3.Text = "HQ 03";
            lblGenero4.Text = "HQ 04";

            lblGenero.BackColor = Color.Tomato;
            lblGenero.ForeColor = Color.White;


            if (radCapa.Checked == true)
            {
                picImagem01.Image = Properties.Resources.frontHQ01;
                picImagem02.Image = Properties.Resources.frontHQ02;
                picImagem03.Image = Properties.Resources.frontHQ03;
                picImagem04.Image = Properties.Resources.frontHQ04;
            }                                                
            else if (radContraCapa.Checked == true)          
            {                                                
                picImagem01.Image = Properties.Resources.backHQ01;
                picImagem02.Image = Properties.Resources.backHQ02;
                picImagem03.Image = Properties.Resources.backHQ03;
                picImagem04.Image = Properties.Resources.backHQ04;
            }
            else
            {
                MessageBox.Show("Selecione qual imagem exibir (capa ou contracapa)");
            }
        }

        private void radCapa_CheckedChanged(object sender, EventArgs e)
        {
            if (radRomance.Checked == true)
            {
                radRomance.Checked = false;
                radRomance.Checked = true;
            }
            else if (radTerror.Checked == true)
            {
                radTerror.Checked = false;
                radTerror.Checked = true;
            }
            else if (radFic.Checked == true)
            {
                radFic.Checked = false;
                radFic.Checked = true;
            }
            else if (radHQ.Checked == true)
            {
                radHQ.Checked = false;
                radHQ.Checked = true;
            }
            else
            {
                MessageBox.Show("Selecione um gênero.");
            }
        }

        private void radContraCapa_CheckedChanged(object sender, EventArgs e)
        {
            if (radRomance.Checked == true)
            {
                radRomance.Checked = false;
                radRomance.Checked = true;
            }
            else if (radTerror.Checked == true)
            {
                radTerror.Checked = false;
                radTerror.Checked = true;
            }
            else if (radFic.Checked == true)
            {
                radFic.Checked = false;
                radFic.Checked = true;
            }
            else if (radHQ.Checked == true)
            {
                radHQ.Checked = false;
                radHQ.Checked = true;
            }
            else
            {
                MessageBox.Show("Selecione um gênero.");
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pnlGenero_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            new frmLogin().Show();
            Close();
        }
    }
}
