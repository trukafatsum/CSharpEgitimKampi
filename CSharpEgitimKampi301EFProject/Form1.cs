using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301EFProject
{
    public partial class Form1 : Form
    {
        EgitimKampiEfTravelDbEntities db = new EgitimKampiEfTravelDbEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            var values = db.Guide.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Guide guide = new Guide();
            guide.GuideName = txtName.Text;
            guide.GuideSurname = txtSurname.Text;
            db.Guide.Add(guide);
            db.SaveChanges();
            MessageBox.Show("Rehber başarıyla eklendi","Başarılı",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            var removeValue = db.Guide.Find(id);
            db.Guide.Remove(removeValue);
            db.SaveChanges();
            MessageBox.Show("Rehber başarıyla silindi","Başarılı",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            var updateValue = db.Guide.Find(id);
            updateValue.GuideName = txtName.Text;
            updateValue.GuideSurname= txtSurname.Text;
            db.SaveChanges();
            MessageBox.Show("Rehber başarıyla güncellendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnListID_Click(object sender, EventArgs e)
        {
            int id =int.Parse(txtID.Text);
            var values = db.Guide.Where(x => x.GuideID == id).ToList();
            dataGridView1.DataSource = values;
        }
    }
}
