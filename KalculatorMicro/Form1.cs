using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KalculatorMicro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int days = Convert.ToInt32(tbDays.Text);
            double sum = Convert.ToDouble(tbSum.Text);
            double sum_viplat;
            double stavka;
            double nakopitelno = 0;

            if ((days < 366) & (sum < 500001))
            {
                for (int i = 1; i <= days; i++)
                {
                    if (i == days)
                    {
                        stavka = Convert.ToDouble(tbProcent.Text);
                        nakopitelno = nakopitelno + (sum * stavka);
                        sum_viplat = sum + nakopitelno;
                        MessageBox.Show("День " + i + " Ставка " + stavka + " Сумма выплат " + sum_viplat);
                        if (nakopitelno > 30000)
                        {
                            MessageBox.Show("Превышено количество дней для займа");
                        }
                        else
                        {
                            MessageBox.Show("Общая сумма выплаты " + sum_viplat + "\n"
                                            + "Сумма процентов " + nakopitelno + "\n"
                                            + "Эффективная процентная ставка в день " + (nakopitelno / sum / days));
                        }
                    }
                    else
                    {
                        stavka = Convert.ToDouble(tbProcent.Text);
                        nakopitelno = nakopitelno + (sum * stavka);
                        sum_viplat = sum + nakopitelno;
                        MessageBox.Show("День " + i + " Ставка " + stavka + " Сумма выплат " + sum_viplat);
                    }
                }
            }
            else
            {
                MessageBox.Show("Превышено количество дней для займа или максимальная сумма");
            }
        }
    }
}
