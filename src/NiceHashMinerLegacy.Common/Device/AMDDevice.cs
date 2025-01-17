﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NiceHashMinerLegacy.Common.Device
{
    public class AMDDevice : BaseDevice, IGpuDevice
    {
        public AMDDevice(BaseDevice bd, int iPCIeBusID, ulong gpuRam, string codename, string infSection, int openCLPlatformID = -1) : base(bd)
        {
            PCIeBusID = iPCIeBusID;
            GpuRam = gpuRam;
            Codename = codename;
            InfSection = infSection;
            OpenCLPlatformID = openCLPlatformID;
        }

        // TODO does it make sense to set static AMD driver version

        public int OpenCLPlatformID { get; }

        public int PCIeBusID { get; }
        public ulong GpuRam { get; }

        public string Codename { get; }
        public string InfSection { get; }
    }
}
