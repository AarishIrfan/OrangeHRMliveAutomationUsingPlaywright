using AventStack.ExtentReports;
using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;

namespace SwagsLabs
{
    public class Tests : PageTest
    {

        [SetUp]
        public async Task setup()
        {
            ContextOptions();

            await Context.Tracing.StartAsync(new()
            {
                Screenshots = true,
                Snapshots = true,
                Sources = true
            });

            ExtentReport.LogReport("AddPaymentRequest_Test");

        }

        [TearDown]
        public async Task teardown()
        {
            Thread.Sleep(3000);
            // Stop tracing and export it into a zip archive.
            await Context.Tracing.StopAsync(new()
            {
                Path = @"trace/" + TestContext.CurrentContext.Test.MethodName + "_" + DateTime.Now.ToString("yyyymmddhhmmss").ToString() + ".zip"
            });

            ExtentReport.extentReports.Flush();

            await Context.CloseAsync();
            await Browser.CloseAsync();


              //driver.Close();
        }

        [Test]
        public async Task TestMethod4()
        {
            ExtentReport.exParentTest = ExtentReport.extentReports.CreateTest("OrangeHRMLive");

            ExtentReport.exChildTest = ExtentReport.exParentTest.CreateNode("OrangeHRMLive");

            // Module 1 starts//
            await Page.GotoAsync("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");
           
            await Write("#app > div.orangehrm-login-layout > div > div.orangehrm-login-container > div > div.orangehrm-login-slot > div.orangehrm-login-form > form > div:nth-child(2) > div > div:nth-child(2) > input", "Admin", "Username");

            await Write("#app > div.orangehrm-login-layout > div > div.orangehrm-login-container > div > div.orangehrm-login-slot > div.orangehrm-login-form > form > div:nth-child(3) > div > div:nth-child(2) > input", "admin123", "Password");

            await Click("#app > div.orangehrm-login-layout > div > div.orangehrm-login-container > div > div.orangehrm-login-slot > div.orangehrm-login-form > form > div.oxd-form-actions.orangehrm-login-action > button", "LoginBtn");


            ExtentReport.exChildTest = ExtentReport.exParentTest.CreateNode("AdminModule");

            await Click("xpath=//html/body/div/div[1]/div[1]/aside/nav/div[2]/ul/li[1]/a/span", "Admin");
            await Click("#app > div.oxd-layout > div.oxd-layout-container > div.oxd-layout-context > div > div.orangehrm-paper-container > div.orangehrm-header-container > button", "AddUser");
            
            await Click("#app > div.oxd-layout > div.oxd-layout-container > div.oxd-layout-context > div > div > form > div:nth-child(1) > div > div:nth-child(1) > div > div:nth-child(2) > div > div > div.oxd-select-text-input", "UserName");
            await Press("#app > div.oxd-layout > div.oxd-layout-container > div.oxd-layout-context > div > div > form > div:nth-child(1) > div > div:nth-child(1) > div > div:nth-child(2) > div > div > div.oxd-select-text-input", "a");
            await Press("#app > div.oxd-layout > div.oxd-layout-container > div.oxd-layout-context > div > div > form > div:nth-child(1) > div > div:nth-child(1) > div > div:nth-child(2) > div > div > div.oxd-select-text-input", "Enter");


            await Click("#app > div.oxd-layout > div.oxd-layout-container > div.oxd-layout-context > div > div > form > div:nth-child(1) > div > div:nth-child(2) > div > div:nth-child(2) > div > div > input", "UserRole");
            await Press("#app > div.oxd-layout > div.oxd-layout-container > div.oxd-layout-context > div > div > form > div:nth-child(1) > div > div:nth-child(2) > div > div:nth-child(2) > div > div > input", "a");
            await Press("#app > div.oxd-layout > div.oxd-layout-container > div.oxd-layout-context > div > div > form > div:nth-child(1) > div > div:nth-child(2) > div > div:nth-child(2) > div > div > input", "ArrowDown");
            await Press("#app > div.oxd-layout > div.oxd-layout-container > div.oxd-layout-context > div > div > form > div:nth-child(1) > div > div:nth-child(2) > div > div:nth-child(2) > div > div > input", "ArrowDown");
            await Press("#app > div.oxd-layout > div.oxd-layout-container > div.oxd-layout-context > div > div > form > div:nth-child(1) > div > div:nth-child(2) > div > div:nth-child(2) > div > div > input", "Enter");

            await Click("#app > div.oxd-layout > div.oxd-layout-container > div.oxd-layout-context > div > div > form > div:nth-child(1) > div > div:nth-child(3) > div > div:nth-child(2) > div > div", "Status");
            await Press("#app > div.oxd-layout > div.oxd-layout-container > div.oxd-layout-context > div > div > form > div:nth-child(1) > div > div:nth-child(3) > div > div:nth-child(2) > div > div", "e");
            await Press("#app > div.oxd-layout > div.oxd-layout-container > div.oxd-layout-context > div > div > form > div:nth-child(1) > div > div:nth-child(3) > div > div:nth-child(2) > div > div", "Enter");

            await Write("xpath=//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div/form/div[1]/div/div[4]/div/div[2]/input", "AarishTester", "UserName");


            
            await Write("xpath=//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div/form/div[2]/div/div[1]/div/div[2]/input", "Aarishirfantest123", "Password");
            await Write("xpath=//html/body/div/div[1]/div[2]/div[2]/div/div/form/div[2]/div/div[2]/div/div[2]/input", "Aarishirfantest123", "ConfirmPassword");

            // Module 1 ends//


            //Module 2 Starts here//

            ExtentReport.exChildTest = ExtentReport.exParentTest.CreateNode("PIMModule");

            await Click("xpath=//html/body/div/div[1]/div[1]/aside/nav/div[2]/ul/li[2]/a/span", "PIM");
            await Click("xpath=//html/body/div/div[1]/div[2]/div[2]/div/div[2]/div[1]/button", "AddEmp");

            await Page.Locator("#app > div.oxd-layout > div.oxd-layout-container > div.oxd-layout-context > div > div > form > div.orangehrm-employee-container > div.orangehrm-employee-image > div > div:nth-child(2) > input").SetInputFilesAsync("E:\\Pictures\\Aarish.jpg");

            await Click("#app > div.oxd-layout > div.oxd-layout-container > div.oxd-layout-context > div > div > form > div.orangehrm-employee-container > div.orangehrm-employee-form > div:nth-child(1) > div.oxd-grid-1.orangehrm-full-width-grid > div > div > div.--name-grouped-field > div:nth-child(1) > div:nth-child(2) > input", "EmployeeName");

            await Write("#app > div.oxd-layout > div.oxd-layout-container > div.oxd-layout-context > div > div > form > div.orangehrm-employee-container > div.orangehrm-employee-form > div:nth-child(1) > div.oxd-grid-1.orangehrm-full-width-grid > div > div > div.--name-grouped-field > div:nth-child(1) > div:nth-child(2) > input", "Aarish", "FirstName");

            await Write("#app > div.oxd-layout > div.oxd-layout-container > div.oxd-layout-context > div > div > form > div.orangehrm-employee-container > div.orangehrm-employee-form > div:nth-child(1) > div.oxd-grid-1.orangehrm-full-width-grid > div > div > div.--name-grouped-field > div:nth-child(3) > div:nth-child(2) > input", "Irfan", "LastName");

            await Click("#app > div.oxd-layout > div.oxd-layout-container > div.oxd-layout-context > div > div > form > div.oxd-form-actions > button.oxd-button.oxd-button--medium.oxd-button--secondary.orangehrm-left-space", "Savebtn");

            //Module 2 ends here//


            //Module 3 starts here//



            ExtentReport.exChildTest = ExtentReport.exParentTest.CreateNode("leaveModule");

            await Click("xpath=//html/body/div/div[1]/div[1]/aside/nav/div[2]/ul/li[3]/a/span", "LeaveList");

            await Write("#app > div.oxd-layout > div.oxd-layout-container > div.oxd-layout-context > div > div.oxd-table-filter > div.oxd-table-filter-area > form > div:nth-child(1) > div > div:nth-child(1) > div > div:nth-child(2) > div > div > input", "2023-01-03", "FromDate");
            await Write("#app > div.oxd-layout > div.oxd-layout-container > div.oxd-layout-context > div > div.oxd-table-filter > div.oxd-table-filter-area > form > div:nth-child(1) > div > div:nth-child(2) > div > div:nth-child(2) > div > div > input", "2023-02-02", "ToDate");

            await Click("xpath=//html/body/div/div[1]/div[2]/div[2]/div/div[1]/div[2]/form/div[1]/div/div[3]/div/div[2]/div", "Show Leave with Status");

            await Press("xpath=//html/body/div/div[1]/div[2]/div[2]/div/div[1]/div[2]/form/div[1]/div/div[3]/div/div[2]/div", "ArrowDown");
            await Press("xpath=//html/body/div/div[1]/div[2]/div[2]/div/div[1]/div[2]/form/div[1]/div/div[3]/div/div[2]/div", "ArrowDown");
            await Press("xpath=//html/body/div/div[1]/div[2]/div[2]/div/div[1]/div[2]/form/div[1]/div/div[3]/div/div[2]/div", "Enter");


            await Click("xpath=//html/body/div/div[1]/div[2]/div[2]/div/div[1]/div[2]/form/div[1]/div/div[4]/div/div[2]/div/div[1]/div[1]", "Leave Type");

            await Press("xpath=//html/body/div/div[1]/div[2]/div[2]/div/div[1]/div[2]/form/div[1]/div/div[4]/div/div[2]/div/div[1]/div[1]", "ArrowDown");

            await Press("xpath=//html/body/div/div[1]/div[2]/div[2]/div/div[1]/div[2]/form/div[1]/div/div[4]/div/div[2]/div/div[1]/div[1]", "Enter");

            await Write("xpath=//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div[1]/div[2]/form/div[2]/div/div[1]/div/div[2]/div/div/input", "Fiona  Grace", "Employee Name");


            await Click("xpath=//html/body/div/div[1]/div[2]/div[2]/div/div[1]/div[2]/form/div[2]/div/div[2]/div/div[2]/div", "Sub Unit");
            await Press("xpath=//html/body/div/div[1]/div[2]/div[2]/div/div[1]/div[2]/form/div[2]/div/div[2]/div/div[2]/div", "ArrowDown");

            await Press("xpath=//html/body/div/div[1]/div[2]/div[2]/div/div[1]/div[2]/form/div[2]/div/div[2]/div/div[2]/div", "ArrowDown");

            await Press("xpath=//html/body/div/div[1]/div[2]/div[2]/div/div[1]/div[2]/form/div[2]/div/div[2]/div/div[2]/div", "Enter");



        }
        public override BrowserNewContextOptions ContextOptions()
        {
            return new BrowserNewContextOptions()
            {
                RecordVideoDir = @"videos/" + TestContext.CurrentContext.Test.MethodName + "_" + DateTime.Now.ToString("yyyymmddhhmmss").ToString(),
                //StorageStatePath = @"state\Pagetest_state.json",
                ViewportSize = new ViewportSize
                {
                    Height = 780,
                    Width = 1380
                },
                RecordVideoSize = new RecordVideoSize
                {
                    Height = 780,
                    Width = 1380
                }
            };

        }


        public async Task Write(string locator, string data, string detail)
        {
            try
            {
                await Page.FillAsync(locator, data);
                await ExtentReport.TakeScreenshot(Page, Status.Pass, detail);
                Thread.Sleep(1000);
            }
            catch (Exception ex)
            {
                await ExtentReport.TakeScreenshot(Page, Status.Fail, "Entry Failed" + ex);
            }
        }

        public async Task Click(string locator, string detail)
        {
            try
            {
                await Page.ClickAsync(locator);
                await ExtentReport.TakeScreenshot(Page, Status.Pass, detail);
                Thread.Sleep(1000);
            }
            catch (Exception ex)
            {
                await ExtentReport.TakeScreenshot(Page, Status.Fail, "Click Failed" + ex);
            }
        }

        public async Task Press(string locator, string key)
        {
            try
            {
                await Page.PressAsync(locator, key);
                Thread.Sleep(1000);
            }
            catch (Exception ex)
            {
                await ExtentReport.TakeScreenshot(Page, Status.Fail, "Click Failed" + ex);
            }
        }

    }
}

    