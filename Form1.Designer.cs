namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnEgual = new System.Windows.Forms.Button();
            this.brnVirg = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnMore = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.brnLess = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.btnEigth = new System.Windows.Forms.Button();
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnOffOn = new System.Windows.Forms.Button();
            this.btnQuadrado = new System.Windows.Forms.Button();
            this.btnPorcent = new System.Windows.Forms.Button();
            this.brnUmX = new System.Windows.Forms.Button();
            this.btnRaiz = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.SystemColors.Menu;
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold);
            this.txtResult.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtResult.Location = new System.Drawing.Point(12, 80);
            this.txtResult.MaxLength = 16;
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(310, 88);
            this.txtResult.TabIndex = 0;
            this.txtResult.Text = "0";
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnEgual
            // 
            this.btnEgual.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEgual.FlatAppearance.BorderSize = 20;
            this.btnEgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEgual.Location = new System.Drawing.Point(249, 440);
            this.btnEgual.Name = "btnEgual";
            this.btnEgual.Size = new System.Drawing.Size(73, 45);
            this.btnEgual.TabIndex = 32;
            this.btnEgual.Text = "=";
            this.btnEgual.UseVisualStyleBackColor = true;
            this.btnEgual.Click += new System.EventHandler(this.btnEgual_Click);
            // 
            // brnVirg
            // 
            this.brnVirg.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.brnVirg.FlatAppearance.BorderSize = 20;
            this.brnVirg.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnVirg.Location = new System.Drawing.Point(170, 440);
            this.brnVirg.Name = "brnVirg";
            this.brnVirg.Size = new System.Drawing.Size(73, 45);
            this.brnVirg.TabIndex = 33;
            this.brnVirg.Text = ",";
            this.brnVirg.UseVisualStyleBackColor = true;
            this.brnVirg.Click += new System.EventHandler(this.brnVirg_Click);
            // 
            // btnZero
            // 
            this.btnZero.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnZero.FlatAppearance.BorderSize = 20;
            this.btnZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZero.Location = new System.Drawing.Point(12, 440);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(152, 45);
            this.btnZero.TabIndex = 34;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = true;
            this.btnZero.Click += new System.EventHandler(this.addNumbers);
            // 
            // btnMore
            // 
            this.btnMore.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnMore.FlatAppearance.BorderSize = 20;
            this.btnMore.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMore.Location = new System.Drawing.Point(249, 389);
            this.btnMore.Name = "btnMore";
            this.btnMore.Size = new System.Drawing.Size(73, 45);
            this.btnMore.TabIndex = 35;
            this.btnMore.Tag = "+";
            this.btnMore.Text = "+";
            this.btnMore.UseVisualStyleBackColor = true;
            this.btnMore.Click += new System.EventHandler(this.signals);
            // 
            // btnThree
            // 
            this.btnThree.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnThree.FlatAppearance.BorderSize = 20;
            this.btnThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThree.Location = new System.Drawing.Point(170, 389);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(73, 45);
            this.btnThree.TabIndex = 36;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = true;
            this.btnThree.Click += new System.EventHandler(this.addNumbers);
            // 
            // btnTwo
            // 
            this.btnTwo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnTwo.FlatAppearance.BorderSize = 20;
            this.btnTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTwo.Location = new System.Drawing.Point(91, 389);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(73, 45);
            this.btnTwo.TabIndex = 37;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = true;
            this.btnTwo.Click += new System.EventHandler(this.addNumbers);
            // 
            // btnOne
            // 
            this.btnOne.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnOne.FlatAppearance.BorderSize = 20;
            this.btnOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOne.Location = new System.Drawing.Point(12, 389);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(73, 45);
            this.btnOne.TabIndex = 38;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = true;
            this.btnOne.Click += new System.EventHandler(this.addNumbers);
            // 
            // brnLess
            // 
            this.brnLess.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.brnLess.FlatAppearance.BorderSize = 20;
            this.brnLess.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnLess.Location = new System.Drawing.Point(249, 338);
            this.brnLess.Name = "brnLess";
            this.brnLess.Size = new System.Drawing.Size(73, 45);
            this.brnLess.TabIndex = 39;
            this.brnLess.Tag = "-";
            this.brnLess.Text = "-";
            this.brnLess.UseVisualStyleBackColor = true;
            this.brnLess.Click += new System.EventHandler(this.signals);
            // 
            // btnSix
            // 
            this.btnSix.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSix.FlatAppearance.BorderSize = 20;
            this.btnSix.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSix.Location = new System.Drawing.Point(170, 338);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(73, 45);
            this.btnSix.TabIndex = 40;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = true;
            this.btnSix.Click += new System.EventHandler(this.addNumbers);
            // 
            // btnFive
            // 
            this.btnFive.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnFive.FlatAppearance.BorderSize = 20;
            this.btnFive.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFive.Location = new System.Drawing.Point(91, 338);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(73, 45);
            this.btnFive.TabIndex = 41;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = true;
            this.btnFive.Click += new System.EventHandler(this.addNumbers);
            // 
            // btnFour
            // 
            this.btnFour.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnFour.FlatAppearance.BorderSize = 20;
            this.btnFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFour.Location = new System.Drawing.Point(12, 338);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(73, 45);
            this.btnFour.TabIndex = 42;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = true;
            this.btnFour.Click += new System.EventHandler(this.addNumbers);
            // 
            // btnMultiply
            // 
            this.btnMultiply.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnMultiply.FlatAppearance.BorderSize = 20;
            this.btnMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiply.Location = new System.Drawing.Point(249, 287);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(73, 45);
            this.btnMultiply.TabIndex = 43;
            this.btnMultiply.Tag = "*";
            this.btnMultiply.Text = "x";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.signals);
            // 
            // btnNine
            // 
            this.btnNine.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnNine.FlatAppearance.BorderSize = 20;
            this.btnNine.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNine.Location = new System.Drawing.Point(170, 287);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(73, 45);
            this.btnNine.TabIndex = 44;
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = true;
            this.btnNine.Click += new System.EventHandler(this.addNumbers);
            // 
            // btnEigth
            // 
            this.btnEigth.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEigth.FlatAppearance.BorderSize = 20;
            this.btnEigth.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEigth.Location = new System.Drawing.Point(91, 287);
            this.btnEigth.Name = "btnEigth";
            this.btnEigth.Size = new System.Drawing.Size(73, 45);
            this.btnEigth.TabIndex = 45;
            this.btnEigth.Text = "8";
            this.btnEigth.UseVisualStyleBackColor = true;
            this.btnEigth.Click += new System.EventHandler(this.addNumbers);
            // 
            // btnSeven
            // 
            this.btnSeven.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSeven.FlatAppearance.BorderSize = 20;
            this.btnSeven.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeven.Location = new System.Drawing.Point(12, 287);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(73, 45);
            this.btnSeven.TabIndex = 46;
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = true;
            this.btnSeven.Click += new System.EventHandler(this.addNumbers);
            // 
            // btnDivision
            // 
            this.btnDivision.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDivision.FlatAppearance.BorderSize = 20;
            this.btnDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivision.Location = new System.Drawing.Point(249, 239);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(73, 45);
            this.btnDivision.TabIndex = 47;
            this.btnDivision.Tag = "/";
            this.btnDivision.Text = "/";
            this.btnDivision.UseVisualStyleBackColor = true;
            this.btnDivision.Click += new System.EventHandler(this.signals);
            // 
            // btnOffOn
            // 
            this.btnOffOn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnOffOn.FlatAppearance.BorderSize = 20;
            this.btnOffOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOffOn.Location = new System.Drawing.Point(91, 188);
            this.btnOffOn.Name = "btnOffOn";
            this.btnOffOn.Size = new System.Drawing.Size(73, 45);
            this.btnOffOn.TabIndex = 48;
            this.btnOffOn.Text = "CE";
            this.btnOffOn.UseVisualStyleBackColor = true;
            this.btnOffOn.Click += new System.EventHandler(this.btnOffOn_Click);
            // 
            // btnQuadrado
            // 
            this.btnQuadrado.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnQuadrado.FlatAppearance.BorderSize = 20;
            this.btnQuadrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuadrado.Location = new System.Drawing.Point(91, 236);
            this.btnQuadrado.Name = "btnQuadrado";
            this.btnQuadrado.Size = new System.Drawing.Size(73, 45);
            this.btnQuadrado.TabIndex = 49;
            this.btnQuadrado.Tag = "²";
            this.btnQuadrado.Text = "x²";
            this.btnQuadrado.UseVisualStyleBackColor = true;
            this.btnQuadrado.Click += new System.EventHandler(this.signals);
            // 
            // btnPorcent
            // 
            this.btnPorcent.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPorcent.FlatAppearance.BorderSize = 20;
            this.btnPorcent.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPorcent.Location = new System.Drawing.Point(12, 188);
            this.btnPorcent.Name = "btnPorcent";
            this.btnPorcent.Size = new System.Drawing.Size(73, 45);
            this.btnPorcent.TabIndex = 50;
            this.btnPorcent.Tag = "%";
            this.btnPorcent.Text = "%";
            this.btnPorcent.UseVisualStyleBackColor = true;
            this.btnPorcent.Click += new System.EventHandler(this.signals);
            // 
            // brnUmX
            // 
            this.brnUmX.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.brnUmX.FlatAppearance.BorderSize = 20;
            this.brnUmX.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnUmX.Location = new System.Drawing.Point(12, 239);
            this.brnUmX.Name = "brnUmX";
            this.brnUmX.Size = new System.Drawing.Size(73, 45);
            this.brnUmX.TabIndex = 51;
            this.brnUmX.Tag = " 1/x";
            this.brnUmX.Text = " 1/x";
            this.brnUmX.UseVisualStyleBackColor = true;
            this.brnUmX.Click += new System.EventHandler(this.signals);
            // 
            // btnRaiz
            // 
            this.btnRaiz.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRaiz.FlatAppearance.BorderSize = 20;
            this.btnRaiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRaiz.Location = new System.Drawing.Point(170, 236);
            this.btnRaiz.Name = "btnRaiz";
            this.btnRaiz.Size = new System.Drawing.Size(73, 45);
            this.btnRaiz.TabIndex = 52;
            this.btnRaiz.Tag = "√";
            this.btnRaiz.Text = "√2";
            this.btnRaiz.UseVisualStyleBackColor = true;
            this.btnRaiz.Click += new System.EventHandler(this.signals);
            // 
            // btnDel
            // 
            this.btnDel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDel.FlatAppearance.BorderSize = 20;
            this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Location = new System.Drawing.Point(249, 188);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(73, 45);
            this.btnDel.TabIndex = 53;
            this.btnDel.Text = "<=";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRestart.FlatAppearance.BorderSize = 20;
            this.btnRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.Location = new System.Drawing.Point(170, 188);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(73, 45);
            this.btnRestart.TabIndex = 54;
            this.btnRestart.Text = "C";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 37);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(107, 31);
            this.label1.TabIndex = 55;
            this.label1.Text = "Padrão";
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Font = new System.Drawing.Font("Microsoft New Tai Lue", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg.ForeColor = System.Drawing.Color.Red;
            this.lblMsg.Location = new System.Drawing.Point(37, 9);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(0, 26);
            this.lblMsg.TabIndex = 56;
            this.lblMsg.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(334, 491);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnRaiz);
            this.Controls.Add(this.brnUmX);
            this.Controls.Add(this.btnPorcent);
            this.Controls.Add(this.btnQuadrado);
            this.Controls.Add(this.btnOffOn);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnSeven);
            this.Controls.Add(this.btnEigth);
            this.Controls.Add(this.btnNine);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnFour);
            this.Controls.Add(this.btnFive);
            this.Controls.Add(this.btnSix);
            this.Controls.Add(this.brnLess);
            this.Controls.Add(this.btnOne);
            this.Controls.Add(this.btnTwo);
            this.Controls.Add(this.btnThree);
            this.Controls.Add(this.btnMore);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.brnVirg);
            this.Controls.Add(this.btnEgual);
            this.Controls.Add(this.txtResult);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora Jey";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnEgual;
        private System.Windows.Forms.Button brnVirg;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnMore;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button brnLess;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnNine;
        private System.Windows.Forms.Button btnEigth;
        private System.Windows.Forms.Button btnSeven;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnOffOn;
        private System.Windows.Forms.Button btnQuadrado;
        private System.Windows.Forms.Button btnPorcent;
        private System.Windows.Forms.Button brnUmX;
        private System.Windows.Forms.Button btnRaiz;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMsg;
    }
}

