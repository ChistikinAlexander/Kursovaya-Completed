
namespace Kursovaya
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.addbd = new System.Windows.Forms.Button();
            this.editbutton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 124);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(646, 449);
            this.dataGridView1.TabIndex = 0;
            // 
            // addbd
            // 
            this.addbd.BackColor = System.Drawing.Color.LightSeaGreen;
            this.addbd.Location = new System.Drawing.Point(664, 375);
            this.addbd.Name = "addbd";
            this.addbd.Size = new System.Drawing.Size(107, 59);
            this.addbd.TabIndex = 1;
            this.addbd.Text = "Добавить запись";
            this.addbd.UseVisualStyleBackColor = false;
            this.addbd.Click += new System.EventHandler(this.addbd_Click);
            // 
            // editbutton
            // 
            this.editbutton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.editbutton.Location = new System.Drawing.Point(664, 440);
            this.editbutton.Name = "editbutton";
            this.editbutton.Size = new System.Drawing.Size(107, 59);
            this.editbutton.TabIndex = 2;
            this.editbutton.Text = "Изменить";
            this.editbutton.UseVisualStyleBackColor = false;
            this.editbutton.Click += new System.EventHandler(this.editbutton_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button3.Location = new System.Drawing.Point(664, 508);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 51);
            this.button3.TabIndex = 3;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(40, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(545, 49);
            this.label1.TabIndex = 4;
            this.label1.Text = "База данных споривного клуба";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(783, 585);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.editbutton);
            this.Controls.Add(this.addbd);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "База данных";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button addbd;
        private System.Windows.Forms.Button editbutton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
    }
}

