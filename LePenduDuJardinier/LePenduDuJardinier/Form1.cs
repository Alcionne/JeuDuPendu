using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LePenduDuJardinier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Initialisation des Variables
        List<char> listEnigme = new List<char>();
        List<string> affichageReponse = new List<string>();
        int c = 0;
        int pv = 9;
        string catego;

        private void btnNew_Click(object sender, EventArgs e)
        {
            start();
        }

        public void start()
        {
            //Remise à zeros
            affichageReponse.Clear();
            txtBoxReponse.Clear();
            textBoxResultat.Clear();
            ResetBoutons(groupBoxLettres);
            c = 0;
            pv = 9;
            lblTentatives.Text = "Tentatives restantes :  " + pv;
            btnValider.Enabled = true;

            //Mot alétoire
            string motATrouver = generationMot(catego);
            lblMotATrouver.Text = motATrouver;
            listEnigme = motATrouver.ToList();
            for (int i = 0; i < listEnigme.Count; i++)
            {
                affichageReponse.Add("_ ");
            }
            //Vérification espaces, tirets et apostrophe
            for (int i = 0; i < listEnigme.Count; i++)
            {
                if (listEnigme[i].ToString() == " ")
                {
                    affichageReponse[i] = "   ";
                }
                if (listEnigme[i].ToString() == "-")
                {
                    affichageReponse[i] = "-";
                }
                if (listEnigme[i].ToString() == "'")
                {
                    affichageReponse[i] = "'";
                }
            }
            string s = string.Join("", affichageReponse);
            textBoxResultat.Text = s;
        }

        public string generationMot(string c)
        {
            string m = null;
            Mot enigme;
            switch (c)
            {
                case "MotGeo":
                    enigme = new MotGeo();
                    m = enigme.motATrouver;
                    return m;
                case "MotFlore":
                    enigme = new MotFlore();
                    m = enigme.motATrouver;
                    return m;
                case "MotFruitsLegumes":
                    enigme = new MotFruitsLegumes();
                    m = enigme.motATrouver;
                    return m;
                case "MotAnimaux":
                    enigme = new MotAnimaux();
                    m = enigme.motATrouver;
                    return m;
                case "MotCouleurs":
                    enigme = new MotCouleurs();
                    m = enigme.motATrouver;
                    return m;
                case "MotHumain":
                    enigme = new MotHumain();
                    m = enigme.motATrouver;
                    return m;
                case "MotMetiers":
                    enigme = new MotMetiers();
                    m = enigme.motATrouver;
                    return m;
                case "MotSports":
                    enigme = new MotSports();
                    m = enigme.motATrouver;
                    return m;
                case "MotTransports":
                    enigme = new MotTransports();
                    m = enigme.motATrouver;
                    return m;
                case "MotDepartementsFrancais":
                    enigme = new MotDepartementsFrancais();
                    m = enigme.motATrouver;
                    return m;
                case "MotOutils":
                    enigme = new MotOutils();
                    m = enigme.motATrouver;
                    return m;
                case "MotQualitesDefauts":
                    enigme = new MotQualitesDefauts();
                    m = enigme.motATrouver;
                    return m;
                default:
                    return m;
            }
        }

        public void ResetBoutons(GroupBox gbox)
        {
            foreach (Button btn in gbox.Controls)
            {
                btn.Enabled = true;
            }
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            checkReponseExacte(txtBoxReponse.Text, listEnigme, ref affichageReponse);
            string s = string.Join("", affichageReponse);
            textBoxResultat.Text = s;
            txtBoxReponse.Clear();
            checkVictoireDefaite();
        }

        public void lettreSaisie(string l, Button btn)
        {
            checkReponse(l, listEnigme, ref affichageReponse);
            string s = string.Join("", affichageReponse);
            textBoxResultat.Text = s;
            txtBoxReponse.Clear();
            btn.Enabled = false;
            checkVictoireDefaite();
        }

        public void checkReponse(string reponse, List<char> solution, ref List<string> aff)
        {
            bool bonneReponse = false;
            for (int i = 0; i < solution.Count; i++)
            {
                if (reponse == solution[i].ToString())
                {
                    aff[i] = reponse;
                    bonneReponse = true;
                }
            }
            if (bonneReponse == false)
            {
                c++;
                int t = pv - c;
                lblTentatives.Text = "Tentatives restantes :  " + t;
            }
        }

        public void checkReponseExacte(string reponse, List<char> solution, ref List<string> aff)
        {
            bool bonneReponse = false;
            var sol = new string(solution.ToArray());
            if (reponse == sol)
            {
                Victoire();
            }
            if (bonneReponse == false)
            {
                c++;
                int t = pv - c;
                lblTentatives.Text = "Tentatives restantes :  " + t;
            }
        }

        public void checkVictoireDefaite()
        {
            if (c == pv)
            {
                Defaite();
            }
            var temp = new string(listEnigme.ToArray());
            var sol = temp.Replace(" ", "   ");
            var rep = string.Join("", affichageReponse);
            if (rep == sol)
            {
                Victoire();
            }
        }

        public void Victoire()
        {
            textBoxResultat.Text = lblMotATrouver.Text;
            DialogResult dialogResult = MessageBox.Show("Rejouer ?", "Vous avez gagné la partie  :)", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                start();
            }
            else if (dialogResult == DialogResult.No)
            {
                Application.Exit();
            }
        }

        public void Defaite()
        {
            textBoxResultat.Text = lblMotATrouver.Text;
            DialogResult dialogResult = MessageBox.Show("Rejouer ?", "Vous avez perdu la partie  :(", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                start();
            }
            else if (dialogResult == DialogResult.No)
            {
                Application.Exit();
            }
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            lettreSaisie("a", btnA);
        }
        private void btnB_Click(object sender, EventArgs e)
        {
            lettreSaisie("b", btnB);
        }
        private void btnC_Click(object sender, EventArgs e)
        {
            lettreSaisie("c", btnC);
        }
        private void btnD_Click(object sender, EventArgs e)
        {
            lettreSaisie("d", btnD);
        }
        private void btnE_Click(object sender, EventArgs e)
        {
            lettreSaisie("e", btnE);
        }
        private void btnF_Click(object sender, EventArgs e)
        {
            lettreSaisie("f", btnF);
        }
        private void btnG_Click(object sender, EventArgs e)
        {
            lettreSaisie("g", btnG);
        }
        private void btnH_Click(object sender, EventArgs e)
        {
            lettreSaisie("h", btnH);
        }
        private void btnI_Click(object sender, EventArgs e)
        {
            lettreSaisie("i", btnI);
        }
        private void btnJ_Click(object sender, EventArgs e)
        {
            lettreSaisie("j", btnJ);
        }
        private void btnK_Click(object sender, EventArgs e)
        {
            lettreSaisie("k", btnK);
        }
        private void btnL_Click(object sender, EventArgs e)
        {
            lettreSaisie("l", btnL);
        }
        private void btnM_Click(object sender, EventArgs e)
        {
            lettreSaisie("m", btnM);
        }
        private void btnN_Click(object sender, EventArgs e)
        {
            lettreSaisie("n", btnN);
        }
        private void btnO_Click(object sender, EventArgs e)
        {
            lettreSaisie("o", btnO);
        }
        private void btnP_Click(object sender, EventArgs e)
        {
            lettreSaisie("p", btnP);
        }
        private void btnQ_Click(object sender, EventArgs e)
        {
            lettreSaisie("q", btnQ);
        }
        private void btnR_Click(object sender, EventArgs e)
        {
            lettreSaisie("r", btnR);
        }
        private void btnS_Click(object sender, EventArgs e)
        {
            lettreSaisie("s", btnS);
        }
        private void btnT_Click(object sender, EventArgs e)
        {
            lettreSaisie("t", btnT);
        }
        private void btnU_Click(object sender, EventArgs e)
        {
            lettreSaisie("u", btnU);
        }
        private void btnV_Click(object sender, EventArgs e)
        {
            lettreSaisie("v", btnV);
        }
        private void btnW_Click(object sender, EventArgs e)
        {
            lettreSaisie("w", btnW);
        }
        private void btnX_Click(object sender, EventArgs e)
        {
            lettreSaisie("x", btnX);
        }
        private void btnY_Click(object sender, EventArgs e)
        {
            lettreSaisie("y", btnY);
        }
        private void btnZ_Click(object sender, EventArgs e)
        {
            lettreSaisie("z", btnZ);
        }

        private void btnGeo_Click(object sender, EventArgs e)
        {
            btnNew.Enabled = true;
            catego = "MotGeo";
            textBoxCatego.Text = "Pays & Capitales";
            start();
        }

        private void btnFlore_Click(object sender, EventArgs e)
        {
            btnNew.Enabled = true;
            catego = "MotFlore";
            textBoxCatego.Text = "Flore";
            start();
        }

        private void btnMetier_Click(object sender, EventArgs e)
        {
            btnNew.Enabled = true;
            catego = "MotMetiers";
            textBoxCatego.Text = "Métiers";
            start();
        }

        private void btnAnimaux_Click(object sender, EventArgs e)
        {
            btnNew.Enabled = true;
            catego = "MotAnimaux";
            textBoxCatego.Text = "Animaux";
            start();
        }

        private void btnCorps_Click(object sender, EventArgs e)
        {
            btnNew.Enabled = true;
            catego = "MotHumain";
            textBoxCatego.Text = "Corps Humain";
            start();
        }

        private void btnSports_Click(object sender, EventArgs e)
        {
            btnNew.Enabled = true;
            catego = "MotSports";
            textBoxCatego.Text = "Sports";
            start();
        }

        private void btnFrance_Click(object sender, EventArgs e)
        {
            btnNew.Enabled = true;
            catego = "MotDepartementsFrancais";
            textBoxCatego.Text = "Départements Français";
            start();
        }

        private void btnFruits_Click(object sender, EventArgs e)
        {
            btnNew.Enabled = true;
            catego = "MotFruitsLegumes";
            textBoxCatego.Text = "Fruits & Légumes";
            start();
        }

        private void btnOutils_Click(object sender, EventArgs e)
        {
            btnNew.Enabled = true;
            catego = "MotOutils";
            textBoxCatego.Text = "Outils";
            start();
        }

        private void btnTransports_Click(object sender, EventArgs e)
        {
            btnNew.Enabled = true;
            catego = "MotTransports";
            textBoxCatego.Text = "Transports";
            start();
        }

        private void btnCouleurs_Click(object sender, EventArgs e)
        {
            btnNew.Enabled = true;
            catego = "MotCouleurs";
            textBoxCatego.Text = "Couleurs";
            start();
        }

        private void btnQualites_Click(object sender, EventArgs e)
        {
            btnNew.Enabled = true;
            catego = "MotQualitesDefauts";
            textBoxCatego.Text = "Qualités & Défauts";
            start();
        }
    }
}
