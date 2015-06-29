namespace DevExpress.Web.Demos {
    public class FullScreenViewerModel {
        public FullScreenViewerModel() { }
        public FullScreenViewerModel(string url, int deviceHeight, int deviceWidth) {
            DeviceHeight = deviceHeight;
            DeviceWidth = deviceWidth;
            Url = url;
        }
        const int DocumentFrameSize = 40;

        public int DeviceHeight { get; set; }
        public int DeviceWidth { get; set; }
        public string Url { get; set; }

        public bool IsFullScreen { get { return DeviceHeight == 0 && DeviceWidth == 0; } }
        public int FullDeviceHeight { get { return DeviceHeight + DocumentFrameSize; } }
        public int FullDeviceWidth { get { return DeviceWidth + DocumentFrameSize; } }
        public string ImageUrlQrCode { get { return FullScreenModeUtils.GetImageUrlQrCode(Url); } }
    }
}
