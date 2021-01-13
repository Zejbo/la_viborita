
namespace la_viborita
{
    partial class Form1
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
            this.Fondo_del_juego = new System.Windows.Forms.PictureBox();
            this.Scoreboard_Text = new System.Windows.Forms.Label();
            this.Game_Timer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Fondo_del_juego)).BeginInit();
            this.SuspendLayout();
            // 
            // Fondo_del_juego
            // 
            this.Fondo_del_juego.BackColor = System.Drawing.Color.Gray;
            this.Fondo_del_juego.Location = new System.Drawing.Point(13, 13);
            this.Fondo_del_juego.Name = "Fondo_del_juego";
            this.Fondo_del_juego.Size = new System.Drawing.Size(541, 560);
            this.Fondo_del_juego.TabIndex = 0;
            this.Fondo_del_juego.TabStop = false;
            this.Fondo_del_juego.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Scoreboard_Text
            // 
            this.Scoreboard_Text.AutoSize = true;
            this.Scoreboard_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Scoreboard_Text.Location = new System.Drawing.Point(712, 109);
            this.Scoreboard_Text.Name = "Scoreboard_Text";
            this.Scoreboard_Text.Size = new System.Drawing.Size(0, 32);
            this.Scoreboard_Text.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(768, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(805, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 582);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Scoreboard_Text);
            this.Controls.Add(this.Fondo_del_juego);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.UpdateGraphics);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Soltar_Tecla);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Tocar_Tecla);
            ((System.ComponentModel.ISupportInitialize)(this.Fondo_del_juego)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Fondo_del_juego;
        private System.Windows.Forms.Label Scoreboard_Text;
        private System.Windows.Forms.Timer Game_Timer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

