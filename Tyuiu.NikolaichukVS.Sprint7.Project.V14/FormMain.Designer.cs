
namespace Tyuiu.NikolaichukVS.Sprint7.Project.V14
{
    partial class FormMain
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
            this.buttonHelp_NVS = new System.Windows.Forms.Button();
            this.buttonOpen_NVS = new System.Windows.Forms.Button();
            this.groupBox_NVS = new System.Windows.Forms.GroupBox();
            this.buttonOp_NVS = new System.Windows.Forms.Button();
            this.dataGridView_NVS = new System.Windows.Forms.DataGridView();
            this.buttonAdd_NVS = new System.Windows.Forms.Button();
            this.buttonSave_NVS = new System.Windows.Forms.Button();
            this.buttonDelete_NVS = new System.Windows.Forms.Button();
            this.labelSearch_NVS = new System.Windows.Forms.Label();
            this.textBoxSearch_NVS = new System.Windows.Forms.TextBox();
            this.buttonInfo_NVS = new System.Windows.Forms.Button();
            this.openFileDialog_NVS = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog_NVS = new System.Windows.Forms.SaveFileDialog();
            this.groupBox_NVS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_NVS)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonHelp_NVS
            // 
            this.buttonHelp_NVS.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonHelp_NVS.Image = global::Tyuiu.NikolaichukVS.Sprint7.Project.V14.Properties.Resources.help;
            this.buttonHelp_NVS.Location = new System.Drawing.Point(98, 21);
            this.buttonHelp_NVS.Name = "buttonHelp_NVS";
            this.buttonHelp_NVS.Size = new System.Drawing.Size(67, 54);
            this.buttonHelp_NVS.TabIndex = 0;
            this.buttonHelp_NVS.UseVisualStyleBackColor = false;
            this.buttonHelp_NVS.Click += new System.EventHandler(this.buttonHelp_NVS_Click);
            // 
            // buttonOpen_NVS
            // 
            this.buttonOpen_NVS.Location = new System.Drawing.Point(828, 296);
            this.buttonOpen_NVS.Name = "buttonOpen_NVS";
            this.buttonOpen_NVS.Size = new System.Drawing.Size(75, 49);
            this.buttonOpen_NVS.TabIndex = 2;
            this.buttonOpen_NVS.Text = "Открыть";
            this.buttonOpen_NVS.UseVisualStyleBackColor = true;
            // 
            // groupBox_NVS
            // 
            this.groupBox_NVS.Controls.Add(this.buttonOp_NVS);
            this.groupBox_NVS.Controls.Add(this.dataGridView_NVS);
            this.groupBox_NVS.Controls.Add(this.buttonAdd_NVS);
            this.groupBox_NVS.Controls.Add(this.buttonSave_NVS);
            this.groupBox_NVS.Controls.Add(this.buttonDelete_NVS);
            this.groupBox_NVS.Controls.Add(this.labelSearch_NVS);
            this.groupBox_NVS.Controls.Add(this.textBoxSearch_NVS);
            this.groupBox_NVS.Controls.Add(this.buttonHelp_NVS);
            this.groupBox_NVS.Controls.Add(this.buttonInfo_NVS);
            this.groupBox_NVS.Location = new System.Drawing.Point(12, 12);
            this.groupBox_NVS.Name = "groupBox_NVS";
            this.groupBox_NVS.Size = new System.Drawing.Size(1095, 575);
            this.groupBox_NVS.TabIndex = 3;
            this.groupBox_NVS.TabStop = false;
            // 
            // buttonOp_NVS
            // 
            this.buttonOp_NVS.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonOp_NVS.Location = new System.Drawing.Point(192, 21);
            this.buttonOp_NVS.Name = "buttonOp_NVS";
            this.buttonOp_NVS.Size = new System.Drawing.Size(111, 56);
            this.buttonOp_NVS.TabIndex = 9;
            this.buttonOp_NVS.Text = "Открыть";
            this.buttonOp_NVS.UseVisualStyleBackColor = false;
            this.buttonOp_NVS.Click += new System.EventHandler(this.button_Click);
            // 
            // dataGridView_NVS
            // 
            this.dataGridView_NVS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_NVS.Location = new System.Drawing.Point(9, 86);
            this.dataGridView_NVS.Name = "dataGridView_NVS";
            this.dataGridView_NVS.RowHeadersWidth = 51;
            this.dataGridView_NVS.RowTemplate.Height = 24;
            this.dataGridView_NVS.Size = new System.Drawing.Size(903, 468);
            this.dataGridView_NVS.TabIndex = 8;
            // 
            // buttonAdd_NVS
            // 
            this.buttonAdd_NVS.BackColor = System.Drawing.Color.Tan;
            this.buttonAdd_NVS.Location = new System.Drawing.Point(560, 16);
            this.buttonAdd_NVS.Name = "buttonAdd_NVS";
            this.buttonAdd_NVS.Size = new System.Drawing.Size(120, 56);
            this.buttonAdd_NVS.TabIndex = 7;
            this.buttonAdd_NVS.Text = "Добавить строку";
            this.buttonAdd_NVS.UseVisualStyleBackColor = false;
            this.buttonAdd_NVS.Click += new System.EventHandler(this.buttonAdd_NVS_Click);
            // 
            // buttonSave_NVS
            // 
            this.buttonSave_NVS.BackColor = System.Drawing.Color.Chocolate;
            this.buttonSave_NVS.Location = new System.Drawing.Point(945, 471);
            this.buttonSave_NVS.Name = "buttonSave_NVS";
            this.buttonSave_NVS.Size = new System.Drawing.Size(123, 70);
            this.buttonSave_NVS.TabIndex = 6;
            this.buttonSave_NVS.Text = "Сохранить";
            this.buttonSave_NVS.UseVisualStyleBackColor = false;
            this.buttonSave_NVS.Click += new System.EventHandler(this.buttonSave_NVS_Click);
            // 
            // buttonDelete_NVS
            // 
            this.buttonDelete_NVS.BackColor = System.Drawing.Color.Sienna;
            this.buttonDelete_NVS.Location = new System.Drawing.Point(702, 16);
            this.buttonDelete_NVS.Name = "buttonDelete_NVS";
            this.buttonDelete_NVS.Size = new System.Drawing.Size(116, 56);
            this.buttonDelete_NVS.TabIndex = 5;
            this.buttonDelete_NVS.Text = "Удалить строку";
            this.buttonDelete_NVS.UseVisualStyleBackColor = false;
            this.buttonDelete_NVS.Click += new System.EventHandler(this.buttonDelete_NVS_Click);
            // 
            // labelSearch_NVS
            // 
            this.labelSearch_NVS.AutoSize = true;
            this.labelSearch_NVS.Location = new System.Drawing.Point(921, 18);
            this.labelSearch_NVS.Name = "labelSearch_NVS";
            this.labelSearch_NVS.Size = new System.Drawing.Size(48, 17);
            this.labelSearch_NVS.TabIndex = 4;
            this.labelSearch_NVS.Text = "Поиск";
            // 
            // textBoxSearch_NVS
            // 
            this.textBoxSearch_NVS.Location = new System.Drawing.Point(918, 53);
            this.textBoxSearch_NVS.Multiline = true;
            this.textBoxSearch_NVS.Name = "textBoxSearch_NVS";
            this.textBoxSearch_NVS.Size = new System.Drawing.Size(163, 22);
            this.textBoxSearch_NVS.TabIndex = 2;
            this.textBoxSearch_NVS.TextChanged += new System.EventHandler(this.textBoxSearch_NVS_TextChanged);
            // 
            // buttonInfo_NVS
            // 
            this.buttonInfo_NVS.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonInfo_NVS.Image = global::Tyuiu.NikolaichukVS.Sprint7.Project.V14.Properties.Resources.information;
            this.buttonInfo_NVS.Location = new System.Drawing.Point(9, 21);
            this.buttonInfo_NVS.Name = "buttonInfo_NVS";
            this.buttonInfo_NVS.Size = new System.Drawing.Size(71, 54);
            this.buttonInfo_NVS.TabIndex = 1;
            this.buttonInfo_NVS.UseVisualStyleBackColor = false;
            this.buttonInfo_NVS.Click += new System.EventHandler(this.buttonInfo_NVS_Click);
            // 
            // openFileDialog_NVS
            // 
            this.openFileDialog_NVS.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 599);
            this.Controls.Add(this.groupBox_NVS);
            this.Controls.Add(this.buttonOpen_NVS);
            this.Name = "FormMain";
            this.Text = "Общественный транспорт";
            this.groupBox_NVS.ResumeLayout(false);
            this.groupBox_NVS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_NVS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonHelp_NVS;
        private System.Windows.Forms.Button buttonOpen_NVS;
        private System.Windows.Forms.GroupBox groupBox_NVS;
        private System.Windows.Forms.Button buttonOp_NVS;
        private System.Windows.Forms.DataGridView dataGridView_NVS;
        private System.Windows.Forms.Button buttonAdd_NVS;
        private System.Windows.Forms.Button buttonSave_NVS;
        private System.Windows.Forms.Button buttonDelete_NVS;
        private System.Windows.Forms.Label labelSearch_NVS;
        private System.Windows.Forms.TextBox textBoxSearch_NVS;
        private System.Windows.Forms.OpenFileDialog openFileDialog_NVS;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_NVS;
        private System.Windows.Forms.Button buttonInfo_NVS;
    }
}

