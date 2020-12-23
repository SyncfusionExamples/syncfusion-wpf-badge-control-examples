using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Badge_without_BadgeContainer
{
    public class ViewModel
    {
        public List<MailItem> MailItems { get; set; }
        public ViewModel()
        {
            MailItems = new List<MailItem>();
            MailItems.Add(new MailItem()
            {
                ItemName = "Inbox",
                UnreadMessageount = 20
            });
            MailItems.Add(new MailItem()
            {
                ItemName = "Drafts",
                UnreadMessageount = null
            });
            MailItems.Add(new MailItem()
            {
                ItemName = "Sent Items",
                UnreadMessageount = 5
            });
            MailItems.Add(new MailItem()
            {
                ItemName = "Deleted Items",
                UnreadMessageount = null
            });
            MailItems.Add(new MailItem()
            {
                ItemName = "Junk Email",
                UnreadMessageount = null
            });
        }
    }
}
