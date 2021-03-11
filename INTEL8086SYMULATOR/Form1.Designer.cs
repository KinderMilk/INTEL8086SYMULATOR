
namespace INTEL8086SYMULATOR
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.AX_POLE = new System.Windows.Forms.TextBox();
            this.BX_POLE = new System.Windows.Forms.TextBox();
            this.CX_POLE = new System.Windows.Forms.TextBox();
            this.DX_POLE = new System.Windows.Forms.TextBox();
            this.AX_NAPIS = new System.Windows.Forms.TextBox();
            this.BX_NAPIS = new System.Windows.Forms.TextBox();
            this.CX_TEXT = new System.Windows.Forms.TextBox();
            this.DX_NAPIS = new System.Windows.Forms.TextBox();
            this.AL_NAPIS = new System.Windows.Forms.TextBox();
            this.BL_NAPIS = new System.Windows.Forms.TextBox();
            this.CL_NAPIS = new System.Windows.Forms.TextBox();
            this.DL_NAPIS = new System.Windows.Forms.TextBox();
            this.AL_POLE = new System.Windows.Forms.TextBox();
            this.BL_POLE = new System.Windows.Forms.TextBox();
            this.CL_POLE = new System.Windows.Forms.TextBox();
            this.DL_POLE = new System.Windows.Forms.TextBox();
            this.AH_NAPIS = new System.Windows.Forms.TextBox();
            this.AH_POLE = new System.Windows.Forms.TextBox();
            this.DH_POLE = new System.Windows.Forms.TextBox();
            this.CH_NAPIS = new System.Windows.Forms.TextBox();
            this.BH_POLE = new System.Windows.Forms.TextBox();
            this.CH_POLE = new System.Windows.Forms.TextBox();
            this.BH_NAPIS = new System.Windows.Forms.TextBox();
            this.DH_NAPIS = new System.Windows.Forms.TextBox();
            this.AX_BUTTON = new System.Windows.Forms.RadioButton();
            this.BX_BUTTON2 = new System.Windows.Forms.RadioButton();
            this.BX_BUTTON = new System.Windows.Forms.RadioButton();
            this.AX_BUTTON2 = new System.Windows.Forms.RadioButton();
            this.CX_BUTTON = new System.Windows.Forms.RadioButton();
            this.CX_BUTTON2 = new System.Windows.Forms.RadioButton();
            this.DX_BUTTON = new System.Windows.Forms.RadioButton();
            this.DX_BUTTON2 = new System.Windows.Forms.RadioButton();
            this.MOVE_BUTTON = new System.Windows.Forms.Button();
            this.XCHG_BUTTON = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AX_POLE
            // 
            this.AX_POLE.Location = new System.Drawing.Point(82, 67);
            this.AX_POLE.Name = "AX_POLE";
            this.AX_POLE.Size = new System.Drawing.Size(100, 20);
            this.AX_POLE.TabIndex = 0;
            this.AX_POLE.Text = "0000";
            this.AX_POLE.TextChanged += new System.EventHandler(this.AX_POLE_TextChanged);
            // 
            // BX_POLE
            // 
            this.BX_POLE.Location = new System.Drawing.Point(82, 127);
            this.BX_POLE.Name = "BX_POLE";
            this.BX_POLE.Size = new System.Drawing.Size(100, 20);
            this.BX_POLE.TabIndex = 1;
            this.BX_POLE.Text = "0000";
            this.BX_POLE.TextChanged += new System.EventHandler(this.BX_WARTOSC_TextChanged);
            // 
            // CX_POLE
            // 
            this.CX_POLE.Location = new System.Drawing.Point(82, 182);
            this.CX_POLE.Name = "CX_POLE";
            this.CX_POLE.Size = new System.Drawing.Size(100, 20);
            this.CX_POLE.TabIndex = 2;
            this.CX_POLE.Text = "0000";
            // 
            // DX_POLE
            // 
            this.DX_POLE.Location = new System.Drawing.Point(82, 232);
            this.DX_POLE.Name = "DX_POLE";
            this.DX_POLE.Size = new System.Drawing.Size(100, 20);
            this.DX_POLE.TabIndex = 3;
            this.DX_POLE.Text = "0000";
            // 
            // AX_NAPIS
            // 
            this.AX_NAPIS.Location = new System.Drawing.Point(42, 67);
            this.AX_NAPIS.Name = "AX_NAPIS";
            this.AX_NAPIS.Size = new System.Drawing.Size(23, 20);
            this.AX_NAPIS.TabIndex = 4;
            this.AX_NAPIS.Text = "AX";
            // 
            // BX_NAPIS
            // 
            this.BX_NAPIS.Location = new System.Drawing.Point(42, 127);
            this.BX_NAPIS.Name = "BX_NAPIS";
            this.BX_NAPIS.Size = new System.Drawing.Size(23, 20);
            this.BX_NAPIS.TabIndex = 5;
            this.BX_NAPIS.Text = "BX";
            // 
            // CX_TEXT
            // 
            this.CX_TEXT.Location = new System.Drawing.Point(42, 182);
            this.CX_TEXT.Name = "CX_TEXT";
            this.CX_TEXT.Size = new System.Drawing.Size(23, 20);
            this.CX_TEXT.TabIndex = 6;
            this.CX_TEXT.Text = "CX_TEXT";
            this.CX_TEXT.TextChanged += new System.EventHandler(this.CX_TEXT_TextChanged);
            // 
            // DX_NAPIS
            // 
            this.DX_NAPIS.Location = new System.Drawing.Point(42, 232);
            this.DX_NAPIS.Name = "DX_NAPIS";
            this.DX_NAPIS.Size = new System.Drawing.Size(23, 20);
            this.DX_NAPIS.TabIndex = 7;
            this.DX_NAPIS.Text = "DX";
            // 
            // AL_NAPIS
            // 
            this.AL_NAPIS.Location = new System.Drawing.Point(584, 67);
            this.AL_NAPIS.Name = "AL_NAPIS";
            this.AL_NAPIS.Size = new System.Drawing.Size(40, 20);
            this.AL_NAPIS.TabIndex = 8;
            this.AL_NAPIS.Text = "AL";
            this.AL_NAPIS.TextChanged += new System.EventHandler(this.AL_NAPIS_TextChanged);
            // 
            // BL_NAPIS
            // 
            this.BL_NAPIS.Location = new System.Drawing.Point(584, 127);
            this.BL_NAPIS.Name = "BL_NAPIS";
            this.BL_NAPIS.Size = new System.Drawing.Size(40, 20);
            this.BL_NAPIS.TabIndex = 9;
            this.BL_NAPIS.Text = "BL";
            // 
            // CL_NAPIS
            // 
            this.CL_NAPIS.Location = new System.Drawing.Point(584, 182);
            this.CL_NAPIS.Name = "CL_NAPIS";
            this.CL_NAPIS.Size = new System.Drawing.Size(40, 20);
            this.CL_NAPIS.TabIndex = 10;
            this.CL_NAPIS.Text = "CL";
            // 
            // DL_NAPIS
            // 
            this.DL_NAPIS.Location = new System.Drawing.Point(584, 232);
            this.DL_NAPIS.Name = "DL_NAPIS";
            this.DL_NAPIS.Size = new System.Drawing.Size(40, 20);
            this.DL_NAPIS.TabIndex = 11;
            this.DL_NAPIS.Text = "DL";
            // 
            // AL_POLE
            // 
            this.AL_POLE.Location = new System.Drawing.Point(665, 67);
            this.AL_POLE.Name = "AL_POLE";
            this.AL_POLE.Size = new System.Drawing.Size(113, 20);
            this.AL_POLE.TabIndex = 12;
            this.AL_POLE.Text = "0000";
            // 
            // BL_POLE
            // 
            this.BL_POLE.Location = new System.Drawing.Point(665, 127);
            this.BL_POLE.Name = "BL_POLE";
            this.BL_POLE.Size = new System.Drawing.Size(113, 20);
            this.BL_POLE.TabIndex = 13;
            this.BL_POLE.Text = "0000";
            // 
            // CL_POLE
            // 
            this.CL_POLE.Location = new System.Drawing.Point(665, 182);
            this.CL_POLE.Name = "CL_POLE";
            this.CL_POLE.Size = new System.Drawing.Size(113, 20);
            this.CL_POLE.TabIndex = 14;
            this.CL_POLE.Text = "0000";
            // 
            // DL_POLE
            // 
            this.DL_POLE.Location = new System.Drawing.Point(665, 232);
            this.DL_POLE.Name = "DL_POLE";
            this.DL_POLE.Size = new System.Drawing.Size(113, 20);
            this.DL_POLE.TabIndex = 15;
            this.DL_POLE.Text = "0000";
            // 
            // AH_NAPIS
            // 
            this.AH_NAPIS.Location = new System.Drawing.Point(345, 67);
            this.AH_NAPIS.Name = "AH_NAPIS";
            this.AH_NAPIS.Size = new System.Drawing.Size(29, 20);
            this.AH_NAPIS.TabIndex = 16;
            this.AH_NAPIS.Text = "AH";
            // 
            // AH_POLE
            // 
            this.AH_POLE.Location = new System.Drawing.Point(402, 67);
            this.AH_POLE.Name = "AH_POLE";
            this.AH_POLE.Size = new System.Drawing.Size(113, 20);
            this.AH_POLE.TabIndex = 17;
            this.AH_POLE.Text = "0000";
            // 
            // DH_POLE
            // 
            this.DH_POLE.Location = new System.Drawing.Point(402, 232);
            this.DH_POLE.Name = "DH_POLE";
            this.DH_POLE.Size = new System.Drawing.Size(113, 20);
            this.DH_POLE.TabIndex = 18;
            this.DH_POLE.Text = "0000";
            // 
            // CH_NAPIS
            // 
            this.CH_NAPIS.Location = new System.Drawing.Point(345, 182);
            this.CH_NAPIS.Name = "CH_NAPIS";
            this.CH_NAPIS.Size = new System.Drawing.Size(29, 20);
            this.CH_NAPIS.TabIndex = 19;
            this.CH_NAPIS.Text = "CH";
            // 
            // BH_POLE
            // 
            this.BH_POLE.Location = new System.Drawing.Point(402, 127);
            this.BH_POLE.Name = "BH_POLE";
            this.BH_POLE.Size = new System.Drawing.Size(113, 20);
            this.BH_POLE.TabIndex = 20;
            this.BH_POLE.Text = "0000";
            // 
            // CH_POLE
            // 
            this.CH_POLE.Location = new System.Drawing.Point(402, 182);
            this.CH_POLE.Name = "CH_POLE";
            this.CH_POLE.Size = new System.Drawing.Size(113, 20);
            this.CH_POLE.TabIndex = 21;
            this.CH_POLE.Text = "0000";
            // 
            // BH_NAPIS
            // 
            this.BH_NAPIS.Location = new System.Drawing.Point(345, 127);
            this.BH_NAPIS.Name = "BH_NAPIS";
            this.BH_NAPIS.Size = new System.Drawing.Size(29, 20);
            this.BH_NAPIS.TabIndex = 22;
            this.BH_NAPIS.Text = "BH";
            // 
            // DH_NAPIS
            // 
            this.DH_NAPIS.Location = new System.Drawing.Point(345, 232);
            this.DH_NAPIS.Name = "DH_NAPIS";
            this.DH_NAPIS.Size = new System.Drawing.Size(29, 20);
            this.DH_NAPIS.TabIndex = 23;
            this.DH_NAPIS.Text = "DH";
            // 
            // AX_BUTTON
            // 
            this.AX_BUTTON.AutoSize = true;
            this.AX_BUTTON.Location = new System.Drawing.Point(42, 352);
            this.AX_BUTTON.Name = "AX_BUTTON";
            this.AX_BUTTON.Size = new System.Drawing.Size(39, 17);
            this.AX_BUTTON.TabIndex = 24;
            this.AX_BUTTON.TabStop = true;
            this.AX_BUTTON.Text = "AX";
            this.AX_BUTTON.UseVisualStyleBackColor = true;
            // 
            // BX_BUTTON2
            // 
            this.BX_BUTTON2.AutoSize = true;
            this.BX_BUTTON2.Location = new System.Drawing.Point(167, 399);
            this.BX_BUTTON2.Name = "BX_BUTTON2";
            this.BX_BUTTON2.Size = new System.Drawing.Size(39, 17);
            this.BX_BUTTON2.TabIndex = 25;
            this.BX_BUTTON2.TabStop = true;
            this.BX_BUTTON2.Text = "BX";
            this.BX_BUTTON2.UseVisualStyleBackColor = true;
            // 
            // BX_BUTTON
            // 
            this.BX_BUTTON.AutoSize = true;
            this.BX_BUTTON.Location = new System.Drawing.Point(42, 399);
            this.BX_BUTTON.Name = "BX_BUTTON";
            this.BX_BUTTON.Size = new System.Drawing.Size(39, 17);
            this.BX_BUTTON.TabIndex = 26;
            this.BX_BUTTON.TabStop = true;
            this.BX_BUTTON.Text = "BX";
            this.BX_BUTTON.UseVisualStyleBackColor = true;
            // 
            // AX_BUTTON2
            // 
            this.AX_BUTTON2.AutoSize = true;
            this.AX_BUTTON2.Location = new System.Drawing.Point(167, 352);
            this.AX_BUTTON2.Name = "AX_BUTTON2";
            this.AX_BUTTON2.Size = new System.Drawing.Size(39, 17);
            this.AX_BUTTON2.TabIndex = 27;
            this.AX_BUTTON2.TabStop = true;
            this.AX_BUTTON2.Text = "AX";
            this.AX_BUTTON2.UseVisualStyleBackColor = true;
            // 
            // CX_BUTTON
            // 
            this.CX_BUTTON.AutoSize = true;
            this.CX_BUTTON.Location = new System.Drawing.Point(42, 448);
            this.CX_BUTTON.Name = "CX_BUTTON";
            this.CX_BUTTON.Size = new System.Drawing.Size(39, 17);
            this.CX_BUTTON.TabIndex = 28;
            this.CX_BUTTON.TabStop = true;
            this.CX_BUTTON.Text = "CX";
            this.CX_BUTTON.UseVisualStyleBackColor = true;
            // 
            // CX_BUTTON2
            // 
            this.CX_BUTTON2.AutoSize = true;
            this.CX_BUTTON2.Location = new System.Drawing.Point(167, 448);
            this.CX_BUTTON2.Name = "CX_BUTTON2";
            this.CX_BUTTON2.Size = new System.Drawing.Size(39, 17);
            this.CX_BUTTON2.TabIndex = 29;
            this.CX_BUTTON2.TabStop = true;
            this.CX_BUTTON2.Text = "CX";
            this.CX_BUTTON2.UseVisualStyleBackColor = true;
            // 
            // DX_BUTTON
            // 
            this.DX_BUTTON.AutoSize = true;
            this.DX_BUTTON.Location = new System.Drawing.Point(42, 494);
            this.DX_BUTTON.Name = "DX_BUTTON";
            this.DX_BUTTON.Size = new System.Drawing.Size(40, 17);
            this.DX_BUTTON.TabIndex = 30;
            this.DX_BUTTON.TabStop = true;
            this.DX_BUTTON.Text = "DX";
            this.DX_BUTTON.UseVisualStyleBackColor = true;
            // 
            // DX_BUTTON2
            // 
            this.DX_BUTTON2.AutoSize = true;
            this.DX_BUTTON2.Location = new System.Drawing.Point(167, 494);
            this.DX_BUTTON2.Name = "DX_BUTTON2";
            this.DX_BUTTON2.Size = new System.Drawing.Size(40, 17);
            this.DX_BUTTON2.TabIndex = 31;
            this.DX_BUTTON2.TabStop = true;
            this.DX_BUTTON2.Text = "DX";
            this.DX_BUTTON2.UseVisualStyleBackColor = true;
            // 
            // MOVE_BUTTON
            // 
            this.MOVE_BUTTON.Location = new System.Drawing.Point(345, 382);
            this.MOVE_BUTTON.Name = "MOVE_BUTTON";
            this.MOVE_BUTTON.Size = new System.Drawing.Size(143, 83);
            this.MOVE_BUTTON.TabIndex = 32;
            this.MOVE_BUTTON.Text = "MOVE";
            this.MOVE_BUTTON.UseVisualStyleBackColor = true;
            // 
            // XCHG_BUTTON
            // 
            this.XCHG_BUTTON.Location = new System.Drawing.Point(621, 382);
            this.XCHG_BUTTON.Name = "XCHG_BUTTON";
            this.XCHG_BUTTON.Size = new System.Drawing.Size(157, 83);
            this.XCHG_BUTTON.TabIndex = 33;
            this.XCHG_BUTTON.Text = "XCHG";
            this.XCHG_BUTTON.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(836, 560);
            this.Controls.Add(this.XCHG_BUTTON);
            this.Controls.Add(this.MOVE_BUTTON);
            this.Controls.Add(this.DX_BUTTON2);
            this.Controls.Add(this.DX_BUTTON);
            this.Controls.Add(this.CX_BUTTON2);
            this.Controls.Add(this.CX_BUTTON);
            this.Controls.Add(this.AX_BUTTON2);
            this.Controls.Add(this.BX_BUTTON);
            this.Controls.Add(this.BX_BUTTON2);
            this.Controls.Add(this.AX_BUTTON);
            this.Controls.Add(this.DH_NAPIS);
            this.Controls.Add(this.BH_NAPIS);
            this.Controls.Add(this.CH_POLE);
            this.Controls.Add(this.BH_POLE);
            this.Controls.Add(this.CH_NAPIS);
            this.Controls.Add(this.DH_POLE);
            this.Controls.Add(this.AH_POLE);
            this.Controls.Add(this.AH_NAPIS);
            this.Controls.Add(this.DL_POLE);
            this.Controls.Add(this.CL_POLE);
            this.Controls.Add(this.BL_POLE);
            this.Controls.Add(this.AL_POLE);
            this.Controls.Add(this.DL_NAPIS);
            this.Controls.Add(this.CL_NAPIS);
            this.Controls.Add(this.BL_NAPIS);
            this.Controls.Add(this.AL_NAPIS);
            this.Controls.Add(this.DX_NAPIS);
            this.Controls.Add(this.CX_TEXT);
            this.Controls.Add(this.BX_NAPIS);
            this.Controls.Add(this.AX_NAPIS);
            this.Controls.Add(this.DX_POLE);
            this.Controls.Add(this.CX_POLE);
            this.Controls.Add(this.BX_POLE);
            this.Controls.Add(this.AX_POLE);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox AX_POLE;
        private System.Windows.Forms.TextBox BX_POLE;
        private System.Windows.Forms.TextBox CX_POLE;
        private System.Windows.Forms.TextBox DX_POLE;
        private System.Windows.Forms.TextBox AX_NAPIS;
        private System.Windows.Forms.TextBox BX_NAPIS;
        private System.Windows.Forms.TextBox CX_TEXT;
        private System.Windows.Forms.TextBox DX_NAPIS;
        private System.Windows.Forms.TextBox AL_NAPIS;
        private System.Windows.Forms.TextBox BL_NAPIS;
        private System.Windows.Forms.TextBox CL_NAPIS;
        private System.Windows.Forms.TextBox DL_NAPIS;
        private System.Windows.Forms.TextBox AL_POLE;
        private System.Windows.Forms.TextBox BL_POLE;
        private System.Windows.Forms.TextBox CL_POLE;
        private System.Windows.Forms.TextBox DL_POLE;
        private System.Windows.Forms.TextBox AH_NAPIS;
        private System.Windows.Forms.TextBox AH_POLE;
        private System.Windows.Forms.TextBox DH_POLE;
        private System.Windows.Forms.TextBox CH_NAPIS;
        private System.Windows.Forms.TextBox BH_POLE;
        private System.Windows.Forms.TextBox CH_POLE;
        private System.Windows.Forms.TextBox BH_NAPIS;
        private System.Windows.Forms.TextBox DH_NAPIS;
        private System.Windows.Forms.RadioButton AX_BUTTON;
        private System.Windows.Forms.RadioButton BX_BUTTON2;
        private System.Windows.Forms.RadioButton BX_BUTTON;
        private System.Windows.Forms.RadioButton AX_BUTTON2;
        private System.Windows.Forms.RadioButton CX_BUTTON;
        private System.Windows.Forms.RadioButton CX_BUTTON2;
        private System.Windows.Forms.RadioButton DX_BUTTON;
        private System.Windows.Forms.RadioButton DX_BUTTON2;
        private System.Windows.Forms.Button MOVE_BUTTON;
        private System.Windows.Forms.Button XCHG_BUTTON;
    }
}

