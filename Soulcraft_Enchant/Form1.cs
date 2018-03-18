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
            toolTip1.SetToolTip(fromELvl, "Level from which IS will be used");
            toolTip1.SetToolTip(comboBoxFromSC, "Grade from wich IS will be used");
            toolTip1.SetToolTip(hasEWBuff, "Adds 20% on baseprobability");
            toolTip1.SetToolTip(labelEmporiaBuff, "Adds 20% on baseprobability");
            toolTip1.SetToolTip(doEnchanting, "Enables Enchaning");
            toolTip1.SetToolTip(doSoulcraft, "Enables Soulcrafting");
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

        public void EnchantCall(out double isNeed, out double risNeed, bool isWeap = true, int from = 0, int to = 20, double chance = 0, double percentage = 0)
        {
            isNeed = 0;
            risNeed = 0;
            if (to < from)
            {
                int temp = to;
                to = from;
                from = temp;
            }

            if (from < 15 && to <= 15)
            {
                isNeed = Enchant(isWeap, from, to, chance, percentage);
            }
            else if (from >= 15 && to > 15)
            {
                risNeed = Enchant(isWeap, from, to, chance, percentage);
            }
            else
            {
                isNeed = Enchant(isWeap, from, 15, chance, percentage);
                risNeed = Enchant(isWeap, 15, to, chance, percentage);
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

        public void SoulcraftCall(out double isNeed, string from = "Advanced", string to = "Legend", double chance = 0, double percentage = 0)
        {
            int fromInt = GetGrade(from);
            int toInt = GetGrade(to);
            isNeed = 0;

            if (toInt < fromInt)
            {
                int temp = toInt;
                toInt = fromInt;
                fromInt = temp;
            }
            isNeed = Soulcraft(fromInt, toInt, chance, percentage);
        }

        public int GetGrade(string sGrade)
        {
            if (sGrade.Equals("Normal"))
            {
                return 0;
            }
            else if (sGrade.Equals("Advanced"))
            {
                return 1;
            }
            else if (sGrade.Equals("Special"))
            {
                return 2;
            }
            else if (sGrade.Equals("Artifact"))
            {
                return 3;
            }
            else if (sGrade.Equals("Legend"))
            {
                return 4;
            }
            else
            {
                return -1;
            }
        }

        public void getVarianceEnchant(out double varIS, out double varRIS, double expectIS, double expectRIS, bool isWeap, int from, int to, double chance, double percentage)
        {
            if (to < from)
            {
                int temp = to;
                to = from;
                from = temp;
            }
            varIS = 0;
            varRIS = 0;
            if (from < 15 && to <= 15)
            {
                for (int i = from; i < to; i++)
                {
                    varIS += isWeap ? ((1 / (chance + pW[i] * (percentage + 1)) - expectIS) * (1 / (chance + pW[i] * (percentage + 1)) - expectIS) * (chance + pW[i] * (percentage + 1))) 
                                    : ((1 / (chance + pA[i] * (percentage + 1)) - expectIS) * (1 / (chance + pA[i] * (percentage + 1)) - expectIS) * (chance + pA[i] * (percentage + 1)));
                }
            }
            else if (from >= 15 && to > 15)
            {
                for (int i = 15; i < to; i++)
                {
                    varRIS += isWeap ? ((1 / (chance + pW[i] * (percentage + 1)) - expectRIS) * (1 / (chance + pW[i] * (percentage + 1)) - expectRIS) * (chance + pW[i] * (percentage + 1))) 
                                     : ((1 / (chance + pA[i] * (percentage + 1)) - expectRIS) * (1 / (chance + pA[i] * (percentage + 1)) - expectRIS) * (chance + pA[i] * (percentage + 1)));
                }
            }
            else
            {
                for (int i = from; i < 15; i++)
                {
                    varIS += isWeap ? ((1 / (chance + pW[i] * (percentage + 1)) - expectIS) * (1 / (chance + pW[i] * (percentage + 1)) - expectIS) * (chance + pW[i] * (percentage + 1))) 
                                    : ((1 / (chance + pA[i] * (percentage + 1)) - expectIS) * (1 / (chance + pA[i] * (percentage + 1)) - expectIS) * (chance + pA[i] * (percentage + 1)));
                }
                for (int i = 15; i < to; i++)
                {
                    varRIS += isWeap ? ((1 / (chance + pW[i] * (percentage + 1)) - expectRIS) * (1 / (chance + pW[i] * (percentage + 1)) - expectRIS) * (chance + pW[i] * (percentage + 1))) 
                                     : ((1 / (chance + pA[i] * (percentage + 1)) - expectRIS) * (1 / (chance + pA[i] * (percentage + 1)) - expectRIS) * (chance + pA[i] * (percentage + 1)));
                }
            }

        }

        public void getVarianceSoul(out double var, double expect, int from, int to, double chance, double percentage)
        {
            if (to < from)
            {
                int temp = to;
                to = from;
                from = temp;
            }
            var = 0;
            for (int i = from; i < to; i++)
            {
                var += (1 / (chance + pS[i] * (percentage + 1) - expect)) * (1 / (chance + pS[i] * (percentage + 1) - expect)) * (chance + pS[i] * (percentage + 1));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double chanceincrease = chanceIncrease.Text.Equals("") ? 0 : Double.Parse(chanceIncrease.Text) / 100;
            double percentage = (hasEWBuff.Checked ? 0.2 : 0) + (textBoxEnchantEvent.Text.Equals("") ? 0 : Double.Parse(textBoxEnchantEvent.Text) / 100);
            double totalISNeeded = 0;
            double totalRISNeeded = 0;
            double totalISSoulNeeded = 0;
            double isNeeded;
            double risNeeded;
            double varianceIS = 0;
            double varianceRIS = 0;
            double varianceSoul = 0;


            if (doEnchanting.Checked)
            {
                EnchantCall(out isNeeded, out risNeeded, weapOrArmor.Text.Equals("Weapon"), (int)fromELvl.Value, (int)toELvl.Value, chanceincrease, percentage);
                getVarianceEnchant(out varianceIS, out varianceRIS, totalISNeeded, totalRISNeeded, true, (int)fromELvl.Value, (int)toELvl.Value, chanceincrease, percentage);
                totalISNeeded += isNeeded;
                totalRISNeeded += risNeeded;
            }
            if (doSoulcraft.Checked)
            {
                SoulcraftCall(out isNeeded, comboBoxFromSC.Text, comboBoxToSC.Text, chanceincrease, percentage);
                getVarianceSoul(out varianceSoul, totalISSoulNeeded, GetGrade(comboBoxFromSC.Text), GetGrade(comboBoxToSC.Text), chanceincrease, percentage);
                totalISSoulNeeded += isNeeded;
            }


            labelIsNeeded.Text = (Math.Round(totalISNeeded * 1000) / 1000).ToString();
            labelRisNeeded.Text = (Math.Round(totalRISNeeded * 1000) / 1000).ToString();
            labelIsSoulNeeded.Text = (Math.Round(totalISSoulNeeded * 1000) / 1000).ToString();
            outStandardDeviationIS.Text = (Math.Round(Math.Sqrt(varianceIS) * 1000) / 1000).ToString();
            outStandardDeviationRIS.Text = (Math.Round(Math.Sqrt(varianceRIS) * 1000) / 1000).ToString();
            outStandardDeviationSoul.Text = (Math.Round(Math.Sqrt(varianceSoul) * 1000) / 1000).ToString();
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

        private void doSoulcraft_CheckedChanged(object sender, EventArgs e)
        {
            if (doSoulcraft.Checked)
            {
                labelFromSC.Show();
                labelToSC.Show();
                comboBoxFromSC.Show();
                comboBoxToSC.Show();
            }
            else
            {
                labelFromSC.Hide();
                labelToSC.Hide();
                comboBoxFromSC.Hide();
                comboBoxToSC.Hide();
            }
        }
    }
}
