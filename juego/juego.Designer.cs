namespace Juego
{
    partial class Juego
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Juego));
            this.PBImagenes = new System.Windows.Forms.PictureBox();
            this.FLPPalabra = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.LBOportunidades = new System.Windows.Forms.Label();
            this.LBMensage = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.BTCambiarPalabra = new System.Windows.Forms.Button();
            this.BTTeclaA = new System.Windows.Forms.Button();
            this.BTTeclaL = new System.Windows.Forms.Button();
            this.BTTeclaK = new System.Windows.Forms.Button();
            this.BTTeclaJ = new System.Windows.Forms.Button();
            this.BTTeclaI = new System.Windows.Forms.Button();
            this.BTTeclaH = new System.Windows.Forms.Button();
            this.BTTeclaG = new System.Windows.Forms.Button();
            this.BTTeclaF = new System.Windows.Forms.Button();
            this.BTTeclaE = new System.Windows.Forms.Button();
            this.BTTeclaD = new System.Windows.Forms.Button();
            this.BTTeclaC = new System.Windows.Forms.Button();
            this.BTTeclaB = new System.Windows.Forms.Button();
            this.BTTeclaT = new System.Windows.Forms.Button();
            this.BTTeclaS = new System.Windows.Forms.Button();
            this.Q = new System.Windows.Forms.Button();
            this.BTTeclaR = new System.Windows.Forms.Button();
            this.BTTeclaP = new System.Windows.Forms.Button();
            this.BTTeclaO = new System.Windows.Forms.Button();
            this.BTTeclaÑ = new System.Windows.Forms.Button();
            this.BTTeclaN = new System.Windows.Forms.Button();
            this.BTTeclaM = new System.Windows.Forms.Button();
            this.BTTeclaZ = new System.Windows.Forms.Button();
            this.BTTeclaY = new System.Windows.Forms.Button();
            this.BTTeclaX = new System.Windows.Forms.Button();
            this.BTTeclaW = new System.Windows.Forms.Button();
            this.BTTeclaV = new System.Windows.Forms.Button();
            this.PTeclado = new System.Windows.Forms.Panel();
            this.BTTeclaU = new System.Windows.Forms.Button();
            this.BTMusica = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PBImagenes)).BeginInit();
            this.PTeclado.SuspendLayout();
            this.SuspendLayout();
            // 
            // PBImagenes
            // 
            this.PBImagenes.BackColor = System.Drawing.Color.Transparent;
            this.PBImagenes.Image = global::Juego.Properties.Resources.Ahorcado81;
            this.PBImagenes.Location = new System.Drawing.Point(694, 161);
            this.PBImagenes.Name = "PBImagenes";
            this.PBImagenes.Size = new System.Drawing.Size(217, 296);
            this.PBImagenes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBImagenes.TabIndex = 1;
            this.PBImagenes.TabStop = false;
            this.PBImagenes.Click += new System.EventHandler(this.PBImagenes_Click);
            // 
            // FLPPalabra
            // 
            this.FLPPalabra.BackColor = System.Drawing.Color.Transparent;
            this.FLPPalabra.Location = new System.Drawing.Point(78, 176);
            this.FLPPalabra.Name = "FLPPalabra";
            this.FLPPalabra.Size = new System.Drawing.Size(525, 79);
            this.FLPPalabra.TabIndex = 2;
            this.FLPPalabra.Paint += new System.Windows.Forms.PaintEventHandler(this.FLPPalabra_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Oportunidades :";
            // 
            // LBOportunidades
            // 
            this.LBOportunidades.AutoSize = true;
            this.LBOportunidades.BackColor = System.Drawing.Color.Transparent;
            this.LBOportunidades.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBOportunidades.ForeColor = System.Drawing.Color.DarkCyan;
            this.LBOportunidades.Location = new System.Drawing.Point(164, 21);
            this.LBOportunidades.Name = "LBOportunidades";
            this.LBOportunidades.Size = new System.Drawing.Size(17, 28);
            this.LBOportunidades.TabIndex = 4;
            this.LBOportunidades.Text = "-";
            // 
            // LBMensage
            // 
            this.LBMensage.AutoSize = true;
            this.LBMensage.BackColor = System.Drawing.Color.Transparent;
            this.LBMensage.Font = new System.Drawing.Font("Oswald", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBMensage.ForeColor = System.Drawing.Color.Red;
            this.LBMensage.Location = new System.Drawing.Point(154, 49);
            this.LBMensage.Name = "LBMensage";
            this.LBMensage.Size = new System.Drawing.Size(563, 143);
            this.LBMensage.TabIndex = 5;
            this.LBMensage.Text = "¡Has Perdido!";
            this.LBMensage.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(881, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 28);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BTCambiarPalabra
            // 
            this.BTCambiarPalabra.BackColor = System.Drawing.Color.AliceBlue;
            this.BTCambiarPalabra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTCambiarPalabra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTCambiarPalabra.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTCambiarPalabra.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTCambiarPalabra.ForeColor = System.Drawing.Color.DarkCyan;
            this.BTCambiarPalabra.Location = new System.Drawing.Point(255, 261);
            this.BTCambiarPalabra.Name = "BTCambiarPalabra";
            this.BTCambiarPalabra.Size = new System.Drawing.Size(171, 37);
            this.BTCambiarPalabra.TabIndex = 7;
            this.BTCambiarPalabra.Text = "Cambiar Palabra";
            this.BTCambiarPalabra.UseVisualStyleBackColor = false;
            this.BTCambiarPalabra.Click += new System.EventHandler(this.button2_Click);
            // 
            // BTTeclaA
            // 
            this.BTTeclaA.BackColor = System.Drawing.Color.Black;
            this.BTTeclaA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTTeclaA.ForeColor = System.Drawing.Color.White;
            this.BTTeclaA.Location = new System.Drawing.Point(13, 2);
            this.BTTeclaA.Name = "BTTeclaA";
            this.BTTeclaA.Size = new System.Drawing.Size(53, 42);
            this.BTTeclaA.TabIndex = 8;
            this.BTTeclaA.Text = "A";
            this.BTTeclaA.UseVisualStyleBackColor = false;
            this.BTTeclaA.Click += new System.EventHandler(this.BTTeclaA_Click);
            // 
            // BTTeclaL
            // 
            this.BTTeclaL.BackColor = System.Drawing.Color.Black;
            this.BTTeclaL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTTeclaL.ForeColor = System.Drawing.Color.White;
            this.BTTeclaL.Location = new System.Drawing.Point(13, 50);
            this.BTTeclaL.Name = "BTTeclaL";
            this.BTTeclaL.Size = new System.Drawing.Size(53, 42);
            this.BTTeclaL.TabIndex = 9;
            this.BTTeclaL.Text = " L";
            this.BTTeclaL.UseVisualStyleBackColor = false;
            this.BTTeclaL.Click += new System.EventHandler(this.BTTeclaL_Click);
            // 
            // BTTeclaK
            // 
            this.BTTeclaK.BackColor = System.Drawing.Color.Black;
            this.BTTeclaK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTTeclaK.ForeColor = System.Drawing.Color.White;
            this.BTTeclaK.Location = new System.Drawing.Point(603, 2);
            this.BTTeclaK.Name = "BTTeclaK";
            this.BTTeclaK.Size = new System.Drawing.Size(53, 42);
            this.BTTeclaK.TabIndex = 10;
            this.BTTeclaK.Text = "K";
            this.BTTeclaK.UseVisualStyleBackColor = false;
            this.BTTeclaK.Click += new System.EventHandler(this.BTTeclaK_Click);
            // 
            // BTTeclaJ
            // 
            this.BTTeclaJ.BackColor = System.Drawing.Color.Black;
            this.BTTeclaJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTTeclaJ.ForeColor = System.Drawing.Color.White;
            this.BTTeclaJ.Location = new System.Drawing.Point(544, 2);
            this.BTTeclaJ.Name = "BTTeclaJ";
            this.BTTeclaJ.Size = new System.Drawing.Size(53, 42);
            this.BTTeclaJ.TabIndex = 11;
            this.BTTeclaJ.Text = "J";
            this.BTTeclaJ.UseVisualStyleBackColor = false;
            this.BTTeclaJ.Click += new System.EventHandler(this.BTTeclaJ_Click);
            // 
            // BTTeclaI
            // 
            this.BTTeclaI.BackColor = System.Drawing.Color.Black;
            this.BTTeclaI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTTeclaI.ForeColor = System.Drawing.Color.White;
            this.BTTeclaI.Location = new System.Drawing.Point(485, 2);
            this.BTTeclaI.Name = "BTTeclaI";
            this.BTTeclaI.Size = new System.Drawing.Size(53, 42);
            this.BTTeclaI.TabIndex = 12;
            this.BTTeclaI.Text = "I";
            this.BTTeclaI.UseVisualStyleBackColor = false;
            this.BTTeclaI.Click += new System.EventHandler(this.BTTeclaI_Click);
            // 
            // BTTeclaH
            // 
            this.BTTeclaH.BackColor = System.Drawing.Color.Black;
            this.BTTeclaH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTTeclaH.ForeColor = System.Drawing.Color.White;
            this.BTTeclaH.Location = new System.Drawing.Point(426, 2);
            this.BTTeclaH.Name = "BTTeclaH";
            this.BTTeclaH.Size = new System.Drawing.Size(53, 42);
            this.BTTeclaH.TabIndex = 13;
            this.BTTeclaH.Text = "H";
            this.BTTeclaH.UseVisualStyleBackColor = false;
            this.BTTeclaH.Click += new System.EventHandler(this.BTTeclaH_Click);
            // 
            // BTTeclaG
            // 
            this.BTTeclaG.BackColor = System.Drawing.Color.Black;
            this.BTTeclaG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTTeclaG.ForeColor = System.Drawing.Color.White;
            this.BTTeclaG.Location = new System.Drawing.Point(367, 2);
            this.BTTeclaG.Name = "BTTeclaG";
            this.BTTeclaG.Size = new System.Drawing.Size(53, 42);
            this.BTTeclaG.TabIndex = 14;
            this.BTTeclaG.Text = "G";
            this.BTTeclaG.UseVisualStyleBackColor = false;
            this.BTTeclaG.Click += new System.EventHandler(this.BTTeclaG_Click);
            // 
            // BTTeclaF
            // 
            this.BTTeclaF.BackColor = System.Drawing.Color.Black;
            this.BTTeclaF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTTeclaF.ForeColor = System.Drawing.Color.White;
            this.BTTeclaF.Location = new System.Drawing.Point(308, 2);
            this.BTTeclaF.Name = "BTTeclaF";
            this.BTTeclaF.Size = new System.Drawing.Size(53, 42);
            this.BTTeclaF.TabIndex = 15;
            this.BTTeclaF.Text = "F";
            this.BTTeclaF.UseVisualStyleBackColor = false;
            this.BTTeclaF.Click += new System.EventHandler(this.BTTeclaF_Click);
            // 
            // BTTeclaE
            // 
            this.BTTeclaE.BackColor = System.Drawing.Color.Black;
            this.BTTeclaE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTTeclaE.ForeColor = System.Drawing.Color.White;
            this.BTTeclaE.Location = new System.Drawing.Point(249, 2);
            this.BTTeclaE.Name = "BTTeclaE";
            this.BTTeclaE.Size = new System.Drawing.Size(53, 42);
            this.BTTeclaE.TabIndex = 16;
            this.BTTeclaE.Text = "E";
            this.BTTeclaE.UseVisualStyleBackColor = false;
            this.BTTeclaE.Click += new System.EventHandler(this.BTTeclaE_Click);
            // 
            // BTTeclaD
            // 
            this.BTTeclaD.BackColor = System.Drawing.Color.Black;
            this.BTTeclaD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTTeclaD.ForeColor = System.Drawing.Color.White;
            this.BTTeclaD.Location = new System.Drawing.Point(190, 2);
            this.BTTeclaD.Name = "BTTeclaD";
            this.BTTeclaD.Size = new System.Drawing.Size(53, 42);
            this.BTTeclaD.TabIndex = 17;
            this.BTTeclaD.Text = "D";
            this.BTTeclaD.UseVisualStyleBackColor = false;
            this.BTTeclaD.Click += new System.EventHandler(this.BTTeclaD_Click);
            // 
            // BTTeclaC
            // 
            this.BTTeclaC.BackColor = System.Drawing.Color.Black;
            this.BTTeclaC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTTeclaC.ForeColor = System.Drawing.Color.White;
            this.BTTeclaC.Location = new System.Drawing.Point(131, 2);
            this.BTTeclaC.Name = "BTTeclaC";
            this.BTTeclaC.Size = new System.Drawing.Size(53, 42);
            this.BTTeclaC.TabIndex = 18;
            this.BTTeclaC.Text = "C";
            this.BTTeclaC.UseVisualStyleBackColor = false;
            this.BTTeclaC.Click += new System.EventHandler(this.BTTeclaC_Click);
            // 
            // BTTeclaB
            // 
            this.BTTeclaB.BackColor = System.Drawing.Color.Black;
            this.BTTeclaB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTTeclaB.ForeColor = System.Drawing.Color.White;
            this.BTTeclaB.Location = new System.Drawing.Point(72, 2);
            this.BTTeclaB.Name = "BTTeclaB";
            this.BTTeclaB.Size = new System.Drawing.Size(53, 42);
            this.BTTeclaB.TabIndex = 19;
            this.BTTeclaB.Text = "B";
            this.BTTeclaB.UseVisualStyleBackColor = false;
            this.BTTeclaB.Click += new System.EventHandler(this.BTTeclaB_Click);
            // 
            // BTTeclaT
            // 
            this.BTTeclaT.BackColor = System.Drawing.Color.Black;
            this.BTTeclaT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTTeclaT.ForeColor = System.Drawing.Color.White;
            this.BTTeclaT.Location = new System.Drawing.Point(544, 50);
            this.BTTeclaT.Name = "BTTeclaT";
            this.BTTeclaT.Size = new System.Drawing.Size(53, 42);
            this.BTTeclaT.TabIndex = 21;
            this.BTTeclaT.Text = "T";
            this.BTTeclaT.UseVisualStyleBackColor = false;
            this.BTTeclaT.Click += new System.EventHandler(this.BTTeclaT_Click);
            // 
            // BTTeclaS
            // 
            this.BTTeclaS.BackColor = System.Drawing.Color.Black;
            this.BTTeclaS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTTeclaS.ForeColor = System.Drawing.Color.White;
            this.BTTeclaS.Location = new System.Drawing.Point(485, 50);
            this.BTTeclaS.Name = "BTTeclaS";
            this.BTTeclaS.Size = new System.Drawing.Size(53, 42);
            this.BTTeclaS.TabIndex = 22;
            this.BTTeclaS.Text = "S";
            this.BTTeclaS.UseVisualStyleBackColor = false;
            this.BTTeclaS.Click += new System.EventHandler(this.BTTeclaS_Click);
            // 
            // Q
            // 
            this.Q.BackColor = System.Drawing.Color.Black;
            this.Q.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Q.ForeColor = System.Drawing.Color.White;
            this.Q.Location = new System.Drawing.Point(367, 50);
            this.Q.Name = "Q";
            this.Q.Size = new System.Drawing.Size(53, 42);
            this.Q.TabIndex = 23;
            this.Q.Text = "Q";
            this.Q.UseVisualStyleBackColor = false;
            this.Q.Click += new System.EventHandler(this.Q_Click);
            // 
            // BTTeclaR
            // 
            this.BTTeclaR.BackColor = System.Drawing.Color.Black;
            this.BTTeclaR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTTeclaR.ForeColor = System.Drawing.Color.White;
            this.BTTeclaR.Location = new System.Drawing.Point(426, 50);
            this.BTTeclaR.Name = "BTTeclaR";
            this.BTTeclaR.Size = new System.Drawing.Size(53, 42);
            this.BTTeclaR.TabIndex = 24;
            this.BTTeclaR.Text = "R";
            this.BTTeclaR.UseVisualStyleBackColor = false;
            this.BTTeclaR.Click += new System.EventHandler(this.BTTeclaR_Click);
            // 
            // BTTeclaP
            // 
            this.BTTeclaP.BackColor = System.Drawing.Color.Black;
            this.BTTeclaP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTTeclaP.ForeColor = System.Drawing.Color.White;
            this.BTTeclaP.Location = new System.Drawing.Point(308, 50);
            this.BTTeclaP.Name = "BTTeclaP";
            this.BTTeclaP.Size = new System.Drawing.Size(53, 42);
            this.BTTeclaP.TabIndex = 25;
            this.BTTeclaP.Text = "P";
            this.BTTeclaP.UseVisualStyleBackColor = false;
            this.BTTeclaP.Click += new System.EventHandler(this.BTTeclaP_Click);
            // 
            // BTTeclaO
            // 
            this.BTTeclaO.BackColor = System.Drawing.Color.Black;
            this.BTTeclaO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTTeclaO.ForeColor = System.Drawing.Color.White;
            this.BTTeclaO.Location = new System.Drawing.Point(249, 50);
            this.BTTeclaO.Name = "BTTeclaO";
            this.BTTeclaO.Size = new System.Drawing.Size(53, 42);
            this.BTTeclaO.TabIndex = 26;
            this.BTTeclaO.Text = "O";
            this.BTTeclaO.UseVisualStyleBackColor = false;
            this.BTTeclaO.Click += new System.EventHandler(this.BTTeclaO_Click);
            // 
            // BTTeclaÑ
            // 
            this.BTTeclaÑ.BackColor = System.Drawing.Color.Black;
            this.BTTeclaÑ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTTeclaÑ.ForeColor = System.Drawing.Color.White;
            this.BTTeclaÑ.Location = new System.Drawing.Point(190, 50);
            this.BTTeclaÑ.Name = "BTTeclaÑ";
            this.BTTeclaÑ.Size = new System.Drawing.Size(53, 42);
            this.BTTeclaÑ.TabIndex = 27;
            this.BTTeclaÑ.Text = "Ñ";
            this.BTTeclaÑ.UseVisualStyleBackColor = false;
            this.BTTeclaÑ.Click += new System.EventHandler(this.BTTeclaÑ_Click);
            // 
            // BTTeclaN
            // 
            this.BTTeclaN.BackColor = System.Drawing.Color.Black;
            this.BTTeclaN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTTeclaN.ForeColor = System.Drawing.Color.White;
            this.BTTeclaN.Location = new System.Drawing.Point(131, 50);
            this.BTTeclaN.Name = "BTTeclaN";
            this.BTTeclaN.Size = new System.Drawing.Size(53, 42);
            this.BTTeclaN.TabIndex = 28;
            this.BTTeclaN.Text = "N";
            this.BTTeclaN.UseVisualStyleBackColor = false;
            this.BTTeclaN.Click += new System.EventHandler(this.BTTeclaN_Click);
            // 
            // BTTeclaM
            // 
            this.BTTeclaM.BackColor = System.Drawing.Color.Black;
            this.BTTeclaM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTTeclaM.ForeColor = System.Drawing.Color.White;
            this.BTTeclaM.Location = new System.Drawing.Point(72, 50);
            this.BTTeclaM.Name = "BTTeclaM";
            this.BTTeclaM.Size = new System.Drawing.Size(53, 42);
            this.BTTeclaM.TabIndex = 29;
            this.BTTeclaM.Text = "M";
            this.BTTeclaM.UseVisualStyleBackColor = false;
            this.BTTeclaM.Click += new System.EventHandler(this.BTTeclaM_Click);
            // 
            // BTTeclaZ
            // 
            this.BTTeclaZ.BackColor = System.Drawing.Color.Black;
            this.BTTeclaZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTTeclaZ.ForeColor = System.Drawing.Color.White;
            this.BTTeclaZ.Location = new System.Drawing.Point(426, 98);
            this.BTTeclaZ.Name = "BTTeclaZ";
            this.BTTeclaZ.Size = new System.Drawing.Size(53, 42);
            this.BTTeclaZ.TabIndex = 31;
            this.BTTeclaZ.Text = "Z";
            this.BTTeclaZ.UseVisualStyleBackColor = false;
            this.BTTeclaZ.Click += new System.EventHandler(this.BTTeclaZ_Click);
            // 
            // BTTeclaY
            // 
            this.BTTeclaY.BackColor = System.Drawing.Color.Black;
            this.BTTeclaY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTTeclaY.ForeColor = System.Drawing.Color.White;
            this.BTTeclaY.Location = new System.Drawing.Point(367, 98);
            this.BTTeclaY.Name = "BTTeclaY";
            this.BTTeclaY.Size = new System.Drawing.Size(53, 42);
            this.BTTeclaY.TabIndex = 32;
            this.BTTeclaY.Text = "Y";
            this.BTTeclaY.UseVisualStyleBackColor = false;
            this.BTTeclaY.Click += new System.EventHandler(this.BTTeclaY_Click);
            // 
            // BTTeclaX
            // 
            this.BTTeclaX.BackColor = System.Drawing.Color.Black;
            this.BTTeclaX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTTeclaX.ForeColor = System.Drawing.Color.White;
            this.BTTeclaX.Location = new System.Drawing.Point(308, 98);
            this.BTTeclaX.Name = "BTTeclaX";
            this.BTTeclaX.Size = new System.Drawing.Size(53, 42);
            this.BTTeclaX.TabIndex = 33;
            this.BTTeclaX.Text = "X";
            this.BTTeclaX.UseVisualStyleBackColor = false;
            this.BTTeclaX.Click += new System.EventHandler(this.BTTeclaX_Click);
            // 
            // BTTeclaW
            // 
            this.BTTeclaW.BackColor = System.Drawing.Color.Black;
            this.BTTeclaW.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTTeclaW.ForeColor = System.Drawing.Color.White;
            this.BTTeclaW.Location = new System.Drawing.Point(249, 98);
            this.BTTeclaW.Name = "BTTeclaW";
            this.BTTeclaW.Size = new System.Drawing.Size(53, 42);
            this.BTTeclaW.TabIndex = 34;
            this.BTTeclaW.Text = "W";
            this.BTTeclaW.UseVisualStyleBackColor = false;
            this.BTTeclaW.Click += new System.EventHandler(this.BTTeclaW_Click);
            // 
            // BTTeclaV
            // 
            this.BTTeclaV.BackColor = System.Drawing.Color.Black;
            this.BTTeclaV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTTeclaV.ForeColor = System.Drawing.Color.White;
            this.BTTeclaV.Location = new System.Drawing.Point(190, 98);
            this.BTTeclaV.Name = "BTTeclaV";
            this.BTTeclaV.Size = new System.Drawing.Size(53, 42);
            this.BTTeclaV.TabIndex = 35;
            this.BTTeclaV.Text = "V";
            this.BTTeclaV.UseVisualStyleBackColor = false;
            this.BTTeclaV.Click += new System.EventHandler(this.BTTeclaV_Click);
            // 
            // PTeclado
            // 
            this.PTeclado.BackColor = System.Drawing.Color.Transparent;
            this.PTeclado.Controls.Add(this.BTTeclaU);
            this.PTeclado.Controls.Add(this.BTTeclaV);
            this.PTeclado.Controls.Add(this.BTTeclaW);
            this.PTeclado.Controls.Add(this.BTTeclaX);
            this.PTeclado.Controls.Add(this.BTTeclaY);
            this.PTeclado.Controls.Add(this.BTTeclaZ);
            this.PTeclado.Controls.Add(this.BTTeclaM);
            this.PTeclado.Controls.Add(this.BTTeclaN);
            this.PTeclado.Controls.Add(this.BTTeclaÑ);
            this.PTeclado.Controls.Add(this.BTTeclaO);
            this.PTeclado.Controls.Add(this.BTTeclaP);
            this.PTeclado.Controls.Add(this.BTTeclaR);
            this.PTeclado.Controls.Add(this.Q);
            this.PTeclado.Controls.Add(this.BTTeclaS);
            this.PTeclado.Controls.Add(this.BTTeclaT);
            this.PTeclado.Controls.Add(this.BTTeclaB);
            this.PTeclado.Controls.Add(this.BTTeclaC);
            this.PTeclado.Controls.Add(this.BTTeclaD);
            this.PTeclado.Controls.Add(this.BTTeclaE);
            this.PTeclado.Controls.Add(this.BTTeclaF);
            this.PTeclado.Controls.Add(this.BTTeclaG);
            this.PTeclado.Controls.Add(this.BTTeclaH);
            this.PTeclado.Controls.Add(this.BTTeclaI);
            this.PTeclado.Controls.Add(this.BTTeclaJ);
            this.PTeclado.Controls.Add(this.BTTeclaK);
            this.PTeclado.Controls.Add(this.BTTeclaL);
            this.PTeclado.Controls.Add(this.BTTeclaA);
            this.PTeclado.Location = new System.Drawing.Point(6, 302);
            this.PTeclado.Name = "PTeclado";
            this.PTeclado.Size = new System.Drawing.Size(670, 154);
            this.PTeclado.TabIndex = 36;
            // 
            // BTTeclaU
            // 
            this.BTTeclaU.BackColor = System.Drawing.Color.Black;
            this.BTTeclaU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTTeclaU.ForeColor = System.Drawing.Color.White;
            this.BTTeclaU.Location = new System.Drawing.Point(603, 50);
            this.BTTeclaU.Name = "BTTeclaU";
            this.BTTeclaU.Size = new System.Drawing.Size(53, 42);
            this.BTTeclaU.TabIndex = 36;
            this.BTTeclaU.Text = "U";
            this.BTTeclaU.UseVisualStyleBackColor = false;
            this.BTTeclaU.Click += new System.EventHandler(this.BTTeclaU_Click);
            // 
            // BTMusica
            // 
            this.BTMusica.BackColor = System.Drawing.Color.Transparent;
            this.BTMusica.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTMusica.BackgroundImage")));
            this.BTMusica.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTMusica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTMusica.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BTMusica.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BTMusica.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTMusica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTMusica.Location = new System.Drawing.Point(845, 2);
            this.BTMusica.Name = "BTMusica";
            this.BTMusica.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BTMusica.Size = new System.Drawing.Size(30, 28);
            this.BTMusica.TabIndex = 38;
            this.BTMusica.UseVisualStyleBackColor = false;
            this.BTMusica.Click += new System.EventHandler(this.button5_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Oswald", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.DarkCyan;
            this.button2.Location = new System.Drawing.Point(777, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(62, 28);
            this.button2.TabIndex = 39;
            this.button2.Text = "Volver";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Juego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(914, 469);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BTMusica);
            this.Controls.Add(this.PTeclado);
            this.Controls.Add(this.BTCambiarPalabra);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LBOportunidades);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FLPPalabra);
            this.Controls.Add(this.PBImagenes);
            this.Controls.Add(this.LBMensage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Juego";
            this.Text = "juego";
            this.Load += new System.EventHandler(this.Juego_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBImagenes)).EndInit();
            this.PTeclado.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.PictureBox PBImagenes;
        public System.Windows.Forms.FlowLayoutPanel FLPPalabra;
        public System.Windows.Forms.Label LBOportunidades;
        public System.Windows.Forms.Label LBMensage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BTTeclaA;
        private System.Windows.Forms.Button BTTeclaL;
        private System.Windows.Forms.Button BTTeclaK;
        private System.Windows.Forms.Button BTTeclaJ;
        private System.Windows.Forms.Button BTTeclaI;
        private System.Windows.Forms.Button BTTeclaH;
        private System.Windows.Forms.Button BTTeclaG;
        private System.Windows.Forms.Button BTTeclaF;
        private System.Windows.Forms.Button BTTeclaE;
        private System.Windows.Forms.Button BTTeclaD;
        private System.Windows.Forms.Button BTTeclaC;
        private System.Windows.Forms.Button BTTeclaB;
        private System.Windows.Forms.Button BTTeclaT;
        private System.Windows.Forms.Button BTTeclaS;
        private System.Windows.Forms.Button Q;
        private System.Windows.Forms.Button BTTeclaR;
        private System.Windows.Forms.Button BTTeclaP;
        private System.Windows.Forms.Button BTTeclaO;
        private System.Windows.Forms.Button BTTeclaÑ;
        private System.Windows.Forms.Button BTTeclaN;
        private System.Windows.Forms.Button BTTeclaM;
        private System.Windows.Forms.Button BTTeclaZ;
        private System.Windows.Forms.Button BTTeclaY;
        private System.Windows.Forms.Button BTTeclaX;
        private System.Windows.Forms.Button BTTeclaW;
        private System.Windows.Forms.Button BTTeclaV;
        public System.Windows.Forms.Button BTCambiarPalabra;
        private System.Windows.Forms.Panel PTeclado;
        private System.Windows.Forms.Button BTTeclaU;
        private System.Windows.Forms.Button BTMusica;
        public System.Windows.Forms.Button button2;
    }
}