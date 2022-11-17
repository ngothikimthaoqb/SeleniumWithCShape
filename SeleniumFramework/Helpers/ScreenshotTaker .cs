using OpenQA.Selenium;

namespace SeleniumFramework.Helpers
{
    public class ScreenshotTaker
    {
        public void CaptureScreenshot(string fileName, IWebDriver driver)
        {
            try
            {
                string FilePath = $@"..\..\..\ScreenShots\{fileName}.jpg";
                string ImagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, FilePath);
                if (File.Exists(ImagePath))
                {
                    try
                    {
                        File.Delete(ImagePath);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);

                    }
                }
                var screenshot = ((ITakesScreenshot)driver).GetScreenshot();
                screenshot.SaveAsFile(ImagePath);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
