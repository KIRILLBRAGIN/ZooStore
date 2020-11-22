using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Зоомагазин
{
    public partial class FormFinance : Form
    {
        void ShowFinance()
        {
            listViewFinance.Items.Clear();
            foreach (FinanceSet financeSet in Program.zooDb.FinanceSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    //указываем необходимые поля
                    financeSet.Id.ToString(),
                    financeSet.Term.ToString(),
                    financeSet.Data.ToString(),
                    financeSet.Received.ToString(),
                    financeSet.Spent.ToString(),
                });
                item.Tag = financeSet;
                listViewFinance.Items.Add(item);
            }
        }

        public FormFinance()
        {
            InitializeComponent();
            ShowFinance();
        }

        private void FormFinance_Load(object sender, EventArgs e)
        {
            
        }



        private void textBoxReceived_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxReceived_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void textBoxSpent_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSpent_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                FinanceSet financeSet = new FinanceSet();
                financeSet.Term = comboBoxTerm.Text;
                financeSet.Data = dateTimePickerData.Value;
                financeSet.Received = Convert.ToInt32(textBoxReceived.Text);
                financeSet.Spent = Convert.ToInt32(textBoxSpent.Text);
                if (financeSet.Term == "" || financeSet.Data == null || financeSet.Received.ToString() == "" || financeSet.Spent.ToString() == "")
                {
                    throw new Exception("Данные не заполнены!");
                }

                Program.zooDb.FinanceSet.Add(financeSet);
                Program.zooDb.SaveChanges();
                ShowFinance();
            }
            catch (Exception ex) { MessageBox.Show("" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewFinance.SelectedItems.Count == 1)
                {
                    FinanceSet financeSet = listViewFinance.SelectedItems[0].Tag as FinanceSet;
                    financeSet.Term = comboBoxTerm.SelectedItem.ToString().Split('.')[0];
                    financeSet.Data = dateTimePickerData.Value;
                    financeSet.Received = Convert.ToInt32(textBoxReceived.Text);
                    financeSet.Spent = Convert.ToInt32(textBoxSpent.Text);
                    if (financeSet.Term == "" || financeSet.Data == null || financeSet.Received.ToString() == "" || financeSet.Spent.ToString() == "")
                    {
                        throw new Exception("Данные не заполнены!");
                    }
                    Program.zooDb.SaveChanges();
                    ShowFinance();
                }
                else
                {
                    comboBoxTerm.Text = "";
                    dateTimePickerData.Text = "";
                    textBoxReceived.Text = "";
                    textBoxSpent.Text = "";
                }
            }
            catch (Exception ex) { MessageBox.Show("" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewFinance.SelectedItems.Count == 1)
                {
                    FinanceSet financeSet = listViewFinance.SelectedItems[0].Tag as FinanceSet;
                    Program.zooDb.FinanceSet.Remove(financeSet);
                    Program.zooDb.SaveChanges();
                    ShowFinance();
                }
                comboBoxTerm.Text = "";
                dateTimePickerData.Text = "";
                textBoxReceived.Text = "";
                textBoxSpent.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listViewFinance_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewFinance.SelectedItems.Count == 1)
            {
                FinanceSet financeSet = listViewFinance.SelectedItems[0].Tag as FinanceSet;
                comboBoxTerm.SelectedIndex = comboBoxTerm.FindString(financeSet.Id.ToString());
                comboBoxTerm.Text = financeSet.Term.ToString();
                dateTimePickerData.Text = financeSet.Data.ToString();
                textBoxReceived.Text = financeSet.Received.ToString();
                textBoxSpent.Text = financeSet.Spent.ToString();
            }
            else
            {
                comboBoxTerm.SelectedItem = null;
                dateTimePickerData.Text = "";
                textBoxReceived.Text = "";
                textBoxSpent.Text = "";
            }
        }

        private void textBoxSpent_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
