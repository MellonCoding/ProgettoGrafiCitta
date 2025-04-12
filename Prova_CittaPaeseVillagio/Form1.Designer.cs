namespace Prova_CittaPaeseVillagio
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
            p = new Panel();
            btt_add_nodo = new Button();
            txb_nome_nodo = new TextBox();
            lbl_nome_nodo = new Label();
            lbl_metrica_nodo = new Label();
            txb_metrica_nodo = new TextBox();
            btt_stampa = new Button();
            btt_add_arco = new Button();
            cmb_arrivo = new ComboBox();
            cmb_partenza = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            cmb_type = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            txt_n_abi = new TextBox();
            label5 = new Label();
            txt_fuel = new TextBox();
            btt_raggiungibile = new Button();
            label6 = new Label();
            label7 = new Label();
            cmb_part_espl = new ComboBox();
            cmb_arr_espl = new ComboBox();
            btt_raggiungibile_c = new Button();
            SuspendLayout();
            // 
            // p
            // 
            p.Location = new Point(249, 15);
            p.Margin = new Padding(3, 2, 3, 2);
            p.Name = "p";
            p.Size = new Size(872, 614);
            p.TabIndex = 0;
            p.Paint += p_Paint;
            // 
            // btt_add_nodo
            // 
            btt_add_nodo.Location = new Point(10, 93);
            btt_add_nodo.Margin = new Padding(3, 2, 3, 2);
            btt_add_nodo.Name = "btt_add_nodo";
            btt_add_nodo.Size = new Size(224, 22);
            btt_add_nodo.TabIndex = 1;
            btt_add_nodo.Text = "Aggiungi Nodo";
            btt_add_nodo.UseVisualStyleBackColor = true;
            btt_add_nodo.Click += btt_add_nodo_Click;
            // 
            // txb_nome_nodo
            // 
            txb_nome_nodo.Location = new Point(86, 15);
            txb_nome_nodo.Margin = new Padding(3, 2, 3, 2);
            txb_nome_nodo.Name = "txb_nome_nodo";
            txb_nome_nodo.Size = new Size(149, 23);
            txb_nome_nodo.TabIndex = 2;
            // 
            // lbl_nome_nodo
            // 
            lbl_nome_nodo.AutoSize = true;
            lbl_nome_nodo.Location = new Point(10, 15);
            lbl_nome_nodo.Name = "lbl_nome_nodo";
            lbl_nome_nodo.Size = new Size(43, 15);
            lbl_nome_nodo.TabIndex = 3;
            lbl_nome_nodo.Text = "Nome:";
            // 
            // lbl_metrica_nodo
            // 
            lbl_metrica_nodo.AutoSize = true;
            lbl_metrica_nodo.Location = new Point(10, 124);
            lbl_metrica_nodo.Name = "lbl_metrica_nodo";
            lbl_metrica_nodo.Size = new Size(68, 15);
            lbl_metrica_nodo.TabIndex = 5;
            lbl_metrica_nodo.Text = "Val Metrica:";
            // 
            // txb_metrica_nodo
            // 
            txb_metrica_nodo.Location = new Point(112, 119);
            txb_metrica_nodo.Margin = new Padding(3, 2, 3, 2);
            txb_metrica_nodo.Name = "txb_metrica_nodo";
            txb_metrica_nodo.Size = new Size(123, 23);
            txb_metrica_nodo.TabIndex = 4;
            // 
            // btt_stampa
            // 
            btt_stampa.Location = new Point(10, 356);
            btt_stampa.Margin = new Padding(3, 2, 3, 2);
            btt_stampa.Name = "btt_stampa";
            btt_stampa.Size = new Size(224, 22);
            btt_stampa.TabIndex = 6;
            btt_stampa.Text = "Stampa";
            btt_stampa.UseVisualStyleBackColor = true;
            btt_stampa.Click += btt_stampa_Click;
            // 
            // btt_add_arco
            // 
            btt_add_arco.Location = new Point(10, 196);
            btt_add_arco.Margin = new Padding(3, 2, 3, 2);
            btt_add_arco.Name = "btt_add_arco";
            btt_add_arco.Size = new Size(224, 22);
            btt_add_arco.TabIndex = 7;
            btt_add_arco.Text = "Aggiungi Arco";
            btt_add_arco.UseVisualStyleBackColor = true;
            btt_add_arco.Click += btt_add_arco_Click;
            // 
            // cmb_arrivo
            // 
            cmb_arrivo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_arrivo.FormattingEnabled = true;
            cmb_arrivo.Location = new Point(112, 171);
            cmb_arrivo.Margin = new Padding(3, 2, 3, 2);
            cmb_arrivo.Name = "cmb_arrivo";
            cmb_arrivo.Size = new Size(123, 23);
            cmb_arrivo.TabIndex = 8;
            // 
            // cmb_partenza
            // 
            cmb_partenza.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_partenza.FormattingEnabled = true;
            cmb_partenza.Location = new Point(112, 146);
            cmb_partenza.Margin = new Padding(3, 2, 3, 2);
            cmb_partenza.Name = "cmb_partenza";
            cmb_partenza.Size = new Size(123, 23);
            cmb_partenza.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 173);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 10;
            label1.Text = "Nodo Arrivo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 148);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 11;
            label2.Text = "Nodo Partenza:";
            // 
            // cmb_type
            // 
            cmb_type.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_type.FormattingEnabled = true;
            cmb_type.Location = new Point(86, 68);
            cmb_type.Margin = new Padding(3, 2, 3, 2);
            cmb_type.Name = "cmb_type";
            cmb_type.Size = new Size(149, 23);
            cmb_type.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 68);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 13;
            label3.Text = "Type:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 45);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 15;
            label4.Text = "N Abitanti:";
            // 
            // txt_n_abi
            // 
            txt_n_abi.Location = new Point(86, 40);
            txt_n_abi.Margin = new Padding(3, 2, 3, 2);
            txt_n_abi.Name = "txt_n_abi";
            txt_n_abi.Size = new Size(149, 23);
            txt_n_abi.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 307);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 19;
            label5.Text = "Val Fuel:";
            // 
            // txt_fuel
            // 
            txt_fuel.Location = new Point(71, 304);
            txt_fuel.Margin = new Padding(3, 2, 3, 2);
            txt_fuel.Name = "txt_fuel";
            txt_fuel.Size = new Size(164, 23);
            txt_fuel.TabIndex = 18;
            // 
            // btt_raggiungibile
            // 
            btt_raggiungibile.Location = new Point(10, 278);
            btt_raggiungibile.Margin = new Padding(3, 2, 3, 2);
            btt_raggiungibile.Name = "btt_raggiungibile";
            btt_raggiungibile.Size = new Size(224, 22);
            btt_raggiungibile.TabIndex = 17;
            btt_raggiungibile.Text = "Raggiungibile";
            btt_raggiungibile.UseVisualStyleBackColor = true;
            btt_raggiungibile.Click += btt_raggiungibile_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 229);
            label6.Name = "label6";
            label6.Size = new Size(88, 15);
            label6.TabIndex = 23;
            label6.Text = "Nodo Partenza:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(10, 254);
            label7.Name = "label7";
            label7.Size = new Size(75, 15);
            label7.TabIndex = 22;
            label7.Text = "Nodo Arrivo:";
            // 
            // cmb_part_espl
            // 
            cmb_part_espl.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_part_espl.FormattingEnabled = true;
            cmb_part_espl.Location = new Point(112, 223);
            cmb_part_espl.Margin = new Padding(3, 2, 3, 2);
            cmb_part_espl.Name = "cmb_part_espl";
            cmb_part_espl.Size = new Size(123, 23);
            cmb_part_espl.TabIndex = 21;
            // 
            // cmb_arr_espl
            // 
            cmb_arr_espl.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_arr_espl.FormattingEnabled = true;
            cmb_arr_espl.Location = new Point(112, 248);
            cmb_arr_espl.Margin = new Padding(3, 2, 3, 2);
            cmb_arr_espl.Name = "cmb_arr_espl";
            cmb_arr_espl.Size = new Size(123, 23);
            cmb_arr_espl.TabIndex = 20;
            // 
            // btt_raggiungibile_c
            // 
            btt_raggiungibile_c.Location = new Point(10, 329);
            btt_raggiungibile_c.Margin = new Padding(3, 2, 3, 2);
            btt_raggiungibile_c.Name = "btt_raggiungibile_c";
            btt_raggiungibile_c.Size = new Size(224, 22);
            btt_raggiungibile_c.TabIndex = 24;
            btt_raggiungibile_c.Text = "Raggiungibile Carburante";
            btt_raggiungibile_c.UseVisualStyleBackColor = true;
            btt_raggiungibile_c.Click += btt_raggiungibile_c_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SpringGreen;
            ClientSize = new Size(1146, 637);
            Controls.Add(btt_raggiungibile_c);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(cmb_part_espl);
            Controls.Add(cmb_arr_espl);
            Controls.Add(label5);
            Controls.Add(txt_fuel);
            Controls.Add(btt_raggiungibile);
            Controls.Add(label4);
            Controls.Add(txt_n_abi);
            Controls.Add(label3);
            Controls.Add(cmb_type);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmb_partenza);
            Controls.Add(cmb_arrivo);
            Controls.Add(btt_add_arco);
            Controls.Add(btt_stampa);
            Controls.Add(lbl_metrica_nodo);
            Controls.Add(txb_metrica_nodo);
            Controls.Add(lbl_nome_nodo);
            Controls.Add(txb_nome_nodo);
            Controls.Add(btt_add_nodo);
            Controls.Add(p);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel p;
        private Button btt_add_nodo;
        private TextBox txb_nome_nodo;
        private Label lbl_nome_nodo;
        private Label lbl_metrica_nodo;
        private TextBox txb_metrica_nodo;
        private Button btt_stampa;
        private Button btt_add_arco;
        private ComboBox cmb_arrivo;
        private ComboBox cmb_partenza;
        private Label label1;
        private Label label2;
        private ComboBox cmb_type;
        private Label label3;
        private Label label4;
        private TextBox txt_n_abi;
        private Label label5;
        private TextBox txt_fuel;
        private Button btt_raggiungibile;
        private Label label6;
        private Label label7;
        private ComboBox cmb_part_espl;
        private ComboBox cmb_arr_espl;
        private Button btt_raggiungibile_c;
    }
}
