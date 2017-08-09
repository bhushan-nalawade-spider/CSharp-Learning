using System;
using TechTalk.SpecFlow;
using System.Threading;
using System.Threading.Tasks;

using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SpecflowTests
{     
    [Binding]
    public class SpecFlowTestsFeatureSteps
    {
        static IWebDriver driver = new ChromeDriver();
        static IAlert promptHandler;
        [Given(@"User is at eAppreciation Home Page")]
        public void GivenUserIsAtEAppreciationHomePage()
        {
            driver.Navigate().GoToUrl("http://ahirram:PythonCanada@17@10.37.1.7/eAppreciations/");
            Thread.Sleep(2000);
            driver.Navigate().GoToUrl("http://10.37.1.7/eAppreciations/");
        }

        [Given(@"User has logged in with Spider credentials '(.*)'")]
        public void GivenUserHasLoggedInWithSpiderCredentials(string loggedInUser)
        {
            Assert.AreEqual(loggedInUser, driver.FindElement(By.XPath("//section[@id='login']/span")).Text);
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            driver.FindElement(By.XPath("//*[@id='body']//a[text()='Add']")).Click();
        }
        
        [When(@"I add name to the '(.*)' textbox")]
        public void WhenIAddNameToTheTextbox(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I select a name from the dropdown")]
        public void WhenISelectANameFromTheDropdown()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I enter message into the message field")]
        public void WhenIEnterMessageIntoTheMessageField()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"no media file is selected")]
        public void WhenNoMediaFileIsSelected()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click on '(.*)' button")]
        public void WhenIClickOnButton(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I land at the AddAppreciation page '(.*)'")]
        public void ThenILandAtTheAddAppreciationPage(string title)
        {
            Assert.AreEqual(title, driver.Title);
        }
        }

        [Then(@"My name is visible at the '(.*)' text box")]
        public void ThenMyNameIsVisibleAtTheTextBox(string textBox)
        {
            Assert.AreEqual(textBox, driver.FindElement(By.XPath("//input[@id='From']")).Text);
        }


        
        
        [Then(@"The dropdown is shown with matching results")]
        public void ThenTheDropdownIsShownWithMatchingResults()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"The name is displayed below the '(.*)' textbox")]
        public void ThenTheNameIsDisplayedBelowTheTextbox(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the message is added")]
        public void ThenTheMessageIsAdded()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the user lands back at the AddAppreciation page")]
        public void ThenTheUserLandsBackAtTheAddAppreciationPage()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
