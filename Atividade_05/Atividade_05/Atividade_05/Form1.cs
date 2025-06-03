using System.Globalization;

namespace Atividade_05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Declaração dos Arrays. Para armazenar nome e idade
        string[] listaNome = new string[50];
        double[] listaNota = new double[50];

        int cont = 0;   // Tem função de colocar os dados no espaço de mémoria certo 
        private void Btn_save_Click(object sender, EventArgs e)
        {
            // Verificação dos txtBox. Para validação das entradas de dados nos arrays.
            if ((Txt_inp_Name.Text == "") || (Txt_Inp_Nota.Text == ""))
            {
                Lbl_aviso.Text = "Preencher todos os campos";
                Lbl_aviso.Update();
                Thread.Sleep(2000);
                Lbl_aviso.Text = "";
            }
            else // bloco com comando de colocar os dados nos Arrays.
            {
                Lbl_aviso.Text = "Salvo com sucesso!"; // Mensagem dizendo para o úsuario que foi salvo
                Lbl_aviso.Update();
                Thread.Sleep(1000);
                Lbl_aviso.Text = "";

                // Entrada dos dados nos arrays logo 

                listaNome[cont] = Txt_inp_Name.Text.ToString();
                listaNota[cont] = Convert.ToDouble(Txt_Inp_Nota.Text, CultureInfo.InvariantCulture); //Maneira que encontrei pra mostrar double nas notas no listBox

                // Mostra no lbx_NomeNota os nomes e notas.                             
                lbx_NomeNota.Items.Add($"{cont + 1}° Nome: {listaNome[cont]}  Nota: {listaNota[cont]}");
                cont++;

                // Reseta os campos e ja foca pra continuar escrevendo.
                Txt_inp_Name.Text = "";
                Txt_Inp_Nota.Text = "";
                Txt_inp_Name.Focus(); ;
            }

        }

        private void Btn_save_Mod_Click(object sender, EventArgs e)
        {
            // Verificação dos txtBox. Para validação das entradas de dados nos arrays.
            if ((Txt_inp_Name_Mod.Text == "") || (Txt_inp_Nota_Mod.Text == ""))
            {
                Lbl_aviso_Mod.Text = "Preencher todos os campos";
                Lbl_aviso_Mod.Update();
                Thread.Sleep(2000);
                Lbl_aviso_Mod.Text = "";
            }
            else // bloco com comando de colocar os dados nos Arrays.
            {
                Lbl_aviso_Mod.Text = "Alteração Salva com sucesso!"; // Mensagem dizendo para o úsuario que foi salvo
                Lbl_aviso_Mod.Update();
                Thread.Sleep(1000);
                Lbl_aviso_Mod.Text = "";

                // Entrada dos novos dados nos arrays logo 

                listaNome[lbx_NomeNota.SelectedIndex] = Txt_inp_Name_Mod.Text.ToString();
                listaNota[lbx_NomeNota.SelectedIndex] = Convert.ToDouble(Txt_inp_Nota_Mod.Text, CultureInfo.InvariantCulture); //Maneira que encontrei pra mostrar double nas notas no listBox

                // Atualiza o ListBox com a alteração                            
                lbx_NomeNota.Items[lbx_NomeNota.SelectedIndex] = ($"{lbx_NomeNota.SelectedIndex + 1}° Nome: {listaNome[lbx_NomeNota.SelectedIndex]}  Nota: {listaNota[lbx_NomeNota.SelectedIndex]}");

                // Reseta os campos e ja foca pra continuar escrevendo. Também tira a seleção do lbx
                Txt_inp_Name_Mod.Text = "";
                Txt_inp_Nota_Mod.Text = "";
            }
        }
        private void lbx_NomeNota_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = lbx_NomeNota.SelectedIndex;
            // esquema pra não bugar na hora da troca dos strs
            if (indice >= 0 && indice < cont)
            {
                Txt_inp_Name_Mod.Text = listaNome[indice];
                Txt_inp_Nota_Mod.Text = listaNota[indice].ToString();
            }
            else
            {
                // Caso a seleção seja inválida
                Txt_inp_Name_Mod.Text = "";
                Txt_inp_Nota_Mod.Text = "";
            }
        }

        private void Btn_rev_Click(object sender, EventArgs e)
        {
            // Coloca os nomes em ordem e as notas também
            Txt_Alunos_Nome.Clear();
            Txt_Alunos_Nota.Clear();
            for (int i = 0; i < cont; i += 1)
            {
                Txt_Alunos_Nome.Text += $"{listaNome[i]} \r\n";
            }
            for (int i = 0; i < cont; i += 1)
            {
                Txt_Alunos_Nota.Text += $"{listaNota[i]} \r\n";
            }
            // Revela a nota da turma
            double mdTurma = (listaNota.Sum()) / cont;
            Txt_Rev_Md.Text = mdTurma.ToString("F2");
            // Menor nota da turma
            double[] listaMenorNota = new double[cont];
            Array.Copy(listaNota, listaMenorNota, cont) ;
            double min = listaMenorNota.Min();
            Txt_Rev_Min.Text = min.ToString();
            // Maior nota da turma
            double max = listaNota.Max();
            Txt_Rev_Max.Text = max.ToString();
            // alunos com nota maior ou igual a 7
            double cont_set = 0;
            for (int i = 0; i < cont; i += 1)
            {
                if (listaNota[i] >= 7) 
                {
                    cont_set += 1;
                }
            }
            Txt_Rev_set.Text = cont_set.ToString();
        }
    } 
}
