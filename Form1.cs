using Kursovaya.ModelBD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursovaya
{
    public partial class Form1 : Form
    {
        ModelBD.Model1 connect = new ModelBD.Model1();
        public Form1()
        {
            InitializeComponent();
            connect.Sport.Load();
            dataGridView1.DataSource = connect.Sport.Local.ToBindingList();
        }

        private void addbd_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            DialogResult result = form.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                ModelBD.Sport cliadd = new Sport();
                cliadd.FirstName = form.textBox1.Text;
                cliadd.LastName = form.textBox2.Text;
                cliadd.HallName = form.textBox3.Text;
                cliadd.VadilityPeriod = form.textBox4.Text;
                cliadd.Price = form.textBox5.Text;

                connect.Sport.Add(cliadd);
                connect.SaveChanges();
                MessageBox.Show("Запись добавлена");


            }
        }

        private void editbutton_Click(object sender, EventArgs e)
        {
            Form2 formedit = new Form2();
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);

                Sport Clientedit = connect.Sport.Find(id);

                formedit.textBox1.Text = Clientedit.FirstName;
                formedit.textBox2.Text = Clientedit.LastName;
                formedit.textBox3.Text = Clientedit.HallName;
                formedit.textBox4.Text = Clientedit.VadilityPeriod;
                formedit.textBox5.Text = Clientedit.Price;


                DialogResult resultedit = formedit.ShowDialog(this);
                if (resultedit == DialogResult.OK)
                {
                    Clientedit.FirstName = formedit.textBox1.Text;
                    Clientedit.LastName = formedit.textBox2.Text;
                    Clientedit.HallName = formedit.textBox3.Text;
                    Clientedit.VadilityPeriod = formedit.textBox4.Text;
                    Clientedit.Price = formedit.textBox5.Text;
                    connect.SaveChanges();
                    MessageBox.Show("Запись обновлена");
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                if (converted == true)
                {
                    Sport Clientdel = connect.Sport.Find(id);
                    connect.Sport.Remove(Clientdel);
                    connect.SaveChanges();
                    string buff = Clientdel.FirstName;
                    MessageBox.Show("запись " + buff + " удалена");
                }

            }
            else
            {
                MessageBox.Show("Запись не выбрана!");
            }
        }
    }
}
