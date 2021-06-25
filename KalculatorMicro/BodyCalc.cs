//Шагиахметова Зиля 220П
//Калькулятор микрокредита
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
    public partial class FormCalc : Form
    {
        public FormCalc()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int days = Convert.ToInt32(tbDays.Text);
            double sum = Convert.ToDouble(tbSum.Text);
            string stavka_all = tbProcent.Text;
            double sum_viplat;
            double nakopitelno = 0;

            string[] rez = new string[days];
            string[] stavka_string = stavka_all.Split(new char[] { ';' });
            double[] stavka = new double[days];

            int val = 0;
            foreach (string s in stavka_string)
            {
                stavka[val] = Convert.ToDouble(s);
                val++;
            }

            if ((days < 366) & (sum < 500001))
            {
                for (int i = 1; i <= days; i++)
                {
                    if (i == days)
                    {
                        nakopitelno = nakopitelno + (sum * stavka[i - 1]);
                        sum_viplat = sum + nakopitelno;
                        rez[i - 1] = Convert.ToString(("День " + i + " Ставка " + stavka[i - 1] + " Сумма выплат " + sum_viplat));
                        if (nakopitelno > 30000)
                        {
                            MessageBox.Show("Превышено количество дней для займа");
                        }
                        else
                        {
                            lboxRez.Items.AddRange(rez);
                            MessageBox.Show("Общая сумма выплаты " + sum_viplat + "\n"
                                            + "Сумма процентов " + nakopitelno + "\n"
                                            + "Эффективная процентная ставка в день " + (nakopitelno / sum / days));
                        }
                    }
                    else
                    {
                        nakopitelno = nakopitelno + (sum * stavka[i - 1]);
                        sum_viplat = sum + nakopitelno;
                        rez[i - 1] = Convert.ToString(("День " + i + " Ставка " + stavka[i - 1] + " Сумма выплат " + sum_viplat));
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
