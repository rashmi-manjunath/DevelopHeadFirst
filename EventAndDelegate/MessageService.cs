using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventAndDelegate
{
    class MessageService
    {
        public void OnVideoEncoded(object sender,VideoEventArgs e)
        {
            Console.WriteLine("MessageService : sending the messsage.." +e.Video.Title);
        }
    }
}
