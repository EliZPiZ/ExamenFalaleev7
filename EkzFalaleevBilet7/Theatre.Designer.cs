namespace EkzFalaleevBilet7
{
    partial class Theatre
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.TheatreNameLabel = new System.Windows.Forms.Label();
            this.RepresentationLabel = new System.Windows.Forms.Label();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SceneSelector = new System.Windows.Forms.ComboBox();
            this.VIPRButton = new System.Windows.Forms.RadioButton();
            this.PartherRButton = new System.Windows.Forms.RadioButton();
            this.BalconyRButton = new System.Windows.Forms.RadioButton();
            this.QuantityBox = new System.Windows.Forms.TextBox();
            this.CalculationButton = new System.Windows.Forms.Button();
            this.AfishaButton = new System.Windows.Forms.Button();
            this.MakeReceiptButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TheatreNameLabel);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 45);
            this.panel1.TabIndex = 0;
            // 
            // TheatreNameLabel
            // 
            this.TheatreNameLabel.AutoSize = true;
            this.TheatreNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TheatreNameLabel.Location = new System.Drawing.Point(27, 9);
            this.TheatreNameLabel.Name = "TheatreNameLabel";
            this.TheatreNameLabel.Size = new System.Drawing.Size(64, 24);
            this.TheatreNameLabel.TabIndex = 1;
            this.TheatreNameLabel.Text = "Театр";
            // 
            // RepresentationLabel
            // 
            this.RepresentationLabel.AutoSize = true;
            this.RepresentationLabel.Location = new System.Drawing.Point(10, 66);
            this.RepresentationLabel.Name = "RepresentationLabel";
            this.RepresentationLabel.Size = new System.Drawing.Size(86, 13);
            this.RepresentationLabel.TabIndex = 1;
            this.RepresentationLabel.Text = "Представления";
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.Location = new System.Drawing.Point(12, 249);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(66, 13);
            this.QuantityLabel.TabIndex = 2;
            this.QuantityLabel.Text = "Количество";
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Location = new System.Drawing.Point(12, 345);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(155, 13);
            this.InfoLabel.TabIndex = 3;
            this.InfoLabel.Text = "Вывод информации о сеансе";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(12, 371);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(177, 13);
            this.PriceLabel.TabIndex = 4;
            this.PriceLabel.Text = "Общая стоимость билетов будет:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(416, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 292);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // SceneSelector
            // 
            this.SceneSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SceneSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SceneSelector.FormattingEnabled = true;
            this.SceneSelector.Items.AddRange(new object[] {
            "Алые паруса",
            "Щелкунчик",
            "Дон Кихот",
            "Красная шапочка",
            "Лебединое озеро",
            "Летучий корабль"});
            this.SceneSelector.Location = new System.Drawing.Point(12, 82);
            this.SceneSelector.Name = "SceneSelector";
            this.SceneSelector.Size = new System.Drawing.Size(121, 28);
            this.SceneSelector.TabIndex = 6;
            // 
            // VIPRButton
            // 
            this.VIPRButton.AutoSize = true;
            this.VIPRButton.Location = new System.Drawing.Point(12, 132);
            this.VIPRButton.Name = "VIPRButton";
            this.VIPRButton.Size = new System.Drawing.Size(42, 17);
            this.VIPRButton.TabIndex = 7;
            this.VIPRButton.TabStop = true;
            this.VIPRButton.Text = "VIP";
            this.VIPRButton.UseVisualStyleBackColor = true;
            // 
            // PartherRButton
            // 
            this.PartherRButton.AutoSize = true;
            this.PartherRButton.Location = new System.Drawing.Point(13, 161);
            this.PartherRButton.Name = "PartherRButton";
            this.PartherRButton.Size = new System.Drawing.Size(62, 17);
            this.PartherRButton.TabIndex = 8;
            this.PartherRButton.TabStop = true;
            this.PartherRButton.Text = "Партер";
            this.PartherRButton.UseVisualStyleBackColor = true;
            // 
            // BalconyRButton
            // 
            this.BalconyRButton.AutoSize = true;
            this.BalconyRButton.Location = new System.Drawing.Point(13, 186);
            this.BalconyRButton.Name = "BalconyRButton";
            this.BalconyRButton.Size = new System.Drawing.Size(62, 17);
            this.BalconyRButton.TabIndex = 9;
            this.BalconyRButton.TabStop = true;
            this.BalconyRButton.Text = "Балкон";
            this.BalconyRButton.UseVisualStyleBackColor = true;
            // 
            // QuantityBox
            // 
            this.QuantityBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuantityBox.Location = new System.Drawing.Point(12, 265);
            this.QuantityBox.Name = "QuantityBox";
            this.QuantityBox.Size = new System.Drawing.Size(100, 26);
            this.QuantityBox.TabIndex = 10;
            this.QuantityBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.QuantityBox_KeyPress);
            // 
            // CalculationButton
            // 
            this.CalculationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CalculationButton.Location = new System.Drawing.Point(12, 297);
            this.CalculationButton.Name = "CalculationButton";
            this.CalculationButton.Size = new System.Drawing.Size(151, 23);
            this.CalculationButton.TabIndex = 11;
            this.CalculationButton.Text = "Расчет";
            this.CalculationButton.UseVisualStyleBackColor = true;
            this.CalculationButton.Click += new System.EventHandler(this.CalculationButton_Click);
            // 
            // AfishaButton
            // 
            this.AfishaButton.Enabled = false;
            this.AfishaButton.Location = new System.Drawing.Point(416, 364);
            this.AfishaButton.Name = "AfishaButton";
            this.AfishaButton.Size = new System.Drawing.Size(300, 34);
            this.AfishaButton.TabIndex = 12;
            this.AfishaButton.Text = "Добавить афишу";
            this.AfishaButton.UseVisualStyleBackColor = true;
            // 
            // MakeReceiptButton
            // 
            this.MakeReceiptButton.Location = new System.Drawing.Point(32, 404);
            this.MakeReceiptButton.Name = "MakeReceiptButton";
            this.MakeReceiptButton.Size = new System.Drawing.Size(155, 34);
            this.MakeReceiptButton.TabIndex = 13;
            this.MakeReceiptButton.Text = "Оформить квитанцию";
            this.MakeReceiptButton.UseVisualStyleBackColor = true;
            this.MakeReceiptButton.Click += new System.EventHandler(this.MakeReceiptButton_Click);
            // 
            // Theatre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MakeReceiptButton);
            this.Controls.Add(this.AfishaButton);
            this.Controls.Add(this.CalculationButton);
            this.Controls.Add(this.QuantityBox);
            this.Controls.Add(this.BalconyRButton);
            this.Controls.Add(this.PartherRButton);
            this.Controls.Add(this.VIPRButton);
            this.Controls.Add(this.SceneSelector);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.QuantityLabel);
            this.Controls.Add(this.RepresentationLabel);
            this.Controls.Add(this.panel1);
            this.Name = "Theatre";
            this.Text = "Театр";
            this.Load += new System.EventHandler(this.Theatre_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label TheatreNameLabel;
        private System.Windows.Forms.Label RepresentationLabel;
        private System.Windows.Forms.Label QuantityLabel;
        private System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox SceneSelector;
        private System.Windows.Forms.RadioButton VIPRButton;
        private System.Windows.Forms.RadioButton PartherRButton;
        private System.Windows.Forms.RadioButton BalconyRButton;
        private System.Windows.Forms.TextBox QuantityBox;
        private System.Windows.Forms.Button CalculationButton;
        private System.Windows.Forms.Button AfishaButton;
        private System.Windows.Forms.Button MakeReceiptButton;
    }
}

