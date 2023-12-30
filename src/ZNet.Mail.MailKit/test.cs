using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZNet.Net.Mail
{
    internal class TestCls
    {
        public void Test()
        {
            MailKit.Net.Imap.IImapClient client = null;
            //client.GetFolders()


            var folder = client.GetFolder(MailKit.SpecialFolder.All);
            foreach (var message in folder)
            {
                
            }
        }
    }
}
