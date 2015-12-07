using System;

namespace FlexMenu.Utility
{
    public sealed class FlexWindowManager
    {
        #region Fields

        private static FlexWindowManager _instance;

        #endregion


        #region Constructors

        private FlexWindowManager()
        {
            // TODO
        }

        #endregion


        #region Properties

        public static FlexWindowManager Instance
        {
            get
            {
                return _instance ?? (_instance = new FlexWindowManager());
            }
        }

        #endregion

    }
}
