#pragma checksum "D:\practD\practika\Ritual\Ritual\Views\Home\Contacts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "44e219fcdf9383086fd4172dcac46e824910f346"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Contacts), @"mvc.1.0.view", @"/Views/Home/Contacts.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44e219fcdf9383086fd4172dcac46e824910f346", @"/Views/Home/Contacts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8845ce5e3aa72ddb8e5123b866ec876100ddee40", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Contacts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("metatags", async() => {
                WriteLiteral("\r\n    <title>Контакты - Ритуальное услуги в Глубоком</title>\r\n    <meta name=\"description\" content=\"asdasd\" />\r\n");
            }
            );
            WriteLiteral(@"<div>

    <div class=""wrapper style1"">

        <div class=""container"">
            <div class=""row gtr-200"">
                <div class=""col-4 col-12-mobile"" id=""sidebar"">
                    <article id=""main"">
                        <h3 class=""widget-title"">Наши контакты</h3>
                        <ul>
                            <li>
                                <a><p>г.Глубокое, ул.М.Горького, дом 32</p></a>
                            </li>
                            <li>
                                <a><p>+375 (29) 890-92-99</p></a>
                            </li>
                            <li>
                                <a><p>+375 (29) 899-17-67</p></a>
                            </li>
                            <li>
                                <a><p>8 (02156) 2-41-71</p></a>
                            </li>
                        </ul>

                    </article>
                </div>
                <div class=""col-8 col-12-mobile imp-mobile");
            WriteLiteral("\" id=\"content\">\r\n                    <article id=\"main\">\r\n                        <h2>Напишите нам</h2>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "44e219fcdf9383086fd4172dcac46e824910f3464582", async() => {
                WriteLiteral(@"
                            <input name=""Name"" minlength=""2"" maxlength=""20"" required placeholder=""Ваше имя"" type=""text"" size=""40"">
                            <br>
                            <input name=""NumberPhone"" placeholder=""Номер телефона"" minlength=""2"" maxlength=""20"" required type=""text"" size=""40"">
                            <br>
                            <textarea name=""Mess"" rows=""4"" required  minlength=""2"" maxlength=""350"" style=""resize: none;"" placeholder=""Ваше сообщение"" cols=""200""></textarea>
                            <br>
                            <input type=""submit"" value=""Отправить"" />
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

                    </article>
                </div>
            </div>

        </div>
        <br>
        <section id=""banner"">
            <iframe class=""image featured"" src=""https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2280.4612276001076!2d27.70410056360109!3d55.14020717254502!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x46dcad3e57dce87b%3A0x3f40cfa234238291!2z0KDQuNGC0YPQsNC7INC90LAg0Jwu0JPQvtGA0YzQutC-0LPQviAzMg!5e0!3m2!1sru!2sby!4v1616665998199!5m2!1sru!2sby""
                    width=""1500"" height=""500"" style=""border: 0;""");
            BeginWriteAttribute("allowfullscreen", " allowfullscreen=\"", 2584, "\"", 2602, 0);
            EndWriteAttribute();
            WriteLiteral(" loading=\"lazy\"></iframe>\r\n        </section>\r\n    </div>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
