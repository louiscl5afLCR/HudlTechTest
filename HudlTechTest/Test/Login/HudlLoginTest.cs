using HudlTechTest.Page.HomePage;
using HudlTechTest.Utilities.Base;

namespace HudlTechTest.Test.Login;

[TestFixture]
public class HudlLoginTest : BaseTest
{
    private HudlLoginPage hudlLoginPage;

    [SetUp]
    public void Setup()
    {
        hudlLoginPage = new HudlLoginPage(driver);  
    }

    [Test]
    public void ValidLoginTest()
    {
        
        hudlLoginPage.Cookie();
        hudlLoginPage.LoginHomePage();
        hudlLoginPage.EnterUserName("yourusername");
        hudlLoginPage.LoginButtonAfterEmail();  
        hudlLoginPage.EnterPassword("yourpassword");
        hudlLoginPage.ClickLogin();

        // confirming that the user is logged in
        Assert.IsTrue(driver.Url.Contains("https://www.hudl.com/home"));    

    }

    [Test]
    public void InvalidLogin1()
    {
        hudlLoginPage.Cookie();
        hudlLoginPage.LoginHomePage();
        hudlLoginPage.EnterUserName("invalidusername");
        hudlLoginPage.LoginButtonAfterEmail();

        // confirming that the error message is displayed and user cannot log in
        Assert.IsTrue(hudlLoginPage.ErrorMessageDisplayed());
    }

    [Test]
    public void InvalidLogin2()
    {
        hudlLoginPage.Cookie();
        hudlLoginPage.LoginHomePage();
        hudlLoginPage.EnterUserName("username");
        hudlLoginPage.LoginButtonAfterEmail();
        hudlLoginPage.EnterPassword("invalidpassword");
        hudlLoginPage.ClickLogin();

        // confirming that the error message is displayed and user cannot log in
        Assert.IsTrue(hudlLoginPage.ErrorMessageDisplayedPassword());
    }

    [Test]
    public void ScriptInjection()
    {
        hudlLoginPage.Cookie();
        hudlLoginPage.LoginHomePage();
        hudlLoginPage.EnterUserName("<script>£!£DFDFDFaddsd^45^<script>");
        hudlLoginPage.LoginButtonAfterEmail();

        // confirming that the error message is displayed and user cannot log in
        Assert.IsTrue(hudlLoginPage.ErrorMessageDisplayed());
    }

    [Test]
    public void ScriptInjection2()
    {
        hudlLoginPage.Cookie();
        hudlLoginPage.LoginHomePage();
        hudlLoginPage.EnterUserName("<script>£!£DFDFDFaddsd^45^<script>");
        hudlLoginPage.LoginButtonAfterEmail();
        hudlLoginPage.EnterPassword("<script>£!£DFDFDFaddsd^45^<script>");
        hudlLoginPage.ClickLogin();

        // confirming that the error message is displayed and user cannot log in
        Assert.IsTrue(hudlLoginPage.ErrorMessageDisplayed());
    }
}
