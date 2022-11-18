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
        private void bTreeInfoApply_Click_1(object sender, EventArgs e)
        {
            if (tbTreeName.Text == "" || tbTreeAge.Text == "" || tbTrunkLength.Text == "" || tbCrownVolube.Text == "") MessageBox.Show(Constants.fieldsWarning, Constants.warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                EnteredTree = new Tree(tbTreeName.Text, Convert.ToInt32(tbTreeAge.Text), Convert.ToInt32(tbTrunkLength.Text), Convert.ToInt32(tbCrownVolube.Text));

                string procedureText = $"INSERT INTO EnteredTree(Name, Age, TrunkLength, CrownVolume) VALUES ('{tbTreeName.Text}', {tbTreeAge.Text}, {tbTrunkLength.Text}, {tbCrownVolube.Text})";
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
                tbOutput.Text += EnteredTree.TreeGetInfo() + "\n" + "\n";
            }
        }
        private void bClear_Click(object sender, EventArgs e)
        {
            tbOutput.Text = "";
        }
        private void bTreeGrow_Click(object sender, EventArgs e)
        {
            if (EnteredTree.name == default)
            {
                MessageBox.Show(Constants.applyTreeInfo,Constants.warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (rbSviatski.Checked)
                {
                    Sviatski.AddWateringCount();
                    EnteredTree.Grow();
                    using (SqlConnection connect = new SqlConnection(Constants.connectString))
                    {
                        SqlCommand updateTree = new SqlCommand(Constants.updateEnteredTree, connect);
                        SqlCommand updatePersonWateringCount = new SqlCommand(Constants.updateSviatskiWateringCount, connect);

                        try
                        {
                            connect.Open();
                            updateTree.ExecuteNonQuery();
                            updatePersonWateringCount.ExecuteNonQuery();
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
                }
                else if (rbArtuhov.Checked)
                {
                    Artuhov.AddWateringCount();
                    EnteredTree.Grow();
                    using (SqlConnection connect = new SqlConnection(Constants.connectString))
                    {
                        SqlCommand updateTree = new SqlCommand(Constants.updateEnteredTree, connect);
                        SqlCommand updatePersonWateringCount = new SqlCommand(Constants.updateArtuhovWateringCount, connect);

                        try
                        {
                            connect.Open();
                            updateTree.ExecuteNonQuery();
                            updatePersonWateringCount.ExecuteNonQuery();
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
                }

                tbOutput.Text += EnteredTree.TreeGetInfo() + "\n" + "\n" + Artuhov.PersonGetInfo() + "\n" + "\n" + Sviatski.PersonGetInfo() + "\n" + "\n";
            }
        }
        private void tbTreeAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8) e.Handled = true;
        }

        private void tbTrunkLength_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8) e.Handled = true;
        }

        private void tbCrownVolume_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8) e.Handled = true;
        }
    }
}
