#pragma checksum "C:\Users\ateo\Documents\GitHub\SelenYapayZeka\Views\Anasayfa\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5983263ad5dc99415278b2087b69a9074e0d5ab5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Anasayfa_Index), @"mvc.1.0.view", @"/Views/Anasayfa/Index.cshtml")]
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
#line 1 "C:\Users\ateo\Documents\GitHub\SelenYapayZeka\Views\_ViewImports.cshtml"
using SelenYapayZekaGit;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ateo\Documents\GitHub\SelenYapayZeka\Views\_ViewImports.cshtml"
using SelenYapayZekaGit.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\ateo\Documents\GitHub\SelenYapayZeka\Views\Anasayfa\Index.cshtml"
using SelenYapayZekaGit.Classes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ateo\Documents\GitHub\SelenYapayZeka\Views\Anasayfa\Index.cshtml"
using SelenYapayZekaGit.DAL.Classes;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5983263ad5dc99415278b2087b69a9074e0d5ab5", @"/Views/Anasayfa/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d22af923a9f3742302fc73aebbfd3cf86147b14d", @"/Views/_ViewImports.cshtml")]
    public class Views_Anasayfa_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Anasayfa/img/blog/hızlı.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Anasayfa/img/blog/gıvenli (2).png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Anasayfa/img/blog/yapayus.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\ateo\Documents\GitHub\SelenYapayZeka\Views\Anasayfa\Index.cshtml"
    
      Layout = "_AnasayfaLayout";
      List<Kategori> kategoriList = ViewBag.KategoriList;
      List<Urun> urunList = ViewBag.UrunList;
  

#line default
#line hidden
#nullable disable
            WriteLiteral(@"  <!-- Hero Section Begin -->
  <section class=""hero"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-3"">
                <div class=""hero__categories"">
                    <div class=""hero__categories__all"">
                        <i class=""fa fa-bars""></i>
                        <span>Tüm Kategoriler </span>
                    </div>
                    <ul>
                        
");
#nullable restore
#line 20 "C:\Users\ateo\Documents\GitHub\SelenYapayZeka\Views\Anasayfa\Index.cshtml"
                         foreach (var kategori in kategoriList)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li><a");
            BeginWriteAttribute("href", " href=\'", 791, "\'", 828, 2);
            WriteAttributeValue("", 798, "/kategori/", 798, 10, true);
#nullable restore
#line 22 "C:\Users\ateo\Documents\GitHub\SelenYapayZeka\Views\Anasayfa\Index.cshtml"
WriteAttributeValue("", 808, kategori.KategoriId, 808, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 22 "C:\Users\ateo\Documents\GitHub\SelenYapayZeka\Views\Anasayfa\Index.cshtml"
                                                                    Write(kategori.Isim);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 23 "C:\Users\ateo\Documents\GitHub\SelenYapayZeka\Views\Anasayfa\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"              
                    </ul>
                </div>
            </div>
            <div class=""col-lg-9"">
               
                <div class=""hero__item set-bg"" data-setbg=""../../Anasayfa/img/hero/banner.jpg"">
                    <div class=""hero__text"">
                        <span>Organik Oyuncak</span>
                        <h2> <br />100% Organik <br> Oyuncaklar</h2>
                        <p>Çocuğunuzun sağlığı bizim içinde önemli</p>
                        <a href=""#"" class=""primary-btn"">Satın Al</a>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<!-- Hero Section End -->

<!-- Categories Section Begin -->
<section class=""categories"">
    <div class=""container"">
        <div class=""row"">
            <div class=""categories__slider owl-carousel"">
");
#nullable restore
#line 49 "C:\Users\ateo\Documents\GitHub\SelenYapayZeka\Views\Anasayfa\Index.cshtml"
                  
                    foreach (var kategori in kategoriList)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "C:\Users\ateo\Documents\GitHub\SelenYapayZeka\Views\Anasayfa\Index.cshtml"
                         if(!string.IsNullOrEmpty(kategori.ResimUrl)){

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"col-lg-3\">\r\n                            <div class=\"categories__item set-bg\" data-setbg=\"");
#nullable restore
#line 54 "C:\Users\ateo\Documents\GitHub\SelenYapayZeka\Views\Anasayfa\Index.cshtml"
                                                                        Write(kategori.ResimUrl);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                                <h5><a");
            BeginWriteAttribute("href", " href=\'", 2116, "\'", 2153, 2);
            WriteAttributeValue("", 2123, "/kategori/", 2123, 10, true);
#nullable restore
#line 55 "C:\Users\ateo\Documents\GitHub\SelenYapayZeka\Views\Anasayfa\Index.cshtml"
WriteAttributeValue("", 2133, kategori.KategoriId, 2133, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 55 "C:\Users\ateo\Documents\GitHub\SelenYapayZeka\Views\Anasayfa\Index.cshtml"
                                                                        Write(kategori.Isim);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h5>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 58 "C:\Users\ateo\Documents\GitHub\SelenYapayZeka\Views\Anasayfa\Index.cshtml"
                        }else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"col-lg-3\">\r\n                          \r\n                                <h5><a href=\"#\">");
#nullable restore
#line 61 "C:\Users\ateo\Documents\GitHub\SelenYapayZeka\Views\Anasayfa\Index.cshtml"
                                           Write(kategori.Isim);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h5>\r\n                           \r\n                        </div>\r\n");
#nullable restore
#line 64 "C:\Users\ateo\Documents\GitHub\SelenYapayZeka\Views\Anasayfa\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 64 "C:\Users\ateo\Documents\GitHub\SelenYapayZeka\Views\Anasayfa\Index.cshtml"
                         
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral(@"          
            </div>
        </div>
    </div>
</section>
<!-- Categories Section End -->

<!-- Featured Section Begin -->
<section class=""featured spad"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""section-title"">
                    <h2>En Çok Incelenen Ürünler</h2>
                </div>
                <div class=""featured__controls"">
                  
                </div>
            </div>
        </div>
        <div class=""row featured__filter"">
");
#nullable restore
#line 88 "C:\Users\ateo\Documents\GitHub\SelenYapayZeka\Views\Anasayfa\Index.cshtml"
              
                foreach (var urun in urunList)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-lg-3 col-md-4 col-sm-6 mix oranges fresh-meat\">\r\n                        <div class=\"featured__item\">\r\n                            <div class=\"featured__item__pic set-bg\" data-setbg=\"");
#nullable restore
#line 93 "C:\Users\ateo\Documents\GitHub\SelenYapayZeka\Views\Anasayfa\Index.cshtml"
                                                                           Write(urun.ResimUrl);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""">
                                <ul class=""featured__item__pic__hover"">
                                    <li><a href=""#""><i class=""fa fa-heart""></i></a></li>
                                    <li><a href=""#""><i class=""fa fa-retweet""></i></a></li>
                                    <li><a href=""#""><i class=""fa fa-shopping-cart""></i></a></li>
                                </ul>
                            </div>
                            <div class=""featured__item__text"">
                                <h6><a href=""#"">");
#nullable restore
#line 101 "C:\Users\ateo\Documents\GitHub\SelenYapayZeka\Views\Anasayfa\Index.cshtml"
                                           Write(urun.Isim);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h6>\r\n                                <h5>");
#nullable restore
#line 102 "C:\Users\ateo\Documents\GitHub\SelenYapayZeka\Views\Anasayfa\Index.cshtml"
                               Write(urun.IncelemeAdet);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5> Kere Incelendi\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 106 "C:\Users\ateo\Documents\GitHub\SelenYapayZeka\Views\Anasayfa\Index.cshtml"
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral(@"          
        </div>
    </div>
</section>
<!-- Featured Section End -->

<!-- Banner Begin -->




<!-- Blog Section Begin -->
<section class=""from-blog spad"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""section-title from-blog__title"">
                    <h2>NEDEN BIZ</h2>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-lg-4 col-md-4 col-sm-6"">
                <div class=""blog__item"">
                    <div class=""blog__item__pic"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5983263ad5dc99415278b2087b69a9074e0d5ab514221", async() => {
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
            WriteLiteral(@"
                    </div>
                    <div class=""blog__item__text"">
                      
                        <h5><a href=""#"">Hızlı</a></h5>
                        <p> Güvendiğiniz markalara en kısa yoldan ulaşım </p>
                    </div>
                </div>
            </div>
            <div class=""col-lg-4 col-md-4 col-sm-6"">
                <div class=""blog__item"">
                    <div class=""blog__item__pic"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5983263ad5dc99415278b2087b69a9074e0d5ab515827", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                    <div class=""blog__item__text"">
                      
                        <h5><a href=""#"">Güvenilir</a></h5>
                        <p> Sadece Sağlık Bakanlığı onaylı ürünler </p> 
                    </div>
                </div>
            </div>
            <div class=""col-lg-4 col-md-4 col-sm-6"">
                <div class=""blog__item"">
                    <div class=""blog__item__pic"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5983263ad5dc99415278b2087b69a9074e0d5ab517432", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                    <div class=""blog__item__text"">
                      
                        <h5><a href=""#""> BIL 441 Yapay US </a></h5>
                        <p> Bil 441 Yapay Zeka teknolojisi kullanılmıştır! </p>
                    </div>
                </div>
            </div>
            
          
        </div>
    </div>
</section>
<!-- Blog Section End -->");
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
