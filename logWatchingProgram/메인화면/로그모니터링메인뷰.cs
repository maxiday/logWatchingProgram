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
    public partial class 로그모니터링메인뷰 : Form
    {
        public 상단메뉴모델 상단메뉴 { get; set; }
        public 하단메뉴모델 하단메뉴 { get; set; }
        public 로그모니터링메인뷰()
        {
            InitializeComponent();
            InitializeProperty();
            InitializeEvent();
        }

        private void InitializeEvent()
        {
            //이벤트 만들기
            상단메뉴.열기.Click += 열기_Click;
            상단메뉴.강조.Click += 강조_Click;
        }
        
        private void 강조_Click(object sender, EventArgs e)
        {
            try
            {
                강조뷰 newform2 = new 강조뷰();
                newform2.ShowDialog(this);
            }
            catch (Exception)
            {

            }
        }

        private void 열기_Click(object sender, EventArgs e)
        {
            //파일열기후 dgv띄우기
            모니터링화면 화면 = new 모니터링화면();
            화면.TopLevel = false;
            화면.Show();
            하단메뉴.홈화면.Controls.Add(화면);

        }

        private void InitializeProperty()
        {
            //속성초기화하기
            상단메뉴 = new 상단메뉴모델();
            상단메뉴.열기 = this.btnOpen;
            상단메뉴.강조 = this.btnHighlighting;

            하단메뉴 = new 하단메뉴모델();
            하단메뉴.콘텐츠뷰어 = this.콘텐츠뷰어;
            하단메뉴.홈화면 = this.tabPageHome;

        }
    }
}
