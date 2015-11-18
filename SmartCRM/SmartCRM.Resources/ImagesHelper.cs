namespace SmartCRM.Resources
{
    using System;
    using System.Drawing;
    using System.IO;

    using DevExpress.Utils;
    //TODO
    public class ImagesHelper
    {
        static ImagesHelper current;
        private Image errorIcon;
        private Image addIcon;
        private ImageCollection genderTypeImages;
        //static ImageCollection receiptTypeImages;
        //static ImageCollection ratingImages;
        //static ImageCollection ratingLargeImages;
        //static ImageCollection activeRents;
        //static ImageCollection columnHeaderImages;
        //static ImageCollection columnHeaderSmoothImages;
        //static ImageCollection barImages;
        //static ImageCollection folderIcons;
        //static Image aboutImage;

        public static ImagesHelper Current
        {
            get
            {
                if (current == null)
                {
                    current = new ImagesHelper();
                }

                return current;
            }
        }

        public Image ErrorIcon
        {
            get
            {
                if (this.errorIcon == null)
                {
                    Image image = Properties.Resource.Close_16x16;  // Image.FromFile("..\\..\\..\\SmartCRM.Resources\\Images\\Persons.png");
                    this.errorIcon = image;
                }

                return this.errorIcon;
            }
        }

        public Image AddIcon
        {
            get
            {
                if (this.addIcon == null)
                {
                    Image image = Properties.Resource.Add_16x16;
                    this.addIcon = image;
                }

                return this.addIcon;
            }
        }

        public ImageCollection GenderTypeImages
        {
            get
            {
                if (this.genderTypeImages == null)
                {
                    Image image = Properties.Resource.Persons;  // Image.FromFile("..\\..\\..\\SmartCRM.Resources\\Images\\Persons.png");
                    this.genderTypeImages = new ImageCollection();
                    this.genderTypeImages.ImageSize = new Size(16, 16);
                    this.genderTypeImages.TransparentColor = Color.Transparent;
                    this.genderTypeImages.AddImageStrip(image);
                }

                return this.genderTypeImages;
            }
        }
        //public ImageCollection ReceiptTypeImages
        //{
        //    get
        //    {
        //        if (ImagesHelper.receiptTypeImages == null)
        //            ImagesHelper.receiptTypeImages = DevExpress.Utils.Controls.ImageHelper.CreateImageCollectionFromResources("DevExpress.VideoRent.Resources.Images.ReceiptType.png", typeof(ImagesHelper).Assembly, new Size(16, 16));
        //        return ImagesHelper.receiptTypeImages;
        //    }
        //}
        //public ImageCollection RatingImages
        //{
        //    get
        //    {
        //        if (ratingImages == null)
        //            ratingImages = DevExpress.Utils.Controls.ImageHelper.CreateImageCollectionFromResources("DevExpress.VideoRent.Resources.Images.RatingsSmall.png", typeof(ImagesHelper).Assembly, new Size(38, 16));
        //        return ratingImages;
        //    }
        //}
        //public ImageCollection RatingLargeImages
        //{
        //    get
        //    {
        //        if (ratingLargeImages == null)
        //            ratingLargeImages = DevExpress.Utils.Controls.ImageHelper.CreateImageCollectionFromResources("DevExpress.VideoRent.Resources.Images.RatingsLarge.png", typeof(ImagesHelper).Assembly, new Size(250, 37));
        //        return ratingLargeImages;
        //    }
        //}
        //public ImageCollection ActiveRents
        //{
        //    get
        //    {
        //        if (activeRents == null)
        //            activeRents = DevExpress.Utils.Controls.ImageHelper.CreateImageCollectionFromResources("DevExpress.VideoRent.Resources.Images.ActiveRents.png", typeof(ImagesHelper).Assembly, new Size(16, 16));
        //        return activeRents;
        //    }
        //}
        //public ImageCollection BarImages
        //{
        //    get
        //    {
        //        if (ImagesHelper.barImages == null)
        //            ImagesHelper.barImages = DevExpress.Utils.Controls.ImageHelper.CreateImageCollectionFromResources("DevExpress.VideoRent.Resources.Images.BarImages16x16.png", typeof(DevExpress.VideoRent.Resources.ImagesHelper).Assembly, new System.Drawing.Size(16, 16));
        //        return ImagesHelper.barImages;
        //    }
        //}
        //public ImageCollection ColumnHeaderImages
        //{
        //    get
        //    {
        //        if (ImagesHelper.columnHeaderImages == null)
        //            ImagesHelper.columnHeaderImages = DevExpress.Utils.Controls.ImageHelper.CreateImageCollectionFromResources("DevExpress.VideoRent.Resources.Images.ColumnHeaderImages.png", typeof(DevExpress.VideoRent.Resources.ImagesHelper).Assembly, new System.Drawing.Size(13, 13));
        //        return ImagesHelper.columnHeaderImages;
        //    }
        //}
        //public ImageCollection ColumnHeaderSmoothImages
        //{
        //    get
        //    {
        //        if (ImagesHelper.columnHeaderSmoothImages == null)
        //            ImagesHelper.columnHeaderSmoothImages = DevExpress.Utils.Controls.ImageHelper.CreateImageCollectionFromResources("DevExpress.VideoRent.Resources.Images.ColumnHeaderSmoothImages.png", typeof(DevExpress.VideoRent.Resources.ImagesHelper).Assembly, new System.Drawing.Size(13, 13));
        //        return ImagesHelper.columnHeaderSmoothImages;
        //    }
        //}
        //public ImageCollection FolderIcons
        //{
        //    get
        //    {
        //        if (folderIcons == null)
        //            folderIcons = DevExpress.Utils.Controls.ImageHelper.CreateImageCollectionFromResources("DevExpress.VideoRent.Resources.Images.FolderIcons16x16.png", typeof(DevExpress.VideoRent.Resources.ImagesHelper).Assembly, new System.Drawing.Size(16, 16));
        //        return folderIcons;
        //    }
        //}
        //public Image AboutImage
        //{
        //    get
        //    {
        //        if (ImagesHelper.aboutImage == null)
        //            ImagesHelper.aboutImage = ResourceImageHelper.CreateImageFromResources("DevExpress.VideoRent.Resources.Images.About.png", typeof(DevExpress.VideoRent.Resources.ImagesHelper).Assembly);
        //        return ImagesHelper.aboutImage;
        //    }
        //}

        public static byte[] ImageToByteArray(Image photo)
        {
            if (photo == null)
            {
                return null;
            }

            return (byte[])new ImageConverter().ConvertTo(photo, typeof(byte[]));
        }

        public static Bitmap ByteArrayToImage(byte[] blob)
        {
            if (blob == null)
            {
                return null;
            }

            MemoryStream mStream = new MemoryStream();
            byte[] pData = blob;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
        }
    }
}
