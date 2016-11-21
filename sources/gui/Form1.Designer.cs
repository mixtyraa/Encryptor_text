namespace GUI_encryptor
{
    partial class Form1
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
            this.text_key = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.source_text = new System.Windows.Forms.RichTextBox();
            this.processed_text = new System.Windows.Forms.RichTextBox();
            this.rb_decrypt = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_encrypt = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // text_key
            // 
            this.text_key.Location = new System.Drawing.Point(57, 45);
            this.text_key.Name = "text_key";
            this.text_key.Size = new System.Drawing.Size(239, 20);
            this.text_key.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(57, 11);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(514, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Шифр:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ключ:";
            // 
            // source_text
            // 
            this.source_text.DetectUrls = false;
            this.source_text.Location = new System.Drawing.Point(12, 74);
            this.source_text.Name = "source_text";
            this.source_text.Size = new System.Drawing.Size(445, 347);
            this.source_text.TabIndex = 1;
            this.source_text.Text = "";
            this.source_text.TextChanged += new System.EventHandler(this.source_text_TextChanged);
            // 
            // processed_text
            // 
            this.processed_text.Location = new System.Drawing.Point(475, 74);
            this.processed_text.Name = "processed_text";
            this.processed_text.Size = new System.Drawing.Size(445, 347);
            this.processed_text.TabIndex = 2;
            this.processed_text.Text = "";
            // 
            // rb_decrypt
            // 
            this.rb_decrypt.AutoSize = true;
            this.rb_decrypt.Location = new System.Drawing.Point(138, 10);
            this.rb_decrypt.Name = "rb_decrypt";
            this.rb_decrypt.Size = new System.Drawing.Size(101, 17);
            this.rb_decrypt.TabIndex = 6;
            this.rb_decrypt.Text = "Расшифровать";
            this.rb_decrypt.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.rb_encrypt);
            this.groupBox1.Controls.Add(this.rb_decrypt);
            this.groupBox1.Location = new System.Drawing.Point(311, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 32);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // rb_encrypt
            // 
            this.rb_encrypt.AutoSize = true;
            this.rb_encrypt.Checked = true;
            this.rb_encrypt.Location = new System.Drawing.Point(6, 10);
            this.rb_encrypt.Name = "rb_encrypt";
            this.rb_encrypt.Size = new System.Drawing.Size(95, 17);
            this.rb_encrypt.TabIndex = 5;
            this.rb_encrypt.TabStop = true;
            this.rb_encrypt.Text = "Зашифровать";
            this.rb_encrypt.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 441);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.processed_text);
            this.Controls.Add(this.source_text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.text_key);
            this.Name = "Form1";
            this.Text = "Шифратор";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox text_key;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox source_text;
        private System.Windows.Forms.RichTextBox processed_text;
        private System.Windows.Forms.RadioButton rb_decrypt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_encrypt;
    }
}

