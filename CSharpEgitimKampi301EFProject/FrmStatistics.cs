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
    public partial class FrmStatistics : Form
    {
        public FrmStatistics()
        {
            InitializeComponent();
        }
        EgitimKampiEfTravelDbEntities db = new EgitimKampiEfTravelDbEntities();
        private void FrmStatistics_Load(object sender, EventArgs e)
        {
            lblLocationCount.Text = db.Location.Count().ToString();
            lblSumCapacity.Text = db.Location.Sum(x => x.Capacity).ToString();
            lblGuideCount.Text = db.Guide.Count().ToString();
            lblAvgCapacity.Text = ((decimal)db.Location.Average(x => x.Capacity)).ToString("F2");
            lblAvgLocationPrice.Text = ((decimal)db.Location.Average(x => x.Price)).ToString("F2") + '₺';

            int lastCountryId = db.Location.Max(x => x.LocationID);
            lblLastCountryName.Text = db.Location.Where(x => x.LocationID == lastCountryId).Select(x => x.Country).FirstOrDefault();

            lblCapadociaLocationCapacity.Text = db.Location.Where(x => x.City == "Kapadokya").Select(y => y.Capacity).FirstOrDefault().ToString();

            lblTurkiyeCapacityAvg.Text = db.Location.Where(x => x.Country == "Türkiye").Average(y => y.Capacity).ToString();

            var romeGuideId = db.Location.Where(x => x.City == "Roma").Select(y => y.GuideID).FirstOrDefault();
            lblRomeGuideName.Text = db.Guide.Where(x => x.GuideID == romeGuideId).Select(y => y.GuideName + " " + y.GuideSurname).FirstOrDefault().ToString();

            var maxCapacity = db.Location.Max(y => y.Capacity);
            lblMaxCapacityLocation.Text = db.Location.Where(x => x.Capacity == maxCapacity).Select(y => y.City).FirstOrDefault().ToString();

            var maxPrice = db.Location.Max(x => x.Price);
            lblMaxPriceLocation.Text = db.Location.Where(x => x.Price == maxPrice).Select(y => y.City).FirstOrDefault().ToString();

            var guideIdByNameAysegulCinar = db.Guide.Where(x=>x.GuideName == "Ayşegül" && x.GuideSurname == "Çınar").Select(y=>y.GuideID).FirstOrDefault();
            lblAysegulCinarTourCount.Text = db.Location.Where(x=> x.GuideID == guideIdByNameAysegulCinar).Count().ToString();
        }
    }
}
