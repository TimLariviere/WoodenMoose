﻿namespace Microsoft.Marketplace.Storefront.Contracts.V2
{
    public class ImageItem
    {
        public ImageType ImageType { get; set; }
        public string Url { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public string BackgroundColor { get; set; }
        public string ForegroundColor { get; set; }
        public string Caption { get; set; }
        public string ImagePositionInfo { get; set; }
    }
}
