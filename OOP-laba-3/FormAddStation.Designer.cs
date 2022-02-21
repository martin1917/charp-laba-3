namespace OOP_laba_3
{
    partial class FormAddStation
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbDirector = new System.Windows.Forms.TextBox();
            this.tbWaysNumber = new System.Windows.Forms.TextBox();
            this.tbSeatsNumber = new System.Windows.Forms.TextBox();
            this.tbArea = new System.Windows.Forms.TextBox();
            this.tbPassagersAtStation = new System.Windows.Forms.TextBox();
            this.tbEmployeesAtStation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCansel = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(44, 39);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(136, 20);
            this.tbName.TabIndex = 0;
            // 
            // tbDirector
            // 
            this.tbDirector.Location = new System.Drawing.Point(44, 95);
            this.tbDirector.Name = "tbDirector";
            this.tbDirector.Size = new System.Drawing.Size(136, 20);
            this.tbDirector.TabIndex = 1;
            // 
            // tbWaysNumber
            // 
            this.tbWaysNumber.Location = new System.Drawing.Point(44, 202);
            this.tbWaysNumber.Name = "tbWaysNumber";
            this.tbWaysNumber.Size = new System.Drawing.Size(136, 20);
            this.tbWaysNumber.TabIndex = 2;
            // 
            // tbSeatsNumber
            // 
            this.tbSeatsNumber.Location = new System.Drawing.Point(44, 149);
            this.tbSeatsNumber.Name = "tbSeatsNumber";
            this.tbSeatsNumber.Size = new System.Drawing.Size(136, 20);
            this.tbSeatsNumber.TabIndex = 3;
            // 
            // tbArea
            // 
            this.tbArea.Location = new System.Drawing.Point(44, 257);
            this.tbArea.Name = "tbArea";
            this.tbArea.Size = new System.Drawing.Size(136, 20);
            this.tbArea.TabIndex = 4;
            // 
            // tbPassagersAtStation
            // 
            this.tbPassagersAtStation.Location = new System.Drawing.Point(44, 310);
            this.tbPassagersAtStation.Name = "tbPassagersAtStation";
            this.tbPassagersAtStation.Size = new System.Drawing.Size(136, 20);
            this.tbPassagersAtStation.TabIndex = 5;
            // 
            // tbEmployeesAtStation
            // 
            this.tbEmployeesAtStation.Location = new System.Drawing.Point(44, 371);
            this.tbEmployeesAtStation.Name = "tbEmployeesAtStation";
            this.tbEmployeesAtStation.Size = new System.Drawing.Size(136, 20);
            this.tbEmployeesAtStation.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Имя станции";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Директор";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Кол-во мест";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Кол-во путей";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Площадь";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Кол-во пассажиров";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 355);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Кол-во персонала";
            // 
            // btnCansel
            // 
            this.btnCansel.Location = new System.Drawing.Point(12, 427);
            this.btnCansel.Name = "btnCansel";
            this.btnCansel.Size = new System.Drawing.Size(75, 23);
            this.btnCansel.TabIndex = 14;
            this.btnCansel.Text = "Отмена";
            this.btnCansel.UseVisualStyleBackColor = true;
            this.btnCansel.Click += new System.EventHandler(this.btnCansel_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(145, 427);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 15;
            this.btnCreate.Text = "Создать";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // FormAddStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 471);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnCansel);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbEmployeesAtStation);
            this.Controls.Add(this.tbPassagersAtStation);
            this.Controls.Add(this.tbArea);
            this.Controls.Add(this.tbSeatsNumber);
            this.Controls.Add(this.tbWaysNumber);
            this.Controls.Add(this.tbDirector);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormAddStation";
            this.Text = "Добавить вокзал";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbDirector;
        private System.Windows.Forms.TextBox tbWaysNumber;
        private System.Windows.Forms.TextBox tbSeatsNumber;
        private System.Windows.Forms.TextBox tbArea;
        private System.Windows.Forms.TextBox tbPassagersAtStation;
        private System.Windows.Forms.TextBox tbEmployeesAtStation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCansel;
        private System.Windows.Forms.Button btnCreate;
    }
}