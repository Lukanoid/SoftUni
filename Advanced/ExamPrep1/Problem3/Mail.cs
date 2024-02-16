using System.Text;

namespace MailClient
{
    public class Mail
    {
		private string sender;
        private string receiver;
        private string body;

        public Mail(string sender, string receiver, string body)
        {
            this.Sender = sender;
            this.Receiver = receiver;
            this.Body = body;
        }
        public string Sender
		{
            get
            {
                return sender;
            }
            set
            {
                sender = value;
            }
		}

        public string Receiver
        {
            get
            {
                return receiver;
            }
            set
            {
                receiver = value;
            }
        }


        public string Body
        {
            get
            {
                return body;
            }
            set
            {
                body = value;
            }
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"From: {this.Sender} / To: {this.Receiver}");
            sb.AppendLine($"Message: {this.Body}");
            return sb.ToString().Trim();
        }
    }
}