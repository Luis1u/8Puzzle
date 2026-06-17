namespace IA2026
{
    partial class FRMOchoPuzzle
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.LBL00 = new System.Windows.Forms.Label();
            this.LBL01 = new System.Windows.Forms.Label();
            this.LBL02 = new System.Windows.Forms.Label();
            this.LBL12 = new System.Windows.Forms.Label();
            this.LBL11 = new System.Windows.Forms.Label();
            this.LBL10 = new System.Windows.Forms.Label();
            this.LBL22 = new System.Windows.Forms.Label();
            this.LBL21 = new System.Windows.Forms.Label();
            this.LBL20 = new System.Windows.Forms.Label();
            this.BTNDesordenar = new System.Windows.Forms.Button();
            this.TMRReloj = new System.Windows.Forms.Timer(this.components);
            this.LBLContador = new System.Windows.Forms.Label();
            this.BTNGenerarHijos = new System.Windows.Forms.Button();
            this.BTNEsFinal = new System.Windows.Forms.Button();
            this.BTNAnchuraPrioritaria = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.profundidadLimitada = new System.Windows.Forms.Button();
            this.cajaNumero = new System.Windows.Forms.DomainUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.cajaNumeroInterativo = new System.Windows.Forms.DomainUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBL00
            // 
            this.LBL00.BackColor = System.Drawing.Color.LightSkyBlue;
            this.LBL00.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBL00.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL00.Location = new System.Drawing.Point(9, 7);
            this.LBL00.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBL00.Name = "LBL00";
            this.LBL00.Size = new System.Drawing.Size(98, 106);
            this.LBL00.TabIndex = 0;
            this.LBL00.Text = "2";
            this.LBL00.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBL00.Click += new System.EventHandler(this.LBL00_Click);
            // 
            // LBL01
            // 
            this.LBL01.BackColor = System.Drawing.Color.LightSkyBlue;
            this.LBL01.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBL01.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL01.Location = new System.Drawing.Point(111, 7);
            this.LBL01.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBL01.Name = "LBL01";
            this.LBL01.Size = new System.Drawing.Size(98, 106);
            this.LBL01.TabIndex = 1;
            this.LBL01.Text = "8";
            this.LBL01.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBL01.Click += new System.EventHandler(this.LBL01_Click);
            // 
            // LBL02
            // 
            this.LBL02.BackColor = System.Drawing.Color.LightSkyBlue;
            this.LBL02.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBL02.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL02.Location = new System.Drawing.Point(213, 7);
            this.LBL02.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBL02.Name = "LBL02";
            this.LBL02.Size = new System.Drawing.Size(98, 106);
            this.LBL02.TabIndex = 2;
            this.LBL02.Text = "3";
            this.LBL02.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBL02.Click += new System.EventHandler(this.LBL02_Click);
            // 
            // LBL12
            // 
            this.LBL12.BackColor = System.Drawing.Color.LightSkyBlue;
            this.LBL12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBL12.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL12.Location = new System.Drawing.Point(213, 120);
            this.LBL12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBL12.Name = "LBL12";
            this.LBL12.Size = new System.Drawing.Size(98, 106);
            this.LBL12.TabIndex = 5;
            this.LBL12.Text = "4";
            this.LBL12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBL12.Click += new System.EventHandler(this.LBL12_Click);
            // 
            // LBL11
            // 
            this.LBL11.BackColor = System.Drawing.Color.LightSkyBlue;
            this.LBL11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBL11.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL11.Location = new System.Drawing.Point(111, 120);
            this.LBL11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBL11.Name = "LBL11";
            this.LBL11.Size = new System.Drawing.Size(98, 106);
            this.LBL11.TabIndex = 4;
            this.LBL11.Text = "6";
            this.LBL11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBL11.Click += new System.EventHandler(this.LBL11_Click);
            // 
            // LBL10
            // 
            this.LBL10.BackColor = System.Drawing.Color.LightSkyBlue;
            this.LBL10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBL10.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL10.Location = new System.Drawing.Point(9, 120);
            this.LBL10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBL10.Name = "LBL10";
            this.LBL10.Size = new System.Drawing.Size(98, 106);
            this.LBL10.TabIndex = 3;
            this.LBL10.Text = "1";
            this.LBL10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBL10.Click += new System.EventHandler(this.LBL10_Click);
            // 
            // LBL22
            // 
            this.LBL22.BackColor = System.Drawing.Color.LightSkyBlue;
            this.LBL22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBL22.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL22.Location = new System.Drawing.Point(213, 234);
            this.LBL22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBL22.Name = "LBL22";
            this.LBL22.Size = new System.Drawing.Size(98, 106);
            this.LBL22.TabIndex = 8;
            this.LBL22.Text = "5";
            this.LBL22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBL22.Click += new System.EventHandler(this.LBL22_Click);
            // 
            // LBL21
            // 
            this.LBL21.BackColor = System.Drawing.Color.LightSkyBlue;
            this.LBL21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBL21.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL21.Location = new System.Drawing.Point(111, 234);
            this.LBL21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBL21.Name = "LBL21";
            this.LBL21.Size = new System.Drawing.Size(98, 106);
            this.LBL21.TabIndex = 5;
            this.LBL21.Text = "0";
            this.LBL21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBL21.Click += new System.EventHandler(this.LBL21_Click);
            // 
            // LBL20
            // 
            this.LBL20.BackColor = System.Drawing.Color.LightSkyBlue;
            this.LBL20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBL20.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL20.Location = new System.Drawing.Point(9, 234);
            this.LBL20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBL20.Name = "LBL20";
            this.LBL20.Size = new System.Drawing.Size(98, 106);
            this.LBL20.TabIndex = 6;
            this.LBL20.Text = "7";
            this.LBL20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBL20.Click += new System.EventHandler(this.LBL20_Click);
            // 
            // BTNDesordenar
            // 
            this.BTNDesordenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNDesordenar.Location = new System.Drawing.Point(315, 10);
            this.BTNDesordenar.Margin = new System.Windows.Forms.Padding(2);
            this.BTNDesordenar.Name = "BTNDesordenar";
            this.BTNDesordenar.Size = new System.Drawing.Size(218, 41);
            this.BTNDesordenar.TabIndex = 9;
            this.BTNDesordenar.Text = "Desordenar";
            this.BTNDesordenar.UseVisualStyleBackColor = true;
            this.BTNDesordenar.Click += new System.EventHandler(this.BTNDesordenar_Click);
            // 
            // TMRReloj
            // 
            this.TMRReloj.Tick += new System.EventHandler(this.TMRReloj_Tick);
            // 
            // LBLContador
            // 
            this.LBLContador.BackColor = System.Drawing.Color.LightSkyBlue;
            this.LBLContador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBLContador.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLContador.Location = new System.Drawing.Point(315, 54);
            this.LBLContador.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBLContador.Name = "LBLContador";
            this.LBLContador.Size = new System.Drawing.Size(219, 60);
            this.LBLContador.TabIndex = 10;
            this.LBLContador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BTNGenerarHijos
            // 
            this.BTNGenerarHijos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNGenerarHijos.Location = new System.Drawing.Point(315, 120);
            this.BTNGenerarHijos.Margin = new System.Windows.Forms.Padding(2);
            this.BTNGenerarHijos.Name = "BTNGenerarHijos";
            this.BTNGenerarHijos.Size = new System.Drawing.Size(218, 41);
            this.BTNGenerarHijos.TabIndex = 11;
            this.BTNGenerarHijos.Text = "Generar Hijos";
            this.BTNGenerarHijos.UseVisualStyleBackColor = true;
            this.BTNGenerarHijos.Click += new System.EventHandler(this.BTNGenerarHijos_Click);
            // 
            // BTNEsFinal
            // 
            this.BTNEsFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNEsFinal.Location = new System.Drawing.Point(315, 167);
            this.BTNEsFinal.Margin = new System.Windows.Forms.Padding(2);
            this.BTNEsFinal.Name = "BTNEsFinal";
            this.BTNEsFinal.Size = new System.Drawing.Size(218, 41);
            this.BTNEsFinal.TabIndex = 12;
            this.BTNEsFinal.Text = "Es Final";
            this.BTNEsFinal.UseVisualStyleBackColor = true;
            this.BTNEsFinal.Click += new System.EventHandler(this.BTNEsFinal_Click);
            // 
            // BTNAnchuraPrioritaria
            // 
            this.BTNAnchuraPrioritaria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNAnchuraPrioritaria.Location = new System.Drawing.Point(315, 213);
            this.BTNAnchuraPrioritaria.Margin = new System.Windows.Forms.Padding(2);
            this.BTNAnchuraPrioritaria.Name = "BTNAnchuraPrioritaria";
            this.BTNAnchuraPrioritaria.Size = new System.Drawing.Size(218, 41);
            this.BTNAnchuraPrioritaria.TabIndex = 13;
            this.BTNAnchuraPrioritaria.Text = "Anchura Prioritaria";
            this.BTNAnchuraPrioritaria.UseVisualStyleBackColor = true;
            this.BTNAnchuraPrioritaria.Click += new System.EventHandler(this.BTNAnchuraPrioritaria_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // profundidadLimitada
            // 
            this.profundidadLimitada.Location = new System.Drawing.Point(316, 259);
            this.profundidadLimitada.Name = "profundidadLimitada";
            this.profundidadLimitada.Size = new System.Drawing.Size(164, 36);
            this.profundidadLimitada.TabIndex = 14;
            this.profundidadLimitada.Text = "Profundida Limitada";
            this.profundidadLimitada.UseVisualStyleBackColor = true;
            this.profundidadLimitada.Click += new System.EventHandler(this.button1_Click);
            // 
            // cajaNumero
            // 
            this.cajaNumero.Items.Add("31");
            this.cajaNumero.Items.Add("30");
            this.cajaNumero.Items.Add("29");
            this.cajaNumero.Items.Add("28");
            this.cajaNumero.Items.Add("27");
            this.cajaNumero.Items.Add("26");
            this.cajaNumero.Items.Add("25");
            this.cajaNumero.Items.Add("24");
            this.cajaNumero.Items.Add("23");
            this.cajaNumero.Items.Add("22");
            this.cajaNumero.Items.Add("21");
            this.cajaNumero.Items.Add("20");
            this.cajaNumero.Items.Add("19");
            this.cajaNumero.Items.Add("18");
            this.cajaNumero.Items.Add("17");
            this.cajaNumero.Items.Add("16");
            this.cajaNumero.Items.Add("15");
            this.cajaNumero.Items.Add("14");
            this.cajaNumero.Items.Add("13");
            this.cajaNumero.Items.Add("12");
            this.cajaNumero.Items.Add("11");
            this.cajaNumero.Items.Add("10");
            this.cajaNumero.Items.Add("9");
            this.cajaNumero.Items.Add("8");
            this.cajaNumero.Items.Add("7");
            this.cajaNumero.Items.Add("6");
            this.cajaNumero.Items.Add("5");
            this.cajaNumero.Items.Add("4");
            this.cajaNumero.Items.Add("3");
            this.cajaNumero.Items.Add("2");
            this.cajaNumero.Items.Add("1");
            this.cajaNumero.Items.Add("0");
            this.cajaNumero.Location = new System.Drawing.Point(491, 269);
            this.cajaNumero.Name = "cajaNumero";
            this.cajaNumero.ReadOnly = true;
            this.cajaNumero.Size = new System.Drawing.Size(43, 20);
            this.cajaNumero.TabIndex = 15;
            this.cajaNumero.Text = "0";
            this.cajaNumero.UseWaitCursor = true;
            this.cajaNumero.Wrap = true;
            this.cajaNumero.SelectedItemChanged += new System.EventHandler(this.cajaNumero_SelectedItemChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(315, 301);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 36);
            this.button1.TabIndex = 16;
            this.button1.Text = "Profundida Interativa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // cajaNumeroInterativo
            // 
            this.cajaNumeroInterativo.Items.Add("31");
            this.cajaNumeroInterativo.Items.Add("30");
            this.cajaNumeroInterativo.Items.Add("29");
            this.cajaNumeroInterativo.Items.Add("28");
            this.cajaNumeroInterativo.Items.Add("27");
            this.cajaNumeroInterativo.Items.Add("26");
            this.cajaNumeroInterativo.Items.Add("25");
            this.cajaNumeroInterativo.Items.Add("24");
            this.cajaNumeroInterativo.Items.Add("23");
            this.cajaNumeroInterativo.Items.Add("22");
            this.cajaNumeroInterativo.Items.Add("21");
            this.cajaNumeroInterativo.Items.Add("20");
            this.cajaNumeroInterativo.Items.Add("19");
            this.cajaNumeroInterativo.Items.Add("18");
            this.cajaNumeroInterativo.Items.Add("17");
            this.cajaNumeroInterativo.Items.Add("16");
            this.cajaNumeroInterativo.Items.Add("15");
            this.cajaNumeroInterativo.Items.Add("14");
            this.cajaNumeroInterativo.Items.Add("13");
            this.cajaNumeroInterativo.Items.Add("12");
            this.cajaNumeroInterativo.Items.Add("11");
            this.cajaNumeroInterativo.Items.Add("10");
            this.cajaNumeroInterativo.Items.Add("9");
            this.cajaNumeroInterativo.Items.Add("8");
            this.cajaNumeroInterativo.Items.Add("7");
            this.cajaNumeroInterativo.Items.Add("6");
            this.cajaNumeroInterativo.Items.Add("5");
            this.cajaNumeroInterativo.Items.Add("4");
            this.cajaNumeroInterativo.Items.Add("3");
            this.cajaNumeroInterativo.Items.Add("2");
            this.cajaNumeroInterativo.Items.Add("1");
            this.cajaNumeroInterativo.Items.Add("0");
            this.cajaNumeroInterativo.Location = new System.Drawing.Point(491, 311);
            this.cajaNumeroInterativo.Name = "cajaNumeroInterativo";
            this.cajaNumeroInterativo.ReadOnly = true;
            this.cajaNumeroInterativo.Size = new System.Drawing.Size(43, 20);
            this.cajaNumeroInterativo.TabIndex = 17;
            this.cajaNumeroInterativo.Text = "0";
            this.cajaNumeroInterativo.UseWaitCursor = true;
            this.cajaNumeroInterativo.Wrap = true;
            this.cajaNumeroInterativo.SelectedItemChanged += new System.EventHandler(this.domainUpDown1_SelectedItemChanged_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(374, 343);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "h2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(455, 343);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 19;
            this.button3.Text = "h3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(293, 343);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 20;
            this.button4.Text = "h1";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // FRMOchoPuzzle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 430);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cajaNumeroInterativo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cajaNumero);
            this.Controls.Add(this.profundidadLimitada);
            this.Controls.Add(this.BTNAnchuraPrioritaria);
            this.Controls.Add(this.BTNEsFinal);
            this.Controls.Add(this.BTNGenerarHijos);
            this.Controls.Add(this.LBLContador);
            this.Controls.Add(this.BTNDesordenar);
            this.Controls.Add(this.LBL22);
            this.Controls.Add(this.LBL21);
            this.Controls.Add(this.LBL20);
            this.Controls.Add(this.LBL12);
            this.Controls.Add(this.LBL11);
            this.Controls.Add(this.LBL10);
            this.Controls.Add(this.LBL02);
            this.Controls.Add(this.LBL01);
            this.Controls.Add(this.LBL00);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FRMOchoPuzzle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "8 Puzzle";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LBL00;
        private System.Windows.Forms.Label LBL01;
        private System.Windows.Forms.Label LBL02;
        private System.Windows.Forms.Label LBL12;
        private System.Windows.Forms.Label LBL11;
        private System.Windows.Forms.Label LBL10;
        private System.Windows.Forms.Label LBL22;
        private System.Windows.Forms.Label LBL21;
        private System.Windows.Forms.Label LBL20;
        private System.Windows.Forms.Button BTNDesordenar;
        private System.Windows.Forms.Timer TMRReloj;
        private System.Windows.Forms.Label LBLContador;
        private System.Windows.Forms.Button BTNGenerarHijos;
        private System.Windows.Forms.Button BTNEsFinal;
        private System.Windows.Forms.Button BTNAnchuraPrioritaria;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button profundidadLimitada;
        private System.Windows.Forms.DomainUpDown cajaNumero;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DomainUpDown cajaNumeroInterativo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

