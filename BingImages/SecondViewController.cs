using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace BingImages
{
	partial class SecondViewController : UIViewController
	{
		public SecondViewController (IntPtr handle) : base (handle)
		{
		}


        //SecondControllerView Code
        public UIImage TheImage
        {
            get;
            set;
        }


        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);
            ImageTweet.Image = TheImage;
        }

        partial void ButtonTweet_TouchUpInside(UIButton sender)
        {
            var tweet = new Twitter.TWTweetComposeViewController();
            tweet.AddImage(TheImage);
            PresentViewControllerAsync(tweet, true);
        }
	}
}
