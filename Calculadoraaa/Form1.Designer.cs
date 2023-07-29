namespace Calculadoraaa
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
            txtResultado = new TextBox();
            btnUno = new Button();
            btnDos = new Button();
            btnTres = new Button();
            btnSeis = new Button();
            btnCinco = new Button();
            btnCuatro = new Button();
            btnNueve = new Button();
            btnOcho = new Button();
            btnSiete = new Button();
            btnQuitar = new Button();
            btnBorrarTodo = new Button();
            btnBorrar = new Button();
            btnAlcuadrado = new Button();
            btnRaiz = new Button();
            btnMultiplicacion = new Button();
            btnDivision = new Button();
            btnMenos = new Button();
            btnMas = new Button();
            btnResultado = new Button();
            btnPunto = new Button();
            btnCero = new Button();
            btnSigno = new Button();
            SuspendLayout();
            // 
            // txtResultado
            // 
            txtResultado.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtResultado.Location = new Point(12, 12);
            txtResultado.MaxLength = 21;
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(302, 40);
            txtResultado.TabIndex = 0;
            txtResultado.Text = "0";
            txtResultado.TextAlign = HorizontalAlignment.Right;
            // 
            // btnUno
            // 
            btnUno.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnUno.Location = new Point(12, 238);
            btnUno.Name = "btnUno";
            btnUno.Size = new Size(45, 45);
            btnUno.TabIndex = 1;
            btnUno.Text = "1";
            btnUno.UseVisualStyleBackColor = true;
            btnUno.Click += agregarNumero;
            // 
            // btnDos
            // 
            btnDos.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnDos.Location = new Point(74, 238);
            btnDos.Name = "btnDos";
            btnDos.Size = new Size(45, 45);
            btnDos.TabIndex = 2;
            btnDos.Text = "2";
            btnDos.UseVisualStyleBackColor = true;
            btnDos.Click += agregarNumero;
            // 
            // btnTres
            // 
            btnTres.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnTres.Location = new Point(135, 237);
            btnTres.Name = "btnTres";
            btnTres.Size = new Size(45, 45);
            btnTres.TabIndex = 3;
            btnTres.Text = "3";
            btnTres.UseVisualStyleBackColor = true;
            btnTres.Click += agregarNumero;
            // 
            // btnSeis
            // 
            btnSeis.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnSeis.Location = new Point(135, 180);
            btnSeis.Name = "btnSeis";
            btnSeis.Size = new Size(45, 45);
            btnSeis.TabIndex = 6;
            btnSeis.Text = "6";
            btnSeis.UseVisualStyleBackColor = true;
            btnSeis.Click += agregarNumero;
            // 
            // btnCinco
            // 
            btnCinco.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCinco.Location = new Point(74, 181);
            btnCinco.Name = "btnCinco";
            btnCinco.Size = new Size(45, 45);
            btnCinco.TabIndex = 5;
            btnCinco.Text = "5";
            btnCinco.UseVisualStyleBackColor = true;
            btnCinco.Click += agregarNumero;
            // 
            // btnCuatro
            // 
            btnCuatro.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCuatro.Location = new Point(12, 181);
            btnCuatro.Name = "btnCuatro";
            btnCuatro.Size = new Size(45, 45);
            btnCuatro.TabIndex = 4;
            btnCuatro.Text = "4";
            btnCuatro.UseVisualStyleBackColor = true;
            btnCuatro.Click += agregarNumero;
            // 
            // btnNueve
            // 
            btnNueve.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnNueve.Location = new Point(135, 122);
            btnNueve.Name = "btnNueve";
            btnNueve.Size = new Size(45, 45);
            btnNueve.TabIndex = 9;
            btnNueve.Text = "9";
            btnNueve.UseVisualStyleBackColor = true;
            btnNueve.Click += agregarNumero;
            // 
            // btnOcho
            // 
            btnOcho.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnOcho.Location = new Point(74, 123);
            btnOcho.Name = "btnOcho";
            btnOcho.Size = new Size(45, 45);
            btnOcho.TabIndex = 8;
            btnOcho.Text = "8";
            btnOcho.UseVisualStyleBackColor = true;
            btnOcho.Click += agregarNumero;
            // 
            // btnSiete
            // 
            btnSiete.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnSiete.Location = new Point(12, 123);
            btnSiete.Name = "btnSiete";
            btnSiete.Size = new Size(45, 45);
            btnSiete.TabIndex = 7;
            btnSiete.Text = "7";
            btnSiete.UseVisualStyleBackColor = true;
            btnSiete.Click += agregarNumero;
            // 
            // btnQuitar
            // 
            btnQuitar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnQuitar.Location = new Point(135, 71);
            btnQuitar.Name = "btnQuitar";
            btnQuitar.Size = new Size(45, 45);
            btnQuitar.TabIndex = 12;
            btnQuitar.Text = "<-";
            btnQuitar.UseVisualStyleBackColor = true;
            btnQuitar.Click += btnQuitar_Click;
            // 
            // btnBorrarTodo
            // 
            btnBorrarTodo.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnBorrarTodo.Location = new Point(74, 71);
            btnBorrarTodo.Name = "btnBorrarTodo";
            btnBorrarTodo.Size = new Size(45, 45);
            btnBorrarTodo.TabIndex = 11;
            btnBorrarTodo.Text = "C";
            btnBorrarTodo.UseVisualStyleBackColor = true;
            btnBorrarTodo.Click += btnBorrarTodo_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnBorrar.Location = new Point(12, 72);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(45, 45);
            btnBorrar.TabIndex = 10;
            btnBorrar.Text = "CE";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnAlcuadrado
            // 
            btnAlcuadrado.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAlcuadrado.Location = new Point(281, 75);
            btnAlcuadrado.Name = "btnAlcuadrado";
            btnAlcuadrado.Size = new Size(45, 45);
            btnAlcuadrado.TabIndex = 14;
            btnAlcuadrado.Tag = "²";
            btnAlcuadrado.Text = "x²";
            btnAlcuadrado.UseVisualStyleBackColor = true;
            btnAlcuadrado.Click += ClickOperador;
            // 
            // btnRaiz
            // 
            btnRaiz.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnRaiz.Location = new Point(217, 74);
            btnRaiz.Name = "btnRaiz";
            btnRaiz.Size = new Size(45, 45);
            btnRaiz.TabIndex = 13;
            btnRaiz.Tag = "√";
            btnRaiz.Text = "√";
            btnRaiz.UseVisualStyleBackColor = true;
            btnRaiz.Click += ClickOperador;
            // 
            // btnMultiplicacion
            // 
            btnMultiplicacion.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnMultiplicacion.Location = new Point(281, 126);
            btnMultiplicacion.Name = "btnMultiplicacion";
            btnMultiplicacion.Size = new Size(45, 45);
            btnMultiplicacion.TabIndex = 16;
            btnMultiplicacion.Tag = "X";
            btnMultiplicacion.Text = "X";
            btnMultiplicacion.UseVisualStyleBackColor = true;
            btnMultiplicacion.Click += ClickOperador;
            // 
            // btnDivision
            // 
            btnDivision.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnDivision.Location = new Point(217, 125);
            btnDivision.Name = "btnDivision";
            btnDivision.Size = new Size(45, 45);
            btnDivision.TabIndex = 15;
            btnDivision.Tag = "/";
            btnDivision.Text = "/";
            btnDivision.UseVisualStyleBackColor = true;
            btnDivision.Click += ClickOperador;
            // 
            // btnMenos
            // 
            btnMenos.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnMenos.Location = new Point(281, 181);
            btnMenos.Name = "btnMenos";
            btnMenos.Size = new Size(45, 45);
            btnMenos.TabIndex = 18;
            btnMenos.Tag = "-";
            btnMenos.Text = "-";
            btnMenos.UseVisualStyleBackColor = true;
            btnMenos.Click += ClickOperador;
            // 
            // btnMas
            // 
            btnMas.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnMas.Location = new Point(217, 180);
            btnMas.Name = "btnMas";
            btnMas.Size = new Size(45, 45);
            btnMas.TabIndex = 17;
            btnMas.Tag = "+";
            btnMas.Text = "+";
            btnMas.UseVisualStyleBackColor = true;
            btnMas.Click += ClickOperador;
            // 
            // btnResultado
            // 
            btnResultado.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnResultado.Location = new Point(217, 246);
            btnResultado.Name = "btnResultado";
            btnResultado.Size = new Size(109, 45);
            btnResultado.TabIndex = 19;
            btnResultado.Text = "=";
            btnResultado.UseVisualStyleBackColor = true;
            btnResultado.Click += btnResultado_Click;
            // 
            // btnPunto
            // 
            btnPunto.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnPunto.Location = new Point(135, 288);
            btnPunto.Name = "btnPunto";
            btnPunto.Size = new Size(45, 45);
            btnPunto.TabIndex = 22;
            btnPunto.Text = ".";
            btnPunto.UseVisualStyleBackColor = true;
            btnPunto.Click += btnPunto_Click;
            // 
            // btnCero
            // 
            btnCero.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCero.Location = new Point(74, 289);
            btnCero.Name = "btnCero";
            btnCero.Size = new Size(45, 45);
            btnCero.TabIndex = 21;
            btnCero.Text = "0";
            btnCero.UseVisualStyleBackColor = true;
            btnCero.Click += agregarNumero;
            // 
            // btnSigno
            // 
            btnSigno.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSigno.Location = new Point(12, 289);
            btnSigno.Name = "btnSigno";
            btnSigno.Size = new Size(45, 45);
            btnSigno.TabIndex = 20;
            btnSigno.Text = "+/-";
            btnSigno.UseVisualStyleBackColor = true;
            btnSigno.Click += btnSigno_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(335, 345);
            Controls.Add(btnPunto);
            Controls.Add(btnCero);
            Controls.Add(btnSigno);
            Controls.Add(btnResultado);
            Controls.Add(btnMenos);
            Controls.Add(btnMas);
            Controls.Add(btnMultiplicacion);
            Controls.Add(btnDivision);
            Controls.Add(btnAlcuadrado);
            Controls.Add(btnRaiz);
            Controls.Add(btnQuitar);
            Controls.Add(btnBorrarTodo);
            Controls.Add(btnBorrar);
            Controls.Add(btnNueve);
            Controls.Add(btnOcho);
            Controls.Add(btnSiete);
            Controls.Add(btnSeis);
            Controls.Add(btnCinco);
            Controls.Add(btnCuatro);
            Controls.Add(btnTres);
            Controls.Add(btnDos);
            Controls.Add(btnUno);
            Controls.Add(txtResultado);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Calculadora";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtResultado;
        private Button btnUno;
        private Button btnDos;
        private Button btnTres;
        private Button btnSeis;
        private Button btnCinco;
        private Button btnCuatro;
        private Button btnNueve;
        private Button btnOcho;
        private Button btnSiete;
        private Button btnQuitar;
        private Button btnBorrarTodo;
        private Button btnBorrar;
        private Button btnAlcuadrado;
        private Button btnRaiz;
        private Button btnMultiplicacion;
        private Button btnDivision;
        private Button btnMenos;
        private Button btnMas;
        private Button btnResultado;
        private Button btnPunto;
        private Button btnCero;
        private Button btnSigno;
    }
}