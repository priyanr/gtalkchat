﻿using System;
using System.ComponentModel;

namespace Gchat.Data {
    public class Message : INotifyPropertyChanged {
        #region Public Properties

        private string from;
        public string From {
            get { return from; }
            set {
                if (value != from) {
                    from = value;
                    Changed("From");
                }
            }
        }

        private DateTime time;
        public DateTime Time {
            get { return time; }
            set {
                if (value != time) {
                    time = value;
                    Changed("Time");
                    Changed("PrettyTime");
                }
            }
        }

        private string type;
        public string Type {
            get { return type; }
            set {
                if (value != type) {
                    type = value;
                    Changed("Type");
                }
            }
        }

        private string body;
        public string Body {
            get { return body; }
            set {
                if (value != body) {
                    body = value;
                    Changed("Body");
                    Changed("Typing");
                }
            }
        }

        private bool otr;
        public bool OTR {
            get { return otr; }
            set {
                if (value != otr) {
                    otr = value;
                    Changed("OTR");
                }
            }
        }

        public bool Typing { get; set; }

        public bool Outbound { get; set; }

        public bool Offline { get; set; }

        #endregion

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        public void Changed(string property) {
            if (PropertyChanged != null) {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

        #endregion
    }
}