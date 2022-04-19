using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace logWatchingProgram
{
    public partial class 강조뷰 : Form
    {
        BindingSource bindingSource = new BindingSource();
        List<강조클래스> 강조내용 = new List<강조클래스>();


        public 작동버튼들 버튼들 { get; set; }
        public 강조뷰()
        {
            InitializeComponent();
            InitializeProperty();
            InitializeEvent();
        }

        private void InitializeEvent()
        {
            this.Load += 강조화면_Load;
            버튼들.추가.Click += 추가_Click;
            버튼들.삭제.Click += 삭제_Click;
        }

        private void 삭제_Click(object sender, EventArgs e)
        {
            if (강조내용.Count>0)
            {
                bindingSource.RemoveAt(dataGridView1.CurrentRow.Index);
            }
        }

        public class 강조클래스
        {
            public string 칼라 { get; set; }//get , set을 써주어야만 리스트 상태로 DataGridView에 바인딩 할 수가 있다.
            public string 내용 { get; set; }
            public string 글자색 { get; set; }
            public string 배경색 { get; set; }
            public bool 무시 { get; set; }
            public bool 전환 { get; set; }
            public bool 진하게 { get; set; }
            public bool 기울이게 { get; set; }
        }


        private void 강조화면_Load(object sender, EventArgs e)
        {
            bindingSource.DataSource = 강조내용;
            dataGridView1.DataSource = bindingSource;
            dataGridView1.Rows.Clear();
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.GridColor = Color.White;
            colorComboBox1.Items.Add("White");
            colorComboBox1.Items.Add("Red");
            colorComboBox1.Items.Add("Green");
            colorComboBox1.Items.Add("Blue");
            colorComboBox1.Items.Add("Yellow");
            colorComboBox1.Items.Add("Cyan");
            colorComboBox1.Items.Add("Magenta");
            colorComboBox1.Items.Add("DarkRed");
            colorComboBox1.Items.Add("DarkGreen");
            colorComboBox1.Items.Add("DarkBlue");
            colorComboBox1.Items.Add("DarkCyan");
            colorComboBox1.Items.Add("DarkMagenta");
            colorComboBox2.Items.Add("White");
            colorComboBox2.Items.Add("Red");
            colorComboBox2.Items.Add("Green");
            colorComboBox2.Items.Add("Blue");
            colorComboBox2.Items.Add("Yellow");
            colorComboBox2.Items.Add("Cyan");
            colorComboBox2.Items.Add("Magenta");
            colorComboBox2.Items.Add("DarkRed");
            colorComboBox2.Items.Add("DarkGreen");
            colorComboBox2.Items.Add("DarkBlue");
            colorComboBox2.Items.Add("DarkCyan");
            colorComboBox2.Items.Add("DarkMagenta");
            colorComboBox1.SelectedIndex = 3;
            colorComboBox2.SelectedIndex = 5;
            dataGridView1.Columns[0].Resizable = DataGridViewTriState.False;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView1.ReadOnly = true;
            dataGridView1.ColumnHeadersVisible = true;
        }

        private void 추가_Click(object sender, EventArgs e)
        {
            강조클래스 강조 = new 강조클래스();
            강조.칼라 = textBoxString.Text;
            강조.내용 = textBoxString.Text;
            강조.글자색 = colorComboBox1.Text;
            강조.배경색 = colorComboBox2.Text;
            강조.무시 = checkBoxIgnore.Checked;
            강조.전환 = checkBoxInvert.Checked;
            강조.진하게 = checkBoxBold.Checked;   
            강조.기울이게 = checkBoxItalic.Checked;
            bindingSource.Add(강조);
        }

        private void InitializeProperty()
        {
            //속성 초기화
            버튼들 = new 작동버튼들();
            버튼들.추가 = this.buttonAdd;
            버튼들.삭제 = this.buttonDel;
        }
    }
}
