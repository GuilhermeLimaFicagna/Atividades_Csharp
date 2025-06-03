namespace Atividade_05
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Lbl_nome = new Label();
            Lbl_Nota = new Label();
            label1 = new Label();
            Txt_inp_Name = new TextBox();
            Txt_Inp_Nota = new TextBox();
            Btn_save = new Button();
            Lbl_aviso = new Label();
            lbx_NomeNota = new ListBox();
            label2 = new Label();
            Txt_inp_Nota_Mod = new TextBox();
            Txt_inp_Name_Mod = new TextBox();
            label3 = new Label();
            label4 = new Label();
            Btn_save_Mod = new Button();
            Lbl_aviso_Mod = new Label();
            label5 = new Label();
            Txt_Alunos_Nome = new TextBox();
            Btn_rev = new Button();
            label6 = new Label();
            Txt_Alunos_Nota = new TextBox();
            Txt_Rev_Md = new TextBox();
            label7 = new Label();
            label8 = new Label();
            Txt_Rev_Min = new TextBox();
            label9 = new Label();
            Txt_Rev_Max = new TextBox();
            label10 = new Label();
            Txt_Rev_set = new TextBox();
            SuspendLayout();
            // 
            // Lbl_nome
            // 
            Lbl_nome.AutoSize = true;
            Lbl_nome.Font = new Font("Segoe UI", 20F);
            Lbl_nome.Location = new Point(27, 84);
            Lbl_nome.Name = "Lbl_nome";
            Lbl_nome.Size = new Size(101, 37);
            Lbl_nome.TabIndex = 0;
            Lbl_nome.Text = "NOME:";
            // 
            // Lbl_Nota
            // 
            Lbl_Nota.AutoSize = true;
            Lbl_Nota.Font = new Font("Segoe UI", 20F);
            Lbl_Nota.Location = new Point(37, 134);
            Lbl_Nota.Name = "Lbl_Nota";
            Lbl_Nota.Size = new Size(91, 37);
            Lbl_Nota.TabIndex = 1;
            Lbl_Nota.Text = "NOTA:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            label1.Location = new Point(-3, 9);
            label1.Name = "label1";
            label1.Size = new Size(979, 54);
            label1.TabIndex = 2;
            label1.Text = "Cadastre nomes de alunos e suas respectivas notas";
            // 
            // Txt_inp_Name
            // 
            Txt_inp_Name.BackColor = SystemColors.ScrollBar;
            Txt_inp_Name.BorderStyle = BorderStyle.None;
            Txt_inp_Name.Location = new Point(134, 95);
            Txt_inp_Name.Multiline = true;
            Txt_inp_Name.Name = "Txt_inp_Name";
            Txt_inp_Name.RightToLeft = RightToLeft.No;
            Txt_inp_Name.Size = new Size(224, 26);
            Txt_inp_Name.TabIndex = 3;
            Txt_inp_Name.TextAlign = HorizontalAlignment.Center;
            // 
            // Txt_Inp_Nota
            // 
            Txt_Inp_Nota.BackColor = SystemColors.ScrollBar;
            Txt_Inp_Nota.BorderStyle = BorderStyle.None;
            Txt_Inp_Nota.Location = new Point(134, 145);
            Txt_Inp_Nota.Multiline = true;
            Txt_Inp_Nota.Name = "Txt_Inp_Nota";
            Txt_Inp_Nota.Size = new Size(54, 26);
            Txt_Inp_Nota.TabIndex = 4;
            Txt_Inp_Nota.TextAlign = HorizontalAlignment.Center;
            // 
            // Btn_save
            // 
            Btn_save.BackColor = SystemColors.ScrollBar;
            Btn_save.Location = new Point(27, 187);
            Btn_save.Name = "Btn_save";
            Btn_save.Size = new Size(331, 31);
            Btn_save.TabIndex = 5;
            Btn_save.Text = "SALVAR";
            Btn_save.UseCompatibleTextRendering = true;
            Btn_save.UseVisualStyleBackColor = false;
            Btn_save.Click += Btn_save_Click;
            // 
            // Lbl_aviso
            // 
            Lbl_aviso.AutoSize = true;
            Lbl_aviso.Location = new Point(210, 77);
            Lbl_aviso.Name = "Lbl_aviso";
            Lbl_aviso.Size = new Size(7, 15);
            Lbl_aviso.TabIndex = 6;
            Lbl_aviso.Text = "\r\n";
            // 
            // lbx_NomeNota
            // 
            lbx_NomeNota.BackColor = SystemColors.ScrollBar;
            lbx_NomeNota.Font = new Font("Segoe UI", 13F);
            lbx_NomeNota.FormattingEnabled = true;
            lbx_NomeNota.ItemHeight = 23;
            lbx_NomeNota.Location = new Point(27, 311);
            lbx_NomeNota.Name = "lbx_NomeNota";
            lbx_NomeNota.Size = new Size(331, 119);
            lbx_NomeNota.TabIndex = 7;
            lbx_NomeNota.SelectedIndexChanged += lbx_NomeNota_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(-3, 253);
            label2.Name = "label2";
            label2.Size = new Size(395, 38);
            label2.TabIndex = 8;
            label2.Text = "Selecione na lista o aluno que deseja mudar a Nome ou a Nota.\r\n E altere nos campos logo abaixo ";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // Txt_inp_Nota_Mod
            // 
            Txt_inp_Nota_Mod.BackColor = SystemColors.ScrollBar;
            Txt_inp_Nota_Mod.BorderStyle = BorderStyle.None;
            Txt_inp_Nota_Mod.Location = new Point(134, 510);
            Txt_inp_Nota_Mod.Multiline = true;
            Txt_inp_Nota_Mod.Name = "Txt_inp_Nota_Mod";
            Txt_inp_Nota_Mod.Size = new Size(54, 26);
            Txt_inp_Nota_Mod.TabIndex = 12;
            Txt_inp_Nota_Mod.TextAlign = HorizontalAlignment.Center;
            // 
            // Txt_inp_Name_Mod
            // 
            Txt_inp_Name_Mod.BackColor = SystemColors.ScrollBar;
            Txt_inp_Name_Mod.BorderStyle = BorderStyle.None;
            Txt_inp_Name_Mod.Location = new Point(134, 460);
            Txt_inp_Name_Mod.Multiline = true;
            Txt_inp_Name_Mod.Name = "Txt_inp_Name_Mod";
            Txt_inp_Name_Mod.Size = new Size(224, 26);
            Txt_inp_Name_Mod.TabIndex = 11;
            Txt_inp_Name_Mod.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F);
            label3.Location = new Point(37, 499);
            label3.Name = "label3";
            label3.Size = new Size(91, 37);
            label3.TabIndex = 10;
            label3.Text = "NOTA:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F);
            label4.Location = new Point(27, 449);
            label4.Name = "label4";
            label4.Size = new Size(101, 37);
            label4.TabIndex = 9;
            label4.Text = "NOME:";
            // 
            // Btn_save_Mod
            // 
            Btn_save_Mod.BackColor = SystemColors.ScrollBar;
            Btn_save_Mod.Location = new Point(27, 561);
            Btn_save_Mod.Name = "Btn_save_Mod";
            Btn_save_Mod.Size = new Size(331, 31);
            Btn_save_Mod.TabIndex = 13;
            Btn_save_Mod.Text = "SALVAR  ALTERAÇÃO";
            Btn_save_Mod.UseCompatibleTextRendering = true;
            Btn_save_Mod.UseVisualStyleBackColor = false;
            Btn_save_Mod.Click += Btn_save_Mod_Click;
            // 
            // Lbl_aviso_Mod
            // 
            Lbl_aviso_Mod.AutoSize = true;
            Lbl_aviso_Mod.Location = new Point(210, 427);
            Lbl_aviso_Mod.Name = "Lbl_aviso_Mod";
            Lbl_aviso_Mod.Size = new Size(0, 15);
            Lbl_aviso_Mod.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 30F);
            label5.Location = new Point(503, 114);
            label5.Name = "label5";
            label5.Size = new Size(433, 54);
            label5.TabIndex = 15;
            label5.Text = "RELATÓRIO DA TURMA";
            // 
            // Txt_Alunos_Nome
            // 
            Txt_Alunos_Nome.Location = new Point(503, 244);
            Txt_Alunos_Nome.Multiline = true;
            Txt_Alunos_Nome.Name = "Txt_Alunos_Nome";
            Txt_Alunos_Nome.Size = new Size(179, 326);
            Txt_Alunos_Nome.TabIndex = 16;
            Txt_Alunos_Nome.TextAlign = HorizontalAlignment.Center;
            // 
            // Btn_rev
            // 
            Btn_rev.BackColor = SystemColors.ScrollBar;
            Btn_rev.Location = new Point(503, 171);
            Btn_rev.Name = "Btn_rev";
            Btn_rev.Size = new Size(433, 31);
            Btn_rev.TabIndex = 17;
            Btn_rev.Text = "REVELAR";
            Btn_rev.UseCompatibleTextRendering = true;
            Btn_rev.UseVisualStyleBackColor = false;
            Btn_rev.Click += Btn_rev_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(526, 220);
            label6.Name = "label6";
            label6.Size = new Size(203, 21);
            label6.TabIndex = 18;
            label6.Text = "Nome                           | Nota";
            // 
            // Txt_Alunos_Nota
            // 
            Txt_Alunos_Nota.Location = new Point(688, 244);
            Txt_Alunos_Nota.Multiline = true;
            Txt_Alunos_Nota.Name = "Txt_Alunos_Nota";
            Txt_Alunos_Nota.Size = new Size(41, 326);
            Txt_Alunos_Nota.TabIndex = 19;
            Txt_Alunos_Nota.TextAlign = HorizontalAlignment.Center;
            // 
            // Txt_Rev_Md
            // 
            Txt_Rev_Md.Location = new Point(762, 282);
            Txt_Rev_Md.Multiline = true;
            Txt_Rev_Md.Name = "Txt_Rev_Md";
            Txt_Rev_Md.Size = new Size(189, 23);
            Txt_Rev_Md.TabIndex = 20;
            Txt_Rev_Md.TextAlign = HorizontalAlignment.Center;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F);
            label7.Location = new Point(780, 254);
            label7.Name = "label7";
            label7.Size = new Size(146, 25);
            label7.TabIndex = 21;
            label7.Text = "Média da turma";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14F);
            label8.Location = new Point(797, 311);
            label8.Name = "label8";
            label8.Size = new Size(114, 25);
            label8.TabIndex = 23;
            label8.Text = "Menor Nota";
            // 
            // Txt_Rev_Min
            // 
            Txt_Rev_Min.Location = new Point(762, 339);
            Txt_Rev_Min.Multiline = true;
            Txt_Rev_Min.Name = "Txt_Rev_Min";
            Txt_Rev_Min.Size = new Size(189, 23);
            Txt_Rev_Min.TabIndex = 22;
            Txt_Rev_Min.TextAlign = HorizontalAlignment.Center;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14F);
            label9.Location = new Point(797, 375);
            label9.Name = "label9";
            label9.Size = new Size(108, 25);
            label9.TabIndex = 25;
            label9.Text = "Maior Nota";
            // 
            // Txt_Rev_Max
            // 
            Txt_Rev_Max.Location = new Point(762, 403);
            Txt_Rev_Max.Multiline = true;
            Txt_Rev_Max.Name = "Txt_Rev_Max";
            Txt_Rev_Max.Size = new Size(189, 23);
            Txt_Rev_Max.TabIndex = 24;
            Txt_Rev_Max.TextAlign = HorizontalAlignment.Center;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11F);
            label10.Location = new Point(735, 446);
            label10.Name = "label10";
            label10.Size = new Size(244, 40);
            label10.TabIndex = 27;
            label10.Text = "alunos com nota maior ou igual a 7\r\n              Como APROVADOS";
            // 
            // Txt_Rev_set
            // 
            Txt_Rev_set.Location = new Point(762, 499);
            Txt_Rev_set.Multiline = true;
            Txt_Rev_set.Name = "Txt_Rev_set";
            Txt_Rev_set.Size = new Size(189, 23);
            Txt_Rev_set.TabIndex = 26;
            Txt_Rev_set.TextAlign = HorizontalAlignment.Center;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(979, 627);
            Controls.Add(label10);
            Controls.Add(Txt_Rev_set);
            Controls.Add(label9);
            Controls.Add(Txt_Rev_Max);
            Controls.Add(label8);
            Controls.Add(Txt_Rev_Min);
            Controls.Add(label7);
            Controls.Add(Txt_Rev_Md);
            Controls.Add(Txt_Alunos_Nota);
            Controls.Add(label6);
            Controls.Add(Btn_rev);
            Controls.Add(Txt_Alunos_Nome);
            Controls.Add(label5);
            Controls.Add(Lbl_aviso_Mod);
            Controls.Add(Btn_save_Mod);
            Controls.Add(Txt_inp_Nota_Mod);
            Controls.Add(Txt_inp_Name_Mod);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(lbx_NomeNota);
            Controls.Add(Lbl_aviso);
            Controls.Add(Btn_save);
            Controls.Add(Txt_Inp_Nota);
            Controls.Add(Txt_inp_Name);
            Controls.Add(label1);
            Controls.Add(Lbl_Nota);
            Controls.Add(Lbl_nome);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lbl_nome;
        private Label Lbl_Nota;
        private Label label1;
        private TextBox Txt_inp_Name;
        private TextBox Txt_Inp_Nota;
        private Button Btn_save;
        private Label Lbl_aviso;
        private ListBox lbx_NomeNota;
        private Label label2;
        private TextBox Txt_inp_Nota_Mod;
        private TextBox Txt_inp_Name_Mod;
        private Label label3;
        private Label label4;
        private Button Btn_save_Mod;
        private Label Lbl_aviso_Mod;
        private Label label5;
        private TextBox Txt_Alunos_Nome;
        private Button Btn_rev;
        private Label label6;
        private TextBox Txt_Alunos_Nota;
        private TextBox Txt_Rev_Md;
        private Label label7;
        private Label label8;
        private TextBox Txt_Rev_Min;
        private Label label9;
        private TextBox Txt_Rev_Max;
        private Label label10;
        private TextBox Txt_Rev_set;
    }
}
