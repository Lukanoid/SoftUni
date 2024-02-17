using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace MailClient
{
    public class MailBox
    {
		private int capacity;
        private List<Mail> inbox;
        private List<Mail> archive;

        public MailBox(int capacity)
        {
            this.Capacity = capacity;
            inbox = new List<Mail>();
            archive = new List<Mail>();
        }
        public int Capacity
		{
            get
            {
                return capacity;
            }
            set
            {
                capacity = value;
            }
		}

        public List<Mail> Inbox
        {
            get
            {
                return inbox;
            }
            set
            {
                inbox = value;
            }
        }

        public List<Mail> Archive
        {
            get
            {
                return archive;
            }
            set
            {
                archive = value;
            }
        }

        public void IncomingMail(Mail mail)
        {
            if (Capacity > Inbox.Count)
            {
                Inbox.Add(mail);
            }
            
        }

        public bool DeleteMail(string sender)
        {
            Mail mail = Inbox.FirstOrDefault(m => m.Sender == sender);
            if (mail == null)
            {
                return false;
            }

            return Inbox.Remove(mail);
        }

        public int ArchiveInboxMessages()
        {
            Archive.AddRange(Inbox);
            int movedMails = Inbox.Count;
            Inbox = new List<Mail>();

            return movedMails;
        }

        public string GetLongestMessage()
        {
            Mail longestMail = null;

            foreach (var mail in Inbox)
            {
                if (longestMail == null)
                {
                    longestMail = mail;
                }

                if (mail.Body.Length > longestMail.Body.Length)
                {
                    longestMail = mail;
                }
            }

            return longestMail.ToString();
        }

        public string InboxView()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Inbox:");
            foreach (var mail in Inbox)
            {
                sb.AppendLine(mail.ToString());
            }
            return sb.ToString().Trim();
        }
    }
}