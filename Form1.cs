using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;


namespace ex4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Employe> E = new List<Employe>();

        private bool Verif()
        {
            return (string.IsNullOrEmpty(Txt_Nom.Text) || string.IsNullOrEmpty(Txt_Pre.Text) || string.IsNullOrEmpty(Txt_Mat.Text));
        }       
        Cadre C = new Cadre();
        Ouvrier O = new Ouvrier();
        Patron P = new Patron();
        private void Form1_Load(object sender, EventArgs e)
        {
            rad_Ouv.Checked = false;
            grp_pt.Enabled = true;
            rad_Pat.Checked = false;
            grp_ca.Enabled = true;
            rad_1.Checked = false;
            rad_2.Checked = false;
            rad_3.Checked = false;
            rad_4.Checked = false;
            rad_Cad.Enabled = true;
            grp_ou.Enabled = true;


        }

        private void Rad_Pat_CheckedChanged(object sender, EventArgs e)
        {
            if (rad_Pat.Checked == true)
            {
                if (Verif() || String.IsNullOrEmpty(Txt_Ca.Text) || String.IsNullOrEmpty(Txt_Perc.Text))
                {
                    MessageBox.Show("votre donnee sont vide !!");
                    rad_Pat.Checked = false;
                }
                else
                {
                    P = new Patron(Convert.ToInt32(Txt_Mat.Text), Txt_Nom.Text, Txt_Pre.Text, Dat_Nais.Value, Convert.ToDouble(Txt_Perc.Text), Convert.ToDouble(Txt_Ca.Text));
                    grp_pt.Enabled = false;
                    MessageBox.Show("Patron a ete declare");


                }
            }




        }

        private void Rad_Cad_CheckedChanged(object sender, EventArgs e)
        {
            int indice = 0;
            if (rad_Cad.Checked == true)
            {
                if (Verif())
                {
                    if (rad_1.Checked)
                        indice = 1;
                    else if (rad_2.Checked)
                        indice = 2;
                    else if (rad_3.Checked)
                        indice = 3;
                    else if (rad_4.Checked)
                        indice = 4;
                    else
                    {
                        MessageBox.Show("votre donnee sont vide !!");
                        rad_Cad.Checked = false;
                    }
                    C = new Cadre(Convert.ToInt32(Txt_Mat.Text), Txt_Nom.Text, Txt_Pre.Text, Dat_Nais.Value, indice);
                    grp_ca.Enabled = false;
                    MessageBox.Show("Cadre a ete declare");

                }
                else
                {
                    MessageBox.Show("votre donnee sont vide !!");
                    rad_Cad.Checked = false;
                }
            }






        }

        private void rad_Ouv_CheckedChanged(object sender, EventArgs e)
        {
            
            if (Verif())
            {
                MessageBox.Show("votre donnee sont vide !!");
                rad_Ouv.Checked = false;
            }
            else
            {
                O = new Ouvrier(Convert.ToInt32(Txt_Mat.Text), Txt_Nom.Text, Txt_Pre.Text, Dat_Nais.Value, dat_Ent.Value);
                grp_ou.Enabled = false;
                MessageBox.Show("Ouvrier a ete declare");
            }
                    
            


        }

        private void Btn_Ajo_Click(object sender, EventArgs e)
        {
            if (rad_Cad.Checked == true)
            {
                E.Add(C);
            }
            else if (rad_Ouv.Checked == true)
            {
                E.Add(O);
            }
            else if (rad_Pat.Checked == true)
            {
                E.Add(P);
            }
            else
                MessageBox.Show("choisir la poste de l'employe s'il vous plais");
            for (int i = 0;i< E.Count;i++)
            {
                DGV_EM.Rows[i].Cells[0].Value = E[i].Matricule;
                DGV_EM.Rows[i].Cells[1].Value = E[i].Nom;
                DGV_EM.Rows[i].Cells[2].Value = E[i].Prenom;
                DGV_EM.Rows[i].Cells[3].Value = E[i].DateDeNaissance;
                if(rad_Ouv.Checked) 
                    DGV_EM.Rows[i].Cells[4].Value = ((Ouvrier)E[i]).getSalaire();
                if(rad_Cad.Checked)
                    DGV_EM.Rows[i].Cells[4].Value = ((Cadre)E[i]).getSalaire();
                if(rad_Pat.Checked)
                    DGV_EM.Rows[i].Cells[4].Value = ((Patron)E[i]).getSalaire();

            }
            Form1_Load(sender, e);
            /* E.ForEach(emp =>
             {
                 DGV_EM.Rows.Add(emp);
             });*/
        }
    }
}

