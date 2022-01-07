
namespace SAUPPOTO
{
    partial class HelpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.HelpText2 = new System.Windows.Forms.Label();
            this.HelpText1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(180)))), ((int)(((byte)(140)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.HelpText2);
            this.panel1.Controls.Add(this.HelpText1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 546);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 419);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(679, 108);
            this.label3.TabIndex = 4;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 349);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(597, 54);
            this.label2.TabIndex = 3;
            this.label2.Text = "Окно изменения сотрудника\r\nДля возврата в меню сотрудников нажмите на кнопку \"Воз" +
    "врат к списку сотрудников\".\r\nПосле изменения данных в полях  нажмите на кнопку \"" +
    "Редактировать\".";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(598, 54);
            this.label1.TabIndex = 2;
            this.label1.Text = "Окно добавления сотрудника\r\nДля возврата в меню сотрудников нажмите на кнопку \"Во" +
    "зврат к списку сотрудников\".\r\nПосле внесения в поля данных нажмите на кнопку \"Со" +
    "здать\".\r\n";
            // 
            // HelpText2
            // 
            this.HelpText2.AutoSize = true;
            this.HelpText2.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpText2.Location = new System.Drawing.Point(31, 95);
            this.HelpText2.Name = "HelpText2";
            this.HelpText2.Size = new System.Drawing.Size(746, 162);
            this.HelpText2.TabIndex = 1;
            this.HelpText2.Text = resources.GetString("HelpText2.Text");
            // 
            // HelpText1
            // 
            this.HelpText1.AutoSize = true;
            this.HelpText1.BackColor = System.Drawing.Color.Transparent;
            this.HelpText1.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpText1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.HelpText1.Location = new System.Drawing.Point(31, 20);
            this.HelpText1.Name = "HelpText1";
            this.HelpText1.Size = new System.Drawing.Size(659, 54);
            this.HelpText1.TabIndex = 0;
            this.HelpText1.Text = "Главное меню\r\nДля открытия окна меню сотрудников нужно нажать на кнопку \"Перейти " +
    "к меню сотрудников\". \r\nДля открытия окна статистика нужно нажать на кнопку \"Пере" +
    "йти к статистике\".\r\n";
            // 
            // Help_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 546);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Help_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SAUPPOTO";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label HelpText1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label HelpText2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}