
namespace Währungsrechner
{
    partial class Main
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtbxinput = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TSinput = new System.Windows.Forms.ToolStripMenuItem();
            this.TSSIeuro = new System.Windows.Forms.ToolStripMenuItem();
            this.TSSIusdollar = new System.Windows.Forms.ToolStripMenuItem();
            this.TSSIpound = new System.Windows.Forms.ToolStripMenuItem();
            this.TTSIyen = new System.Windows.Forms.ToolStripMenuItem();
            this.TSoutput = new System.Windows.Forms.ToolStripMenuItem();
            this.TTSOeuro = new System.Windows.Forms.ToolStripMenuItem();
            this.TTSOdollar = new System.Windows.Forms.ToolStripMenuItem();
            this.TTSOpound = new System.Windows.Forms.ToolStripMenuItem();
            this.TTSOyen = new System.Windows.Forms.ToolStripMenuItem();
            this.lblinputw = new System.Windows.Forms.Label();
            this.lblinput = new System.Windows.Forms.Label();
            this.lbloutput = new System.Windows.Forms.Label();
            this.lbloutputw = new System.Windows.Forms.Label();
            this.txtbxoutbut = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtbxinput
            // 
            this.txtbxinput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtbxinput.Location = new System.Drawing.Point(120, 79);
            this.txtbxinput.Name = "txtbxinput";
            this.txtbxinput.Size = new System.Drawing.Size(100, 27);
            this.txtbxinput.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSinput,
            this.TSoutput});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(536, 33);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TSinput
            // 
            this.TSinput.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSSIeuro,
            this.TSSIusdollar,
            this.TSSIpound,
            this.TTSIyen});
            this.TSinput.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.TSinput.Name = "TSinput";
            this.TSinput.Size = new System.Drawing.Size(92, 29);
            this.TSinput.Text = "Eingabe";
            // 
            // TSSIeuro
            // 
            this.TSSIeuro.Name = "TSSIeuro";
            this.TSSIeuro.Size = new System.Drawing.Size(180, 30);
            this.TSSIeuro.Text = "Euro";
            this.TSSIeuro.Click += new System.EventHandler(this.TSSIeuro_Click);
            // 
            // TSSIusdollar
            // 
            this.TSSIusdollar.Name = "TSSIusdollar";
            this.TSSIusdollar.Size = new System.Drawing.Size(180, 30);
            this.TSSIusdollar.Text = "US-Dollar";
            this.TSSIusdollar.Click += new System.EventHandler(this.TSSIusdollar_Click);
            // 
            // TSSIpound
            // 
            this.TSSIpound.Name = "TSSIpound";
            this.TSSIpound.Size = new System.Drawing.Size(180, 30);
            this.TSSIpound.Text = "Pound";
            this.TSSIpound.Click += new System.EventHandler(this.TSSIpound_Click);
            // 
            // TTSIyen
            // 
            this.TTSIyen.Name = "TTSIyen";
            this.TTSIyen.Size = new System.Drawing.Size(180, 30);
            this.TTSIyen.Text = "Yen";
            this.TTSIyen.Click += new System.EventHandler(this.TTSIyen_Click);
            // 
            // TSoutput
            // 
            this.TSoutput.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TTSOeuro,
            this.TTSOdollar,
            this.TTSOpound,
            this.TTSOyen});
            this.TSoutput.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.TSoutput.Name = "TSoutput";
            this.TSoutput.Size = new System.Drawing.Size(97, 29);
            this.TSoutput.Text = "Ausgabe";
            // 
            // TTSOeuro
            // 
            this.TTSOeuro.Name = "TTSOeuro";
            this.TTSOeuro.Size = new System.Drawing.Size(180, 30);
            this.TTSOeuro.Text = "Euro";
            this.TTSOeuro.Click += new System.EventHandler(this.TTSOeuro_Click);
            // 
            // TTSOdollar
            // 
            this.TTSOdollar.Name = "TTSOdollar";
            this.TTSOdollar.Size = new System.Drawing.Size(180, 30);
            this.TTSOdollar.Text = "US-Dollar";
            this.TTSOdollar.Click += new System.EventHandler(this.TTSOdollar_Click);
            // 
            // TTSOpound
            // 
            this.TTSOpound.Name = "TTSOpound";
            this.TTSOpound.Size = new System.Drawing.Size(180, 30);
            this.TTSOpound.Text = "Pound";
            this.TTSOpound.Click += new System.EventHandler(this.TTSOpound_Click);
            // 
            // TTSOyen
            // 
            this.TTSOyen.Name = "TTSOyen";
            this.TTSOyen.Size = new System.Drawing.Size(180, 30);
            this.TTSOyen.Text = "Yen";
            this.TTSOyen.Click += new System.EventHandler(this.TTSOyen_Click);
            // 
            // lblinputw
            // 
            this.lblinputw.AutoSize = true;
            this.lblinputw.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblinputw.Location = new System.Drawing.Point(226, 82);
            this.lblinputw.Name = "lblinputw";
            this.lblinputw.Size = new System.Drawing.Size(25, 22);
            this.lblinputw.TabIndex = 3;
            this.lblinputw.Text = "   ";
            // 
            // lblinput
            // 
            this.lblinput.AutoSize = true;
            this.lblinput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblinput.Location = new System.Drawing.Point(33, 82);
            this.lblinput.Name = "lblinput";
            this.lblinput.Size = new System.Drawing.Size(81, 22);
            this.lblinput.TabIndex = 4;
            this.lblinput.Text = "Eingabe:";
            // 
            // lbloutput
            // 
            this.lbloutput.AutoSize = true;
            this.lbloutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lbloutput.Location = new System.Drawing.Point(276, 82);
            this.lbloutput.Name = "lbloutput";
            this.lbloutput.Size = new System.Drawing.Size(96, 22);
            this.lbloutput.TabIndex = 7;
            this.lbloutput.Text = "Ausgabe:  ";
            // 
            // lbloutputw
            // 
            this.lbloutputw.AutoSize = true;
            this.lbloutputw.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lbloutputw.Location = new System.Drawing.Point(484, 82);
            this.lbloutputw.Name = "lbloutputw";
            this.lbloutputw.Size = new System.Drawing.Size(25, 22);
            this.lbloutputw.TabIndex = 6;
            this.lbloutputw.Text = "   ";
            // 
            // txtbxoutbut
            // 
            this.txtbxoutbut.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtbxoutbut.Location = new System.Drawing.Point(378, 79);
            this.txtbxoutbut.Name = "txtbxoutbut";
            this.txtbxoutbut.Size = new System.Drawing.Size(100, 27);
            this.txtbxoutbut.TabIndex = 5;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 316);
            this.Controls.Add(this.lbloutput);
            this.Controls.Add(this.lbloutputw);
            this.Controls.Add(this.txtbxoutbut);
            this.Controls.Add(this.lblinput);
            this.Controls.Add(this.lblinputw);
            this.Controls.Add(this.txtbxinput);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Währungsrechner";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbxinput;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TSinput;
        private System.Windows.Forms.ToolStripMenuItem TSSIeuro;
        private System.Windows.Forms.ToolStripMenuItem TSSIusdollar;
        private System.Windows.Forms.ToolStripMenuItem TSSIpound;
        private System.Windows.Forms.ToolStripMenuItem TTSIyen;
        private System.Windows.Forms.ToolStripMenuItem TSoutput;
        private System.Windows.Forms.ToolStripMenuItem TTSOeuro;
        private System.Windows.Forms.ToolStripMenuItem TTSOdollar;
        private System.Windows.Forms.ToolStripMenuItem TTSOpound;
        private System.Windows.Forms.ToolStripMenuItem TTSOyen;
        private System.Windows.Forms.Label lblinputw;
        private System.Windows.Forms.Label lblinput;
        private System.Windows.Forms.Label lbloutput;
        private System.Windows.Forms.Label lbloutputw;
        private System.Windows.Forms.TextBox txtbxoutbut;
    }
}

