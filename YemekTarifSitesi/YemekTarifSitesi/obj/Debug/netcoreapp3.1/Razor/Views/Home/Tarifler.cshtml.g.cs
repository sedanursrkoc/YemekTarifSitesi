#pragma checksum "C:\Users\Hp\source\repos\WebProgramlamaProjeOdevi\YemekTarifSitesi\YemekTarifSitesi\Views\Home\Tarifler.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b329e2c8e2301bc72c6c96863406dcb49a5b40e2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Tarifler), @"mvc.1.0.view", @"/Views/Home/Tarifler.cshtml")]
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
#line 1 "C:\Users\Hp\source\repos\WebProgramlamaProjeOdevi\YemekTarifSitesi\YemekTarifSitesi\Views\_ViewImports.cshtml"
using YemekTarifSitesi;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Hp\source\repos\WebProgramlamaProjeOdevi\YemekTarifSitesi\YemekTarifSitesi\Views\_ViewImports.cshtml"
using YemekTarifSitesi.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b329e2c8e2301bc72c6c96863406dcb49a5b40e2", @"/Views/Home/Tarifler.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5af5f53225f22390d87fc9ccf2f14f9c15e97e05", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Tarifler : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<YemekTarifSitesi.Models.YemekTarifModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Hp\source\repos\WebProgramlamaProjeOdevi\YemekTarifSitesi\YemekTarifSitesi\Views\Home\Tarifler.cshtml"
  
    ViewData["Title"] = "Tarifler";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""hero-wrap hero-wrap-2"" style=""background-image: url('images/image_1.jpg');"" data-stellar-background-ratio=""0.5"">
    <div class=""overlay""></div>
    <div class=""container"">
        <div class=""row no-gutters slider-text align-items-end justify-content-center"">
            <div class=""col-md-9 ftco-animate text-center mb-4"">
                <h1 class=""mb-2 bread"">Tarifler</h1>
                <p class=""breadcrumbs""><span class=""mr-2""><a href=""index.html"">Home <i class=""ion-ios-arrow-forward""></i></a></span> <span>Blog <i class=""ion-ios-arrow-forward""></i></span></p>
            </div>
        </div>
    </div>
</section>


<section class=""ftco-section bg-light"">

    <div class=""container"">

        <div class=""row ftco-search"">
            <div class=""col-md-12 nav-link-wrap"">
                <div class=""nav nav-pills d-flex text-center"" id=""v-pills-tab"" role=""tablist"" aria-orientation=""vertical"">
                    <a class=""nav-link ftco-animate active"" id=""v-pills-1-t");
            WriteLiteral(@"ab"" data-toggle=""pill"" href=""#v-pills-1"" role=""tab"" aria-controls=""v-pills-1"" aria-selected=""true"">Hepsi</a>

                    <a class=""nav-link ftco-animate"" id=""v-pills-2-tab"" data-toggle=""pill"" href=""#v-pills-2"" role=""tab"" aria-controls=""v-pills-2"" aria-selected=""false"">Kahvaltı</a>

                    <a class=""nav-link ftco-animate"" id=""v-pills-3-tab"" data-toggle=""pill"" href=""#v-pills-3"" role=""tab"" aria-controls=""v-pills-3"" aria-selected=""false"">Öğle</a>

                    <a class=""nav-link ftco-animate"" id=""v-pills-4-tab"" data-toggle=""pill"" href=""#v-pills-4"" role=""tab"" aria-controls=""v-pills-4"" aria-selected=""false"">Akşam</a>

                    <a class=""nav-link ftco-animate"" id=""v-pills-5-tab"" data-toggle=""pill"" href=""#v-pills-5"" role=""tab"" aria-controls=""v-pills-5"" aria-selected=""false"">Tatlı</a>

                    <a class=""nav-link ftco-animate"" id=""v-pills-6-tab"" data-toggle=""pill"" href=""#v-pills-6"" role=""tab"" aria-controls=""v-pills-6"" aria-selected=""false"">İçecek</a>

    ");
            WriteLiteral(@"            </div>
            </div>
            <div class=""col-md-12 tab-wrap"">

                <div class=""tab-content"" id=""v-pills-tabContent"">
                    <div class=""tab-pane fade show active"" id=""v-pills-1"" role=""tabpanel"" aria-labelledby=""v-pills-day-1-tab"">
");
#nullable restore
#line 45 "C:\Users\Hp\source\repos\WebProgramlamaProjeOdevi\YemekTarifSitesi\YemekTarifSitesi\Views\Home\Tarifler.cshtml"
                         foreach (var item in Model.Yemek)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"col-md-4 ftco-animate\">\r\n                                <div class=\"blog-entry\">\r\n                                    <img");
            BeginWriteAttribute("src", " src=\"", 2720, "\"", 2740, 1);
#nullable restore
#line 49 "C:\Users\Hp\source\repos\WebProgramlamaProjeOdevi\YemekTarifSitesi\YemekTarifSitesi\Views\Home\Tarifler.cshtml"
WriteAttributeValue("", 2726, item.Fotograf, 2726, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""d-block w-100 h-100"">
                                    <div class=""text pt-3 pb-4 px-4"">
                                        <div class=""meta"">
                                            <div><a href=""#"">Tür:</a></div>
                                            <div><a href=""#"">Admin</a></div>
                                        </div>
                                        <h3 class=""heading""><a href=""#"">");
#nullable restore
#line 55 "C:\Users\Hp\source\repos\WebProgramlamaProjeOdevi\YemekTarifSitesi\YemekTarifSitesi\Views\Home\Tarifler.cshtml"
                                                                   Write(item.YemekAdi);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a></h3>
                                        <p class=""clearfix"">
                                            <a href=""#"" class=""float-left read"">Read more</a>
                                            <a href=""#"" class=""float-right meta-chat"">Puan: ");
#nullable restore
#line 58 "C:\Users\Hp\source\repos\WebProgramlamaProjeOdevi\YemekTarifSitesi\YemekTarifSitesi\Views\Home\Tarifler.cshtml"
                                                                                       Write(item.Puan);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                        </p>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 63 "C:\Users\Hp\source\repos\WebProgramlamaProjeOdevi\YemekTarifSitesi\YemekTarifSitesi\Views\Home\Tarifler.cshtml"

                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div>
                    <div class=""tab-pane fade"" id=""v-pills-2"" role=""tabpanel"" aria-labelledby=""v-pills-day-2-tab"">
                    </div>
                    <div class=""tab-pane fade"" id=""v-pills-3"" role=""tabpanel"" aria-labelledby=""v-pills-day-3-tab"">
                    </div>
                    <div class=""tab-pane fade"" id=""v-pills-4"" role=""tabpanel"" aria-labelledby=""v-pills-day-4-tab"">
                    </div>
                    <div class=""tab-pane fade"" id=""v-pills-5"" role=""tabpanel"" aria-labelledby=""v-pills-day-5-tab"">
");
#nullable restore
#line 73 "C:\Users\Hp\source\repos\WebProgramlamaProjeOdevi\YemekTarifSitesi\YemekTarifSitesi\Views\Home\Tarifler.cshtml"
                         foreach (var item in Model.Yemek)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 75 "C:\Users\Hp\source\repos\WebProgramlamaProjeOdevi\YemekTarifSitesi\YemekTarifSitesi\Views\Home\Tarifler.cshtml"
                             foreach (var item2 in Model.YemekTur)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 77 "C:\Users\Hp\source\repos\WebProgramlamaProjeOdevi\YemekTarifSitesi\YemekTarifSitesi\Views\Home\Tarifler.cshtml"
                                 if (@item2.TurId == 1)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div class=\"col-md-4 ftco-animate\">\r\n                                        <div class=\"blog-entry\">\r\n                                            <img");
            BeginWriteAttribute("src", " src=\"", 4704, "\"", 4724, 1);
#nullable restore
#line 81 "C:\Users\Hp\source\repos\WebProgramlamaProjeOdevi\YemekTarifSitesi\YemekTarifSitesi\Views\Home\Tarifler.cshtml"
WriteAttributeValue("", 4710, item.Fotograf, 4710, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""d-block w-100 h-100"">
                                            <div class=""text pt-3 pb-4 px-4"">
                                                <div class=""meta"">
                                                    <div><a href=""#"">Tür:</a></div>
                                                    <div><a href=""#"">Admin</a></div>
                                                </div>
                                                <h3 class=""heading""><a href=""#"">");
#nullable restore
#line 87 "C:\Users\Hp\source\repos\WebProgramlamaProjeOdevi\YemekTarifSitesi\YemekTarifSitesi\Views\Home\Tarifler.cshtml"
                                                                           Write(item.YemekAdi);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a></h3>
                                                <p class=""clearfix"">
                                                    <a href=""#"" class=""float-left read"">Read more</a>
                                                    <a href=""#"" class=""float-right meta-chat"">Puan: ");
#nullable restore
#line 90 "C:\Users\Hp\source\repos\WebProgramlamaProjeOdevi\YemekTarifSitesi\YemekTarifSitesi\Views\Home\Tarifler.cshtml"
                                                                                               Write(item.Puan);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                                </p>\r\n                                            </div>\r\n                                        </div>\r\n                                    </div>\r\n");
#nullable restore
#line 95 "C:\Users\Hp\source\repos\WebProgramlamaProjeOdevi\YemekTarifSitesi\YemekTarifSitesi\Views\Home\Tarifler.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 95 "C:\Users\Hp\source\repos\WebProgramlamaProjeOdevi\YemekTarifSitesi\YemekTarifSitesi\Views\Home\Tarifler.cshtml"
                                 
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 96 "C:\Users\Hp\source\repos\WebProgramlamaProjeOdevi\YemekTarifSitesi\YemekTarifSitesi\Views\Home\Tarifler.cshtml"
                             

                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"tab-pane fade\" id=\"v-pills-6\" role=\"tabpanel\" aria-labelledby=\"v-pills-day-6-tab\">\r\n                    </div>\r\n");
            WriteLiteral("</section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<YemekTarifSitesi.Models.YemekTarifModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
