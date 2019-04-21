﻿namespace Gim.Domain.Helpers.Event
{
    using System.ComponentModel;
    using System.Runtime.CompilerServices;

    public abstract class ANotifyPropertyChangedModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;


        // This method is called by the Set accessor of each property.
        // The CallerMemberName attribute that is applied to the optional propertyName
        // parameter causes the property name of the caller to be substituted as an argument.
        protected void NotifyPropertyChanged( [ CallerMemberName ] string propertyName = "" )
        {
            PropertyChanged?.Invoke( this, new PropertyChangedEventArgs( propertyName ) );
        }
    }
}