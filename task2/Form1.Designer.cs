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
            this.dataGridView_payment_graphic = new System.Windows.Forms.DataGridView();
            this.Month = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Balance_owed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Payment_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Balance_owed_end_period = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_profit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_sum = new System.Windows.Forms.TextBox();
            this.textBox_term = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_interest_rate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button_start_evaluate = new System.Windows.Forms.Button();
            this.textBox_final_sum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_payment_graphic)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_payment_graphic
            // 
            this.dataGridView_payment_graphic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_payment_graphic.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Month,
            this.Balance_owed,
            this.Payment_amount,
            this.Balance_owed_end_period});
            this.dataGridView_payment_graphic.Location = new System.Drawing.Point(278, 30);
            this.dataGridView_payment_graphic.Name = "dataGridView_payment_graphic";
            this.dataGridView_payment_graphic.RowHeadersVisible = false;
            this.dataGridView_payment_graphic.RowHeadersWidth = 40;
            this.dataGridView_payment_graphic.RowTemplate.Height = 24;
            this.dataGridView_payment_graphic.Size = new System.Drawing.Size(528, 331);
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
            this.Balance_owed.HeaderText = "Состояние счёта";
            this.Balance_owed.MinimumWidth = 6;
            this.Balance_owed.Name = "Balance_owed";
            this.Balance_owed.Width = 111;
            // 
            // Payment_amount
            // 
            this.Payment_amount.HeaderText = "Проценты за период";
            this.Payment_amount.MinimumWidth = 6;
            this.Payment_amount.Name = "Payment_amount";
            this.Payment_amount.Width = 112;
            // 
            // Balance_owed_end_period
            // 
            this.Balance_owed_end_period.HeaderText = "Состояние счёта на конец периода";
            this.Balance_owed_end_period.MinimumWidth = 6;
            this.Balance_owed_end_period.Name = "Balance_owed_end_period";
            this.Balance_owed_end_period.Width = 111;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(275, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 399);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Общая сумма процентов:";
            // 
            // textBox_profit
            // 
            this.textBox_profit.Location = new System.Drawing.Point(284, 434);
            this.textBox_profit.Multiline = true;
            this.textBox_profit.Name = "textBox_profit";
            this.textBox_profit.ReadOnly = true;
            this.textBox_profit.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_profit.Size = new System.Drawing.Size(173, 48);
            this.textBox_profit.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Сумма депозита:";
            // 
            // textBox_sum
            // 
            this.textBox_sum.Location = new System.Drawing.Point(20, 129);
            this.textBox_sum.Multiline = true;
            this.textBox_sum.Name = "textBox_sum";
            this.textBox_sum.Size = new System.Drawing.Size(210, 38);
            this.textBox_sum.TabIndex = 6;
            // 
            // textBox_term
            // 
            this.textBox_term.Location = new System.Drawing.Point(20, 226);
            this.textBox_term.Multiline = true;
            this.textBox_term.Name = "textBox_term";
            this.textBox_term.Size = new System.Drawing.Size(210, 38);
            this.textBox_term.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Срок, в месяцах:";
            // 
            // textBox_interest_rate
            // 
            this.textBox_interest_rate.Location = new System.Drawing.Point(20, 326);
            this.textBox_interest_rate.Multiline = true;
            this.textBox_interest_rate.Name = "textBox_interest_rate";
            this.textBox_interest_rate.Size = new System.Drawing.Size(210, 38);
            this.textBox_interest_rate.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(217, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Процентная ставка, % годовых:";
            // 
            // button_start_evaluate
            // 
            this.button_start_evaluate.Location = new System.Drawing.Point(17, 435);
            this.button_start_evaluate.Name = "button_start_evaluate";
            this.button_start_evaluate.Size = new System.Drawing.Size(210, 47);
            this.button_start_evaluate.TabIndex = 11;
            this.button_start_evaluate.Text = "Рассчитать";
            this.button_start_evaluate.UseVisualStyleBackColor = true;
            this.button_start_evaluate.Click += new System.EventHandler(this.button_start_evaluate_Click);
            // 
            // textBox_final_sum
            // 
            this.textBox_final_sum.Location = new System.Drawing.Point(522, 434);
            this.textBox_final_sum.Multiline = true;
            this.textBox_final_sum.Name = "textBox_final_sum";
            this.textBox_final_sum.ReadOnly = true;
            this.textBox_final_sum.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_final_sum.Size = new System.Drawing.Size(173, 48);
            this.textBox_final_sum.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(519, 399);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Общая сумма к выдаче:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 508);
            this.Controls.Add(this.textBox_final_sum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button_start_evaluate);
            this.Controls.Add(this.textBox_interest_rate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_term);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_sum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_profit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_payment_graphic);
            this.Name = "Form1";
            this.Text = "Депозитный калькулятор";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_payment_graphic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView_payment_graphic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_profit;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Balance_owed_end_period;
        private System.Windows.Forms.TextBox textBox_final_sum;
        private System.Windows.Forms.Label label6;
    }
}

