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
            int days = Convert.ToInt32(tbDays);
            double sum = Convert.ToDouble(tbSum);
            double sum_viplat;
            double stavka;
            double nakopitelno = 0;

            if ((days < 366) & (sum < 500001))
            {
                for (int i = 1; i <= days; i++)
                {
                    if (i == days)
                    {
                        stavka = Convert.ToDouble(Console.ReadLine());
                        nakopitelno = nakopitelno + (sum * stavka);
                        sum_viplat = sum + nakopitelno;
                        if (nakopitelno > 30000)
                        {
                            MessageBox.Show("Превышено количество дней для займа");
                        }
                        else
                        {
                            MessageBox.Show("День " + i + " Ставка " + stavka + " Сумма выплат " + sum_viplat + "\n"
                                            + "Общая сумма выплаты " + sum_viplat + "\n"
                                            + "Сумма процентов " + nakopitelno + "\n"
                                            + "Эффективная процентная ставка в день " + (nakopitelno / sum / days));
                        }
                    }
                    stavka = Convert.ToDouble(Console.ReadLine());
                    nakopitelno = nakopitelno + (sum * stavka);
                    sum_viplat = sum + nakopitelno;
                    MessageBox.Show("День " + i + " Ставка " + stavka + " Сумма выплат " + sum_viplat);
                }
            }
            else
            {
                MessageBox.Show("Превышено количество дней для займа");
            }
        }
    }
}
