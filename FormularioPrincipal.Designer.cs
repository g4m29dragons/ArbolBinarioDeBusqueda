namespace Diseño_arboles_binarios
{
    partial class Fase_4_árbol_binario
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
            this.txtNodo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.panelPreorden = new System.Windows.Forms.Panel();
            this.panelArbol = new System.Windows.Forms.PictureBox();
            this.panelInorden = new System.Windows.Forms.Panel();
            this.panelPosorden = new System.Windows.Forms.Panel();
            this.btnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.panelArbol)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNodo
            // 
            this.txtNodo.Location = new System.Drawing.Point(25, 24);
            this.txtNodo.Name = "txtNodo";
            this.txtNodo.Size = new System.Drawing.Size(100, 20);
            this.txtNodo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Valor Entero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Árbol ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Recorrido Preorden";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 369);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Recorrido Inorden";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 458);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Recorrido Posorden";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(155, 21);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(109, 23);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar Nodo";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // panelPreorden
            // 
            this.panelPreorden.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelPreorden.Location = new System.Drawing.Point(25, 307);
            this.panelPreorden.Name = "panelPreorden";
            this.panelPreorden.Size = new System.Drawing.Size(743, 58);
            this.panelPreorden.TabIndex = 10;
            // 
            // panelArbol
            // 
            this.panelArbol.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelArbol.Location = new System.Drawing.Point(25, 77);
            this.panelArbol.Name = "panelArbol";
            this.panelArbol.Size = new System.Drawing.Size(743, 211);
            this.panelArbol.TabIndex = 11;
            this.panelArbol.TabStop = false;
            // 
            // panelInorden
            // 
            this.panelInorden.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelInorden.Location = new System.Drawing.Point(25, 387);
            this.panelInorden.Name = "panelInorden";
            this.panelInorden.Size = new System.Drawing.Size(743, 65);
            this.panelInorden.TabIndex = 12;
            // 
            // panelPosorden
            // 
            this.panelPosorden.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelPosorden.Location = new System.Drawing.Point(25, 478);
            this.panelPosorden.Name = "panelPosorden";
            this.panelPosorden.Size = new System.Drawing.Size(743, 63);
            this.panelPosorden.TabIndex = 13;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(317, 21);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(103, 23);
            this.btnLimpiar.TabIndex = 14;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // Fase_4_árbol_binario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 568);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.panelPosorden);
            this.Controls.Add(this.panelInorden);
            this.Controls.Add(this.panelArbol);
            this.Controls.Add(this.panelPreorden);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNodo);
            this.Name = "Fase_4_árbol_binario";
            this.Text = "Fase_4_árbol_binario";
            ((System.ComponentModel.ISupportInitialize)(this.panelArbol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNodo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Panel panelPreorden;
        private System.Windows.Forms.PictureBox panelArbol;
        private System.Windows.Forms.Panel panelInorden;
        private System.Windows.Forms.Panel panelPosorden;
        private System.Windows.Forms.Button btnLimpiar;
    }
}