using Syncfusion.Windows.Controls.Notification;
using Syncfusion.Windows.Shared;
using System.Windows;

namespace Badge_Features
{
    class ViewModel : NotificationObject
    {
        private HorizontalAlignment horizontalAlignment= HorizontalAlignment.Right;
        private VerticalAlignment verticalAlignment= VerticalAlignment.Top;
        private double content = 10;
        private BadgeAnimationType animationType = BadgeAnimationType.None;
        private BadgeShape shape= BadgeShape.Ellipse;
        private BadgeFill fill= BadgeFill.Success;
        private Visibility visibility = Visibility.Visible;
        private HorizontalAlignment horizontalContentAlignment= HorizontalAlignment.Center;
        private VerticalAlignment verticalContentAlignment= VerticalAlignment.Center;
        private BadgeAnchor horizontalAnchor= BadgeAnchor.Center;
        private BadgeAnchor verticalAnchor= BadgeAnchor.Center;

        public BadgeAnimationType AnimationType
        {
            get {
                return animationType;
            }
            set {
                animationType = value;
                this.RaisePropertyChanged(nameof(this.AnimationType));
            }
        }
        
        public BadgeAnchor HorizontalAnchor
        {
            get {
                return horizontalAnchor;
            }
            set {
                horizontalAnchor = value;
                this.RaisePropertyChanged(nameof(this.HorizontalAnchor));
            }
        }
        public BadgeAnchor VerticalAnchor
        {
            get {
                return verticalAnchor;
            }
            set {
                verticalAnchor = value;
                this.RaisePropertyChanged(nameof(this.VerticalAnchor));
            }
        }
        
         public HorizontalAlignment HorizontalContentAlignment
        {
            get {
                return horizontalContentAlignment;
            }
            set {
                horizontalContentAlignment = value;
                this.RaisePropertyChanged(nameof(this.HorizontalContentAlignment));
            }
        } 
        
        public VerticalAlignment VerticalContentAlignment
        {
            get {
                return verticalContentAlignment;
            }
            set {
                verticalContentAlignment = value;
                this.RaisePropertyChanged(nameof(this.VerticalContentAlignment));
            }
        } 
        
        public Visibility Visibility
        {
            get {
                return visibility;
            }
            set {
                visibility = value;
                this.RaisePropertyChanged(nameof(this.Visibility));
            }
        } 
         public BadgeFill Fill
        {
            get {
                return fill;
            }
            set {
                fill = value;
                this.RaisePropertyChanged(nameof(this.Fill));
            }
        } 
        
        public BadgeShape Shape
        {
            get {
                return shape;
            }
            set {
                shape = value;
                this.RaisePropertyChanged(nameof(this.Shape));
            }
        } 
        
        public double Content
        {
            get {
                return content;
            }
            set {
                content = value;
                this.RaisePropertyChanged(nameof(this.Content));
            }
        }
        
        public HorizontalAlignment HorizontalAlignment
        {
            get {
                return horizontalAlignment;
            }
            set {
                horizontalAlignment = value;
                this.RaisePropertyChanged(nameof(this.HorizontalAlignment));
            }
        }
         public VerticalAlignment VerticalAlignment
        {
            get {
                return verticalAlignment;
            }
            set {
                verticalAlignment = value;
                this.RaisePropertyChanged(nameof(this.VerticalAlignment));
            }
        }

    }
}
