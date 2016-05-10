// � 2015-2016 Sitecore Corporation A/S. All rights reserved.

using Sitecore.Rocks.Commands;
using Sitecore.Rocks.UI.StartPage.Commands;

namespace Sitecore.Rocks.UI.StartPage.Tabs.GetStarted.SitecoreRocks.LearnAboutSitecoreRocks
{
    [Command, StartPageCommand("Read: Sitecore Rocks Release Notes", StartPageLearnAboutSitecoreRocksGroup.Name, 1000)]
    public class OpenSitecoreRocksReleaseNotes : StartPageCommandBase
    {
        protected override void Execute()
        {
            AppHost.Browsers.Navigate(@"http://vsplugins.sitecore.net/Release-Notes.ashx");
        }
    }
}
