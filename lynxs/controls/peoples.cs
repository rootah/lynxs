using System.Data;
using lynxs.classes;
using MongoDB.Bson;
using MongoDB.Driver;

namespace lynxs.controls
{
    public partial class peoples : DevExpress.XtraEditors.XtraUserControl
    {
        public peoples(){
            InitializeComponent();
        }

        private void stdFullGridFill()
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
        private void groupView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (groupView.GetFocusedRow() == null) return;
            var selectedgroupno = groupView.GetRowCellValue(groupView.FocusedRowHandle, "num").ToString();
            if (selectedgroupno == "All")
            {
                stdHeadLabel.Text = @"Students All";
                stdFullGridFill();}
            else
            {
                stdHeadLabel.Text = @"Students " + selectedgroupno;

                stdGridFill(selectedgroupno);
            }
        }
    }
}
