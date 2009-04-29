﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqToTwitter
{
    /// <summary>
    /// DIrect message elements contain a set of values that describe a message, as well as nested <sender> and <recipient> nodes.
    /// </summary>
    public class DirectMessage
    {
        public DirectMessageType Type { get; set; }

        //  <id>87864628</id>
        public int ID { get; set; }

        //  <sender_id>1234567</sender_id>
        public int SenderID { get; set; }

        //  <text>;)</text>
        public string Text { get; set; }

        //  <recipient_id>15411837</recipient_id>
        public int RecipientID { get; set; }

        //  <created_at>Tue Apr 07 16:47:25 +0000 2009</created_at>
        public DateTime CreatedAt { get; set; }

        //  <sender_screen_name>senderscreenname</sender_screen_name>
        public string SenderScreenName { get; set; }

        //  <recipient_screen_name>JoeMayo</recipient_screen_name>
        public string RecipientScreenName { get; set; }

        public User Sender { get; set; }

        public User Recipient { get; set; }
    }
}