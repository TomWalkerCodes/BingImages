// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace BingImages
{
	[Register ("ResultImageCell")]
	partial class ResultImageCell
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIImageView BingImage { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (BingImage != null) {
				BingImage.Dispose ();
				BingImage = null;
			}
		}
	}
}
