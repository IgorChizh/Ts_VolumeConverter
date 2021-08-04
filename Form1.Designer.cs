
namespace volumeConverter
{
    partial class volumeConverter
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
            this.clLabel = new System.Windows.Forms.Label();
            this.litreLabel = new System.Windows.Forms.Label();
            this.convertClTitilLabel = new System.Windows.Forms.Label();
            this.clTexBox = new System.Windows.Forms.TextBox();
            this.litreTexBox = new System.Windows.Forms.TextBox();
            this.convertButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clLabel
            // 
            this.clLabel.AutoSize = true;
            this.clLabel.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.clLabel.Location = new System.Drawing.Point(167, 82);
            this.clLabel.Name = "clLabel";
            this.clLabel.Size = new System.Drawing.Size(23, 17);
            this.clLabel.TabIndex = 0;
            this.clLabel.Text = "CL";
            // 
            // litreLabel
            // 
            this.litreLabel.AutoSize = true;
            this.litreLabel.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.litreLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.litreLabel.Location = new System.Drawing.Point(166, 126);
            this.litreLabel.Name = "litreLabel";
            this.litreLabel.Size = new System.Drawing.Size(45, 17);
            this.litreLabel.TabIndex = 1;
            this.litreLabel.Text = "Litre";
            // 
            // convertClTitilLabel
            // 
            this.convertClTitilLabel.AutoSize = true;
            this.convertClTitilLabel.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertClTitilLabel.ForeColor = System.Drawing.Color.Teal;
            this.convertClTitilLabel.Location = new System.Drawing.Point(41, 32);
            this.convertClTitilLabel.Name = "convertClTitilLabel";
            this.convertClTitilLabel.Size = new System.Drawing.Size(280, 30);
            this.convertClTitilLabel.TabIndex = 2;
            this.convertClTitilLabel.Text = "Convert CL to Litre";
            // 
            // clTexBox
            // 
            this.clTexBox.BackColor = System.Drawing.Color.White;
            this.clTexBox.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clTexBox.ForeColor = System.Drawing.Color.Teal;
            this.clTexBox.Location = new System.Drawing.Point(57, 75);
            this.clTexBox.Multiline = true;
            this.clTexBox.Name = "clTexBox";
            this.clTexBox.Size = new System.Drawing.Size(100, 32);
            this.clTexBox.TabIndex = 3;
            this.clTexBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // litreTexBox
            // 
            this.litreTexBox.BackColor = System.Drawing.Color.White;
            this.litreTexBox.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.litreTexBox.ForeColor = System.Drawing.Color.Teal;
            this.litreTexBox.Location = new System.Drawing.Point(57, 119);
            this.litreTexBox.Multiline = true;
            this.litreTexBox.Name = "litreTexBox";
            this.litreTexBox.Size = new System.Drawing.Size(100, 32);
            this.litreTexBox.TabIndex = 4;
            this.litreTexBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // convertButton
            // 
            this.convertButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.convertButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.convertButton.FlatAppearance.BorderSize = 2;
            this.convertButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.convertButton.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.convertButton.Location = new System.Drawing.Point(57, 172);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(85, 45);
            this.convertButton.TabIndex = 5;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = false;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.Silver;
            this.clearButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.clearButton.FlatAppearance.BorderSize = 2;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.clearButton.Location = new System.Drawing.Point(169, 181);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(64, 27);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // volumeConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(372, 264);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.litreTexBox);
            this.Controls.Add(this.clTexBox);
            this.Controls.Add(this.convertClTitilLabel);
            this.Controls.Add(this.litreLabel);
            this.Controls.Add(this.clLabel);
            this.MaximizeBox = false;
            this.Name = "volumeConverter";
            this.Text = "Volume Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label clLabel;
        private System.Windows.Forms.Label litreLabel;
        private System.Windows.Forms.Label convertClTitilLabel;
        private System.Windows.Forms.TextBox clTexBox;
        private System.Windows.Forms.TextBox litreTexBox;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Button clearButton;
    }
}

