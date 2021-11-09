using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudUpload.Cloud_Upload_Errors {

    public enum Errors {
        NoClientError = 100,
        NoClientEmail = 101,
        NoClientPassword = 102,
        OuputFileNull = 103,
        InvalidSettingVal = 104
    }
}
