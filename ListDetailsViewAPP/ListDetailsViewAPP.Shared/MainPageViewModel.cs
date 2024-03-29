﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ListDetailsViewAPP
{
    public class Email
    {
        public string From { get; set; }

        public string Subject { get; set; }

        public string Body { get; set; }
    }

    public class MainPageViewModel
    {
        public ObservableCollection<Email> Emails { get; set; }

        public MainPageViewModel()
        {
            var emails = new List<Email>
            {
                new Email { From = "Steve Johnson", Subject = "Lunch Tomorrow", Body = "Are you available for lunch tomorrow? A client would like to discuss a project with you." },
                new Email { From = "Becky Davidson", Subject = "Kids game", Body = "Don't forget the kids have their soccer game this Friday. We have to supply end of game snacks." },
                new Email { From = "OneDrive", Subject = "Check out your event recap", Body = "Your new album.\r\nYou uploaded some photos to your OneDrive and automatically created an album for you." },
                new Email { From = "Twitter", Subject = "Follow randomPerson, APersonYouMightKnow", Body = "Here are some people we think you might like to follow:\r\n.@randomPerson\r\nAPersonYouMightKnow" },
            };

            Emails = new ObservableCollection<Email>(emails);
        }
    }
}
