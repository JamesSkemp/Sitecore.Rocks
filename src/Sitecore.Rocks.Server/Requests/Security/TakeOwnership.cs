// � 2015-2016 Sitecore Corporation A/S. All rights reserved.

using System;
using Sitecore.Configuration;
using Sitecore.Diagnostics;

namespace Sitecore.Rocks.Server.Requests.Security
{
    public class TakeOwnership
    {
        [NotNull]
        public string Execute([NotNull] string databaseName, [NotNull] string itemList)
        {
            Assert.ArgumentNotNull(databaseName, nameof(databaseName));
            Assert.ArgumentNotNull(itemList, nameof(itemList));

            var database = Factory.GetDatabase(databaseName);
            if (database == null)
            {
                throw new InvalidOperationException("Database not found");
            }

            var list = itemList.Split('|');
            foreach (var id in list)
            {
                var item = database.GetItem(id);
                if (item == null)
                {
                    continue;
                }

                item.Editing.BeginEdit();
                item[FieldIDs.Owner] = Context.User.GetDomainName();
                item.Editing.EndEdit();
            }

            return string.Empty;
        }
    }
}
