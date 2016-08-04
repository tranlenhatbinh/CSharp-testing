using BasicSelenium.Common;

namespace BasicSelenium.PageObjects
{
    public class HomePage : GeneralPage
    {
        #region Methods

        public HomePage Open()
        {
            Constant.WebDriver.Navigate().GoToUrl(Constant.HomePageUrl);
            return this;
        }
        #endregion
    }
}