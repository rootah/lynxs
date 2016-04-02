using System;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraLayout;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using lynxs.classes;
using lynxs.forms;
using MongoDB.Bson;

namespace lynxs.controls
{
    public partial class peoples : DevExpress.XtraEditors.XtraUserControl
    {
        public peoples()
        {
            InitializeComponent();
            gridsInit();
        }

        private void gridsInit()
        {
            studentView.Columns.AddVisible("name");
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
        }

        private void stdGridFill(string groupno)
        {
            var stable = db_actions.stdlist(groupno);
            realTimeStudents.DataSource = stable;
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

        private async void studentView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                var id = studentView.GetRowCellValue(studentView.FocusedRowHandle, "_id").ToString();
                var detail = await db_actions.stdDetail(id);
                var x = detail["contacts"].AsBsonDocument;
                
                infoheader.Text = (string)detail["fullname"];
                phonemain.Text = (string) x["phonemain"];
                phoneadd.Text = (string) x["phoneadd"];
            }
            catch
            { }
        }
    }
}
