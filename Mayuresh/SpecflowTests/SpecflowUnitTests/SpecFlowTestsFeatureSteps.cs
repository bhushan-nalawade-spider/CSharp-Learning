using System;
using TechTalk.SpecFlow;
using System.Threading;
using System.Threading.Tasks;

using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SpecflowUnitTests
{
    [Binding]
    public class SpecFlowTestsFeatureSteps
    {
        static IWebDriver driver = new ChromeDriver();

        #region Given

        [Given(@"User is at eAppreciation Home Page")]
        public void GivenUserIsAtEAppreciationHomePage()
        {
            driver.Navigate().GoToUrl("http://<User>:<Password>@10.37.1.7/eAppreciations/");
            Thread.Sleep(2000);
            driver.Navigate().GoToUrl("http://10.37.1.7/eAppreciations/");
            Thread.Sleep(2000);
        }
        
        [Given(@"User has logged in with Spider credentials '(.*)'")]
        public void GivenUserHasLoggedInWithSpiderCredentials(string loggedInUser)
        {
            Assert.AreEqual(loggedInUser, driver.FindElement(By.XPath("//section[@id='login']/span")).Text);
        }


        #endregion

        #region When

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            driver.FindElement(By.XPath("//*[@id='body']//a[text()='Add']")).Click();
        }

        [When(@"I add name '(.*)' to the '(.*)' textbox")]
        public void WhenIAddNameToTheTextbox(string appreciatedPersonName, string textBox)
        {
            driver.FindElement(By.XPath("//input[@id='" + textBox + "']")).SendKeys(appreciatedPersonName);
            Thread.Sleep(2000);
        }

        [When(@"I select given name from the '(.*)' dropdown")]
        public void WhenISelectGivenNameFromTheDropdown(string textBox)
        {
            IWebElement toTextBox = driver.FindElement(By.XPath("//input[@id='" + textBox + "']"));
            toTextBox.SendKeys(Keys.ArrowDown);
            toTextBox.SendKeys(Keys.Enter);

        }

        
        [When(@"I enter message '(.*)' into the '(.*)' field")]
        public void WhenIEnterMessageIntoTheMessageField(string message, string messageField)
        {
            driver.FindElement(By.Id(messageField)).SendKeys(message);
        }
        
        [When(@"no media file is selected")]
        public void WhenNoMediaFileIsSelected()
        {
            
        }
        
        [When(@"I click on '(.*)' button")]
        public void WhenIClickOnButton(string buttonToClick)
        {
            if (buttonToClick.Equals("Save and Close"))
            {
                driver.FindElement(By.Id("saveAndCloseBtn")).Click();
            }
            else if (buttonToClick.Equals("Save and Add More"))
            {
                driver.FindElement(By.Id("saveAndContinueBtn")).Click();
            }
        }

        [When(@"Media file '(.*)' is selected")]
        public void WhenMediaFileIsSelected(string address)
        {
            IWebElement messageElement = driver.FindElement(By.Id("messageFile"));
            messageElement.Click();
            Thread.Sleep(5000);
            messageElement.SendKeys(address);
            messageElement.SendKeys(Keys.Enter);
            
        }


        #endregion

        #region Then

        [Then(@"I land at the page '(.*)'")]
        public void ThenILandAtThePage(string title)
        {
            Assert.IsTrue(driver.Title.Contains(title));            
        }

        [Then(@"My name '(.*)' is visible at the '(.*)' textbox")]
        public void ThenMyNameIsVisibleAtTheTextbox(string userName, string textBox)
        {
            Assert.AreEqual(userName, driver.FindElement(By.XPath("//input[@id='" + textBox + "']")).GetAttribute("value").ToString());
        }


        [Then(@"The given name '(.*)' is shown in '(.*)' section")]
        public void ThenTheGivenNameIsShownInSection(string appreciatedPersonName, string nameSection)
        {
            IWebElement toTextBox = driver.FindElement(By.XPath("//input[@id='" + nameSection + "']"));
            Assert.AreEqual(appreciatedPersonName, toTextBox.GetAttribute("value").ToString().TrimEnd(';'));
        }

        [Then(@"The '(.*)' dropdown is shown with matching results '(.*)' ")]
        public void ThenTheDropdownIsShownWithMatchingResults(string textBox, string appreciatedPersonName)
        {
            IWebElement toTextBox = driver.FindElement(By.XPath("//input[@id='" + textBox + "']"));
            toTextBox.SendKeys(Keys.ArrowDown);
            toTextBox.SendKeys(Keys.Enter);
            Assert.AreEqual(appreciatedPersonName, toTextBox.GetAttribute("value").ToString());
        }
        
        [Then(@"The name '(.*)' is displayed below the '(.*)' textbox")]
        public void ThenTheNameIsDisplayedBelowTheTextbox(string appreciatedPersonName, string textBox)
        {
            Assert.AreEqual(appreciatedPersonName, driver.FindElement(By.XPath("//input[@id='" + textBox + "']")).GetAttribute("value").ToString());
        }

        [Then(@"the message '(.*)' is added to the '(.*)' field")]
        public void ThenTheMessageIsAddedToTheField(string message, string messageField)
        {
            Assert.AreEqual(message, driver.FindElement(By.Id(messageField)).GetAttribute("value").ToString());
            Thread.Sleep(2000);
        }

        #endregion

        //[Then(@"the user lands back at the AddAppreciation page")]
        //public void ThenTheUserLandsBackAtTheAddAppreciationPage()
        //{
        //    ScenarioContext.Current.Pending();
        //}
        
        //[Then(@"I land at the AddAppreciation page")]
        //public void ThenILandAtTheAddAppreciationPage()
        //{
        //    ScenarioContext.Current.Pending();
        //}
    }
}
