#pragma checksum "d:\2019\faegdotnetcore_segundosemestre\myshop\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1db0d079a0da9c4267f7602972513edc54c2dd57"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/Index.cshtml", typeof(AspNetCore.Views_Product_Index))]
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
#line 1 "d:\2019\faegdotnetcore_segundosemestre\myshop\Views\_ViewImports.cshtml"
using myshop;

#line default
#line hidden
#line 2 "d:\2019\faegdotnetcore_segundosemestre\myshop\Views\_ViewImports.cshtml"
using myshop.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1db0d079a0da9c4267f7602972513edc54c2dd57", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"778f4a0eb2d7e64ca5ebfa603b461ddb51d38a85", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<myshop.Models.Product>>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(38, 35, true);
            WriteLiteral("<!DOCTYPE HTML>\r\n<html lang=\"en\">\r\n");
            EndContext();
            BeginContext(73, 1290, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1db0d079a0da9c4267f7602972513edc54c2dd573364", async() => {
                BeginContext(79, 1277, true);
                WriteLiteral(@"
<meta charset=""utf-8"">
<meta http-equiv=""pragma"" content=""no-cache"" />
<meta http-equiv=""cache-control"" content=""max-age=604800"" />
<meta name=""viewport"" content=""width=device-width, initial-scale=1, shrink-to-fit=no"">
<meta name=""author"" content=""Bootstrap-ecommerce by Vosidiy"">
 
<title>UI KIT - Marketplace and Ecommerce html template</title>
 
<link href=""/images/favicon.ico"" rel=""shortcut icon"" type=""image/x-icon"">
 
<!-- jQuery -->
<script src=""/js/jquery-2.0.0.min.js"" type=""text/javascript""></script>
 
<!-- Bootstrap4 files-->
<script src=""/js/bootstrap.bundle.min.js"" type=""text/javascript""></script>
<link href=""/css/bootstrap.css"" rel=""stylesheet"" type=""text/css""/>
 
<!-- Font awesome 5 -->
<link href=""/fonts/fontawesome/stylesheets/fontawesome-all.min.css"" type=""text/css"" rel=""stylesheet"">
 
<!-- custom style -->
<link href=""/css/ui.css"" rel=""stylesheet"" type=""text/css""/>
<link href=""/css/responsive.css"" rel=""stylesheet"" media=""only screen and (max-width: 1200px)"" />
 
<!-- c");
                WriteLiteral("ustom javascript -->\r\n<script src=\"/js/script.js\" type=\"text/javascript\"></script>\r\n \r\n<script type=\"text/javascript\">\r\n/// some script\r\n \r\n// jquery ready start\r\n$(document).ready(function() {\r\n    // jQuery code\r\n \r\n}); \r\n// jquery end\r\n</script>\r\n \r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1363, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1365, 4165, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1db0d079a0da9c4267f7602972513edc54c2dd575949", async() => {
                BeginContext(1371, 2739, true);
                WriteLiteral(@"
<header class=""section-header"">
<nav class=""navbar navbar-top navbar-expand-lg navbar-dark bg-secondary"">
<div class=""container"">
  <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarNav"" aria-controls=""navbarNav"" aria-expanded=""false"" aria-label=""Toggle navigation"">
    <span class=""navbar-toggler-icon""></span>
  </button>
  <div class=""collapse navbar-collapse"" id=""navbarNav"">
    <ul class=""navbar-nav"">
<li class=""nav-item active"">
<a class=""nav-link"" href=""http://bootstrap-ecommerce.com"">Home <span class=""sr-only"">(current)</span></a>
</li>
<li class=""nav-item""><a class=""nav-link"" href=""html-components.html""> Documentation </a></li>
<li class=""nav-item dropdown"">
    <a class=""nav-link  dropdown-toggle"" href=""#"" data-toggle=""dropdown"">  Dropdown  </a>
    <ul class=""dropdown-menu"">
      <li><a class=""dropdown-item"" href=""#""> Menu item 1</a></li>
      <li><a class=""dropdown-item"" href=""#""> Menu item 2 </a></li>
    </ul>
</li>
<li class=""nav-item""");
                WriteLiteral(@"><a class=""nav-link"" href=""http://bootstrap-ecommerce.com""> Download <i class=""fa fa-download""></i></a></li>
    </ul>
  </div>
</div> <!-- container //  -->
</nav>
<section class=""header-main shadow"">
    <div class=""container"">
<div class=""row align-items-center"">
    <div class=""col-lg-3 col-sm-4"">
    <div class=""brand-wrap"">
        <img class=""logo"" src=""images/logo-dark.png"">
        <h2 class=""logo-text"">LOGO</h2>
    </div> <!-- brand-wrap.// -->
    </div>
    <div class=""col-lg-6 col-sm-8"">
             
    </div> <!-- col.// -->
    <div class=""col-lg-3 col-sm-12"">
            <a href=""#"" class=""widget-header float-md-right"">
                <div class=""icontext"">
                    <div class=""icon-wrap""><i class=""flip-h fa-lg fa fa-phone""></i></div>
                    <div class=""text-wrap"">
                        <small>Phone</small>
                        <div>+97150 2813773</div>
                    </div>
                </div>
            </a>
    </div> <!--");
                WriteLiteral(@" col.// -->
</div> <!-- row.// -->
    </div> <!-- container.// -->
</section> <!-- header-main .// -->
</header> <!-- section-header.// -->
 
<!-- ========================= SECTION PAGETOP ========================= -->
<section class=""section-pagetop bg-secondary"">
<div class=""container clearfix"">
    <h2 class=""title-page"">Produto</h2>
</div> <!-- container //  -->
</section>
<!-- ========================= SECTION INTRO END// ========================= -->
 
<!-- ========================= SECTION CONTENT ========================= -->
<section class=""section-content bg padding-y"">
<div class=""container"">
 
<div class=""row"">
    <main class=""col-sm-9"">
 
        ");
                EndContext();
                BeginContext(4111, 79, false);
#line 112 "d:\2019\faegdotnetcore_segundosemestre\myshop\Views\Product\Index.cshtml"
   Write(Html.ActionLink("Novo","Form","Product",null, new {@class = "btn btn-primary"}));

#line default
#line hidden
                EndContext();
                BeginContext(4190, 360, true);
                WriteLiteral(@"
        <table class=""table"">
            <thead>
                <tr>
                <th scope=""col"">#</th>
                <th scope=""col"">Nome</th>
                <th scope=""col"">Descrição</th>
                <th scope=""col"">Preço</th>
                <th scope=""col"">Foto</th>
                </tr>
            </thead>
            <tbody>
");
                EndContext();
#line 124 "d:\2019\faegdotnetcore_segundosemestre\myshop\Views\Product\Index.cshtml"
                 foreach (var product in Model)
                {

#line default
#line hidden
                BeginContext(4618, 46, true);
                WriteLiteral("                <tr>\r\n                    <td>");
                EndContext();
                BeginContext(4665, 10, false);
#line 127 "d:\2019\faegdotnetcore_segundosemestre\myshop\Views\Product\Index.cshtml"
                   Write(product.Id);

#line default
#line hidden
                EndContext();
                BeginContext(4675, 31, true);
                WriteLiteral("</td>\r\n                    <td>");
                EndContext();
                BeginContext(4707, 12, false);
#line 128 "d:\2019\faegdotnetcore_segundosemestre\myshop\Views\Product\Index.cshtml"
                   Write(product.Name);

#line default
#line hidden
                EndContext();
                BeginContext(4719, 31, true);
                WriteLiteral("</td>\r\n                    <td>");
                EndContext();
                BeginContext(4751, 19, false);
#line 129 "d:\2019\faegdotnetcore_segundosemestre\myshop\Views\Product\Index.cshtml"
                   Write(product.Description);

#line default
#line hidden
                EndContext();
                BeginContext(4770, 31, true);
                WriteLiteral("</td>\r\n                    <td>");
                EndContext();
                BeginContext(4802, 13, false);
#line 130 "d:\2019\faegdotnetcore_segundosemestre\myshop\Views\Product\Index.cshtml"
                   Write(product.Price);

#line default
#line hidden
                EndContext();
                BeginContext(4815, 31, true);
                WriteLiteral("</td>\r\n                    <td>");
                EndContext();
                BeginContext(4847, 23, false);
#line 131 "d:\2019\faegdotnetcore_segundosemestre\myshop\Views\Product\Index.cshtml"
                   Write(product.FileNameStorage);

#line default
#line hidden
                EndContext();
                BeginContext(4870, 30, true);
                WriteLiteral("</td>\r\n                </tr>\r\n");
                EndContext();
#line 133 "d:\2019\faegdotnetcore_segundosemestre\myshop\Views\Product\Index.cshtml"
                }

#line default
#line hidden
                BeginContext(4919, 604, true);
                WriteLiteral(@"            </tbody>
        </table>

 
 
 
    </main> <!-- col.// -->
</div>
 
</div> <!-- container .//  -->
</section>
<!-- ========================= SECTION CONTENT END// ========================= -->
 
 
 
<!-- ========================= FOOTER ========================= -->
<footer class=""section-footer bg-secondary"">
    <div class=""container"">
        <section class=""footer-top padding-top"">
             
        </section> <!-- //footer-top -->
    </div><!-- //container -->
</footer>
<!-- ========================= FOOTER END // ========================= -->
 
 
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5530, 9, true);
            WriteLiteral("\r\n</html>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<myshop.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
