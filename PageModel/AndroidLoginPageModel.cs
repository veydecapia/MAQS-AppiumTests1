﻿using CognizantSoftvision.Maqs.BaseAppiumTest;
using OpenQA.Selenium;

namespace PageModel
{
    /// <summary>
    /// Page object for the AndroidLoginPageModel inheriting from the ALoginPageModel
    /// </summary>
    public class AndroidLoginPageModel : ALoginPageModel
    {
        /// <summary>
        /// The user name input element 'By' finder
        /// </summary>
        protected override LazyMobileElement UserNameInput
        {
            get { return new LazyMobileElement(this.TestObject, 
                By.Id("com.magenic.appiumtesting.maqsregistrydemo:id/userNameField"), "User Name Field"); }
        }

        /// <summary>
        /// The password input element 'By' finder
        /// </summary>
        protected override LazyMobileElement PasswordInput
        {
            get { return new LazyMobileElement(this.TestObject, 
                By.Id("com.magenic.appiumtesting.maqsregistrydemo:id/passwordField"), "Password Field"); }
        }

        /// <summary>
        /// The login button element 'By' finder
        /// </summary>
        protected override LazyMobileElement LoginButton
        {
            get { return new LazyMobileElement(this.TestObject, 
                By.Id("com.magenic.appiumtesting.maqsregistrydemo:id/loginButton"), "Login Button"); }
        }

        /// <summary>
        /// The error message element 'By' finder
        /// </summary>
        protected override LazyMobileElement ErrorMessage
        {
            get { return new LazyMobileElement(this.TestObject, By.Id("message"), "Error Message Label"); }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AndroidLoginPageModel" /> class.
        /// </summary>
        /// <param name="testObject">The appium test object</param>
        public AndroidLoginPageModel(IAppiumTestObject testObject) : base(testObject)
        {
        }

        /// <summary>
        /// Get the iOS version of the HomePageModel
        /// </summary>
        /// <returns>The iOS version of the HomePageModel</returns>
        protected override AHomePageModel GetHomePageModel()
        {
            return new AndroidHomePageModel(TestObject);
        }
    }
}