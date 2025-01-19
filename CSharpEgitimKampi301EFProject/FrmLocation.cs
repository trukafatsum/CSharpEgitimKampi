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
    public partial class FrmLocation : Form
    {
        public FrmLocation()
        {
            InitializeComponent();
        }
        
        EgitimKampiEfTravelDbEntities db = new EgitimKampiEfTravelDbEntities();

        private void btnList_Click(object sender, EventArgs e)
        {
            var values = db.Location.Select(x => new
            {
                x.LocationID,
                x.City,
                x.Country,
                x.Capacity,
                x.Price,
                x.DayNight,
                x.GuideID,
            }).ToList();
            dataGridView1.DataSource = values;
        }

        private void FrmLocation_Load(object sender, EventArgs e)
        {
            var values = db.Guide.Select(x => new
            {
                FullName= x.GuideName + " " + x.GuideSurname,
                x.GuideID,
            }).ToList();
            cmbGuides.DisplayMember = "FullName";
            cmbGuides.ValueMember = "GuideID";
            cmbGuides.DataSource = values;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Location location = new Location();
            location.Capacity = byte.Parse(numCapacity.Value.ToString());
            location.City = txtCity.Text;
            location.Country = txtCountry.Text;
            location.Price = decimal.Parse(txtPrice.Text);
            location.DayNight = txtDayNight.Text;
            location.GuideID = int.Parse(cmbGuides.SelectedValue.ToString());
            db.Location.Add(location);
            db.SaveChanges();
            MessageBox.Show("Ekleme işlemi başarılı");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            var deletedValue = db.Location.Find(id);
            db.Location.Remove(deletedValue);
            db.SaveChanges();
            MessageBox.Show("Silme işlemi başarılı");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            var updatedValue = db.Location.Find(id);
            updatedValue.Capacity = byte.Parse(numCapacity.Value.ToString());
            updatedValue.City = txtCity.Text;
            updatedValue.Country = txtCountry.Text;
            updatedValue.Price = decimal.Parse(txtPrice.Text);
            updatedValue.DayNight = txtDayNight.Text;
            updatedValue.GuideID = int.Parse(cmbGuides.SelectedValue.ToString());
            db.SaveChanges();
            MessageBox.Show("Güncelleme işlemi başarılı");
        }

        private void btnListID_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            var values = db.Location.Where(x => x.LocationID == id).Select(x => new
            {
                x.LocationID,
                x.City,
                x.Country,
                x.Capacity,
                x.Price,
                x.DayNight,
                x.GuideID,
            }).ToList();
            dataGridView1.DataSource = values;
        }
    }
}
