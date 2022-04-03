using System;
using System.IO;
using System.Windows.Forms;

namespace Ziskin_1
{
    public partial class Form1 : Form
    {
        double sum;
        int term;
        double interest_rate;

        string file_name = "results_2";

         

        public Form1()
        {
            InitializeComponent();

            if (File.Exists(file_name))
            {
                using (StreamReader sw = new StreamReader(file_name))
                {
                    string file = sw.ReadToEnd();
                    string[] lines = file.Split(';');
                    if (lines.Length == 3)
                    {
                        textBox_sum.Text = lines[0];
                        textBox_term.Text = lines[1];
                        textBox_interest_rate.Text = lines[2];
                    }
                }
            }
        }

        private void button_start_evaluate_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox_sum.Text.Replace('.', ','), out sum) || sum <= 0)
            {
                MessageBox.Show("Сумма введена неверно");
                return;
            }
            if (!int.TryParse(textBox_term.Text, out term) || term <= 0)
            {
                MessageBox.Show("Срок задан неверно");
                return;
            }
            if (!double.TryParse(textBox_interest_rate.Text.Replace('.', ','), out interest_rate) || interest_rate <= 0)
            {
                MessageBox.Show("Процентная ставка задана неверно!");
                return;
            }

            using (StreamWriter sw = File.CreateText(file_name))
            {
                sw.Write(string.Join(";", sum.ToString(), term.ToString(), interest_rate.ToString()));
            }

            Evaluate();
        }

        public void Evaluate()
        {
            dataGridView_payment_graphic.Rows.Clear();
            dataGridView_payment_graphic.Refresh();

            double P = interest_rate / 100 / 12;
            var current_sum = sum;
            var sum_after_interest_rate_added = sum;
            double profit = 0;

            for (int month_num = 1; month_num <= term; month_num++)
            {
                var current_deposit_interest = current_sum * P;
                sum_after_interest_rate_added = current_sum + current_deposit_interest;
                profit += current_deposit_interest;

                dataGridView_payment_graphic.Rows.Add(month_num,
                    CurrencyFormat(current_sum),
                    CurrencyFormat(current_deposit_interest),
                    CurrencyFormat(sum_after_interest_rate_added));

                current_sum = sum_after_interest_rate_added;

                //int indexer = dataGridView_payment_graphic.Rows.Add();
                //dataGridView_payment_graphic.Rows[indexer].Cells["Month"].Value = 199;
            }

            textBox_profit.Text = CurrencyFormat(profit);
            textBox_final_sum.Text = CurrencyFormat(profit + sum);
        }

        string CurrencyFormat(object obj)
        {
            return String.Format("{0:C}", obj);
        }


    }
}
