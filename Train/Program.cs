using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Train
{
    static class Program
    {
        /// <summary>
        /// 해당 응용 프로그램의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());

            Flag flag = new Flag();
            if (flag.LOGIN)
            {
                if (flag.ADMIN)
                {
                    Application.Run(new Admin()); // 관리자 화면
                }
                else Application.Run(new Main()); // Main.cs 메모리 할당
            }
        }
    }
}
