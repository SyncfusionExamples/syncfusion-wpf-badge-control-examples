using Syncfusion.Windows.Shared;
using System.Security.RightsManagement;

namespace Content_CustomUI
{
    class ViewModel : NotificationObject
    {
        private double content= 100;

        public  double Content
        {
            get
            {
                return content;
            }
            set
            {
                content = value;
                this.RaisePropertyChanged(nameof(this.Content));
            }
        }
    }
}
