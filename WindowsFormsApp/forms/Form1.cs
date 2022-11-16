using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace WindowsFormsApp
{
    public partial class MainForm : Form
    {
        Person Sviatski = new Person("Святский Алексей Николаевич", 0);
        Person Artuhov = new Person("Артюхов Александр Сергеевич", 0);
        Tree EnteredTree = new Tree();

        public MainForm()
        {
            InitializeComponent();
        }
        private void TreeInfoApplyButton_Click_1(object sender, EventArgs e)
        {
            if (TreeNameBox.Text == "" || TreeAgeBox.Text == "" || TreeTrunkLengthBox.Text == "" || TreeCrownVolubeBox.Text == "") MessageBox.Show(Constants.fieldsWarning, Constants.warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                EnteredTree = new Tree(TreeNameBox.Text, Convert.ToInt32(TreeAgeBox.Text), Convert.ToInt32(TreeTrunkLengthBox.Text), Convert.ToInt32(TreeCrownVolubeBox.Text));

                string procedureText = $"INSERT INTO EnteredTree(Name, Age, TrunkLength, CrownVolume) VALUES ('{TreeNameBox.Text}', {TreeAgeBox.Text}, {TreeTrunkLengthBox.Text}, {TreeCrownVolubeBox.Text})";
                using (SqlConnection connect = new SqlConnection(Constants.connectString))
                {
                    SqlCommand addTree = new SqlCommand(procedureText, connect);
                    SqlCommand clearWateringCountArtuhov = new SqlCommand(Constants.clearArtuhovWateringCount,connect);
                    SqlCommand clearWateringCountSviatski = new SqlCommand(Constants.clearSviatskiWateringCount, connect);

                    try
                    {
                        connect.Open();
                        addTree.ExecuteNonQuery();
                        clearWateringCountArtuhov.ExecuteNonQuery();
                        clearWateringCountSviatski.ExecuteNonQuery();
                    }
                    catch
                    {
                        MessageBox.Show(Constants.warningMessage, Constants.warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
                Sviatski.watering = 0;
                Artuhov.watering = 0;
                OutputTextBox.Text += EnteredTree.TreeGetInfo() + "\n" + "\n";
            }
        }
        private void ClearButton_Click(object sender, EventArgs e)
        {
            OutputTextBox.Text = "";
        }
        private void TreeGrowButton_Click(object sender, EventArgs e)
        {
            if (EnteredTree.name == default)
            {
                MessageBox.Show(Constants.applyTreeInfo,Constants.warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (SviatskiRadioButton.Checked)
                {
                    Sviatski.AddWateringCount();
                    EnteredTree.Grow();
                    using (SqlConnection connect1 = new SqlConnection(Constants.connectString))
                    {
                        SqlCommand updateTree = new SqlCommand(Constants.updateEnteredTree, connect1);
                        SqlCommand updatePersonWateringCount = new SqlCommand(Constants.updateSviatskiWateringCount, connect1);

                        try
                        {
                            connect1.Open();
                            updateTree.ExecuteNonQuery();
                            updatePersonWateringCount.ExecuteNonQuery();
                        }
                        catch
                        {
                            MessageBox.Show(Constants.warningMessage, Constants.warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        finally
                        {
                            connect1.Close();
                        }
                    }
                }
                else if (ArtuhovRadioButton.Checked)
                {
                    Artuhov.AddWateringCount();
                    EnteredTree.Grow();
                    using (SqlConnection connect1 = new SqlConnection(Constants.connectString))
                    {
                        SqlCommand updateTree = new SqlCommand(Constants.updateEnteredTree, connect1);
                        SqlCommand updatePersonWateringCount = new SqlCommand(Constants.updateArtuhovWateringCount, connect1);

                        try
                        {
                            connect1.Open();
                            updateTree.ExecuteNonQuery();
                            updatePersonWateringCount.ExecuteNonQuery();
                        }
                        catch
                        {
                            MessageBox.Show(Constants.warningMessage, Constants.warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        finally
                        {
                            connect1.Close();
                        }
                    }
                }

                OutputTextBox.Text += EnteredTree.TreeGetInfo() + "\n" + "\n" + Artuhov.PersonGetInfo() + "\n" + "\n" + Sviatski.PersonGetInfo() + "\n" + "\n";
            }
        }
        private void TreeAgeBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8) e.Handled = true;
        }

        private void TreeTrunkLengthBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8) e.Handled = true;
        }

        private void TreeCrownVolumeBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8) e.Handled = true;
        }
    }
}
