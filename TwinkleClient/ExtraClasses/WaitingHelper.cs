using DevExpress.XtraSplashScreen;
using TwinkleClient.BaseGUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwinkleClient.ExtraClasses
{
    internal sealed class WaitingHelper
    {
        private SplashScreenManager sm;

        public WaitingHelper(Control parentForm)
        {
            SplashFormProperties prop = new SplashFormProperties();
            prop.UseFadeInEffect = true;
            prop.UseFadeOutEffect = true;
            sm = new SplashScreenManager(typeof(WaitLoadingForm), prop);
        }

        public void Show()
        {
            sm.ShowWaitForm();
        }

        public void Hide()
        {
            sm.CloseWaitForm();
        }
        
    }
}
