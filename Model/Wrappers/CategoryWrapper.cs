﻿using System.ComponentModel;

namespace MarketplaceApp.Model.Wrappers
{
    public class CategoryWrapper : INotifyPropertyChanged
    {

        private bool _isSelected;
        public string FormatName { get; set; }
        public string Icon { get; set; }
        public string RealName { get; set; }
        public bool IsSelected
        {
            get => _isSelected;

            set
            {
                if (_isSelected != value)
                {
                    _isSelected = value;
                    OnPropertyChanged(nameof(IsSelected));
                }
            }
        }



        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
