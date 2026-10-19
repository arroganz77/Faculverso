using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Faculverso
{

    public partial class BVisNov : Form
    {

        string nome;

        string[] dialog = new string[]
        {
            "Meu primeiro dia em minha nova faculdade, preciso me apressar para não me perder nos assuntos já que cheguei um pouco depois que meus colegas,\nentão vamos lá! mas... por onde eu vou?", // Você/Pensamento 0
            "Ei! Ei! Você aí! A pessoa nova, quero falar com você", // Maria/Fala 1 (nesse caso estarica com o nome "garota agitada"
            "O-oi ahn... Sim, o que posso a-ajudar?", // Você /Fala 2
            "Você está perdido né, soube que você acabou de chegar", // Maria/Fala 3
            "Sim, ainda não sei por onde ir, esse lugar é enorme", // Você/Fala 4
            "Aah entendi, eu também me perdi assim no meu primeiro dia, essa faculdade é realmente muito grande haha, bom,\ndesculpa te assustar assim do nada, eu sou Maria Fernanda, líder da turma A de jogos digitais", // Maria/Fala 5
            "Soube pelo grupo de liderança de nossa turma ontem a noite que você chegaria hoje! Aliás, qual é o seu nome?",// Maria/Fala 6
            " quais são seus pronomes?", // Maria/Fala 7
            "", // Você/Fala 8
            "Oiii, prazer em te conhecer, vou te mostrar tudinhooo, mas antes, quero te conhecer um pouco melhor, venha, vamos conversar um pouco!", // Maria/Fala 9
            "hmm, entendi, você é uma pessoa bem legal, acho que meus amigos vão gostar de você, venha ver eles comigo!" // Maria/Fala 10 (No caso a resposta neutra) 

        };
        int contdialog = 0;

        public BVisNov()
        {
            InitializeComponent();
            btnVoltDial.Enabled = false; // Começa com o botão de voltar desabilitado 
            nome = "";
        }

        //Botão para voltar pro no menu
        private void btnMenu_Click(object sender, EventArgs e)
        {
            AMenu f1 = new AMenu();
            f1.Show();
            this.Close();
        }

        //Botão avançar dialogo
        private void btnAvanDial_Click(object sender, EventArgs e)
        {
            NextDialogo();


        }

        //Botão de Voltar dialogo
        private void btnVoltDial_Click(object sender, EventArgs e)
        {
            PrevDialogo();
        }


        //Metodo para avançar o dialogo
        public void NextDialogo()
        {
            contdialog++;
            if (contdialog == 0)
            {
                lblDialog.Text = dialog[0];
            }
            else if (contdialog == 1)
            {
                lblDialog.Text = dialog[1];
                pictureBox2.Visible = true;
                btnVoltDial.Enabled = true;
            }
            else if (contdialog == 2)
            {
                lblDialog.Text = dialog[2];
            }
            else if (contdialog == 3)
            {
                lblDialog.Text = dialog[3];
            }
            else if (contdialog == 4)
            {
                lblDialog.Text = dialog[4];
            }
            else if (contdialog == 5)
            {
                lblDialog.Text = dialog[5];
            }
            else if (contdialog == 6)
            {
                lblDialog.Text = dialog[6];
            }
            else if (contdialog == 7)
            {
                lblDialog.Text = dialog[7];
                btnAvanDial.Enabled = false;
                gbNome.Visible = true;
            }
            else if (contdialog == 8)
            {
                gbNome.Visible = false;
                lblDialog.Text = dialog[8];
                btnAvanDial.Enabled = true;
                lblDialog.Text = "Diz seus " + nome + "e seus pronomes (seus pronomes são: ele/dele)";
            }
            else if (contdialog == 9)
            {
                lblDialog.Text = $"Oiii {nome}, prazer em te conhecer, vou te mostrar tudinhooo, mas antes, quero te conhecer um pouco melhor, venha, vamos conversar um pouco!";
            }

        }
        //Metódo para voltar o dialogo
        public void PrevDialogo()
        {
            contdialog--;
            if (contdialog == 0)
            {
                lblDialog.Text = dialog[0];
                btnVoltDial.Enabled = false;
                pictureBox2.Visible = false;
            }
            else if (contdialog == 1)
            {
                lblDialog.Text = dialog[1];
                btnVoltDial.Enabled = true;
            }
            else if (contdialog == 2)
            {
                lblDialog.Text = dialog[2];
            }
            else if (contdialog == 3)
            {
                lblDialog.Text = dialog[3];
            }
            else if (contdialog == 4)
            {
                lblDialog.Text = dialog[4];
            }
            else if (contdialog == 5)
            {
                lblDialog.Text = dialog[5];
            }
            else if (contdialog == 6)
            {
                lblDialog.Text = dialog[6];
            }
            else if (contdialog == 7)
            {
                lblDialog.Text = dialog[7];
            }
            else if (contdialog == 8)
            {
                lblDialog.Text = dialog[8];
            }
            else if (contdialog == 9)
            {
                lblDialog.Text = dialog[9];
            }
        }

        private void btnSeuNome_Click(object sender, EventArgs e)
        {
            nome = tbNome.Text;
            contdialog++;
            NextDialogo();
            gbNome.Visible = false;
        }
    }
}
