using System;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Show_Hijri
{


    public partial class frmShowHijri : Form
    {
        public frmShowHijri()
        {
            InitializeComponent();
        }

        DateTimeFormatInfo DTFormat = new CultureInfo("ar-sa", false).DateTimeFormat;

        private void frmShowHijri_Load(object sender, EventArgs e)
        {
            try
            {
                DTFormat.Calendar = new HijriCalendar();
                string myDate = "اليوم " + DateTime.Today.AddDays(0).Date.ToString("yyyy/MM/dd", DTFormat) + " هـ " + "شهر " + DateTime.Today.AddDays(0).Date.ToString("y", DTFormat);
                string HijriMonth = DateTime.Today.AddDays(0).Date.ToString("MM", DTFormat);
                if ((HijriMonth == "01") || (HijriMonth == "07") || (HijriMonth == "11") || (HijriMonth == "12"))
                    myDate += " - من الأشهر الحرم";
                lblHijriDate.Text = myDate;

                this.Width = lblHijriDate.Width + btnClose.Width;
                btnClose.Left = this.Width - btnClose.Width;

                int screenWidth = Screen.PrimaryScreen.Bounds.Width;
                int screenHeight = Screen.PrimaryScreen.Bounds.Height;
                int taskbarHeight = Screen.PrimaryScreen.Bounds.Bottom - Screen.PrimaryScreen.WorkingArea.Bottom;

                int xForm = screenWidth - this.Width;
                int yForm = screenHeight - (this.Height + taskbarHeight);

                this.Location = new Point(xForm, yForm);

                if (System.Diagnostics.Process.GetProcessesByName("Show_Hijri").Count() > 1)
                {
                    MessageBox.Show("لا حاجة الي تشغيل اكثر من نسخة من البرنامج");
                    Application.Exit();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }


        private bool mouseIsDown = false;
        private Point firstPoint;

        private void frmShowHijri_MouseDown(object sender, MouseEventArgs e)
        {
            firstPoint = e.Location;
            mouseIsDown = true;
        }

        private void frmShowHijri_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseIsDown)
            {
                // Get the difference between the two points
                int xDiff = firstPoint.X - e.Location.X;
                int yDiff = firstPoint.Y - e.Location.Y;

                // Set the new point
                int x = this.Location.X - xDiff;
                int y = this.Location.Y - yDiff;
                this.Location = new Point(x, y);
            }
        }

        private void frmShowHijri_MouseUp(object sender, MouseEventArgs e)
        {
            mouseIsDown = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
