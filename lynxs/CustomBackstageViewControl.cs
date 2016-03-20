using System.ComponentModel;
using DevExpress.Utils.Drawing.Animation;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Ribbon.ViewInfo;

namespace lynxs {

    [ToolboxItem(true)]
    class CustomBackstageViewControl : BackstageViewControl {
    
        public CustomBackstageViewControl() : base() { }
        
        protected override BackstageViewInfo CreateViewInfo() {
            if (ShouldUseOffice2013ControlStyle)
                return new CustomOffice2013BackstageViewInfo(this);
            return new BackstageViewInfo(this);
        }

    }

    public class CustomOffice2013BackstageViewInfo : Office2013BackstageViewInfo {
      
        public CustomOffice2013BackstageViewInfo(BackstageViewControl control) : base(control) { }

        protected override void AddTransitionAnimation(BackstageViewTransitionAnimationInfo.Direction direction) {
            ClearTransitionAnimation();
            BackstageViewTransitionAnimationInfo info = new BackstageViewTransitionAnimationInfo(Control, direction, -LeftPaneBounds.Width, 0, 0, Control.Ribbon, Control, Control.Parent as IXtraAnimationListener);
            XtraAnimator.Current.AddAnimation(info);
        }
    }
}
