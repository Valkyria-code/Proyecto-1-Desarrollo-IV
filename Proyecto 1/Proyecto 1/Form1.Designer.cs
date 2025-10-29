namespace Proyecto_1
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
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_menos = new System.Windows.Forms.Button();
            this.btn_multiplicar = new System.Windows.Forms.Button();
            this.btn_dividir = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_cuadrado = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_0 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_mas = new System.Windows.Forms.Button();
            this.btn_igual = new System.Windows.Forms.Button();
            this.btn_ans = new System.Windows.Forms.Button();
            this.btn_punto = new System.Windows.Forms.Button();
            this.btn_cierra_parentesis = new System.Windows.Forms.Button();
            this.btn_raiz_cuadrada = new System.Windows.Forms.Button();
            this.btn_abre_parentesis = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_potencia = new System.Windows.Forms.Button();
            this.btn_historial = new System.Windows.Forms.Button();
            this.btn_clear_entry = new System.Windows.Forms.Button();
            this.txt_entrada = new System.Windows.Forms.TextBox();
            this.dgv_historial = new System.Windows.Forms.DataGridView();
            this.btn_raiz = new System.Windows.Forms.Button();
            this.btn_cierre_indice_raiz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_historial)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_9
            // 
            this.btn_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_9.Location = new System.Drawing.Point(189, 269);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(47, 50);
            this.btn_9.TabIndex = 0;
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = true;
            this.btn_9.Click += new System.EventHandler(this.AgregarDigito);
            // 
            // btn_menos
            // 
            this.btn_menos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_menos.Location = new System.Drawing.Point(270, 394);
            this.btn_menos.Name = "btn_menos";
            this.btn_menos.Size = new System.Drawing.Size(47, 46);
            this.btn_menos.TabIndex = 1;
            this.btn_menos.Text = "-";
            this.btn_menos.UseVisualStyleBackColor = true;
            this.btn_menos.Click += new System.EventHandler(this.AgregarDigito);
            // 
            // btn_multiplicar
            // 
            this.btn_multiplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_multiplicar.Location = new System.Drawing.Point(270, 331);
            this.btn_multiplicar.Name = "btn_multiplicar";
            this.btn_multiplicar.Size = new System.Drawing.Size(47, 49);
            this.btn_multiplicar.TabIndex = 2;
            this.btn_multiplicar.Text = "*";
            this.btn_multiplicar.UseVisualStyleBackColor = true;
            this.btn_multiplicar.Click += new System.EventHandler(this.AgregarDigito);
            // 
            // btn_dividir
            // 
            this.btn_dividir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dividir.Location = new System.Drawing.Point(270, 208);
            this.btn_dividir.Name = "btn_dividir";
            this.btn_dividir.Size = new System.Drawing.Size(47, 46);
            this.btn_dividir.TabIndex = 3;
            this.btn_dividir.Text = "/";
            this.btn_dividir.UseVisualStyleBackColor = true;
            this.btn_dividir.Click += new System.EventHandler(this.AgregarDigito);
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(270, 76);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(47, 50);
            this.btn_clear.TabIndex = 4;
            this.btn_clear.Text = "C";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_cuadrado
            // 
            this.btn_cuadrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cuadrado.Location = new System.Drawing.Point(270, 144);
            this.btn_cuadrado.Name = "btn_cuadrado";
            this.btn_cuadrado.Size = new System.Drawing.Size(47, 48);
            this.btn_cuadrado.TabIndex = 5;
            this.btn_cuadrado.Text = "^2";
            this.btn_cuadrado.UseVisualStyleBackColor = true;
            this.btn_cuadrado.Click += new System.EventHandler(this.AgregarDigito);
            // 
            // btn_7
            // 
            this.btn_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_7.Location = new System.Drawing.Point(28, 269);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(47, 50);
            this.btn_7.TabIndex = 6;
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = true;
            this.btn_7.Click += new System.EventHandler(this.AgregarDigito);
            // 
            // btn_5
            // 
            this.btn_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_5.Location = new System.Drawing.Point(108, 330);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(47, 50);
            this.btn_5.TabIndex = 7;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = true;
            this.btn_5.Click += new System.EventHandler(this.AgregarDigito);
            // 
            // btn_3
            // 
            this.btn_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_3.Location = new System.Drawing.Point(189, 394);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(47, 46);
            this.btn_3.TabIndex = 8;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = true;
            this.btn_3.Click += new System.EventHandler(this.AgregarDigito);
            // 
            // btn_1
            // 
            this.btn_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_1.Location = new System.Drawing.Point(28, 394);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(47, 46);
            this.btn_1.TabIndex = 9;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.AgregarDigito);
            // 
            // btn_0
            // 
            this.btn_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_0.Location = new System.Drawing.Point(28, 450);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(47, 46);
            this.btn_0.TabIndex = 10;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = true;
            this.btn_0.Click += new System.EventHandler(this.AgregarDigito);
            // 
            // btn_2
            // 
            this.btn_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_2.Location = new System.Drawing.Point(108, 394);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(47, 46);
            this.btn_2.TabIndex = 11;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.AgregarDigito);
            // 
            // btn_6
            // 
            this.btn_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_6.Location = new System.Drawing.Point(189, 331);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(47, 49);
            this.btn_6.TabIndex = 12;
            this.btn_6.Text = "6";
            this.btn_6.UseVisualStyleBackColor = true;
            this.btn_6.Click += new System.EventHandler(this.AgregarDigito);
            // 
            // btn_mas
            // 
            this.btn_mas.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mas.Location = new System.Drawing.Point(270, 269);
            this.btn_mas.Name = "btn_mas";
            this.btn_mas.Size = new System.Drawing.Size(47, 46);
            this.btn_mas.TabIndex = 13;
            this.btn_mas.Text = "+";
            this.btn_mas.UseVisualStyleBackColor = true;
            this.btn_mas.Click += new System.EventHandler(this.AgregarDigito);
            // 
            // btn_igual
            // 
            this.btn_igual.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_igual.Location = new System.Drawing.Point(270, 450);
            this.btn_igual.Name = "btn_igual";
            this.btn_igual.Size = new System.Drawing.Size(47, 46);
            this.btn_igual.TabIndex = 14;
            this.btn_igual.Text = "=";
            this.btn_igual.UseVisualStyleBackColor = true;
            this.btn_igual.Click += new System.EventHandler(this.btn_igual_Click);
            // 
            // btn_ans
            // 
            this.btn_ans.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ans.Location = new System.Drawing.Point(185, 450);
            this.btn_ans.Name = "btn_ans";
            this.btn_ans.Size = new System.Drawing.Size(56, 46);
            this.btn_ans.TabIndex = 15;
            this.btn_ans.Text = "Ans";
            this.btn_ans.UseVisualStyleBackColor = true;
            this.btn_ans.Click += new System.EventHandler(this.btn_ans_Click);
            // 
            // btn_punto
            // 
            this.btn_punto.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_punto.Location = new System.Drawing.Point(108, 450);
            this.btn_punto.Name = "btn_punto";
            this.btn_punto.Size = new System.Drawing.Size(47, 46);
            this.btn_punto.TabIndex = 16;
            this.btn_punto.Text = ".";
            this.btn_punto.UseVisualStyleBackColor = true;
            this.btn_punto.Click += new System.EventHandler(this.AgregarDigito);
            // 
            // btn_cierra_parentesis
            // 
            this.btn_cierra_parentesis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cierra_parentesis.Location = new System.Drawing.Point(109, 144);
            this.btn_cierra_parentesis.Name = "btn_cierra_parentesis";
            this.btn_cierra_parentesis.Size = new System.Drawing.Size(47, 50);
            this.btn_cierra_parentesis.TabIndex = 17;
            this.btn_cierra_parentesis.Text = ")";
            this.btn_cierra_parentesis.UseVisualStyleBackColor = true;
            this.btn_cierra_parentesis.Click += new System.EventHandler(this.AgregarDigito);
            // 
            // btn_raiz_cuadrada
            // 
            this.btn_raiz_cuadrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_raiz_cuadrada.Location = new System.Drawing.Point(189, 208);
            this.btn_raiz_cuadrada.Name = "btn_raiz_cuadrada";
            this.btn_raiz_cuadrada.Size = new System.Drawing.Size(47, 46);
            this.btn_raiz_cuadrada.TabIndex = 18;
            this.btn_raiz_cuadrada.Text = "√";
            this.btn_raiz_cuadrada.UseVisualStyleBackColor = true;
            this.btn_raiz_cuadrada.Click += new System.EventHandler(this.btn_raiz_cuadrada_Click);
            // 
            // btn_abre_parentesis
            // 
            this.btn_abre_parentesis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_abre_parentesis.Location = new System.Drawing.Point(28, 141);
            this.btn_abre_parentesis.Name = "btn_abre_parentesis";
            this.btn_abre_parentesis.Size = new System.Drawing.Size(47, 50);
            this.btn_abre_parentesis.TabIndex = 19;
            this.btn_abre_parentesis.Text = "(";
            this.btn_abre_parentesis.UseVisualStyleBackColor = true;
            this.btn_abre_parentesis.Click += new System.EventHandler(this.btn_abre_parentesis_Click);
            // 
            // btn_8
            // 
            this.btn_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_8.Location = new System.Drawing.Point(108, 269);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(47, 50);
            this.btn_8.TabIndex = 20;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = true;
            this.btn_8.Click += new System.EventHandler(this.AgregarDigito);
            // 
            // btn_4
            // 
            this.btn_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_4.Location = new System.Drawing.Point(28, 330);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(47, 50);
            this.btn_4.TabIndex = 21;
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = true;
            this.btn_4.Click += new System.EventHandler(this.AgregarDigito);
            // 
            // btn_potencia
            // 
            this.btn_potencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btn_potencia.Location = new System.Drawing.Point(189, 144);
            this.btn_potencia.Name = "btn_potencia";
            this.btn_potencia.Size = new System.Drawing.Size(47, 48);
            this.btn_potencia.TabIndex = 22;
            this.btn_potencia.Text = "^";
            this.btn_potencia.UseVisualStyleBackColor = true;
            this.btn_potencia.Click += new System.EventHandler(this.btn_potencia_Click);
            // 
            // btn_historial
            // 
            this.btn_historial.Font = new System.Drawing.Font("Microsoft Tai Le", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_historial.Location = new System.Drawing.Point(28, 76);
            this.btn_historial.Name = "btn_historial";
            this.btn_historial.Size = new System.Drawing.Size(127, 50);
            this.btn_historial.TabIndex = 23;
            this.btn_historial.Text = "Historial";
            this.btn_historial.UseVisualStyleBackColor = true;
            this.btn_historial.Click += new System.EventHandler(this.btn_historial_Click);
            // 
            // btn_clear_entry
            // 
            this.btn_clear_entry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear_entry.Location = new System.Drawing.Point(189, 76);
            this.btn_clear_entry.Name = "btn_clear_entry";
            this.btn_clear_entry.Size = new System.Drawing.Size(47, 50);
            this.btn_clear_entry.TabIndex = 24;
            this.btn_clear_entry.Text = "CE";
            this.btn_clear_entry.UseVisualStyleBackColor = true;
            this.btn_clear_entry.Click += new System.EventHandler(this.btn_clear_entry_Click);
            // 
            // txt_entrada
            // 
            this.txt_entrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_entrada.Location = new System.Drawing.Point(29, 21);
            this.txt_entrada.Name = "txt_entrada";
            this.txt_entrada.Size = new System.Drawing.Size(289, 29);
            this.txt_entrada.TabIndex = 25;
            // 
            // dgv_historial
            // 
            this.dgv_historial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_historial.Location = new System.Drawing.Point(347, 21);
            this.dgv_historial.Name = "dgv_historial";
            this.dgv_historial.Size = new System.Drawing.Size(246, 475);
            this.dgv_historial.TabIndex = 26;
            // 
            // btn_raiz
            // 
            this.btn_raiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_raiz.Location = new System.Drawing.Point(109, 208);
            this.btn_raiz.Name = "btn_raiz";
            this.btn_raiz.Size = new System.Drawing.Size(47, 46);
            this.btn_raiz.TabIndex = 27;
            this.btn_raiz.Text = "ⁿ√";
            this.btn_raiz.UseVisualStyleBackColor = true;
            this.btn_raiz.Click += new System.EventHandler(this.btn_raiz_Click);
            // 
            // btn_cierre_indice_raiz
            // 
            this.btn_cierre_indice_raiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cierre_indice_raiz.Location = new System.Drawing.Point(28, 206);
            this.btn_cierre_indice_raiz.Name = "btn_cierre_indice_raiz";
            this.btn_cierre_indice_raiz.Size = new System.Drawing.Size(47, 50);
            this.btn_cierre_indice_raiz.TabIndex = 28;
            this.btn_cierre_indice_raiz.Text = "]";
            this.btn_cierre_indice_raiz.UseVisualStyleBackColor = true;
            this.btn_cierre_indice_raiz.Click += new System.EventHandler(this.AgregarDigito);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 510);
            this.Controls.Add(this.btn_cierre_indice_raiz);
            this.Controls.Add(this.btn_raiz);
            this.Controls.Add(this.dgv_historial);
            this.Controls.Add(this.txt_entrada);
            this.Controls.Add(this.btn_clear_entry);
            this.Controls.Add(this.btn_historial);
            this.Controls.Add(this.btn_potencia);
            this.Controls.Add(this.btn_4);
            this.Controls.Add(this.btn_8);
            this.Controls.Add(this.btn_abre_parentesis);
            this.Controls.Add(this.btn_raiz_cuadrada);
            this.Controls.Add(this.btn_cierra_parentesis);
            this.Controls.Add(this.btn_punto);
            this.Controls.Add(this.btn_ans);
            this.Controls.Add(this.btn_igual);
            this.Controls.Add(this.btn_mas);
            this.Controls.Add(this.btn_6);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_0);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_5);
            this.Controls.Add(this.btn_7);
            this.Controls.Add(this.btn_cuadrado);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_dividir);
            this.Controls.Add(this.btn_multiplicar);
            this.Controls.Add(this.btn_menos);
            this.Controls.Add(this.btn_9);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_historial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_menos;
        private System.Windows.Forms.Button btn_multiplicar;
        private System.Windows.Forms.Button btn_dividir;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_cuadrado;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_0;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_mas;
        private System.Windows.Forms.Button btn_igual;
        private System.Windows.Forms.Button btn_ans;
        private System.Windows.Forms.Button btn_punto;
        private System.Windows.Forms.Button btn_cierra_parentesis;
        private System.Windows.Forms.Button btn_raiz_cuadrada;
        private System.Windows.Forms.Button btn_abre_parentesis;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_potencia;
        private System.Windows.Forms.Button btn_historial;
        private System.Windows.Forms.Button btn_clear_entry;
        private System.Windows.Forms.TextBox txt_entrada;
        private System.Windows.Forms.DataGridView dgv_historial;
        private System.Windows.Forms.Button btn_raiz;
        private System.Windows.Forms.Button btn_cierre_indice_raiz;
    }
}

