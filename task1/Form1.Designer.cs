namespace Ziskin_1
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
            this.groupBox_type = new System.Windows.Forms.GroupBox();
            this.radioButton_annuit_type = new System.Windows.Forms.RadioButton();
            this.radioButton_diff_type = new System.Windows.Forms.RadioButton();
            this.dataGridView_payment_graphic = new System.Windows.Forms.DataGridView();
            this.Month = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Balance_owed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Payment_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Interest_rate_part = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Debt_part = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Balance_owed_end_period = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_overpayment = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_sum = new System.Windows.Forms.TextBox();
            this.textBox_term = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_interest_rate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button_start_evaluate = new System.Windows.Forms.Button();
            this.groupBox_type.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_payment_graphic)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_type
            // 
            this.groupBox_type.Controls.Add(this.radioButton_annuit_type);
            this.groupBox_type.Controls.Add(this.radioButton_diff_type);
            this.groupBox_type.Location = new System.Drawing.Point(27, 28);
            this.groupBox_type.Name = "groupBox_type";
            this.groupBox_type.Size = new System.Drawing.Size(217, 100);
            this.groupBox_type.TabIndex = 0;
            this.groupBox_type.TabStop = false;
            this.groupBox_type.Text = "Тип платежа";
            // 
            // radioButton_annuit_type
            // 
            this.radioButton_annuit_type.AutoSize = true;
            this.radioButton_annuit_type.Location = new System.Drawing.Point(7, 59);
            this.radioButton_annuit_type.Name = "radioButton_annuit_type";
            this.radioButton_annuit_type.Size = new System.Drawing.Size(117, 21);
            this.radioButton_annuit_type.TabIndex = 1;
            this.radioButton_annuit_type.Text = "Аннуитетный";
            this.radioButton_annuit_type.UseVisualStyleBackColor = true;
            // 
            // radioButton_diff_type
            // 
            this.radioButton_diff_type.AutoSize = true;
            this.radioButton_diff_type.Checked = true;
            this.radioButton_diff_type.Location = new System.Drawing.Point(7, 31);
            this.radioButton_diff_type.Name = "radioButton_diff_type";
            this.radioButton_diff_type.Size = new System.Drawing.Size(183, 21);
            this.radioButton_diff_type.TabIndex = 0;
            this.radioButton_diff_type.TabStop = true;
            this.radioButton_diff_type.Text = "Дифференцированный";
            this.radioButton_diff_type.UseVisualStyleBackColor = true;
            // 
            // dataGridView_payment_graphic
            // 
            this.dataGridView_payment_graphic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_payment_graphic.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Month,
            this.Balance_owed,
            this.Payment_amount,
            this.Interest_rate_part,
            this.Debt_part,
            this.Balance_owed_end_period});
            this.dataGridView_payment_graphic.Location = new System.Drawing.Point(273, 59);
            this.dataGridView_payment_graphic.Name = "dataGridView_payment_graphic";
            this.dataGridView_payment_graphic.RowHeadersVisible = false;
            this.dataGridView_payment_graphic.RowHeadersWidth = 40;
            this.dataGridView_payment_graphic.RowTemplate.Height = 24;
            this.dataGridView_payment_graphic.Size = new System.Drawing.Size(824, 331);
            this.dataGridView_payment_graphic.TabIndex = 1;
            // 
            // Month
            // 
            this.Month.HeaderText = "Месяц (номер)";
            this.Month.MinimumWidth = 6;
            this.Month.Name = "Month";
            this.Month.Width = 60;
            // 
            // Balance_owed
            // 
            this.Balance_owed.HeaderText = "Остаток долга";
            this.Balance_owed.MinimumWidth = 6;
            this.Balance_owed.Name = "Balance_owed";
            this.Balance_owed.Width = 111;
            // 
            // Payment_amount
            // 
            this.Payment_amount.HeaderText = "Размер платежа";
            this.Payment_amount.MinimumWidth = 6;
            this.Payment_amount.Name = "Payment_amount";
            this.Payment_amount.Width = 112;
            // 
            // Interest_rate_part
            // 
            this.Interest_rate_part.HeaderText = "Процентная часть";
            this.Interest_rate_part.MinimumWidth = 6;
            this.Interest_rate_part.Name = "Interest_rate_part";
            this.Interest_rate_part.Width = 111;
            // 
            // Debt_part
            // 
            this.Debt_part.HeaderText = "Долговая часть";
            this.Debt_part.MinimumWidth = 6;
            this.Debt_part.Name = "Debt_part";
            this.Debt_part.Width = 112;
            // 
            // Balance_owed_end_period
            // 
            this.Balance_owed_end_period.HeaderText = "Остаток долга на конец периода";
            this.Balance_owed_end_period.MinimumWidth = 6;
            this.Balance_owed_end_period.Name = "Balance_owed_end_period";
            this.Balance_owed_end_period.Width = 111;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(270, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "График платежей:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 412);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Общая переплата:";
            // 
            // textBox_overpayment
            // 
            this.textBox_overpayment.Location = new System.Drawing.Point(273, 447);
            this.textBox_overpayment.Multiline = true;
            this.textBox_overpayment.Name = "textBox_overpayment";
            this.textBox_overpayment.ReadOnly = true;
            this.textBox_overpayment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_overpayment.Size = new System.Drawing.Size(824, 48);
            this.textBox_overpayment.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Сумма кредита:";
            // 
            // textBox_sum
            // 
            this.textBox_sum.Location = new System.Drawing.Point(34, 182);
            this.textBox_sum.Multiline = true;
            this.textBox_sum.Name = "textBox_sum";
            this.textBox_sum.Size = new System.Drawing.Size(210, 38);
            this.textBox_sum.TabIndex = 6;
            // 
            // textBox_term
            // 
            this.textBox_term.Location = new System.Drawing.Point(34, 279);
            this.textBox_term.Multiline = true;
            this.textBox_term.Name = "textBox_term";
            this.textBox_term.Size = new System.Drawing.Size(210, 38);
            this.textBox_term.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Срок, в месяцах:";
            // 
            // textBox_interest_rate
            // 
            this.textBox_interest_rate.Location = new System.Drawing.Point(34, 379);
            this.textBox_interest_rate.Multiline = true;
            this.textBox_interest_rate.Name = "textBox_interest_rate";
            this.textBox_interest_rate.Size = new System.Drawing.Size(210, 38);
            this.textBox_interest_rate.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(217, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Процентная ставка, % годовых:";
            // 
            // button_start_evaluate
            // 
            this.button_start_evaluate.Location = new System.Drawing.Point(34, 448);
            this.button_start_evaluate.Name = "button_start_evaluate";
            this.button_start_evaluate.Size = new System.Drawing.Size(210, 47);
            this.button_start_evaluate.TabIndex = 11;
            this.button_start_evaluate.Text = "Рассчитать график платежей";
            this.button_start_evaluate.UseVisualStyleBackColor = true;
            this.button_start_evaluate.Click += new System.EventHandler(this.button_start_evaluate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 523);
            this.Controls.Add(this.button_start_evaluate);
            this.Controls.Add(this.textBox_interest_rate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_term);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_sum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_overpayment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_payment_graphic);
            this.Controls.Add(this.groupBox_type);
            this.Name = "Form1";
            this.Text = "Кредитный калькулятор";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_type.ResumeLayout(false);
            this.groupBox_type.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_payment_graphic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_type;
        private System.Windows.Forms.RadioButton radioButton_annuit_type;
        private System.Windows.Forms.RadioButton radioButton_diff_type;
        private System.Windows.Forms.DataGridView dataGridView_payment_graphic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_overpayment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_sum;
        private System.Windows.Forms.TextBox textBox_term;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_interest_rate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_start_evaluate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Month;
        private System.Windows.Forms.DataGridViewTextBoxColumn Balance_owed;
        private System.Windows.Forms.DataGridViewTextBoxColumn Payment_amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Interest_rate_part;
        private System.Windows.Forms.DataGridViewTextBoxColumn Debt_part;
        private System.Windows.Forms.DataGridViewTextBoxColumn Balance_owed_end_period;
    }
}

