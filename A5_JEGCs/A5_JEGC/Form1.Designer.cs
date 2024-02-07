namespace A5_JEGC
{
    partial class F1SushiOrder
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
            this.LblClientName = new System.Windows.Forms.Label();
            this.GbClientData = new System.Windows.Forms.GroupBox();
            this.TxtBClientName = new System.Windows.Forms.TextBox();
            this.LblHowManyPpl = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.LblPlace = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.GbOrderData = new System.Windows.Forms.GroupBox();
            this.LblSushiType = new System.Windows.Forms.Label();
            this.GbMenu = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.LblCombo1 = new System.Windows.Forms.Label();
            this.GbCombo1 = new System.Windows.Forms.GroupBox();
            this.LblFirstCombo = new System.Windows.Forms.Label();
            this.GbCombo2 = new System.Windows.Forms.GroupBox();
            this.LblCombo2 = new System.Windows.Forms.Label();
            this.GbCombo3 = new System.Windows.Forms.GroupBox();
            this.LblCombo3 = new System.Windows.Forms.Label();
            this.GbCombo4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Lbl2Combo4 = new System.Windows.Forms.Label();
            this.GbFoodType = new System.Windows.Forms.GroupBox();
            this.LblFoodType = new System.Windows.Forms.Label();
            this.LblComboOrder = new System.Windows.Forms.Label();
            this.LblStewType = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.GbClientData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.GbOrderData.SuspendLayout();
            this.GbMenu.SuspendLayout();
            this.GbCombo1.SuspendLayout();
            this.GbCombo2.SuspendLayout();
            this.GbCombo3.SuspendLayout();
            this.GbCombo4.SuspendLayout();
            this.GbFoodType.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblClientName
            // 
            this.LblClientName.AutoSize = true;
            this.LblClientName.ForeColor = System.Drawing.Color.Red;
            this.LblClientName.Location = new System.Drawing.Point(6, 19);
            this.LblClientName.Name = "LblClientName";
            this.LblClientName.Size = new System.Drawing.Size(47, 13);
            this.LblClientName.TabIndex = 0;
            this.LblClientName.Text = "Nombre:";
            // 
            // GbClientData
            // 
            this.GbClientData.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GbClientData.Controls.Add(this.comboBox1);
            this.GbClientData.Controls.Add(this.LblPlace);
            this.GbClientData.Controls.Add(this.numericUpDown1);
            this.GbClientData.Controls.Add(this.LblHowManyPpl);
            this.GbClientData.Controls.Add(this.TxtBClientName);
            this.GbClientData.Controls.Add(this.LblClientName);
            this.GbClientData.ForeColor = System.Drawing.Color.Red;
            this.GbClientData.Location = new System.Drawing.Point(12, 12);
            this.GbClientData.Name = "GbClientData";
            this.GbClientData.Size = new System.Drawing.Size(392, 106);
            this.GbClientData.TabIndex = 1;
            this.GbClientData.TabStop = false;
            this.GbClientData.Text = "Datos del cliente";
            // 
            // TxtBClientName
            // 
            this.TxtBClientName.Location = new System.Drawing.Point(59, 16);
            this.TxtBClientName.MaxLength = 20;
            this.TxtBClientName.Name = "TxtBClientName";
            this.TxtBClientName.Size = new System.Drawing.Size(100, 20);
            this.TxtBClientName.TabIndex = 3;
            this.TxtBClientName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LblHowManyPpl
            // 
            this.LblHowManyPpl.AutoSize = true;
            this.LblHowManyPpl.ForeColor = System.Drawing.Color.Red;
            this.LblHowManyPpl.Location = new System.Drawing.Point(6, 45);
            this.LblHowManyPpl.Name = "LblHowManyPpl";
            this.LblHowManyPpl.Size = new System.Drawing.Size(108, 13);
            this.LblHowManyPpl.TabIndex = 4;
            this.LblHowManyPpl.Text = "Numero de personas:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(120, 42);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(43, 20);
            this.numericUpDown1.TabIndex = 5;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // LblPlace
            // 
            this.LblPlace.AutoSize = true;
            this.LblPlace.ForeColor = System.Drawing.Color.Red;
            this.LblPlace.Location = new System.Drawing.Point(6, 74);
            this.LblPlace.Name = "LblPlace";
            this.LblPlace.Size = new System.Drawing.Size(131, 13);
            this.LblPlace.TabIndex = 6;
            this.LblPlace.Text = "Lugar en el que nos visita:";
            this.LblPlace.Click += new System.EventHandler(this.LblPlace_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Sucursal Cuautlancingo (Puebla)",
            "Sucursal Tehuacán (Puebla)",
            "Sucursal Altamira (Tamaulipas)",
            "Sucursal Victoria (Tamaulipas)",
            "Sucursal Xalapa (Veracruz)",
            "Sucursal Guasave (Sinaloa)",
            "Sucursal Los Mochis (Sinaloa)"});
            this.comboBox1.Location = new System.Drawing.Point(140, 71);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // GbOrderData
            // 
            this.GbOrderData.BackColor = System.Drawing.Color.Black;
            this.GbOrderData.Controls.Add(this.comboBox3);
            this.GbOrderData.Controls.Add(this.LblStewType);
            this.GbOrderData.Controls.Add(this.LblComboOrder);
            this.GbOrderData.Controls.Add(this.comboBox2);
            this.GbOrderData.ForeColor = System.Drawing.Color.Red;
            this.GbOrderData.Location = new System.Drawing.Point(12, 309);
            this.GbOrderData.Name = "GbOrderData";
            this.GbOrderData.Size = new System.Drawing.Size(392, 101);
            this.GbOrderData.TabIndex = 3;
            this.GbOrderData.TabStop = false;
            this.GbOrderData.Text = "Datos de la orden";
            // 
            // LblSushiType
            // 
            this.LblSushiType.AutoSize = true;
            this.LblSushiType.Location = new System.Drawing.Point(18, 397);
            this.LblSushiType.Name = "LblSushiType";
            this.LblSushiType.Size = new System.Drawing.Size(0, 13);
            this.LblSushiType.TabIndex = 3;
            // 
            // GbMenu
            // 
            this.GbMenu.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GbMenu.Controls.Add(this.GbFoodType);
            this.GbMenu.Controls.Add(this.GbCombo4);
            this.GbMenu.Controls.Add(this.GbCombo3);
            this.GbMenu.Controls.Add(this.GbCombo2);
            this.GbMenu.Controls.Add(this.GbCombo1);
            this.GbMenu.Controls.Add(this.LblCombo1);
            this.GbMenu.ForeColor = System.Drawing.Color.Red;
            this.GbMenu.Location = new System.Drawing.Point(410, 12);
            this.GbMenu.Name = "GbMenu";
            this.GbMenu.Size = new System.Drawing.Size(378, 426);
            this.GbMenu.TabIndex = 4;
            this.GbMenu.TabStop = false;
            this.GbMenu.Text = "Menu";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "COMBO 1 ",
            "COMBO 2",
            "COMBO 3",
            "COMBO 4"});
            this.comboBox2.Location = new System.Drawing.Point(93, 24);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 0;
            // 
            // LblCombo1
            // 
            this.LblCombo1.AutoSize = true;
            this.LblCombo1.Location = new System.Drawing.Point(85, 16);
            this.LblCombo1.Name = "LblCombo1";
            this.LblCombo1.Size = new System.Drawing.Size(0, 13);
            this.LblCombo1.TabIndex = 0;
            // 
            // GbCombo1
            // 
            this.GbCombo1.BackColor = System.Drawing.Color.Red;
            this.GbCombo1.Controls.Add(this.LblFirstCombo);
            this.GbCombo1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GbCombo1.Location = new System.Drawing.Point(9, 19);
            this.GbCombo1.Name = "GbCombo1";
            this.GbCombo1.Size = new System.Drawing.Size(178, 100);
            this.GbCombo1.TabIndex = 1;
            this.GbCombo1.TabStop = false;
            this.GbCombo1.Text = "COMBO 1";
            // 
            // LblFirstCombo
            // 
            this.LblFirstCombo.AutoSize = true;
            this.LblFirstCombo.Location = new System.Drawing.Point(6, 16);
            this.LblFirstCombo.Name = "LblFirstCombo";
            this.LblFirstCombo.Size = new System.Drawing.Size(171, 13);
            this.LblFirstCombo.TabIndex = 0;
            this.LblFirstCombo.Text = "1 guiso servido sobre arroz o pasta";
            // 
            // GbCombo2
            // 
            this.GbCombo2.BackColor = System.Drawing.Color.Red;
            this.GbCombo2.Controls.Add(this.LblCombo2);
            this.GbCombo2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GbCombo2.Location = new System.Drawing.Point(193, 19);
            this.GbCombo2.Name = "GbCombo2";
            this.GbCombo2.Size = new System.Drawing.Size(178, 100);
            this.GbCombo2.TabIndex = 2;
            this.GbCombo2.TabStop = false;
            this.GbCombo2.Text = "COMBO 2";
            // 
            // LblCombo2
            // 
            this.LblCombo2.AutoSize = true;
            this.LblCombo2.Location = new System.Drawing.Point(6, 16);
            this.LblCombo2.Name = "LblCombo2";
            this.LblCombo2.Size = new System.Drawing.Size(120, 13);
            this.LblCombo2.TabIndex = 0;
            this.LblCombo2.Text = "10 Sushis mixtos + arroz";
            // 
            // GbCombo3
            // 
            this.GbCombo3.BackColor = System.Drawing.Color.Red;
            this.GbCombo3.Controls.Add(this.LblCombo3);
            this.GbCombo3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GbCombo3.Location = new System.Drawing.Point(9, 131);
            this.GbCombo3.Name = "GbCombo3";
            this.GbCombo3.Size = new System.Drawing.Size(178, 100);
            this.GbCombo3.TabIndex = 3;
            this.GbCombo3.TabStop = false;
            this.GbCombo3.Text = "COMBO 3";
            // 
            // LblCombo3
            // 
            this.LblCombo3.AutoSize = true;
            this.LblCombo3.Location = new System.Drawing.Point(6, 16);
            this.LblCombo3.Name = "LblCombo3";
            this.LblCombo3.Size = new System.Drawing.Size(119, 13);
            this.LblCombo3.TabIndex = 0;
            this.LblCombo3.Text = "2 guisos + arroz o pasta";
            // 
            // GbCombo4
            // 
            this.GbCombo4.BackColor = System.Drawing.Color.Red;
            this.GbCombo4.Controls.Add(this.Lbl2Combo4);
            this.GbCombo4.Controls.Add(this.label1);
            this.GbCombo4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GbCombo4.Location = new System.Drawing.Point(193, 131);
            this.GbCombo4.Name = "GbCombo4";
            this.GbCombo4.Size = new System.Drawing.Size(178, 100);
            this.GbCombo4.TabIndex = 4;
            this.GbCombo4.TabStop = false;
            this.GbCombo4.Text = "COMBO 4";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "12 sushis mixtos + arroz ó pasta ";
            // 
            // Lbl2Combo4
            // 
            this.Lbl2Combo4.AutoSize = true;
            this.Lbl2Combo4.Location = new System.Drawing.Point(9, 33);
            this.Lbl2Combo4.Name = "Lbl2Combo4";
            this.Lbl2Combo4.Size = new System.Drawing.Size(41, 13);
            this.Lbl2Combo4.TabIndex = 1;
            this.Lbl2Combo4.Text = "+ guiso";
            // 
            // GbFoodType
            // 
            this.GbFoodType.BackColor = System.Drawing.Color.Red;
            this.GbFoodType.Controls.Add(this.LblFoodType);
            this.GbFoodType.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GbFoodType.Location = new System.Drawing.Point(9, 237);
            this.GbFoodType.Name = "GbFoodType";
            this.GbFoodType.Size = new System.Drawing.Size(362, 183);
            this.GbFoodType.TabIndex = 5;
            this.GbFoodType.TabStop = false;
            this.GbFoodType.Text = "TIPOS DE GUISOS";
            // 
            // LblFoodType
            // 
            this.LblFoodType.AutoSize = true;
            this.LblFoodType.Location = new System.Drawing.Point(47, 33);
            this.LblFoodType.Name = "LblFoodType";
            this.LblFoodType.Size = new System.Drawing.Size(277, 13);
            this.LblFoodType.TabIndex = 0;
            this.LblFoodType.Text = "Pollo teriyaki, Pollo a la naranja, BBQ Ribs, Kurai Chicken";
            // 
            // LblComboOrder
            // 
            this.LblComboOrder.AutoSize = true;
            this.LblComboOrder.ForeColor = System.Drawing.Color.Red;
            this.LblComboOrder.Location = new System.Drawing.Point(6, 27);
            this.LblComboOrder.Name = "LblComboOrder";
            this.LblComboOrder.Size = new System.Drawing.Size(81, 13);
            this.LblComboOrder.TabIndex = 1;
            this.LblComboOrder.Text = "Tipo de combo:";
            // 
            // LblStewType
            // 
            this.LblStewType.AutoSize = true;
            this.LblStewType.ForeColor = System.Drawing.Color.Red;
            this.LblStewType.Location = new System.Drawing.Point(6, 58);
            this.LblStewType.Name = "LblStewType";
            this.LblStewType.Size = new System.Drawing.Size(147, 13);
            this.LblStewType.TabIndex = 2;
            this.LblStewType.Text = "Tipo de guiso para su combo:";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Pollo Teriyaki",
            "Pollo a la naranja",
            "BBQ Ribs",
            "Kurai Chicken",
            "Ninguno"});
            this.comboBox3.Location = new System.Drawing.Point(159, 55);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 3;
            // 
            // F1SushiOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::A5_JEGC.Properties.Resources.logo_kurai;
            this.ClientSize = new System.Drawing.Size(799, 449);
            this.Controls.Add(this.LblSushiType);
            this.Controls.Add(this.GbMenu);
            this.Controls.Add(this.GbOrderData);
            this.Controls.Add(this.GbClientData);
            this.Name = "F1SushiOrder";
            this.Text = "BIENVENIDO A KURAI";
            this.GbClientData.ResumeLayout(false);
            this.GbClientData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.GbOrderData.ResumeLayout(false);
            this.GbOrderData.PerformLayout();
            this.GbMenu.ResumeLayout(false);
            this.GbMenu.PerformLayout();
            this.GbCombo1.ResumeLayout(false);
            this.GbCombo1.PerformLayout();
            this.GbCombo2.ResumeLayout(false);
            this.GbCombo2.PerformLayout();
            this.GbCombo3.ResumeLayout(false);
            this.GbCombo3.PerformLayout();
            this.GbCombo4.ResumeLayout(false);
            this.GbCombo4.PerformLayout();
            this.GbFoodType.ResumeLayout(false);
            this.GbFoodType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblClientName;
        private System.Windows.Forms.GroupBox GbClientData;
        private System.Windows.Forms.TextBox TxtBClientName;
        private System.Windows.Forms.Label LblHowManyPpl;
        private System.Windows.Forms.Label LblPlace;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox GbOrderData;
        private System.Windows.Forms.Label LblSushiType;
        private System.Windows.Forms.GroupBox GbMenu;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.GroupBox GbCombo1;
        private System.Windows.Forms.Label LblFirstCombo;
        private System.Windows.Forms.Label LblCombo1;
        private System.Windows.Forms.GroupBox GbCombo3;
        private System.Windows.Forms.Label LblCombo3;
        private System.Windows.Forms.GroupBox GbCombo2;
        private System.Windows.Forms.Label LblCombo2;
        private System.Windows.Forms.GroupBox GbFoodType;
        private System.Windows.Forms.Label LblFoodType;
        private System.Windows.Forms.GroupBox GbCombo4;
        private System.Windows.Forms.Label Lbl2Combo4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblComboOrder;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label LblStewType;
    }
}

