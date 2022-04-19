using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace logWatchingProgram
{
    public partial class 모니터링화면 : Form
    {
        public 모니터링화면()
        {
            InitializeComponent();
            InitializeEvent();
        }

        private void InitializeEvent()
        {
            this.Load += 모니터링화면_Load;
        }

        private void 모니터링화면_Load(object sender, EventArgs e)
        {
            // 컬럼명과 컬럼헤더를 사용해 컬럼을 정의한다
            모니터링파일.Columns.Add("ID", "Id");
            모니터링파일.Columns.Add("ID2", "Id2");


            using (OpenFileDialog fd = new OpenFileDialog())
            {
                string filePath = string.Empty;
                string fileName = string.Empty;
                fd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); //바탕화면으로 기본폴더 설정
                if (fd.ShowDialog() == DialogResult.OK)
                {
                    filePath = fd.FileName; //전체 경로와 파일명 
                    fileName = fd.SafeFileName; //선택한 파일명은 fd.SafeFileName
                }

                // 데이타를 읽는 StreamReader
                StreamReader rd = new StreamReader(filePath);

                // 마지막이 될 때까지 루프
                while (!rd.EndOfStream)
                {
                    // 한 라인을 읽는다
                    string line = rd.ReadLine();

                    // 라인을 콤마로 분리하여 컬럼을 만든다
                    string[] cols = line.Split(',');
                    int i = 0;
                    i++;
                    // 한 라인에 각 컬럼의 데이타를 순서대로 넣는다
                    모니터링파일.Rows.Add(i.ToString(),cols[0]);
                }

                // StreamReader는 사용 후 반드시 닫는다
                rd.Close();

            }
        }

    }
}
