using Bunit;
using Bunit.JSInterop;
using Microsoft.AspNetCore.Components.Web;
using Xunit;

namespace RazorTestLibrary.Tests
{
    public class MyButtonTests : TestContext
    {
        static IRenderedComponent<MyButton> component;
        
        public MyButtonTests()
        {
            component = SetupButtonComponent();
        }

        private IRenderedComponent<MyButton> SetupButtonComponent()
        {
            var jsModule = JSInterop.SetupModule("import", new string[] { "./_content/HeadlessUI/common.js" });
            jsModule.SetupVoid().SetVoidResult();
            return RenderComponent<MyButton>();
        }

        [Fact]
        public void NewButton_HasButtonTag()
        {
            var button = component.Find("button");
            Assert.NotNull(button);
        }        
    }
}
