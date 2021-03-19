﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace MVVMDoctolib.Model
{
    public abstract class AbstractModelWithNotification:INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;


        protected void RaisePropertyChange(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
