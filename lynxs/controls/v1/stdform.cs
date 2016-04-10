using System;
using System.Drawing;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using lynxs.classes;
using MongoDB.Bson;

namespace lynxs.controls.v1
{
    public partial class stdform : XtraUserControl
    {
        public stdform()
        {
            InitializeComponent();
            groupFill();
            fakeGen();

            /*
             *      UNDONE add fakegen to another contacts (email, skype etc.)
             */
        }

        private void fakeGen()
        {
            fname.Text = Faker.Name.First();
            lname.Text = Faker.Name.Last();
            phonemain.Text = Faker.Phone.CellNumber();
            phoneadd.Text = Faker.Phone.CellNumber();
            stdid.Text = ObjectId.GenerateNewId().ToString();}
        private async void groupFill()
        {
            @group.Properties.Items.Clear();
            group.Properties.Items.AddRange(await dbActions.groupComboFill());
        }

        private void parentResize()

        {
            var parentForm = ParentForm;
            if (parentForm != null)
            {
                parentForm.ClientSize = new Size(mainlayout.Root.MinSize.Width, mainlayout.Root.MinSize.Height);
            }
        }

        private void addPhone_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            contactsGroup.BeginUpdate();
            var phonebox = new TextEdit();

            var phone = contactsGroup.AddItem();
            phone.TextLocation = Locations.Top;
            phone.Text = @"phone";
            phone.Control = phonebox;
            parentResize();

            contactsGroup.EndUpdate();
            
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            var parentForm = ParentForm;
            parentForm?.Close();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            var stdcontacts = new BsonDocument
            {
                {"phonemain", phonemain.Text},
                {"phoneadd", phoneadd.Text}
            };

            var stdoc = new BsonDocument
            {
                {"fname", fname.Text},
                {"lname", lname.Text },
                {"fullname", lname.Text + " " + fname.Text },
                {"groupno", @group.Text },
                {"contacts", stdcontacts }
            };

            dbActions.stdInsert(stdoc);
        }

        private void checkButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton1.Checked)
                groupFeeDate.Enabled = true;
            else groupFeeDate.Enabled = false;

        }
    }
}
