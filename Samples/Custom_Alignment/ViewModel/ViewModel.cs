using Syncfusion.Windows.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_Alignment
{
    class ViewModel : NotificationObject
    {

        private double horizontalCustomAlignment = 1.0;
        private double verticalCustomAlignment = 0.8;
        private double horizontalCustomAnchor = 1.0;
        private double verticalCustomAnchor = 0.5;

        public double HorizontalCustomAlignment
        {
            get
            {
                return horizontalCustomAlignment;
            }
            set
            {
                horizontalCustomAlignment = value;
                this.RaisePropertyChanged(nameof(this.HorizontalCustomAlignment));
            }
        }

        public double VerticalCustomAlignment
        {
            get
            {
                return verticalCustomAlignment;
            }
            set
            {
                verticalCustomAlignment = value;
                this.RaisePropertyChanged(nameof(this.VerticalCustomAlignment));
            }
        }
        
        public double HorizontalCustomAnchor
        {
            get
            {
                return horizontalCustomAnchor;
            }
            set
            {
                horizontalCustomAnchor = value;
                this.RaisePropertyChanged(nameof(this.HorizontalCustomAnchor));
            }
        }

        public double VerticalCustomAnchor
        {
            get
            {
                return verticalCustomAnchor;
            }
            set
            {
                verticalCustomAnchor = value;
                this.RaisePropertyChanged(nameof(this.VerticalCustomAnchor));
            }
        }
    }
}