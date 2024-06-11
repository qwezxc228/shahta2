namespace shahta2
{
    partial class FormMine
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
            labelOre = new Label();
            textBoxSell = new TextBox();
            buttonSell = new Button();
            labelWorker = new Label();
            buttonBuy = new Button();
            SuspendLayout();
            // 
            // labelOre
            // 
            labelOre.AutoSize = true;
            labelOre.Font = new Font("Old English Text MT", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelOre.Location = new Point(151, 61);
            labelOre.Name = "labelOre";
            labelOre.Size = new Size(91, 34);
            labelOre.TabIndex = 0;
            labelOre.Text = "Ore: 0";
            // 
            // textBoxSell
            // 
            textBoxSell.Font = new Font("Segoe UI", 22F);
            textBoxSell.Location = new Point(36, 194);
            textBoxSell.Name = "textBoxSell";
            textBoxSell.Size = new Size(206, 47);
            textBoxSell.TabIndex = 1;
            // 
            // buttonSell
            // 
            buttonSell.Font = new Font("Old English Text MT", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSell.Location = new Point(286, 193);
            buttonSell.Name = "buttonSell";
            buttonSell.Size = new Size(122, 48);
            buttonSell.TabIndex = 2;
            buttonSell.Text = "Sell";
            buttonSell.UseVisualStyleBackColor = true;
            buttonSell.Click += button1_Click;
            // 
            // labelWorker
            // 
            labelWorker.AutoSize = true;
            labelWorker.Font = new Font("Old English Text MT", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelWorker.Location = new Point(107, 264);
            labelWorker.Name = "labelWorker";
            labelWorker.Size = new Size(135, 34);
            labelWorker.TabIndex = 0;
            labelWorker.Text = "Worker: 1";
            // 
            // buttonBuy
            // 
            buttonBuy.Font = new Font("Old English Text MT", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonBuy.Location = new Point(68, 344);
            buttonBuy.Name = "buttonBuy";
            buttonBuy.Size = new Size(200, 48);
            buttonBuy.TabIndex = 2;
            buttonBuy.Text = "Buy: 300$";
            buttonBuy.UseVisualStyleBackColor = true;
            buttonBuy.Click += button1_Click;
            // 
            // FormMine
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(483, 450);
            Controls.Add(buttonBuy);
            Controls.Add(buttonSell);
            Controls.Add(textBoxSell);
            Controls.Add(labelWorker);
            Controls.Add(labelOre);
            Name = "FormMine";
            Text = "FormMine";
            Load += FormMine_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelOre;
        private TextBox textBoxSell;
        private Button buttonSell;
        private Label labelWorker;
        private Button buttonBuy;
    }
}