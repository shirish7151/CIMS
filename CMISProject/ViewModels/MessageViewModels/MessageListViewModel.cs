﻿using CMISProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CMISProject.ViewModels.MessageViewModels
{
    public class MessageListViewModel
    {
        //[Required]
        [Display(Name = "MessageType")]
        [UIHint("Message Type")]
        public MessageType MessageType { get; set; }

        //[Required]
        [Display(Name = "Message")]
        [UIHint("Enter Message")]
        [DataType(DataType.MultilineText)]
        [UIHint("Message")]
        public string Msg { get; set; }
    }
}