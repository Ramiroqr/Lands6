﻿namespace Lands.ViewModels
{
    using Lands.Models;
    using System;
    using System.Collections.ObjectModel;
    using System.Linq;

    class LandViewModel : BaseViewModel
    {
        #region Attributes
        private ObservableCollection<Border> borders;
        #endregion

        #region Properties
        public Land Land
        {
            get;
            set;
        }

        public ObservableCollection<Border> Borders
        {
            get { return this.borders; }
            set { SetValue(ref this.borders, value); }
        }
        #endregion

        #region Constructors
        public LandViewModel(Land land)
        {
            this.Land = land;
            this.LoadBorders();
        }

        #endregion

        #region Methods
        private void LoadBorders()
        {
            this.Borders = new ObservableCollection<Border>();
            foreach (var border in this.Land.Borders)
            {
                var Land = MainViewModel.GetInstance().LandsList.Where(
                        l => l.Alpha3Code == border).FirstOrDefault();

                if (Land != null)
                {
                    this.Borders.Add(new Border
                    {
                        Code = Land.Alpha3Code,
                        Name = Land.Name,
                    });
                }
            }
        }
        #endregion
    }
}
