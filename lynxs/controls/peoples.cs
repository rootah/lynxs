using System.Data;
using DevExpress.XtraGrid.Views.Base;
using lynxs.classes;
using MongoDB.Bson;
using MongoDB.Driver;

namespace lynxs.controls
{
    public partial class peoples : DevExpress.XtraEditors.XtraUserControl
    {
        public peoples()
        {
            InitializeComponent();
            
        }

        public void stdFullGridFill()
        {
            var stable = db_actions.stdFullList();
            
            realTimeStudents.DataSource = null;
            realTimeStudents.DataSource = stable;
            studentView.PopulateColumns();
        }

        private void stdGridFill(string groupno)
        {
            var stable = db_actions.stdlist(groupno);
            realTimeStudents.DataSource = null;
            realTimeStudents.DataSource = stable;
            studentView.PopulateColumns();
        }
        public void groupView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (groupView.GetFocusedRow() == null) return;
            var selectedgroupno = groupView.GetRowCellValue(groupView.FocusedRowHandle, "num").ToString();
            if (selectedgroupno == "All")
            {
                stdHeadLabel.Text = @"students All";
                stdFullGridFill();}
            else
            {
                stdHeadLabel.Text = @"students " + selectedgroupno;

                stdGridFill(selectedgroupno);
            }
        }
    }
}
