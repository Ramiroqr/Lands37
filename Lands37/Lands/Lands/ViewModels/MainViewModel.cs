using System;
using System.Collections.Generic;
using System.Text;

namespace Lands.ViewModels
{
    class MainViewModel
    {
        #region ViewModels
        public LoginViewModel Login
        {
            get;
            set;
        }

        public LandsViewModel Lands
        {
            get;
            set;
        }
        #endregion

        #region Constructors
        public MainViewModel()
        {
            intance = this;
            this.Login = new LoginViewModel();
        }
        #endregion

        #region Patron Singleton
        private static MainViewModel intance;

        public static MainViewModel GetInstance()
        {
            if (intance == null)
            {
                return new MainViewModel();
            }
            return intance;
        }
        #endregion
    }
}
