using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace w03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Invalidate() 메소드에 의해 Paint() 이벤트가 발생하고 이벤트 매개변수로 전달되는 Graphics 클래스의 객체를 통해 새로운 내용을 화면에 출력
            panel1.Invalidate();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics; //컨트롤을 그리는데 사용할 Graphics 객체
            Random r = new Random();
            //생성된 난수 값에 해당하는 색상을 생성 
            Color c = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256));
            //사각형 영역(ClipRectangle 프로퍼티)을 단색의 c색상으로 채움
            g.FillRectangle(new SolidBrush(c), e.ClipRectangle);
        }

    }
}
