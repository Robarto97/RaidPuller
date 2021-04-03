namespace RaidPuller
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.OpenAncient = new System.Windows.Forms.Button();
            this.RareBox = new System.Windows.Forms.ListBox();
            this.EpicBox = new System.Windows.Forms.ListBox();
            this.LegoBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.OpenSacred = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.OpenVoid = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.VoidRareBox = new System.Windows.Forms.ListBox();
            this.VoidEpicBox = new System.Windows.Forms.ListBox();
            this.VoidLegoBox = new System.Windows.Forms.ListBox();
            this.imageListColorRare = new System.Windows.Forms.ImageList(this.components);
            this.imageListColorEpic = new System.Windows.Forms.ImageList(this.components);
            this.imageListColorLego = new System.Windows.Forms.ImageList(this.components);
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.Result = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ancient";
            // 
            // OpenAncient
            // 
            this.OpenAncient.Location = new System.Drawing.Point(94, 30);
            this.OpenAncient.Name = "OpenAncient";
            this.OpenAncient.Size = new System.Drawing.Size(75, 23);
            this.OpenAncient.TabIndex = 6;
            this.OpenAncient.Text = "OpenA";
            this.OpenAncient.UseVisualStyleBackColor = true;
            this.OpenAncient.Click += new System.EventHandler(this.OpenAncient_Click);
            // 
            // RareBox
            // 
            this.RareBox.FormattingEnabled = true;
            this.RareBox.Items.AddRange(new object[] {
            "Bombardier",
            "Cataphract",
            "Conquerer",
            "Courtier",
            "Crossbowman",
            "Grandmaster",
            "Halberdier",
            "Myrmidon",
            "Preserver",
            "Quaestor",
            "Valerie"});
            this.RareBox.Location = new System.Drawing.Point(1028, 12);
            this.RareBox.Name = "RareBox";
            this.RareBox.Size = new System.Drawing.Size(120, 30);
            this.RareBox.TabIndex = 13;
            this.RareBox.Visible = false;
            // 
            // EpicBox
            // 
            this.EpicBox.FormattingEnabled = true;
            this.EpicBox.Items.AddRange(new object[] {
            "Alaric the Hooded",
            "Archmage Hellmut",
            "Chancellor Yasmin",
            "Gerhard the Stone",
            "Hordin",
            "Knight-Errant",
            "Lordly Legionary",
            "Masker Fearmonger",
            "Oathbound",
            "Seneschal",
            "Stag Knight"});
            this.EpicBox.Location = new System.Drawing.Point(1028, 48);
            this.EpicBox.Name = "EpicBox";
            this.EpicBox.Size = new System.Drawing.Size(120, 30);
            this.EpicBox.TabIndex = 14;
            this.EpicBox.Visible = false;
            // 
            // LegoBox
            // 
            this.LegoBox.FormattingEnabled = true;
            this.LegoBox.Items.AddRange(new object[] {
            "Black Knight",
            "Cillian the Lucky",
            "Lord Champfort",
            "Lugan the Steadfast",
            "Minaya",
            "Richtoff the Bold",
            "Septimus",
            "Sethallia"});
            this.LegoBox.Location = new System.Drawing.Point(1028, 85);
            this.LegoBox.Name = "LegoBox";
            this.LegoBox.Size = new System.Drawing.Size(120, 30);
            this.LegoBox.TabIndex = 15;
            this.LegoBox.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Sacred";
            // 
            // OpenSacred
            // 
            this.OpenSacred.Location = new System.Drawing.Point(94, 134);
            this.OpenSacred.Name = "OpenSacred";
            this.OpenSacred.Size = new System.Drawing.Size(75, 23);
            this.OpenSacred.TabIndex = 17;
            this.OpenSacred.Text = "OpenS";
            this.OpenSacred.UseVisualStyleBackColor = true;
            this.OpenSacred.Click += new System.EventHandler(this.OpenSacred_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(94, 186);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 23);
            this.Clear.TabIndex = 20;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // OpenVoid
            // 
            this.OpenVoid.Location = new System.Drawing.Point(94, 80);
            this.OpenVoid.Name = "OpenVoid";
            this.OpenVoid.Size = new System.Drawing.Size(75, 23);
            this.OpenVoid.TabIndex = 21;
            this.OpenVoid.Text = "OpenV";
            this.OpenVoid.UseVisualStyleBackColor = true;
            this.OpenVoid.Click += new System.EventHandler(this.OpenVoid_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Void";
            // 
            // VoidRareBox
            // 
            this.VoidRareBox.FormattingEnabled = true;
            this.VoidRareBox.Items.AddRange(new object[] {
            "Coldheart",
            "Bellower",
            "Fellhound",
            "Dilgol",
            "Pain Keeper"});
            this.VoidRareBox.Location = new System.Drawing.Point(1028, 123);
            this.VoidRareBox.Name = "VoidRareBox";
            this.VoidRareBox.Size = new System.Drawing.Size(120, 30);
            this.VoidRareBox.TabIndex = 24;
            this.VoidRareBox.Visible = false;
            // 
            // VoidEpicBox
            // 
            this.VoidEpicBox.FormattingEnabled = true;
            this.VoidEpicBox.Items.AddRange(new object[] {
            "Madame Serris",
            "Peydma",
            "Umbrall",
            "Psylar",
            "Golden Reaper"});
            this.VoidEpicBox.Location = new System.Drawing.Point(1028, 159);
            this.VoidEpicBox.Name = "VoidEpicBox";
            this.VoidEpicBox.Size = new System.Drawing.Size(120, 30);
            this.VoidEpicBox.TabIndex = 25;
            this.VoidEpicBox.Visible = false;
            // 
            // VoidLegoBox
            // 
            this.VoidLegoBox.FormattingEnabled = true;
            this.VoidLegoBox.Items.AddRange(new object[] {
            "Arbiter",
            "Krisk",
            "Raglin",
            "Turvold",
            "Venus"});
            this.VoidLegoBox.Location = new System.Drawing.Point(1028, 195);
            this.VoidLegoBox.Name = "VoidLegoBox";
            this.VoidLegoBox.Size = new System.Drawing.Size(120, 30);
            this.VoidLegoBox.TabIndex = 26;
            this.VoidLegoBox.Visible = false;
            // 
            // imageListColorRare
            // 
            this.imageListColorRare.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListColorRare.ImageStream")));
            this.imageListColorRare.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListColorRare.Images.SetKeyName(0, "Bombardier.jpg");
            this.imageListColorRare.Images.SetKeyName(1, "Cataphract.jpg");
            this.imageListColorRare.Images.SetKeyName(2, "Conquerer.jpg");
            this.imageListColorRare.Images.SetKeyName(3, "Courtier.jpg");
            this.imageListColorRare.Images.SetKeyName(4, "Crossbowman.jpg");
            this.imageListColorRare.Images.SetKeyName(5, "Grandmaster.jpg");
            this.imageListColorRare.Images.SetKeyName(6, "Halberdier.jpg");
            this.imageListColorRare.Images.SetKeyName(7, "Myrmidon.jpg");
            this.imageListColorRare.Images.SetKeyName(8, "Preserver.jpg");
            this.imageListColorRare.Images.SetKeyName(9, "Quaestor.jpg");
            this.imageListColorRare.Images.SetKeyName(10, "Valerie.jpg");
            // 
            // imageListColorEpic
            // 
            this.imageListColorEpic.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListColorEpic.ImageStream")));
            this.imageListColorEpic.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListColorEpic.Images.SetKeyName(0, "Alaric the Hooded.jpg");
            this.imageListColorEpic.Images.SetKeyName(1, "Archmage Hellmut.jpg");
            this.imageListColorEpic.Images.SetKeyName(2, "Chancellor Yasmin.jpg");
            this.imageListColorEpic.Images.SetKeyName(3, "Gerhard the Stone.jpg");
            this.imageListColorEpic.Images.SetKeyName(4, "Hordin.jpg");
            this.imageListColorEpic.Images.SetKeyName(5, "Knight-Errant.jpg");
            this.imageListColorEpic.Images.SetKeyName(6, "Lordly Legionary.jpg");
            this.imageListColorEpic.Images.SetKeyName(7, "Masked Fearmonger.jpg");
            this.imageListColorEpic.Images.SetKeyName(8, "Oathbound.jpg");
            this.imageListColorEpic.Images.SetKeyName(9, "Seneschal.jpg");
            this.imageListColorEpic.Images.SetKeyName(10, "Stag Knight.jpg");
            // 
            // imageListColorLego
            // 
            this.imageListColorLego.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListColorLego.ImageStream")));
            this.imageListColorLego.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListColorLego.Images.SetKeyName(0, "Black Knight.jpg");
            this.imageListColorLego.Images.SetKeyName(1, "Cillian the Lucky.jpg");
            this.imageListColorLego.Images.SetKeyName(2, "Lord Champfort.jpg");
            this.imageListColorLego.Images.SetKeyName(3, "Lugan the Steadfast.jpg");
            this.imageListColorLego.Images.SetKeyName(4, "Minaya.jpg");
            this.imageListColorLego.Images.SetKeyName(5, "Richtoff the Bold.jpg");
            this.imageListColorLego.Images.SetKeyName(6, "Septimus.jpg");
            this.imageListColorLego.Images.SetKeyName(7, "Sethallia.jpg");
            // 
            // PictureBox
            // 
            this.PictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBox.Location = new System.Drawing.Point(0, 0);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(984, 523);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox.TabIndex = 28;
            this.PictureBox.TabStop = false;
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Location = new System.Drawing.Point(579, 80);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(28, 13);
            this.Result.TabIndex = 27;
            this.Result.Text = "Test";
            this.Result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 523);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.VoidLegoBox);
            this.Controls.Add(this.VoidEpicBox);
            this.Controls.Add(this.VoidRareBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OpenVoid);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.OpenSacred);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LegoBox);
            this.Controls.Add(this.EpicBox);
            this.Controls.Add(this.RareBox);
            this.Controls.Add(this.OpenAncient);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OpenAncient;
        private System.Windows.Forms.ListBox RareBox;
        private System.Windows.Forms.ListBox EpicBox;
        private System.Windows.Forms.ListBox LegoBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button OpenSacred;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button OpenVoid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox VoidRareBox;
        private System.Windows.Forms.ListBox VoidEpicBox;
        private System.Windows.Forms.ListBox VoidLegoBox;
        private System.Windows.Forms.ImageList imageListColorEpic;
        private System.Windows.Forms.ImageList imageListColorLego;
        public System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.ImageList imageListColorRare;
        private System.Windows.Forms.Label Result;
    }
}

