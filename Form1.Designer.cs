namespace CH_9_PP_1___Vending_Machine
{
    partial class vendingMachinePP2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(vendingMachinePP2));
            this.vendingMachinePictureBox = new System.Windows.Forms.PictureBox();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.colaGroupBox = new System.Windows.Forms.GroupBox();
            this.colaOutputLabel = new System.Windows.Forms.Label();
            this.colaPriceLabel1 = new System.Windows.Forms.Label();
            this.colaPictureBox = new System.Windows.Forms.PictureBox();
            this.rootBeerGroupBox = new System.Windows.Forms.GroupBox();
            this.rootBeerOutputLabel = new System.Windows.Forms.Label();
            this.rootBeerPriceLabel1 = new System.Windows.Forms.Label();
            this.rootBeerPictureBox = new System.Windows.Forms.PictureBox();
            this.lemonGroupBox = new System.Windows.Forms.GroupBox();
            this.lemonOutputLabel = new System.Windows.Forms.Label();
            this.lemonPriceLabel1 = new System.Windows.Forms.Label();
            this.lemonPictureBox = new System.Windows.Forms.PictureBox();
            this.grapeGroupBox = new System.Windows.Forms.GroupBox();
            this.grapeOutputLabel = new System.Windows.Forms.Label();
            this.grapePriceLabel1Fifty = new System.Windows.Forms.Label();
            this.grapePictureBox = new System.Windows.Forms.PictureBox();
            this.creamGroupBox = new System.Windows.Forms.GroupBox();
            this.creamOutputLabel = new System.Windows.Forms.Label();
            this.creamPriceLabel1Fifty = new System.Windows.Forms.Label();
            this.creamPictureBox = new System.Windows.Forms.PictureBox();
            this.totslalSalesGroupBox = new System.Windows.Forms.GroupBox();
            this.totalSalesOutputLabel = new System.Windows.Forms.Label();
            this.totalTextLabel = new System.Windows.Forms.Label();
            this.grabDrinksButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.vendingMachinePictureBox)).BeginInit();
            this.colaGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colaPictureBox)).BeginInit();
            this.rootBeerGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rootBeerPictureBox)).BeginInit();
            this.lemonGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lemonPictureBox)).BeginInit();
            this.grapeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grapePictureBox)).BeginInit();
            this.creamGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.creamPictureBox)).BeginInit();
            this.totslalSalesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // vendingMachinePictureBox
            // 
            this.vendingMachinePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.vendingMachinePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("vendingMachinePictureBox.Image")));
            this.vendingMachinePictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("vendingMachinePictureBox.InitialImage")));
            this.vendingMachinePictureBox.Location = new System.Drawing.Point(74, 88);
            this.vendingMachinePictureBox.Name = "vendingMachinePictureBox";
            this.vendingMachinePictureBox.Size = new System.Drawing.Size(523, 751);
            this.vendingMachinePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.vendingMachinePictureBox.TabIndex = 0;
            this.vendingMachinePictureBox.TabStop = false;
            // 
            // instructionLabel
            // 
            this.instructionLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.instructionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionLabel.Location = new System.Drawing.Point(78, 54);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(190, 31);
            this.instructionLabel.TabIndex = 1;
            this.instructionLabel.Text = "Soda Pops";
            this.instructionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // colaGroupBox
            // 
            this.colaGroupBox.Controls.Add(this.colaOutputLabel);
            this.colaGroupBox.Controls.Add(this.colaPriceLabel1);
            this.colaGroupBox.Controls.Add(this.colaPictureBox);
            this.colaGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colaGroupBox.Location = new System.Drawing.Point(90, 122);
            this.colaGroupBox.Name = "colaGroupBox";
            this.colaGroupBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.colaGroupBox.Size = new System.Drawing.Size(208, 113);
            this.colaGroupBox.TabIndex = 2;
            this.colaGroupBox.TabStop = false;
            this.colaGroupBox.Text = "                                                                                 " +
    "                        :Drinks Left";
            // 
            // colaOutputLabel
            // 
            this.colaOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colaOutputLabel.Location = new System.Drawing.Point(114, 71);
            this.colaOutputLabel.Name = "colaOutputLabel";
            this.colaOutputLabel.Size = new System.Drawing.Size(76, 36);
            this.colaOutputLabel.TabIndex = 5;
            this.colaOutputLabel.Text = "20";
            this.colaOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.colaOutputLabel.Click += new System.EventHandler(this.colaOutputLabel_Click);
            // 
            // colaPriceLabel1
            // 
            this.colaPriceLabel1.AutoSize = true;
            this.colaPriceLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colaPriceLabel1.Location = new System.Drawing.Point(132, 20);
            this.colaPriceLabel1.Name = "colaPriceLabel1";
            this.colaPriceLabel1.Size = new System.Drawing.Size(49, 18);
            this.colaPriceLabel1.TabIndex = 4;
            this.colaPriceLabel1.Text = "$1.00";
            // 
            // colaPictureBox
            // 
            this.colaPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colaPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colaPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("colaPictureBox.Image")));
            this.colaPictureBox.Location = new System.Drawing.Point(6, 10);
            this.colaPictureBox.Name = "colaPictureBox";
            this.colaPictureBox.Size = new System.Drawing.Size(102, 97);
            this.colaPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.colaPictureBox.TabIndex = 3;
            this.colaPictureBox.TabStop = false;
            this.colaPictureBox.Click += new System.EventHandler(this.colaPictureBox_Click);
            // 
            // rootBeerGroupBox
            // 
            this.rootBeerGroupBox.Controls.Add(this.rootBeerOutputLabel);
            this.rootBeerGroupBox.Controls.Add(this.rootBeerPriceLabel1);
            this.rootBeerGroupBox.Controls.Add(this.rootBeerPictureBox);
            this.rootBeerGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rootBeerGroupBox.Location = new System.Drawing.Point(367, 122);
            this.rootBeerGroupBox.Name = "rootBeerGroupBox";
            this.rootBeerGroupBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rootBeerGroupBox.Size = new System.Drawing.Size(208, 113);
            this.rootBeerGroupBox.TabIndex = 3;
            this.rootBeerGroupBox.TabStop = false;
            this.rootBeerGroupBox.Text = "                                                                                 " +
    "                        :Drinks Left";
            // 
            // rootBeerOutputLabel
            // 
            this.rootBeerOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rootBeerOutputLabel.Location = new System.Drawing.Point(114, 71);
            this.rootBeerOutputLabel.Name = "rootBeerOutputLabel";
            this.rootBeerOutputLabel.Size = new System.Drawing.Size(76, 36);
            this.rootBeerOutputLabel.TabIndex = 5;
            this.rootBeerOutputLabel.Text = "20";
            this.rootBeerOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rootBeerPriceLabel1
            // 
            this.rootBeerPriceLabel1.AutoSize = true;
            this.rootBeerPriceLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rootBeerPriceLabel1.Location = new System.Drawing.Point(132, 20);
            this.rootBeerPriceLabel1.Name = "rootBeerPriceLabel1";
            this.rootBeerPriceLabel1.Size = new System.Drawing.Size(49, 18);
            this.rootBeerPriceLabel1.TabIndex = 4;
            this.rootBeerPriceLabel1.Text = "$1.00";
            // 
            // rootBeerPictureBox
            // 
            this.rootBeerPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rootBeerPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rootBeerPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("rootBeerPictureBox.Image")));
            this.rootBeerPictureBox.Location = new System.Drawing.Point(6, 10);
            this.rootBeerPictureBox.Name = "rootBeerPictureBox";
            this.rootBeerPictureBox.Size = new System.Drawing.Size(102, 97);
            this.rootBeerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rootBeerPictureBox.TabIndex = 3;
            this.rootBeerPictureBox.TabStop = false;
            this.rootBeerPictureBox.Click += new System.EventHandler(this.rootBeerPictureBox_Click);
            // 
            // lemonGroupBox
            // 
            this.lemonGroupBox.Controls.Add(this.lemonOutputLabel);
            this.lemonGroupBox.Controls.Add(this.lemonPriceLabel1);
            this.lemonGroupBox.Controls.Add(this.lemonPictureBox);
            this.lemonGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lemonGroupBox.Location = new System.Drawing.Point(90, 257);
            this.lemonGroupBox.Name = "lemonGroupBox";
            this.lemonGroupBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lemonGroupBox.Size = new System.Drawing.Size(208, 113);
            this.lemonGroupBox.TabIndex = 4;
            this.lemonGroupBox.TabStop = false;
            this.lemonGroupBox.Text = "                                                                                 " +
    "                        :Drinks Left";
            // 
            // lemonOutputLabel
            // 
            this.lemonOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lemonOutputLabel.Location = new System.Drawing.Point(114, 71);
            this.lemonOutputLabel.Name = "lemonOutputLabel";
            this.lemonOutputLabel.Size = new System.Drawing.Size(76, 36);
            this.lemonOutputLabel.TabIndex = 5;
            this.lemonOutputLabel.Text = "20";
            this.lemonOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lemonPriceLabel1
            // 
            this.lemonPriceLabel1.AutoSize = true;
            this.lemonPriceLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lemonPriceLabel1.Location = new System.Drawing.Point(132, 20);
            this.lemonPriceLabel1.Name = "lemonPriceLabel1";
            this.lemonPriceLabel1.Size = new System.Drawing.Size(49, 18);
            this.lemonPriceLabel1.TabIndex = 4;
            this.lemonPriceLabel1.Text = "$1.00";
            // 
            // lemonPictureBox
            // 
            this.lemonPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lemonPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lemonPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("lemonPictureBox.Image")));
            this.lemonPictureBox.Location = new System.Drawing.Point(6, 10);
            this.lemonPictureBox.Name = "lemonPictureBox";
            this.lemonPictureBox.Size = new System.Drawing.Size(102, 97);
            this.lemonPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lemonPictureBox.TabIndex = 3;
            this.lemonPictureBox.TabStop = false;
            this.lemonPictureBox.Click += new System.EventHandler(this.lemonPictureBox_Click);
            // 
            // grapeGroupBox
            // 
            this.grapeGroupBox.Controls.Add(this.grapeOutputLabel);
            this.grapeGroupBox.Controls.Add(this.grapePriceLabel1Fifty);
            this.grapeGroupBox.Controls.Add(this.grapePictureBox);
            this.grapeGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grapeGroupBox.Location = new System.Drawing.Point(367, 257);
            this.grapeGroupBox.Name = "grapeGroupBox";
            this.grapeGroupBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grapeGroupBox.Size = new System.Drawing.Size(208, 113);
            this.grapeGroupBox.TabIndex = 5;
            this.grapeGroupBox.TabStop = false;
            this.grapeGroupBox.Text = "                                                                                 " +
    "                        :Drinks Left";
            // 
            // grapeOutputLabel
            // 
            this.grapeOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grapeOutputLabel.Location = new System.Drawing.Point(114, 71);
            this.grapeOutputLabel.Name = "grapeOutputLabel";
            this.grapeOutputLabel.Size = new System.Drawing.Size(76, 36);
            this.grapeOutputLabel.TabIndex = 5;
            this.grapeOutputLabel.Text = "20";
            this.grapeOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grapePriceLabel1Fifty
            // 
            this.grapePriceLabel1Fifty.AutoSize = true;
            this.grapePriceLabel1Fifty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grapePriceLabel1Fifty.Location = new System.Drawing.Point(132, 20);
            this.grapePriceLabel1Fifty.Name = "grapePriceLabel1Fifty";
            this.grapePriceLabel1Fifty.Size = new System.Drawing.Size(49, 18);
            this.grapePriceLabel1Fifty.TabIndex = 4;
            this.grapePriceLabel1Fifty.Text = "$1.50";
            // 
            // grapePictureBox
            // 
            this.grapePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grapePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.grapePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("grapePictureBox.Image")));
            this.grapePictureBox.Location = new System.Drawing.Point(6, 10);
            this.grapePictureBox.Name = "grapePictureBox";
            this.grapePictureBox.Size = new System.Drawing.Size(102, 97);
            this.grapePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.grapePictureBox.TabIndex = 3;
            this.grapePictureBox.TabStop = false;
            this.grapePictureBox.Click += new System.EventHandler(this.grapePictureBox_Click);
            // 
            // creamGroupBox
            // 
            this.creamGroupBox.Controls.Add(this.creamOutputLabel);
            this.creamGroupBox.Controls.Add(this.creamPriceLabel1Fifty);
            this.creamGroupBox.Controls.Add(this.creamPictureBox);
            this.creamGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creamGroupBox.Location = new System.Drawing.Point(90, 394);
            this.creamGroupBox.Name = "creamGroupBox";
            this.creamGroupBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.creamGroupBox.Size = new System.Drawing.Size(208, 113);
            this.creamGroupBox.TabIndex = 6;
            this.creamGroupBox.TabStop = false;
            this.creamGroupBox.Text = "                                                                                 " +
    "                        :Drinks Left";
            // 
            // creamOutputLabel
            // 
            this.creamOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.creamOutputLabel.Location = new System.Drawing.Point(114, 71);
            this.creamOutputLabel.Name = "creamOutputLabel";
            this.creamOutputLabel.Size = new System.Drawing.Size(76, 36);
            this.creamOutputLabel.TabIndex = 5;
            this.creamOutputLabel.Text = "20";
            this.creamOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // creamPriceLabel1Fifty
            // 
            this.creamPriceLabel1Fifty.AutoSize = true;
            this.creamPriceLabel1Fifty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creamPriceLabel1Fifty.Location = new System.Drawing.Point(132, 20);
            this.creamPriceLabel1Fifty.Name = "creamPriceLabel1Fifty";
            this.creamPriceLabel1Fifty.Size = new System.Drawing.Size(49, 18);
            this.creamPriceLabel1Fifty.TabIndex = 4;
            this.creamPriceLabel1Fifty.Text = "$1.50";
            // 
            // creamPictureBox
            // 
            this.creamPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.creamPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.creamPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("creamPictureBox.Image")));
            this.creamPictureBox.Location = new System.Drawing.Point(6, 10);
            this.creamPictureBox.Name = "creamPictureBox";
            this.creamPictureBox.Size = new System.Drawing.Size(102, 97);
            this.creamPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.creamPictureBox.TabIndex = 3;
            this.creamPictureBox.TabStop = false;
            this.creamPictureBox.Click += new System.EventHandler(this.creamPictureBox_Click);
            // 
            // totslalSalesGroupBox
            // 
            this.totslalSalesGroupBox.Controls.Add(this.totalSalesOutputLabel);
            this.totslalSalesGroupBox.Controls.Add(this.totalTextLabel);
            this.totslalSalesGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totslalSalesGroupBox.Location = new System.Drawing.Point(415, 532);
            this.totslalSalesGroupBox.Name = "totslalSalesGroupBox";
            this.totslalSalesGroupBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.totslalSalesGroupBox.Size = new System.Drawing.Size(166, 104);
            this.totslalSalesGroupBox.TabIndex = 7;
            this.totslalSalesGroupBox.TabStop = false;
            // 
            // totalSalesOutputLabel
            // 
            this.totalSalesOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalSalesOutputLabel.Location = new System.Drawing.Point(33, 50);
            this.totalSalesOutputLabel.Name = "totalSalesOutputLabel";
            this.totalSalesOutputLabel.Size = new System.Drawing.Size(109, 36);
            this.totalSalesOutputLabel.TabIndex = 5;
            this.totalSalesOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalTextLabel
            // 
            this.totalTextLabel.AutoSize = true;
            this.totalTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTextLabel.Location = new System.Drawing.Point(41, 20);
            this.totalTextLabel.Name = "totalTextLabel";
            this.totalTextLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.totalTextLabel.Size = new System.Drawing.Size(89, 18);
            this.totalTextLabel.TabIndex = 4;
            this.totalTextLabel.Text = "Total Sale:";
            this.totalTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.totalTextLabel.Click += new System.EventHandler(this.totalTextLabel_Click);
            // 
            // grabDrinksButton
            // 
            this.grabDrinksButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.grabDrinksButton.Location = new System.Drawing.Point(222, 690);
            this.grabDrinksButton.Name = "grabDrinksButton";
            this.grabDrinksButton.Size = new System.Drawing.Size(139, 47);
            this.grabDrinksButton.TabIndex = 8;
            this.grabDrinksButton.Text = "Exit";
            this.grabDrinksButton.UseVisualStyleBackColor = true;
            this.grabDrinksButton.Click += new System.EventHandler(this.grabDrinksButton_Click);
            // 
            // vendingMachinePP2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 836);
            this.Controls.Add(this.grabDrinksButton);
            this.Controls.Add(this.totslalSalesGroupBox);
            this.Controls.Add(this.creamGroupBox);
            this.Controls.Add(this.grapeGroupBox);
            this.Controls.Add(this.lemonGroupBox);
            this.Controls.Add(this.rootBeerGroupBox);
            this.Controls.Add(this.colaGroupBox);
            this.Controls.Add(this.instructionLabel);
            this.Controls.Add(this.vendingMachinePictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "vendingMachinePP2";
            this.Text = "Vending Machine Simulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vendingMachinePictureBox)).EndInit();
            this.colaGroupBox.ResumeLayout(false);
            this.colaGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colaPictureBox)).EndInit();
            this.rootBeerGroupBox.ResumeLayout(false);
            this.rootBeerGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rootBeerPictureBox)).EndInit();
            this.lemonGroupBox.ResumeLayout(false);
            this.lemonGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lemonPictureBox)).EndInit();
            this.grapeGroupBox.ResumeLayout(false);
            this.grapeGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grapePictureBox)).EndInit();
            this.creamGroupBox.ResumeLayout(false);
            this.creamGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.creamPictureBox)).EndInit();
            this.totslalSalesGroupBox.ResumeLayout(false);
            this.totslalSalesGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox vendingMachinePictureBox;
        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.GroupBox colaGroupBox;
        private System.Windows.Forms.PictureBox colaPictureBox;
        private System.Windows.Forms.Label colaOutputLabel;
        private System.Windows.Forms.Label colaPriceLabel1;
        private System.Windows.Forms.GroupBox rootBeerGroupBox;
        private System.Windows.Forms.Label rootBeerOutputLabel;
        private System.Windows.Forms.Label rootBeerPriceLabel1;
        private System.Windows.Forms.PictureBox rootBeerPictureBox;
        private System.Windows.Forms.GroupBox lemonGroupBox;
        private System.Windows.Forms.Label lemonOutputLabel;
        private System.Windows.Forms.Label lemonPriceLabel1;
        private System.Windows.Forms.PictureBox lemonPictureBox;
        private System.Windows.Forms.GroupBox grapeGroupBox;
        private System.Windows.Forms.Label grapeOutputLabel;
        private System.Windows.Forms.Label grapePriceLabel1Fifty;
        private System.Windows.Forms.PictureBox grapePictureBox;
        private System.Windows.Forms.GroupBox creamGroupBox;
        private System.Windows.Forms.Label creamOutputLabel;
        private System.Windows.Forms.Label creamPriceLabel1Fifty;
        private System.Windows.Forms.PictureBox creamPictureBox;
        private System.Windows.Forms.GroupBox totslalSalesGroupBox;
        private System.Windows.Forms.Label totalSalesOutputLabel;
        private System.Windows.Forms.Label totalTextLabel;
        private System.Windows.Forms.Button grabDrinksButton;
    }
}

