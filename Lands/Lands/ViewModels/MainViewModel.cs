using Lands.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lands.ViewModels
{
    public class MainViewModel
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
        public LandViewModel Land
        {
            get;
            set;
        }
        #endregion

        #region Constructors
        public MainViewModel()
        {
            instance = this;
            this.Login = new LoginViewModel();
        }
        #endregion

        #region Singleyton
        private static MainViewModel instance;

        public static MainViewModel GetInstance()
        { 
            if (instance==null)
            {
                return new MainViewModel();
            }
            return instance;
        }

        #endregion

        #region Properties
        public List<Land> LandsList
        {
            get;
            set;
        }

        public TokenResponse Token
        {
            get;
            set;
        }
        #endregion
    }
}

