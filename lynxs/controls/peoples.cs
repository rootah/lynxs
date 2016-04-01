using lynxs.classes;

namespace lynxs.controls
{
    public partial class peoples : DevExpress.XtraEditors.XtraUserControl
    {
        public peoples()
        {
            InitializeComponent();
        }

        public async void groupFullFill()
        {
            var groupTable = await db_actions.groupList();
            
            realTimeGroup.DataSource = groupTable;
            groupView.PopulateColumns();
            
            groupView.FocusedRowHandle = groupView.GetVisibleRowHandle(0);
            stdFullGridFill();
        }
        public void stdFullGridFill()
        {
            var stdtable = db_actions.stdFullList();
            
            realTimeStudents.DataSource = stdtable;
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
            try
            {
                var selectedgroupno = groupView.GetRowCellValue(groupView.FocusedRowHandle, "num").ToString();
                if (selectedgroupno == "All")
                {
                    stdHeadLabel.Text = @"students All";
                    stdFullGridFill();
                }
                else
                {
                    stdHeadLabel.Text = @"students " + selectedgroupno;

                    stdGridFill(selectedgroupno);
                }
            }
            catch
            { return; }
            
        }
    }
}
