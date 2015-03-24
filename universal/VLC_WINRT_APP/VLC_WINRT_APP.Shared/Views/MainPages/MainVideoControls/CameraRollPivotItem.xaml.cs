﻿using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using VLC_WINRT_APP.Model.Video;

namespace VLC_WINRT_APP.Views.MainPages.MainVideoControls
{
    public sealed partial class CameraRollPivotItem : Page
    {
        public CameraRollPivotItem()
        {
            this.InitializeComponent();
        }
        private void VideosWrapGrid_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            TemplateSizer.ComputeCompactVideo(sender as ItemsWrapGrid, CameraRollListView.ActualWidth);
        }
    }
}
