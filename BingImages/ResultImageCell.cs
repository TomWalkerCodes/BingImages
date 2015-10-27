using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace BingImages
{
	partial class ResultImageCell : UICollectionViewCell
	{
		public ResultImageCell (IntPtr handle) : base (handle)
		{
		}

        public UIImageView TheImage
        {
            get { return this.BingImage; }
        }
	}
}
