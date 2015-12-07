using FlexMenu.Controls;
using FlexMenu.Utility;
using System;
using System.Linq;

namespace FlexMenu
{
    public sealed class FlexMenuManager
    {
        #region Fields

        private static FlexMenuManager instance;

        private FlexLightbox lightbox;

        #endregion


        #region Constructors

        private FlexMenuManager() { }

        #endregion


        #region Properties

        public static FlexMenuManager Instance
        {
            get
            {
                return instance ?? (instance = new FlexMenuManager());
            }
        }

        #endregion


        #region Methods

        public void OpenLightbox()
        {
            var window = WindowHelper.GetActiveWindow();

            lightbox = WindowHelper.Find<FlexLightbox>(window);
            lightbox?.Open();
        }

        public void CloseLightbox()
        {
            lightbox?.Close();
            lightbox = null;
        }

        #endregion
    }
}
