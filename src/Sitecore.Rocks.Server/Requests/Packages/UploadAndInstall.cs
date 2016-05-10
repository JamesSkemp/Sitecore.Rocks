// � 2015-2016 Sitecore Corporation A/S. All rights reserved.

using System.IO;
using Sitecore.Configuration;
using Sitecore.IO;
using Sitecore.Rocks.Server.Packages;

namespace Sitecore.Rocks.Server.Requests.Packages
{
    public class UploadAndInstall
    {
        [NotNull]
        public string Execute([NotNull] string data, [NotNull] string fileName)
        {
            var packagePath = Upload(data, fileName);

            var installer = new PackageInstaller(packagePath);

            installer.Install();

            return string.Empty;
        }

        [NotNull]
        private static string Upload([NotNull] string data, [NotNull] string fileName)
        {
            var packagePath = FileUtil.MapPath(Settings.PackagePath);

            var targetFileName = Path.Combine(packagePath, fileName);
            var index = 1;
            while (File.Exists(targetFileName))
            {
                targetFileName = Path.Combine(packagePath, Path.GetFileNameWithoutExtension(fileName) + " (" + index + ")" + Path.GetExtension(fileName));
                index++;
            }

            using (var source = new MemoryStream(System.Convert.FromBase64String(data)))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(targetFileName) ?? string.Empty);

                using (var target = new FileStream(targetFileName, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    FileUtil.CopyStream(source, target);
                }
            }

            return targetFileName;
        }
    }
}
