#pragma checksum "C:\Users\User\Desktop\backend-project\backendproject\backendproject\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4a86126b73b7921284563a2188e5226c286e673a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\User\Desktop\backend-project\backendproject\backendproject\Views\_ViewImports.cshtml"
using backendproject.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\backend-project\backendproject\backendproject\Views\_ViewImports.cshtml"
using backendproject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a86126b73b7921284563a2188e5226c286e673a", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa8653c43aabc8ebe362b43510aefe260c18aa5c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/icon/section.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("section-title"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\User\Desktop\backend-project\backendproject\backendproject\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    Layout = "_Layout1";
    int count = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- Background Area Start -->\r\n<section id=\"slider-container\" class=\"slider-area\">\r\n    <div class=\"slider-owl owl-theme owl-carousel\">\r\n        <!-- Start Slingle Slide -->\r\n");
#nullable restore
#line 12 "C:\Users\User\Desktop\backend-project\backendproject\backendproject\Views\Home\Index.cshtml"
         foreach (Slider item in Model.Sliders)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"single-slide item\"");
            BeginWriteAttribute("style", " style=\"", 386, "\"", 438, 3);
            WriteAttributeValue("", 394, "background-image:", 394, 17, true);
            WriteAttributeValue(" ", 411, "url(img/slider/", 412, 16, true);
#nullable restore
#line 14 "C:\Users\User\Desktop\backend-project\backendproject\backendproject\Views\Home\Index.cshtml"
WriteAttributeValue("", 427, item.Image, 427, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                <!-- Start Slider Content -->
                <div class=""slider-content-area"">
                    <div class=""container"">
                        <div class=""row"">
                            <div class=""col-md-7 col-md-offset-left-5"">
                                <div class=""slide-content-wrapper"">
                                    <div class=""slide-content"">
                                        ");
#nullable restore
#line 22 "C:\Users\User\Desktop\backend-project\backendproject\backendproject\Views\Home\Index.cshtml"
                                   Write(Html.Raw(item.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        <p>");
#nullable restore
#line 23 "C:\Users\User\Desktop\backend-project\backendproject\backendproject\Views\Home\Index.cshtml"
                                      Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                        <a class=\"default-btn\"");
            BeginWriteAttribute("href", " href=\"", 1026, "\"", 1043, 1);
#nullable restore
#line 24 "C:\Users\User\Desktop\backend-project\backendproject\backendproject\Views\Home\Index.cshtml"
WriteAttributeValue("", 1033, item.Link, 1033, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">Learn more</a>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <!-- Start Slider Content -->
            </div>
");
#nullable restore
#line 33 "C:\Users\User\Desktop\backend-project\backendproject\backendproject\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <!-- End Slingle Slide -->
    </div>
</section>
<!-- Background Area End -->
<!-- Notice Start -->
<section class=""notice-area pt-150 pb-150"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-6 col-sm-6 col-xs-12"">
                <div class=""notice-left"">
                    <h3>notice board</h3>
                    ");
#nullable restore
#line 45 "C:\Users\User\Desktop\backend-project\backendproject\backendproject\Views\Home\Index.cshtml"
               Write(await Component.InvokeAsync("Notice"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"col-md-6 col-sm-6 col-xs-12\">\r\n                <div class=\"notice-right\">\r\n\r\n");
#nullable restore
#line 51 "C:\Users\User\Desktop\backend-project\backendproject\backendproject\Views\Home\Index.cshtml"
                     foreach (NoticeRight item in Model.NoticeRights)
                    {
                        if (count < 2)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"single-notice-right mb-25 pb-25\">\r\n                                <h3>");
#nullable restore
#line 56 "C:\Users\User\Desktop\backend-project\backendproject\backendproject\Views\Home\Index.cshtml"
                               Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                <p>");
#nullable restore
#line 57 "C:\Users\User\Desktop\backend-project\backendproject\backendproject\Views\Home\Index.cshtml"
                              Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </div>\r\n");
#nullable restore
#line 59 "C:\Users\User\Desktop\backend-project\backendproject\backendproject\Views\Home\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"single-notice-right\">\r\n                                <h3>");
#nullable restore
#line 63 "C:\Users\User\Desktop\backend-project\backendproject\backendproject\Views\Home\Index.cshtml"
                               Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                <p>");
#nullable restore
#line 64 "C:\Users\User\Desktop\backend-project\backendproject\backendproject\Views\Home\Index.cshtml"
                              Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </div>\r\n");
#nullable restore
#line 66 "C:\Users\User\Desktop\backend-project\backendproject\backendproject\Views\Home\Index.cshtml"
                        }
                        count++;
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n<!-- Notice End -->\r\n<!-- Choose Start -->\r\n<section class=\"choose-area pb-85 pt-77\"");
            BeginWriteAttribute("style", " style=\"", 2834, "\"", 2903, 4);
            WriteAttributeValue("", 2842, "background:", 2842, 11, true);
            WriteAttributeValue(" ", 2853, "url(../img/choose/", 2854, 19, true);
#nullable restore
#line 76 "C:\Users\User\Desktop\backend-project\backendproject\backendproject\Views\Home\Index.cshtml"
WriteAttributeValue("", 2872, Model.Choose.BackGroundImage, 2872, 29, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2901, ");", 2901, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n    <div class=\"choose-area-img\"");
            BeginWriteAttribute("style", " style=\"", 2939, "\"", 3014, 4);
            WriteAttributeValue("", 2947, "background:", 2947, 11, true);
            WriteAttributeValue(" ", 2958, "url(../img/choose/", 2959, 19, true);
#nullable restore
#line 77 "C:\Users\User\Desktop\backend-project\backendproject\backendproject\Views\Home\Index.cshtml"
WriteAttributeValue("", 2977, Model.Choose.SecondBackGroundImage, 2977, 35, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3012, ");", 3012, 2, true);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-md-8 col-md-offset-left-4 col-sm-8 col-md-offset-left-4\">\r\n                <div class=\"choose-content text-left\">\r\n                    <h2>");
#nullable restore
#line 82 "C:\Users\User\Desktop\backend-project\backendproject\backendproject\Views\Home\Index.cshtml"
                   Write(Model.Choose.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                    ");
#nullable restore
#line 83 "C:\Users\User\Desktop\backend-project\backendproject\backendproject\Views\Home\Index.cshtml"
               Write(Html.Raw(Model.Choose.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <a class=\"default-btn\"");
            BeginWriteAttribute("href", " href=\"", 3372, "\"", 3397, 1);
#nullable restore
#line 84 "C:\Users\User\Desktop\backend-project\backendproject\backendproject\Views\Home\Index.cshtml"
WriteAttributeValue("", 3379, Model.Choose.Link, 3379, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">view courses</a>
                </div>
            </div>
        </div>
    </div>
</section>
<!-- Choose Area End -->
<!-- Courses Area Start -->
<div class=""courses-area pt-150 text-center"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-xs-12"">
                <div class=""section-title"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4a86126b73b7921284563a2188e5226c286e673a13370", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    <h2>COURSES WE OFFER</h2>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n           ");
#nullable restore
#line 103 "C:\Users\User\Desktop\backend-project\backendproject\backendproject\Views\Home\Index.cshtml"
      Write(await Component.InvokeAsync("Course",3));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </div>
    </div>
</div>
<!-- Courses Area End -->
<!-- Event Area Start -->
<div class=""event-area one text-center pt-140 pb-150"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-xs-12"">
                <div class=""section-title"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4a86126b73b7921284563a2188e5226c286e673a15219", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    <h2>UPCOMMING EVENTS</h2>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col-md-6 col-sm-12 col-xs-12\">\r\n");
#nullable restore
#line 121 "C:\Users\User\Desktop\backend-project\backendproject\backendproject\Views\Home\Index.cshtml"
                 foreach (var item in Model.Events.Take(4))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"single-event mb-35\">\r\n                        <div class=\"event-date\">\r\n                            <h3><a href=\"event-details.html\">");
#nullable restore
#line 125 "C:\Users\User\Desktop\backend-project\backendproject\backendproject\Views\Home\Index.cshtml"
                                                        Write(item.Day.ToString("dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>");
#nullable restore
#line 125 "C:\Users\User\Desktop\backend-project\backendproject\backendproject\Views\Home\Index.cshtml"
                                                                                      Write(item.Month.ToString("MMMM"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></a></h3>\r\n                        </div>\r\n                        <div class=\"event-content text-left\">\r\n                            <div class=\"event-content-left\">\r\n                                <h4><a href=\"event-details.html\">");
#nullable restore
#line 129 "C:\Users\User\Desktop\backend-project\backendproject\backendproject\Views\Home\Index.cshtml"
                                                            Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h4>\r\n                                <ul>\r\n                                    <li><i class=\"fa fa-clock-o\"></i>");
#nullable restore
#line 131 "C:\Users\User\Desktop\backend-project\backendproject\backendproject\Views\Home\Index.cshtml"
                                                                Write(item.StartTime.ToString("hh:mm tt"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 131 "C:\Users\User\Desktop\backend-project\backendproject\backendproject\Views\Home\Index.cshtml"
                                                                                                       Write(item.EndTime.ToString("hh:mm tt"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                    <li><i class=\"fa fa-map-marker\"></i>");
#nullable restore
#line 132 "C:\Users\User\Desktop\backend-project\backendproject\backendproject\Views\Home\Index.cshtml"
                                                                   Write(item.City);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
                                </ul>
                            </div>
                            <div class=""event-content-right"">
                                <a class=""default-btn"" href=""event-details.html"">join now</a>
                            </div>
                        </div>
                    </div>
");
#nullable restore
#line 140 "C:\Users\User\Desktop\backend-project\backendproject\backendproject\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n            <div class=\"col-md-6 hidden-sm col-xs-12\">\r\n");
#nullable restore
#line 143 "C:\Users\User\Desktop\backend-project\backendproject\backendproject\Views\Home\Index.cshtml"
                     foreach (var item in Model.Events.Skip(4).Take(4))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"single-event mb-35\">\r\n                            <div class=\"event-date\">\r\n                                <h3><a href=\"event-details.html\">");
#nullable restore
#line 147 "C:\Users\User\Desktop\backend-project\backendproject\backendproject\Views\Home\Index.cshtml"
                                                            Write(item.Day.ToString("dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>");
#nullable restore
#line 147 "C:\Users\User\Desktop\backend-project\backendproject\backendproject\Views\Home\Index.cshtml"
                                                                                          Write(item.Month.ToString("MMMM"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></a></h3>
                            </div>
                            <div class=""event-content text-left"">
                                <div class=""event-content-left"">
                                    <h4><a href=""event-details.html"">");
#nullable restore
#line 151 "C:\Users\User\Desktop\backend-project\backendproject\backendproject\Views\Home\Index.cshtml"
                                                                Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h4>\r\n                                    <ul>\r\n                                        <li><i class=\"fa fa-clock-o\"></i>");
#nullable restore
#line 153 "C:\Users\User\Desktop\backend-project\backendproject\backendproject\Views\Home\Index.cshtml"
                                                                    Write(item.StartTime.ToString("hh:mm tt"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 153 "C:\Users\User\Desktop\backend-project\backendproject\backendproject\Views\Home\Index.cshtml"
                                                                                                           Write(item.EndTime.ToString("hh:mm tt"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                        <li><i class=\"fa fa-map-marker\"></i>");
#nullable restore
#line 154 "C:\Users\User\Desktop\backend-project\backendproject\backendproject\Views\Home\Index.cshtml"
                                                                       Write(item.City);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
                                    </ul>
                                </div>
                                <div class=""event-content-right"">
                                    <a class=""default-btn"" href=""event-details.html"">join now</a>
                                </div>
                            </div>
                        </div>
");
#nullable restore
#line 162 "C:\Users\User\Desktop\backend-project\backendproject\backendproject\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<!-- Event Area End -->\r\n<!-- Testimonial Area Start -->\r\n");
#nullable restore
#line 169 "C:\Users\User\Desktop\backend-project\backendproject\backendproject\Views\Home\Index.cshtml"
Write(await Component.InvokeAsync("Testimonial"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Testimonial Area End -->
<!-- Blog Area Start -->
<div class=""blog-area pt-150 pb-150"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-xs-12"">
                <div class=""section-title text-center"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4a86126b73b7921284563a2188e5226c286e673a24109", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    <h2>LATEST FROM BLOG</h2>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n            ");
#nullable restore
#line 183 "C:\Users\User\Desktop\backend-project\backendproject\backendproject\Views\Home\Index.cshtml"
       Write(await Component.InvokeAsync("Blog",3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n<!-- Blog Area End -->\r\n<!-- Subscribe Start -->\r\n");
#nullable restore
#line 189 "C:\Users\User\Desktop\backend-project\backendproject\backendproject\Views\Home\Index.cshtml"
Write(await Component.InvokeAsync("Subscribe"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- Subscribe End -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
