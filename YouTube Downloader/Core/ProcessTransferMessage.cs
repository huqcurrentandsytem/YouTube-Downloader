﻿namespace YouTube.Downloader.Core
{
    using System.Collections.Generic;

    using YouTube.Downloader.ViewModels.Interfaces.Process;

    internal class ProcessTransferMessage
    {
        internal ProcessTransferMessage(ProcessTransferType processTransferType, IEnumerable<IProcessViewModel> processes)
        {
            ProcessTransferType = processTransferType;
            Processes = processes;
        }

        internal ProcessTransferType ProcessTransferType { get; }

        internal IEnumerable<IProcessViewModel> Processes { get; }
    }
}