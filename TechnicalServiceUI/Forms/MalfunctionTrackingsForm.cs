using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Abstract;
using Business.DependencyResolvers.AutoFac;
using Entities.Concrete;

namespace TechnicalServiceUI.Forms
{
    public partial class MalfunctionTrackingsForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly ITrackingService _trackingService;
        public MalfunctionTrackingsForm()
        {
            InitializeComponent();
            _trackingService = InstanceFactory.GetInstance<ITrackingService>();
        }

        private void MalfunctionTrackingsForm_Load(object sender, EventArgs e)
        {
            GetAllMalfunctionTrackings();
        }

        private void GetAllMalfunctionTrackings()
        {
            gridControlMalfunctionTrackings.DataSource = _trackingService.GetAll().Data;
        }

        private void gridViewMalfunctionTracking_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtTrackingId.Text = gridViewMalfunctionTracking.GetFocusedRowCellValue("TrackingId").ToString();
            memoDescription.Text = gridViewMalfunctionTracking.GetFocusedRowCellValue("Description").ToString();
            deTrackingDate.Text = gridViewMalfunctionTracking.GetFocusedRowCellValue("Date").ToString();
            txtProductSeriesNumber.Text = gridViewMalfunctionTracking.GetFocusedRowCellValue("ProductSeriesNumber").ToString();

        }

        private void btnAddMalfunctionTracking_Click(object sender, EventArgs e)
        {
            var result = _trackingService.Add(new Tracking
            {
                ProductSeriesNumber = txtProductSeriesNumber.Text,
                Date = Convert.ToDateTime(deTrackingDate.Text),
                Description = memoDescription.Text
            });
           

            if (result.Success)
            {
                XtraMessageBox.Show(result.Message,"Adding a new Tracking Malfunction",MessageBoxButtons.OK,MessageBoxIcon.Information);
                GetAllMalfunctionTrackings();
            }
        }

        private void btnUpdateMalfunctionTracking_Click(object sender, EventArgs e)
        {
            var result = _trackingService.Update(new Tracking
            {
                TrackingId = Convert.ToInt32(txtTrackingId.Text),
                ProductSeriesNumber = txtProductSeriesNumber.Text,
                Date = Convert.ToDateTime(deTrackingDate.Text),
                Description = memoDescription.Text
            });

            if (result.Success)
            {
                XtraMessageBox.Show(result.Message, "Updating current Tracking Malfunction", MessageBoxButtons.OK, MessageBoxIcon.Question);
                GetAllMalfunctionTrackings();
            }
        }

        private void btnDeleteMalfunctionTracking_Click(object sender, EventArgs e)
        {
            var result = _trackingService.Delete(new Tracking
            {
                TrackingId = Convert.ToInt32(txtTrackingId.Text)
            });


            if (result.Success)
            {
                XtraMessageBox.Show(result.Message, "Deleting current Tracking Malfunction", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                GetAllMalfunctionTrackings();
            }
        }
    }
}