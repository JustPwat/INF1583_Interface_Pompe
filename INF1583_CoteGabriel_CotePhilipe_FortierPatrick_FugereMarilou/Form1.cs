using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INF1583_CoteGabriel_CotePhilipe_FortierPatrick_FugereMarilou
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblMontant_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnMontantMax_Click(object sender, EventArgs e)
        {
            textDollars.Visible = true;
            textQuantitéLitre.Visible = false;
            txtBoxAmount.Enabled = true;
        }

        private void btnQtyMax_Click(object sender, EventArgs e)
        {
            textDollars.Visible = false;
            textQuantitéLitre.Visible = true;
            txtBoxAmount.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i;
            if (string.IsNullOrEmpty(txtBoxAmount.Text.Trim()) || !int.TryParse(txtBoxAmount.Text, out i))
                
            {
                MessageBox.Show("Veuillez entrer un nombre");
            }
            panelPompeSoph.Visible = true;
        }

        private void btnOkUserPass_Click(object sender, EventArgs e)
        {
            
            if (!(string.IsNullOrEmpty(boxUser.Text.Trim())) && !(string.IsNullOrEmpty(boxPass.Text.Trim())))

            {
                panelAfterLogin.Visible = true;
                tabMenuAll.SelectedTab = tabMenu;

            }

            if (string.IsNullOrEmpty(boxUser.Text.Trim()) && string.IsNullOrEmpty(boxPass.Text.Trim()))

            {
                MessageBox.Show("Veuillez entrer votre identifiant et votre mot de passe");

            }
            

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            panelAfterLogin.Visible = false;
        }

        private void btnCarte_Click(object sender, EventArgs e)
        {
            txtJetons.Enabled = true;
            txtAmount.Enabled = true;
        }

        private void btnComptant_Click(object sender, EventArgs e)
        {
            txtJetons.Enabled = true;
            txtAmount.Enabled = true;
        }

        private void btnJeton_Click(object sender, EventArgs e)
        {
            txtJetons.Enabled = true;
            txtAmount.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtJetons.Text.Trim()) && string.IsNullOrEmpty(txtAmount.Text.Trim()))

            {
                MessageBox.Show("Veuillez remplir les champs de Montant et Jetons");
            }

            if (!string.IsNullOrEmpty(txtJetons.Text.Trim()) && !string.IsNullOrEmpty(txtAmount.Text.Trim()))

            {
                tabMenuAll.SelectedTab = tabMenu;
            }
        }

        private void btnPayer1_Click(object sender, EventArgs e)
        {
            tabMenuAll.SelectedTab = tabPayer;
        }

        private void btnPayer4_Click(object sender, EventArgs e)
        {
            tabMenuAll.SelectedTab = tabPayer;
        }

        private void btnPayer2_Click(object sender, EventArgs e)
        {
            tabMenuAll.SelectedTab = tabPayer;
        }

        private void btnPayer5_Click(object sender, EventArgs e)
        {
            tabMenuAll.SelectedTab = tabPayer;
        }

        private void btnPayer3_Click(object sender, EventArgs e)
        {
            tabMenuAll.SelectedTab = tabPayer;
        }

        private void btnOrd1_Click(object sender, EventArgs e)
        {
            btnPayer1.Enabled = true;
            btnImpayer1.Enabled = true;
        }

        private void btnSup1_Click(object sender, EventArgs e)
        {
            btnPayer1.Enabled = true;
            btnImpayer1.Enabled = true;
        }

        private void btnOrd2_Click(object sender, EventArgs e)
        {
            btnPayer2.Enabled = true;
            btnImpayer2.Enabled = true;
        }

        private void btnSup2_Click(object sender, EventArgs e)
        {
            btnPayer2.Enabled = true;
            btnImpayer2.Enabled = true;
        }

        private void btnOrd3_Click(object sender, EventArgs e)
        {
            btnPayer3.Enabled = true;
            btnImpayer3.Enabled = true;
        }

        private void btnSup3_Click(object sender, EventArgs e)
        {
            btnPayer3.Enabled = true;
            btnImpayer3.Enabled = true;
        }

        private void btnOrd4_Click(object sender, EventArgs e)
        {
            btnPayer4.Enabled = true;
            btnImpayer4.Enabled = true;
        }

        private void btnSup4_Click(object sender, EventArgs e)
        {
            btnPayer4.Enabled = true;
            btnImpayer4.Enabled = true;
        }

        private void btnOrd5_Click(object sender, EventArgs e)
        {
            btnPayer5.Enabled = true;
            btnImpayer5.Enabled = true;
        }

        private void btnSup5_Click(object sender, EventArgs e)
        {
            btnPayer5.Enabled = true;
            btnImpayer5.Enabled = true;
        }

        private void btnImpayer1_Click(object sender, EventArgs e)
        {
            lblPompeImp.Text = "Pompe # 1";
            tabMenuAll.SelectedTab = tabImpayer;
        }

        private void btnImpayer2_Click(object sender, EventArgs e)
        {
            lblPompeImp.Text = "Pompe # 2";
            tabMenuAll.SelectedTab = tabImpayer;
        }

        private void btnImpayer3_Click(object sender, EventArgs e)
        {
            lblPompeImp.Text = "Pompe # 3";
            tabMenuAll.SelectedTab = tabImpayer;
        }

        private void btnImpayer4_Click(object sender, EventArgs e)
        {
            lblPompeImp.Text = "Pompe # 4";
            tabMenuAll.SelectedTab = tabImpayer;
        }

        private void btnImpayer5_Click(object sender, EventArgs e)
        {
            lblPompeImp.Text = "Pompe # 5";
            tabMenuAll.SelectedTab = tabImpayer;
        }

        private void btnAnnulerImpayer_Click(object sender, EventArgs e)
        {
            tabMenuAll.SelectedTab = tabMenu;
        }

        private void btnOkImpayer_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPlaque.Text.Trim()) && !string.IsNullOrEmpty(txtMarque.Text.Trim()) 
             && !string.IsNullOrEmpty(txtCouleur.Text.Trim()) && !string.IsNullOrEmpty(txtDate.Text.Trim()))

            {
                MessageBox.Show("Merci pour ce signalement");
                txtPlaque.Text = "";
                txtMarque.Text = "";
                txtCouleur.Text = "";
                txtDate.Text = "";
                tabMenuAll.SelectedTab = tabMenu;
                
            }

            
            

        }

        private void btnAnnulerNewUser_Click(object sender, EventArgs e)
        {
            tabMenuAll.SelectedTab = tabMenu;
        }

        private void btnOKnewUser_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNameUser.Text.Trim()) && !string.IsNullOrEmpty(txtMdpUser.Text.Trim()) && !string.IsNullOrEmpty(txtAdminKeyCreate.Text.Trim()))
            
            {
                MessageBox.Show("Utilisateur créé !");
                txtNameUser.Text = "";
                txtMdpUser.Text = "";
                txtAdminKeyCreate.Text = "";
                tabMenuAll.SelectedTab = tabMenu;

            }
        }

        private void btnCreerUser_Click(object sender, EventArgs e)
        {
            tabMenuAll.SelectedTab = tabUser;
            panelNewUser.Visible = true;
            panelDeleteU.Visible = false;
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            panelDeleteU.Visible = true;
            panelNewUser.Visible = false;
            tabMenuAll.SelectedTab = tabUser;
        }

        private void btnOkDeleteU_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAdminKeyDelete.Text.Trim()))

            {
                MessageBox.Show("Utilisateur supprimé !");
                txtDeleteU.Text = "";
                txtAdminKeyDelete.Text = "";
                tabMenuAll.SelectedTab = tabMenu;
                panelDeleteU.Visible = false;

            }
            
        }

        private void btnAnnulerU_Click(object sender, EventArgs e)
        {
            tabMenuAll.SelectedTab = tabMenu;
            panelDeleteU.Visible = false;
        }
    }
}
