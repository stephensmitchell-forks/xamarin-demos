#region Copyright Syncfusion Inc. 2001 - 2018
// Copyright Syncfusion Inc. 2001 - 2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using Syncfusion.SfDataGrid;
using Syncfusion.SfDataGrid.XForms;
using Xamarin.Forms;

namespace SampleBrowser.SfDataGrid
{
    [Xamarin.Forms.Internals.Preserve(AllMembers = true)]
    public class Red : DataGridStyle
	{
		public Red ()
		{
		}
        //public override Color GetHeaderBorderColor()
        //{
        //    return Color.Red;
        //}
        public override Color GetHeaderBackgroundColor()
        {
            return Color.FromRgb (190, 93, 93);
        }

        public override Color GetHeaderForegroundColor()
        {
            return Color.FromRgb(255, 255, 255);
        }

        public override Color GetSelectionBackgroundColor ()
		{
			return Color.FromRgb (229, 115, 115);
		}

		public override Color GetSelectionForegroundColor ()
		{
			return Color.FromRgb (255, 255, 255);
		}

		public override Color GetCaptionSummaryRowBackgroundColor ()
		{
			return Color.FromRgb (224, 224, 224);
		}

		public override Color GetCaptionSummaryRowForegroundColor ()
		{
			return Color.FromRgb (51, 51, 51);
		}

		public override Color GetBorderColor ()
		{
			return Color.FromRgb (180, 180, 180);
		}

		public override Color GetAlternatingRowBackgroundColor()
		{
			return Color.FromRgb (255, 235, 237);
		}

        public override Color GetRecordForegroundColor()
        {
            return Color.FromRgb(0, 0, 0);
        }

        public override GridLinesVisibility GetGridLinesVisibility()
        {
            return GridLinesVisibility.Horizontal;
        }
    }
}

