﻿using Alturos.Yolo.LearningImage.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Alturos.Yolo.LearningImage.Contract
{
    public interface IAnnotationPackageProvider
    {
        bool IsSyncing { get; set; }

        List<AnnotationPackage> GetPackages();
        AnnotationPackage DownloadPackage(AnnotationPackage package);
        Task SyncPackages(List<AnnotationPackage> packages);
        double GetSyncProgress();
    }
}
