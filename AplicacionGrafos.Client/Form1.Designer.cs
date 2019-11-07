namespace AplicacionGrafos.Client
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_Palab_Ini = new System.Windows.Forms.TextBox();
            this.lbl_palabra1 = new System.Windows.Forms.Label();
            this.lb_palabra2 = new System.Windows.Forms.Label();
            this.txt_Palab_Fin = new System.Windows.Forms.TextBox();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.btn_Accion = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_dataSet = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.combo_cantidad = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_Palab_Ini
            // 
            this.txt_Palab_Ini.Location = new System.Drawing.Point(6, 108);
            this.txt_Palab_Ini.Multiline = true;
            this.txt_Palab_Ini.Name = "txt_Palab_Ini";
            this.txt_Palab_Ini.Size = new System.Drawing.Size(155, 38);
            this.txt_Palab_Ini.TabIndex = 0;
            // 
            // lbl_palabra1
            // 
            this.lbl_palabra1.AutoSize = true;
            this.lbl_palabra1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_palabra1.Location = new System.Drawing.Point(7, 82);
            this.lbl_palabra1.Name = "lbl_palabra1";
            this.lbl_palabra1.Size = new System.Drawing.Size(137, 17);
            this.lbl_palabra1.TabIndex = 1;
            this.lbl_palabra1.Text = "Ingrese palabra Uno";
            // 
            // lb_palabra2
            // 
            this.lb_palabra2.AutoSize = true;
            this.lb_palabra2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_palabra2.Location = new System.Drawing.Point(177, 82);
            this.lb_palabra2.Name = "lb_palabra2";
            this.lb_palabra2.Size = new System.Drawing.Size(137, 17);
            this.lb_palabra2.TabIndex = 3;
            this.lb_palabra2.Text = "Ingrese Palabra Dos";
            // 
            // txt_Palab_Fin
            // 
            this.txt_Palab_Fin.Location = new System.Drawing.Point(180, 108);
            this.txt_Palab_Fin.Multiline = true;
            this.txt_Palab_Fin.Name = "txt_Palab_Fin";
            this.txt_Palab_Fin.Size = new System.Drawing.Size(149, 38);
            this.txt_Palab_Fin.TabIndex = 2;
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.Location = new System.Drawing.Point(227, 28);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(0, 20);
            this.lbl_Titulo.TabIndex = 4;
            // 
            // btn_Accion
            // 
            this.btn_Accion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Accion.Location = new System.Drawing.Point(8, 170);
            this.btn_Accion.Name = "btn_Accion";
            this.btn_Accion.Size = new System.Drawing.Size(151, 43);
            this.btn_Accion.TabIndex = 5;
            this.btn_Accion.Text = "Consultar";
            this.btn_Accion.UseVisualStyleBackColor = true;
            this.btn_Accion.Click += new System.EventHandler(this.Btn_Accion_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 301);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(572, 198);
            this.dataGridView1.TabIndex = 6;
            // 
            // lbl_dataSet
            // 
            this.lbl_dataSet.AutoSize = true;
            this.lbl_dataSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dataSet.Location = new System.Drawing.Point(232, -47);
            this.lbl_dataSet.Name = "lbl_dataSet";
            this.lbl_dataSet.Size = new System.Drawing.Size(171, 20);
            this.lbl_dataSet.TabIndex = 7;
            this.lbl_dataSet.Text = "Resultado de Consulta";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.combo_cantidad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_Palab_Ini);
            this.groupBox1.Controls.Add(this.lbl_dataSet);
            this.groupBox1.Controls.Add(this.lbl_palabra1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.txt_Palab_Fin);
            this.groupBox1.Controls.Add(this.btn_Accion);
            this.groupBox1.Controls.Add(this.lb_palabra2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(588, 534);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Palabras";
            // 
            // combo_cantidad
            // 
            this.combo_cantidad.AutoCompleteCustomSource.AddRange(new string[] {
            "5",
            "4",
            "3",
            "2",
            "1"});
            this.combo_cantidad.FormattingEnabled = true;
            this.combo_cantidad.Items.AddRange(new object[] {
            "7 Caracteres",
            "6 Caracteres",
            "5 Caracteres",
            "4 Caracteres",
            "3 Caracteres",
            "2 Caracteres"});
            this.combo_cantidad.Location = new System.Drawing.Point(352, 108);
            this.combo_cantidad.Name = "combo_cantidad";
            this.combo_cantidad.Size = new System.Drawing.Size(142, 32);
            this.combo_cantidad.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(349, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Cantidad de Letras X palabra";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Resultados Consulta";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(612, 574);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_Titulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Palab_Ini;
        private System.Windows.Forms.Label lbl_palabra1;
        private System.Windows.Forms.Label lb_palabra2;
        private System.Windows.Forms.TextBox txt_Palab_Fin;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.Button btn_Accion;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_dataSet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combo_cantidad;
    }
}

