using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Practice
{
    public class EmployeeForm : Form
    {
        Label lblEmpId, lblEmpName, lblDesignation, lblDOJ, lblSalary, lblDeptNo;
        TextBox txtEmpId, txtEmpName, txtDesignation, txtDOJ, txtSalary, txtDeptNo;
        Button btnInsert, btnFind, btnClear, btnUpdate, btnDelete, btnClose, btnUpdateDB;
        DataGridView dataGridView1;

        DataTable dt = new DataTable();

        public EmployeeForm()
        {
            this.Text = "GVOperationWithDataset";
            this.Size = new Size(750, 350);

            InitializeControls();
            CreateTable();
        }

        void InitializeControls()
        {
            lblEmpId = new Label() { Text = "Enter EmpId", Location = new Point(20, 20) };
            lblEmpName = new Label() { Text = "Enter EmpName", Location = new Point(20, 50) };
            lblDesignation = new Label() { Text = "Enter Designation", Location = new Point(20, 80) };
            lblDOJ = new Label() { Text = "Emp DOJ", Location = new Point(20, 110) };
            lblSalary = new Label() { Text = "Enter Salary", Location = new Point(20, 140) };
            lblDeptNo = new Label() { Text = "Emp DeptNo", Location = new Point(20, 170) };

            txtEmpId = new TextBox() { Location = new Point(150, 20) };
            txtEmpName = new TextBox() { Location = new Point(150, 50) };
            txtDesignation = new TextBox() { Location = new Point(150, 80) };
            txtDOJ = new TextBox() { Location = new Point(150, 110) };
            txtSalary = new TextBox() { Location = new Point(150, 140) };
            txtDeptNo = new TextBox() { Location = new Point(150, 170) };

            btnInsert = new Button() { Text = "Insert", Location = new Point(20, 210) };
            btnFind = new Button() { Text = "Find", Location = new Point(100, 210) };
            btnClear = new Button() { Text = "Clear", Location = new Point(180, 210) };

            btnUpdate = new Button() { Text = "Update", Location = new Point(20, 240) };
            btnDelete = new Button() { Text = "Delete", Location = new Point(100, 240) };
            btnClose = new Button() { Text = "Close", Location = new Point(180, 240) };

            btnUpdateDB = new Button()
            {
                Text = "Update into Database",
                Location = new Point(300, 240),
                Width = 180
            };

            dataGridView1 = new DataGridView()
            {
                Location = new Point(300, 20),
                Size = new Size(400, 200)
            };

            this.Controls.AddRange(new Control[]
            {
                lblEmpId,lblEmpName,lblDesignation,lblDOJ,lblSalary,lblDeptNo,
                txtEmpId,txtEmpName,txtDesignation,txtDOJ,txtSalary,txtDeptNo,
                btnInsert,btnFind,btnClear,btnUpdate,btnDelete,btnClose,btnUpdateDB,
                dataGridView1
            });

            btnInsert.Click += BtnInsert_Click;
            btnClear.Click += BtnClear_Click;
            btnDelete.Click += BtnDelete_Click;
            btnUpdate.Click += BtnUpdate_Click;
            btnFind.Click += BtnFind_Click;
            btnClose.Click += BtnClose_Click;
        }

        void CreateTable()
        {
            dt.Columns.Add("EmpId");
            dt.Columns.Add("EmpName");
            dt.Columns.Add("Designation");
            dt.Columns.Add("DOJ");
            dt.Columns.Add("Salary");
            dt.Columns.Add("DeptNo");

            dataGridView1.DataSource = dt;
        }

        void BtnInsert_Click(object sender, EventArgs e)
        {
            dt.Rows.Add(txtEmpId.Text, txtEmpName.Text, txtDesignation.Text,
                        txtDOJ.Text, txtSalary.Text, txtDeptNo.Text);
        }

        void BtnClear_Click(object sender, EventArgs e)
        {
            txtEmpId.Clear();
            txtEmpName.Clear();
            txtDesignation.Clear();
            txtDOJ.Clear();
            txtSalary.Clear();
            txtDeptNo.Clear();
        }

        void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
        }

        void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int i = dataGridView1.CurrentRow.Index;
                dt.Rows[i][0] = txtEmpId.Text;
                dt.Rows[i][1] = txtEmpName.Text;
                dt.Rows[i][2] = txtDesignation.Text;
                dt.Rows[i][3] = txtDOJ.Text;
                dt.Rows[i][4] = txtSalary.Text;
                dt.Rows[i][5] = txtDeptNo.Text;
            }
        }

        void BtnFind_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value?.ToString() == txtEmpId.Text)
                {
                    row.Selected = true;
                    break;
                }
            }
        }

        void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new EmployeeForm());
        }
    }
}