using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMS.Models
{
    public class AppSettings
    {
        public string CronJobInterval { get; set; }
        public string Secret { get; set; }
        public string PublishDataImport { get; set; }
        public string PublishDataError { get; set; }
        public string ImportFilePath { get; set; }
        public string ImportErrorFilePath { get; set; }
        public string ImportProcessedFilePath { get; set; }
        public string PDImportName { get; set; }
        public string ImportStatusProcessed { get; set; }
        public string ImportStatusInProgress { get; set; }
        public string ImportStatusFailed { get; set; }
        public string ImportStatusPending { get; set; }
        public string ImportStatusStopped { get; set; }
        public string ImportStatusCanceled { get; set; }
        public string LoggerFilePath { get; set; }

        public bool IsHangfireJobEnable { get; set; }
        public bool IsActualPostEnable { get; set; }

    }
}
