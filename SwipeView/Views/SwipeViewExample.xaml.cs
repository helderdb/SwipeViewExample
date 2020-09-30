using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace SwipeView.Views
{
    public partial class SwipeViewExample : ContentPage
    {
        private bool _isExpanded = false;

        public SwipeViewExample()
        {
            InitializeComponent();
        }

        void OnSwipedUp(System.Object sender, Xamarin.Forms.SwipedEventArgs e)
        {
            if (!_isExpanded)
            {
                SwipeView.TranslateTo(0, 0, 200, Easing.Linear);
                _isExpanded = true;
            }
        }

        void OnSwipedDown(System.Object sender, Xamarin.Forms.SwipedEventArgs e)
        {
            if (_isExpanded)
            {
                SwipeView.TranslateTo(0, 400, 200, Easing.Linear);
                _isExpanded = false;
            }
        }
    }
}