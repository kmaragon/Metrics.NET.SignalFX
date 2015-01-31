﻿
using System.IO;

namespace Metrics.SignalFx.Helpers
{
    public interface IWebRequestor
    {
        Stream GetWriteStream(int contentLength);

        Stream Send();
    }
}
