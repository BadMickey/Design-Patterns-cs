﻿namespace FluentBuilder
{
    public class Email
    {
        public string To { get; set; }
        public string From { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }

        public override string ToString()
        {
            return ($"{To} - {From}\n {Subject}\n {Body}\n");
        }
    }
}
