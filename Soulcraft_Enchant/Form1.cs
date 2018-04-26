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
        double grandTIS = 0;
        double grandTRIS = 0;

        public Form1()
        {
            //
            //Size: 367, 333
            //
            InitializeComponent();
            //
            // tooltips
            //
            toolTip1.SetToolTip(fromELvl, "Level from which IS will be used");
            toolTip1.SetToolTip(comboBoxFromSC, "Grade from wich IS will be used");
            toolTip1.SetToolTip(checkBoxhasEWBuff, "Adds 20% on baseprobability");
            toolTip1.SetToolTip(labelEmporiaBuff, "Adds 20% on baseprobability");
            toolTip1.SetToolTip(checkBoxDoEnchanting, "Enables Enchaning");
            toolTip1.SetToolTip(checkBoxDoSoulcraft, "Enables Soulcrafting");
            toolTip1.SetToolTip(labelEnchantEvent, "Multiplier from Enchant event (e.g 1, 1.5, 2)");
            toolTip1.SetToolTip(textBoxEnchantEvent, "Multiplier from Enchant event (e.g 1, 1.5, 2)");
            toolTip1.SetToolTip(labelChanceIncrease, "The percentage the enchantsuccessrate gets increased by");
            toolTip1.SetToolTip(labelChanceIncrease2, "The percentage the enchantsuccessrate gets increased by");
            toolTip1.SetToolTip(textBoxChanceIncrease, "The percentage the enchantsuccessrate gets increased by");
            toolTip1.SetToolTip(labelNumOfItems, "Number of items to enchant");
            toolTip1.SetToolTip(numberOfItems, "Number of items to enchant");
            toolTip1.SetToolTip(fromELvl, "The level the item currently has and IS/RIS will be used");
            toolTip1.SetToolTip(toELvl, "The level the item has after enchanting");
            toolTip1.SetToolTip(labelSuccessProbability, "The probability to have at least 1 success");
            toolTip1.SetToolTip(labelSuccessProbability2, "The probability to have at least 1 success");
            toolTip1.SetToolTip(textBoxSuccessProbability, "The probability to have at least 1 success");
        }

        public double Enchant(bool isWeap, int from, int to, double chance, double percentage, double success)
        {
            double expected = 0;
            if (success > 0 && success < 1)
            {
                for (int i = from; i < to; i++)
                {
                    expected += isWeap ? GetExpected(pW, i, chance, percentage, success) : GetExpected(pA, i, chance, percentage, success);
                }
            }
            else
            {
                for (int i = from; i < to; i++)
                {
                    expected += isWeap ? GetAvgExpected(pW, i, chance, percentage) : GetAvgExpected(pA, i, chance, percentage);
                }
            }
            return expected;
        }


        public void EnchantCall(out double isNeed, out double risNeed, bool isWeap = true, int from = 0, int to = 20, double chance = 0, double percentage = 0, double success = 0)
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
                isNeed = Enchant(isWeap, from, to, chance, percentage, success);
            }
            else if (from >= 15 && to > 15)
            {
                risNeed = Enchant(isWeap, from, to, chance, percentage, success);
            }
            else
            {
                isNeed = Enchant(isWeap, from, 15, chance, percentage, success);
                risNeed = Enchant(isWeap, 15, to, chance, percentage, success);
            }
        }

        public double Soulcraft(int from, int to, double chance, double percentage, double success)
        {
            double expected = 0;
            if (success > 0 && success < 1)
            {
                for (int i = from; i < to; i++)
                {
                    expected += GetExpected(pS, i, chance, percentage, success);
                }
            }
            else
            {
                for (int i = from; i < to; i++)
                {
                    expected += GetAvgExpected(pS, i, chance, percentage);
                }
            }
            return expected;
        }

        public void SoulcraftCall(out double isNeed, string from = "Advanced", string to = "Legend", double chance = 0, double percentage = 0, double success = 0)
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
            isNeed = Soulcraft(fromInt, toInt, chance, percentage, success);
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

        public double GetExpected(double[] arr, int index, double chance, double percentage, double success)
        {
            double expected = Math.Log(1 - success) / Math.Log(1 - GetChance(arr, index, chance, percentage));
            if (GetChance(arr, index, chance, percentage) == 1)
            {
                return 0;
            }
            return expected < 1 ? 1 : expected;
        }

        public double GetAvgExpected(double[] arr, int index, double chance, double percentage)
        {
            double expected = 1/ GetChance(arr, index, chance, percentage);
            if (expected <= 1)
            {
                return 0;
            }
            return expected;
        }

        public double GetChance(double[] arr, int index, double chance, double percentage)
        {
            double successrate = (chance + arr[index] * (percentage + 1));
            return successrate > 1 ? 1 : successrate;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //http://www.wolframalpha.com/input/?i=solve+for+k,+1-(1-p)%5Ek%3E%3Dm,+0%3Cm%3C1,+0%3Cp%3C1
            double chanceincrease = textBoxChanceIncrease.Text.Equals("") || Double.Parse(textBoxChanceIncrease.Text) <= 0 ? 0 : Double.Parse(textBoxChanceIncrease.Text) / 100;
            double percentage = (checkBoxhasEWBuff.Checked ? 0.2 : 0) + (textBoxEnchantEvent.Text.Equals("") || Double.Parse(textBoxEnchantEvent.Text) <= 1 ? 0 : Double.Parse(textBoxEnchantEvent.Text) - 1);
            double success = textBoxSuccessProbability.Text.Equals("") || Double.Parse(textBoxSuccessProbability.Text) <= 0 ? 0 : Double.Parse(textBoxSuccessProbability.Text) / 100;
            double totalISNeeded = 0;
            double totalRISNeeded = 0;
            double totalISSoulNeeded = 0;
            double isNeeded;
            double risNeeded;


            if (checkBoxDoEnchanting.Checked)
            {
                EnchantCall(out isNeeded, out risNeeded, comboBoxWeapOrArmor.Text.Equals("Weapon"), (int)fromELvl.Value, (int)toELvl.Value, chanceincrease, percentage, success);
                totalISNeeded += isNeeded * (int)numberOfItems.Value;
                totalRISNeeded += risNeeded * (int)numberOfItems.Value;
            }
            if (checkBoxDoSoulcraft.Checked)
            {
                SoulcraftCall(out isNeeded, comboBoxFromSC.Text, comboBoxToSC.Text, chanceincrease, percentage, success);
                totalISSoulNeeded += isNeeded * (int)numberOfItems.Value;
            }

            grandTIS += totalISNeeded + totalISSoulNeeded;
            grandTRIS += totalRISNeeded;

            labelIsNeeded.Text = (Math.Round(totalISNeeded * 1000) / 1000).ToString();
            labelRisNeeded.Text = (Math.Round(totalRISNeeded * 1000) / 1000).ToString();
            labelIsSoulNeeded.Text = (Math.Round(totalISSoulNeeded * 1000) / 1000).ToString();
            labelOutTotalIS.Text = (Math.Round(grandTIS * 1000) / 1000).ToString();
            labelOutTotalRIS.Text = (Math.Round(grandTRIS * 1000) / 1000).ToString();
        }

        private void doEnchanting_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDoEnchanting.Checked)
            {
                labelItemToEnchant.Show();
                labelFrom.Show();
                labelTo.Show();
                comboBoxWeapOrArmor.Show();
                fromELvl.Show();
                toELvl.Show();
            }
            else
            {
                labelItemToEnchant.Hide();
                labelFrom.Hide();
                labelTo.Hide();
                comboBoxWeapOrArmor.Hide();
                fromELvl.Hide();
                toELvl.Hide();
            }
        }

        private void doSoulcraft_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDoSoulcraft.Checked)
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

        private void buttonResetTotal_Click(object sender, EventArgs e)
        {
            labelOutTotalIS.Text = "0";
            labelOutTotalRIS.Text = "0";
            grandTIS = 0;
            grandTRIS = 0;
        }

        private void buttonViewSuccessrates_Click(object sender, EventArgs e)
        {
            string wProbs = "";
            string aProbs = "";
            string sProbs = "";
            double chanceincrease = textBoxChanceIncrease.Text.Equals("") || Double.Parse(textBoxChanceIncrease.Text) <= 0 ? 0 : Double.Parse(textBoxChanceIncrease.Text) / 100;
            double percentage = (checkBoxhasEWBuff.Checked ? 0.2 : 0) + (textBoxEnchantEvent.Text.Equals("") || Double.Parse(textBoxEnchantEvent.Text) <= 0 ? 0 : Double.Parse(textBoxEnchantEvent.Text) - 1);

            for (int i = 0; i < pW.Length; i++)
            {
                // wProbs += String.Format((GetChance(pW, i, chanceincrease, percentage) * 100).ToString(), "{##0.00}") + "%\n";
                wProbs += String.Format("{0:##0.00}", GetChance(pW, i, chanceincrease, percentage) * 100) + "%\n";
            }
            for (int i = 0; i < pA.Length; i++)
            {
                aProbs += String.Format("{0:##0.00}", GetChance(pA, i, chanceincrease, percentage) * 100) + "%\n";
            }
            for (int i = 0; i < pS.Length; i++)
            {
                sProbs += String.Format("{0:##0.00}", GetChance(pS, i, chanceincrease, percentage) * 100) + "%\n";
            }
            labelWeaponProbs.Text = wProbs;
            labelArmorProbs.Text = aProbs;
            labelSCProbs.Text = sProbs;
            tabControl.SelectTab(1);
        }
    }
}
