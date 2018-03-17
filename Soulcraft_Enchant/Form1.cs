using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soulcraft_Enchant
{
    public partial class Form1 : Form
    {
        private readonly double[] pW =
        {
            0.95, 0.95, 0.95, 0.3, 0.27, 0.24, 0.21, 0.18, 0.15, 0.12, 0.09, 0.06, 0.03, 0.03, 0.01, 0.007, 0.004, 0.002, 0.0018, 0.0017
        };
        private readonly double[] pA =
        {
            0.95, 0.95, 0.95, 0.5, 0.4, 0.3, 0.25, 0.2, 0.18, 0.16, 0.14, 0.12, 0.1, 0.05, 0.03, 0.009, 0.008, 0.004, 0.0035, 0.0034
        };
        private readonly double[] pS =
        {
            0.06, 0.04, 0.02, 0.02
        };

        public Form1()
        {
            InitializeComponent();
        }

        public double Enchant(bool isWeap, int from, int to, double chance, double percentage)
        {
            double expected = 0;
            for (int i = from; i < to; i++)
            {
                expected += isWeap ? 1 / (chance + pW[i] * (percentage + 1)) : 1 / (chance + pA[i] * (percentage + 1));
            }
            return expected;
        }

        public void EnchantCall(bool isWeap = true, int from = 0, int to = 20, double chance = 0, double percentage = 0)
        {
            if (from < 15 && to < 15)
            {
                isNeeded.Text = (Math.Round(Enchant(isWeap, from, to, chance, percentage) * 1000) / 1000).ToString();
            }
            else if (from >= 15 && to >= 15)
            {
                risNeeded.Text = (Math.Round(Enchant(isWeap, from, to, chance, percentage) * 1000) / 1000).ToString();
            }
            else
            {
                isNeeded.Text = (Math.Round(Enchant(isWeap, from, 15, chance, percentage) * 1000) / 1000).ToString();
                risNeeded.Text = (Math.Round(Enchant(isWeap, 15, to, chance, percentage) * 1000) / 1000).ToString();
            }
        }

        public double Soulcraft(int from, int to, double chance, double percentage)
        {
            double expected = 0;
            for (int i = from; i < to; i++)
            {
                expected += 1 / (chance + pS[i] * (percentage + 1));
            }
            return expected;
        }

        public void SoulcraftCall(string from = "Advanced", string to = "Legend", double chance = 0, double percentage = 0)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            double chanceincrease = chanceIncrease.Text.Equals("") ? 0 : Double.Parse(chanceIncrease.Text) / 100;
            double percentage = hasEWBuff.Checked ? 0.2 : 0;

            if (doEnchanting.Checked)
            {
                EnchantCall(weapOrArmor.Text.Equals("Weapon"), (int)fromELvl.Value, (int)toELvl.Value, chanceincrease, percentage);
            }
        }

        private void doEnchanting_CheckedChanged(object sender, EventArgs e)
        {
            if (doEnchanting.Checked)
            {
                labelItemToEnchant.Show();
                labelFrom.Show();
                labelTo.Show();
                weapOrArmor.Show();
                fromELvl.Show();
                toELvl.Show();
            }
            else
            {
                labelItemToEnchant.Hide();
                labelFrom.Hide();
                labelTo.Hide();
                weapOrArmor.Hide();
                fromELvl.Hide();
                toELvl.Hide();
            }
        }
    }
}
