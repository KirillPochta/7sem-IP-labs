
namespace WindowsFormsApp1
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
            this.dataGridViewPhone = new System.Windows.Forms.DataGridView();
            this.buttonAddPhone = new System.Windows.Forms.Button();
            this.textBoxNameAdd = new System.Windows.Forms.TextBox();
            this.textBoxNumberAdd = new System.Windows.Forms.TextBox();
            this.textBoxNameUpd = new System.Windows.Forms.TextBox();
            this.textBoxNumberUpd = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhone)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPhone
            // 
            this.dataGridViewPhone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPhone.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewPhone.Name = "dataGridViewPhone";
            this.dataGridViewPhone.RowHeadersWidth = 51;
            this.dataGridViewPhone.RowTemplate.Height = 24;
            this.dataGridViewPhone.Size = new System.Drawing.Size(463, 362);
            this.dataGridViewPhone.TabIndex = 0;
            this.dataGridViewPhone.SelectionChanged += new System.EventHandler(this.dataGridViewPhone_SelectionChanged);
            // 
            // buttonAddPhone
            // 
            this.buttonAddPhone.Location = new System.Drawing.Point(590, 130);
            this.buttonAddPhone.Name = "buttonAddPhone";
            this.buttonAddPhone.Size = new System.Drawing.Size(75, 23);
            this.buttonAddPhone.TabIndex = 1;
            this.buttonAddPhone.Text = "Add";
            this.buttonAddPhone.UseVisualStyleBackColor = true;
            this.buttonAddPhone.Click += new System.EventHandler(this.addPhone);
            // 
            // textBoxNameAdd
            // 
            this.textBoxNameAdd.Location = new System.Drawing.Point(505, 65);
            this.textBoxNameAdd.Name = "textBoxNameAdd";
            this.textBoxNameAdd.Size = new System.Drawing.Size(100, 22);
            this.textBoxNameAdd.TabIndex = 2;
            // 
            // textBoxNumberAdd
            // 
            this.textBoxNumberAdd.Location = new System.Drawing.Point(648, 65);
            this.textBoxNumberAdd.Name = "textBoxNumberAdd";
            this.textBoxNumberAdd.Size = new System.Drawing.Size(100, 22);
            this.textBoxNumberAdd.TabIndex = 3;
            // 
            // textBoxNameUpd
            // 
            this.textBoxNameUpd.Location = new System.Drawing.Point(505, 190);
            this.textBoxNameUpd.Name = "textBoxNameUpd";
            this.textBoxNameUpd.Size = new System.Drawing.Size(100, 22);
            this.textBoxNameUpd.TabIndex = 4;
            // 
            // textBoxNumberUpd
            // 
            this.textBoxNumberUpd.Location = new System.Drawing.Point(648, 190);
            this.textBoxNumberUpd.Name = "textBoxNumberUpd";
            this.textBoxNumberUpd.Size = new System.Drawing.Size(100, 22);
            this.textBoxNumberUpd.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(590, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.updatePhone);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(590, 351);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.deletePhone);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxNumberUpd);
            this.Controls.Add(this.textBoxNameUpd);
            this.Controls.Add(this.textBoxNumberAdd);
            this.Controls.Add(this.textBoxNameAdd);
            this.Controls.Add(this.buttonAddPhone);
            this.Controls.Add(this.dataGridViewPhone);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPhone;
        private System.Windows.Forms.Button buttonAddPhone;
        private System.Windows.Forms.TextBox textBoxNameAdd;
        private System.Windows.Forms.TextBox textBoxNumberAdd;
        private System.Windows.Forms.TextBox textBoxNameUpd;
        private System.Windows.Forms.TextBox textBoxNumberUpd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

