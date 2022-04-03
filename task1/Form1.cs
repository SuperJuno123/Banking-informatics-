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

        string file_name = "results";

         

        public Form1()
        {
            InitializeComponent();

            if (File.Exists(file_name))
            {
                using (StreamReader sw = new StreamReader(file_name))
                {
                    string file = sw.ReadToEnd();
                    string[] lines = file.Split(';');
                    if (lines.Length == 4)
                    {
                        textBox_sum.Text = lines[0];
                        textBox_term.Text = lines[1];
                        textBox_interest_rate.Text = lines[2];
                        if (lines[3] == "annuity")
                        {
                            radioButton_annuit_type.Checked = true;
                            radioButton_annuit_type.Refresh();
                        }
                        else
                        {
                            radioButton_diff_type.Checked = true;
                            radioButton_diff_type.Refresh();
                        }
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
                sw.Write(string.Join(";", sum.ToString(), term.ToString(), interest_rate.ToString(),
                    radioButton_annuit_type.Checked ? "annuity" : "differentiated"));
            }

            textBox_overpayment.Text = "рыба";

            if (radioButton_annuit_type.Checked)
            {
                AnnuityPayment();
            }
            else
            {
                DifferentiatedPayment();
            }
        }

        public void AnnuityPayment()
        {
            dataGridView_payment_graphic.Rows.Clear();
            dataGridView_payment_graphic.Refresh();

            double P = interest_rate / 100 / 12;
            double payment = sum * (P + P / (Math.Pow(1 + P, term) - 1));
            double current_sum = sum;

            for (int month_num = 1; month_num <= term; month_num++)
            {
                var interest_rate_part = current_sum * P;
                var debt_part = payment - interest_rate_part;
                var sum_after_payment = current_sum - debt_part;

                dataGridView_payment_graphic.Rows.Add(month_num,
                    CurrencyFormat(current_sum),
                    CurrencyFormat(payment),
                    CurrencyFormat(interest_rate_part),
                    CurrencyFormat(debt_part),
                    CurrencyFormat(sum_after_payment));

                current_sum = sum_after_payment;

                //int indexer = dataGridView_payment_graphic.Rows.Add();
                //dataGridView_payment_graphic.Rows[indexer].Cells["Month"].Value = 199;
            }

            textBox_overpayment.Text = CurrencyFormat((payment * term) - sum);

        }

        string CurrencyFormat(object obj)
        {
            return String.Format("{0:C}", obj);
        }

        public void DifferentiatedPayment()
        {
            dataGridView_payment_graphic.Rows.Clear();
            dataGridView_payment_graphic.Refresh();

            double P = interest_rate / 100 / 12;
            var debt_part = sum / term;
            double current_payment;
            double current_sum = sum;
            double payments = 0;
            double sum_after_payment;

            for (int month_num = 1; month_num <= term; month_num++)
            {
                var interest_rate_part = current_sum * P;
                current_payment = interest_rate_part + debt_part;
                payments += current_payment;
                if (current_sum >= current_payment)
                {
                    sum_after_payment  = current_sum - debt_part;
                }
                else
                {
                    sum_after_payment = 0;
                }
                dataGridView_payment_graphic.Rows.Add(month_num,
                    CurrencyFormat(current_sum),
                    CurrencyFormat(current_payment),
                    CurrencyFormat(interest_rate_part),
                    CurrencyFormat(debt_part),
                    CurrencyFormat(sum_after_payment));

                current_sum = sum_after_payment;

                //int indexer = dataGridView_payment_graphic.Rows.Add();
                //dataGridView_payment_graphic.Rows[indexer].Cells["Month"].Value = 199;
            }

            textBox_overpayment.Text = CurrencyFormat(payments - sum);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
