﻿using EngineeringToolsCV_1.Command;
using EngineeringToolsCV_1.Models;
using EngineeringToolsCV_1.Service;
using EngineeringToolsCV_1.Store;
using EngineeringToolsCV_1.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using System.Windows.Media;


namespace EngineeringToolsCV_1.ViewModels
{
    public class DashboardViewModel : ViewModelBase
    {
        private Brush setBackColor;
        private bool setEnable;
        private bool setEnableInfo;
        private bool setEnableBeruf;
        private bool setEnableBildung;
        private bool setEnableQualication;
        private bool setEnableMedia;
        private bool setEnableActivität;
        private bool setEnableHobby;
        private bool setEnableConfig;

        private Brush setVisibility;

        private Brush infoBackColor;
        private Brush infoForeGrounColor;

        private Brush berufForeGrounColor;
        private Brush berufBackColor;

        private Brush ausbildungBackColor;
        private Brush ausbildungForeColor;

        private Brush projektBackColor;
        private Brush projektForeColor;

        private Brush qualifikationBackColor;
        private Brush qualifikationForeColor;

        private Brush mediaBackColor;
        private Brush mediaForeColor;

        private Brush configBackColor;
        private Brush configForeColor;

        private Brush tätigkeitBackColor;
        private Brush tätigkeitForeColor;

        private Brush interesseBackColor;
        private Brush interesseForeColor;

        private NavigationBarViewModel navigationBar;
        private MStudentInformations _mStudent;
        public ICommand InfoCommand { get; set; }

        public ICommand BerufCommand{ get; set; }

        public DashboardViewModel(NavigationStore navigationStore, MStudentInformations mStudent)
        {
            this._mStudent = mStudent;
            this.executeInfoCommand(navigationStore);
            this.executeBerufCommand(navigationStore);
            this.init();
        }

        private void executeInfoCommand(NavigationStore navigationStore)
        {
            navigationBar = new NavigationBarViewModel("Home -> Dashboard -> Information");

            InfoCommand = new NavigateCommand<InformationViewModel>(
               new LayoutNavigationService<InformationViewModel>(navigationStore,
               () => new InformationViewModel(navigationStore,this._mStudent), navigationBar));
        }

        private void executeBerufCommand(NavigationStore navigationStore)
        {
            navigationBar = new NavigationBarViewModel("Home -> Dashboard -> Beruferfahrung");

            BerufCommand = new NavigateCommand<BerufViewModel>(
               new LayoutNavigationService<BerufViewModel>(navigationStore,
               () => new BerufViewModel(navigationStore), navigationBar));
        }

        private void init()
        {
            this.InfoBackColor = Brushes.RoyalBlue;
            this.InfoForeGroundColor = Brushes.AliceBlue;

            this.BerufForeGroundColor = Brushes.AliceBlue;
            this.BerufBackColor = Brushes.RoyalBlue;

            this.AusbildungBackColor = Brushes.RoyalBlue;
            this.AusbildungForeColor = Brushes.AliceBlue;

            this.MediaBackColor = Brushes.RoyalBlue;
            this.MediaForeColor = Brushes.AliceBlue;

            this.ProjektBackColor = Brushes.RoyalBlue;
            this.ProjektForeColor = Brushes.AliceBlue;

            this.QualifikationBackColor = Brushes.RoyalBlue;
            this.QualifikationForeColor = Brushes.AliceBlue;

            this.ConfigBackColor = Brushes.RoyalBlue;
            this.ConfigForeColor = Brushes.AliceBlue;

            this.TätigkeitBackColor = Brushes.RoyalBlue;
            this.TätigkeitForeColor = Brushes.AliceBlue;

            this.InteresseBackColor = Brushes.RoyalBlue;
            this.InteresseForeColor = Brushes.AliceBlue;

            this.SetEnableInfo = true;
            this.SetEnableBeruf = true;
            this.SetEnableBildung = true;
            this.SetEnableActivität = true;
            this.SetEnableHobby = true;
            this.SetEnableMedia = true;
            this.SetEnableConfig = true;
        }

        public Brush SetBackColor
        {
            get { return this.setBackColor; }
            set
            {
                if (this.setBackColor != value)
                {
                    this.setBackColor = value;
                    this.OnPropertyChanged(nameof(SetBackColor));
                }
            }
        }

        public bool SetEnableInfo
        {
            get { return this.setEnableInfo; }
            set
            {
                if (this.setEnableInfo != value)
                {
                    this.setEnableInfo = value;
                    this.OnPropertyChanged(nameof(setEnableInfo));
                }
            }
        }

        public bool SetEnableBeruf
        {
            get { return this.setEnableBeruf; }
            set
            {
                if (this.setEnableBeruf != value)
                {
                    this.setEnableBeruf = value;
                    this.OnPropertyChanged(nameof(SetEnableBeruf));
                }
            }
        }

        public bool SetEnableBildung
        {
            get { return this.setEnableBildung; }
            set
            {
                if (this.setEnableBildung != value)
                {
                    this.setEnableBildung = value;
                    this.OnPropertyChanged(nameof(SetEnableBildung));
                }
            }
        }

        public bool SetEnableQualication
        {
            get { return this.setEnableQualication; }
            set
            {
                if (this.setEnableQualication != value)
                {
                    this.setEnableQualication = value;
                    this.OnPropertyChanged(nameof(SetEnableQualication));
                }
            }
        }

        public bool SetEnableMedia
        {
            get { return this.setEnableMedia; }
            set
            {
                if (this.setEnableMedia != value)
                {
                    this.setEnableMedia = value;
                    this.OnPropertyChanged(nameof(SetEnableMedia));
                }
            }
        }

        public bool SetEnableActivität
        {
            get { return this.setEnableActivität; }
            set
            {
                if (this.setEnableActivität != value)
                {
                    this.setEnableActivität = value;
                    this.OnPropertyChanged(nameof(SetEnableActivität));
                }
            }
        }

        public bool SetEnableHobby
        {
            get { return this.setEnableHobby; }
            set
            {
                if (this.setEnableHobby != value)
                {
                    this.setEnableHobby = value;
                    this.OnPropertyChanged(nameof(SetEnableHobby));
                }
            }
        }

        public bool SetEnableConfig
        {
            get { return this.setEnableConfig; }
            set
            {
                if (this.setEnableConfig != value)
                {
                    this.setEnableConfig = value;
                    this.OnPropertyChanged(nameof(setEnableConfig));
                }
            }
        }
        public bool SetEnable
        {
            get { return this.setEnable; }
            set
            {
                if (this.setEnable != value)
                {
                    this.setEnable = value;
                    this.OnPropertyChanged(nameof(SetEnable));
                }
            }
        }

        public Brush SetVisibility
        {
            get { return this.setVisibility; }
            set
            {
                if (this.setVisibility != value)
                {
                    this.setVisibility = value;
                    this.OnPropertyChanged(nameof(SetVisibility));
                }
            }
        }

        public Brush ConfigBackColor
        {
            get { return this.configBackColor; }
            set
            {
                if (this.configBackColor != value)
                {
                    this.configBackColor = value;
                    this.OnPropertyChanged(nameof(ConfigBackColor));
                }
            }
        }

        public Brush ConfigForeColor
        {
            get { return this.configForeColor; }
            set
            {
                if (this.configForeColor != value)
                {
                    this.configForeColor = value;
                    this.OnPropertyChanged(nameof(ConfigForeColor));
                }
            }
        }

        public Brush InteresseBackColor
        {
            get { return this.interesseBackColor; }
            set
            {
                if (this.interesseBackColor != value)
                {
                    this.interesseBackColor = value;
                    this.OnPropertyChanged(nameof(interesseBackColor));
                }
            }
        }

        public Brush InteresseForeColor
        {
            get { return this.interesseForeColor; }
            set
            {
                if (this.interesseForeColor != value)
                {
                    this.interesseForeColor = value;
                    this.OnPropertyChanged(nameof(InteresseBackColor));
                }
            }
        }

        public Brush InfoBackColor
        {
            get { return this.infoBackColor; }
            set
            {
                if (this.infoBackColor != value)
                {
                    this.infoBackColor = value;
                    this.OnPropertyChanged(nameof(InfoBackColor));
                }
            }
        }

        public Brush InfoForeGroundColor
        {
            get { return this.infoForeGrounColor; }
            set
            {
                if (this.infoForeGrounColor != value)
                {
                    this.infoForeGrounColor = value;
                    this.OnPropertyChanged(nameof(InfoForeGroundColor));
                }
            }
        }

        public Brush BerufForeGroundColor
        {
            get { return this.berufForeGrounColor; }
            set
            {
                if (this.berufForeGrounColor != value)
                {
                    this.berufForeGrounColor = value;
                    this.OnPropertyChanged(nameof(BerufForeGroundColor));
                }
            }
        }

        public Brush BerufBackColor
        {
            get { return this.berufBackColor; }
            set
            {
                if (this.berufBackColor != value)
                {
                    this.berufBackColor = value;
                    this.OnPropertyChanged(nameof(BerufBackColor));
                }
            }
        }

        public Brush AusbildungForeColor
        {
            get { return this.ausbildungForeColor; }
            set
            {
                if (this.ausbildungForeColor != value)
                {
                    this.ausbildungForeColor = value;
                    this.OnPropertyChanged(nameof(AusbildungForeColor));
                }
            }
        }

        public Brush AusbildungBackColor
        {
            get { return this.ausbildungBackColor; }
            set
            {
                if (this.ausbildungBackColor != value)
                {
                    this.ausbildungBackColor = value;
                    this.OnPropertyChanged(nameof(AusbildungBackColor));
                }
            }
        }


        public Brush ProjektBackColor
        {
            get { return this.projektBackColor; }
            set
            {
                if (this.projektBackColor != value)
                {
                    this.projektBackColor = value;
                    this.OnPropertyChanged(nameof(ProjektBackColor));
                }
            }
        }

        public Brush ProjektForeColor
        {
            get { return this.projektForeColor; }
            set
            {
                if (this.projektForeColor != value)
                {
                    this.projektForeColor = value;
                    this.OnPropertyChanged(nameof(ProjektForeColor));
                }
            }
        }

        public Brush QualifikationBackColor
        {
            get { return this.qualifikationBackColor; }
            set
            {
                if (this.qualifikationBackColor != value)
                {
                    this.qualifikationBackColor = value;
                    this.OnPropertyChanged(nameof(qualifikationBackColor));
                }
            }
        }

        public Brush QualifikationForeColor
        {
            get { return this.qualifikationForeColor; }
            set
            {
                if (this.qualifikationForeColor != value)
                {
                    this.qualifikationForeColor = value;
                    this.OnPropertyChanged(nameof(qualifikationForeColor));
                }
            }
        }


        public Brush MediaBackColor
        {
            get { return this.mediaBackColor; }
            set
            {
                if (this.mediaBackColor != value)
                {
                    this.mediaBackColor = value;
                    this.OnPropertyChanged(nameof(MediaBackColor));
                }
            }
        }

        public Brush MediaForeColor
        {
            get { return this.mediaForeColor; }
            set
            {
                if (this.mediaForeColor != value)
                {
                    this.mediaForeColor = value;
                    this.OnPropertyChanged(nameof(MediaForeColor));
                }
            }
        }


        public Brush TätigkeitBackColor
        {
            get { return this.tätigkeitBackColor; }
            set
            {
                if (this.tätigkeitBackColor != value)
                {
                    this.tätigkeitBackColor = value;
                    this.OnPropertyChanged(nameof(TätigkeitBackColor));
                }
            }
        }

        public Brush TätigkeitForeColor
        {
            get { return this.tätigkeitForeColor; }
            set
            {
                if (this.tätigkeitForeColor != value)
                {
                    this.tätigkeitForeColor = value;
                    this.OnPropertyChanged(nameof(TätigkeitForeColor));
                }
            }
        }
    }

}
