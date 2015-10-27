using System;
using System.Drawing;
using Foundation;
using UIKit;
using BingImages.Shared;
using SDWebImage;


namespace BingImages
{
    public partial class RootViewController : UIViewController, IUICollectionViewDataSource
    {
        public RootViewController(IntPtr handle)
            : base(handle)
        {
        }

        public override void DidReceiveMemoryWarning()
        {
            // Releases the view if it doesn't have a superview.
            base.DidReceiveMemoryWarning();

            // Release any cached data, images, etc that aren't in use.
        }

        #region View lifecycle

        BingHelper helper;
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            helper = new BingHelper();

            ImageCollection.WeakDataSource = this;
            // Perform any additional setup after loading the view, typically from a nib.
        }

        #endregion

        async partial void ButtonQuery_TouchUpInside(UIButton sender)
        {

            LabelResults.ResignFirstResponder();

            ProgressBar.StartAnimating();
            await helper.QueryBingImages(TextFieldSearch.Text);
            LabelResults.Text = "Search Results: " + helper.Images.Count;

            ImageCollection.ReloadData();

            ProgressBar.StopAnimating();
        }

        public UICollectionViewCell GetCell(UICollectionView collectionView, NSIndexPath indexPath)
        {
            var cell = (ResultImageCell)collectionView.DequeueReusableCell("image", indexPath);

            // handles the downloading the image and caching
            var result = helper.Images[indexPath.Row];
            cell.TheImage.SetImage(
                url: new NSUrl(result.MediaUrl));

            return cell;
        }

        public nint GetItemsCount(UICollectionView collectionView, nint section)
        {
            return (nint)helper.Images.Count;
        }

        public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
        {
            base.PrepareForSegue(segue, sender);

            var vc = (SecondViewController)segue.DestinationViewController;

            var cell = (ResultImageCell)sender;

            vc.TheImage = cell.TheImage.Image;
        }
    }
}