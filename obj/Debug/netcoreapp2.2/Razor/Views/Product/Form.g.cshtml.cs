#pragma checksum "d:\2019\faegdotnetcore_segundosemestre\myshop\Views\Product\Form.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e417be0be6f51555bccffbde06f86cbb1e7c64a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Form), @"mvc.1.0.view", @"/Views/Product/Form.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/Form.cshtml", typeof(AspNetCore.Views_Product_Form))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e417be0be6f51555bccffbde06f86cbb1e7c64a", @"/Views/Product/Form.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"778f4a0eb2d7e64ca5ebfa603b461ddb51d38a85", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Form : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<myshop.Models.Product>
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
            BeginContext(31, 35, true);
            WriteLiteral("<!DOCTYPE HTML>\r\n<html lang=\"en\">\r\n");
            EndContext();
            BeginContext(66, 1290, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e417be0be6f51555bccffbde06f86cbb1e7c64a3350", async() => {
                BeginContext(72, 1277, true);
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
            BeginContext(1356, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1358, 4485, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e417be0be6f51555bccffbde06f86cbb1e7c64a5935", async() => {
                BeginContext(1364, 2784, true);
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
 
<article class=""card"">
    <div class=""card-body"">
");
                EndContext();
#line 114 "d:\2019\faegdotnetcore_segundosemestre\myshop\Views\Product\Form.cshtml"
         using (Html.BeginForm("Form","Product")){

#line default
#line hidden
                BeginContext(4200, 62, true);
                WriteLiteral("        <!--<form action = \"/product/save\" method=\"POST\">-->\r\n");
                EndContext();
                BeginContext(4273, 25, false);
#line 116 "d:\2019\faegdotnetcore_segundosemestre\myshop\Views\Product\Form.cshtml"
     Write(Html.HiddenFor(m => m.Id));

#line default
#line hidden
                EndContext();
                BeginContext(4300, 50, true);
                WriteLiteral("          <div class=\"form-group\">\r\n              ");
                EndContext();
                BeginContext(4351, 26, false);
#line 118 "d:\2019\faegdotnetcore_segundosemestre\myshop\Views\Product\Form.cshtml"
         Write(Html.LabelFor(m => m.Name));

#line default
#line hidden
                EndContext();
                BeginContext(4377, 16, true);
                WriteLiteral("\r\n              ");
                EndContext();
                BeginContext(4394, 84, false);
#line 119 "d:\2019\faegdotnetcore_segundosemestre\myshop\Views\Product\Form.cshtml"
         Write(Html.EditorFor(m => m.Name, new { htmlAttributes = new { @class = "form-control" }}));

#line default
#line hidden
                EndContext();
                BeginContext(4478, 16, true);
                WriteLiteral("\r\n              ");
                EndContext();
                BeginContext(4495, 38, false);
#line 120 "d:\2019\faegdotnetcore_segundosemestre\myshop\Views\Product\Form.cshtml"
         Write(Html.ValidationMessageFor(m => m.Name));

#line default
#line hidden
                EndContext();
                BeginContext(4533, 70, true);
                WriteLiteral("\r\n          </div>\r\n          <div class=\"form-group\">\r\n              ");
                EndContext();
                BeginContext(4604, 33, false);
#line 123 "d:\2019\faegdotnetcore_segundosemestre\myshop\Views\Product\Form.cshtml"
         Write(Html.LabelFor(m => m.Description));

#line default
#line hidden
                EndContext();
                BeginContext(4637, 16, true);
                WriteLiteral("\r\n              ");
                EndContext();
                BeginContext(4654, 91, false);
#line 124 "d:\2019\faegdotnetcore_segundosemestre\myshop\Views\Product\Form.cshtml"
         Write(Html.EditorFor(m => m.Description, new { htmlAttributes = new { @class = "form-control" }}));

#line default
#line hidden
                EndContext();
                BeginContext(4745, 16, true);
                WriteLiteral("\r\n              ");
                EndContext();
                BeginContext(4762, 45, false);
#line 125 "d:\2019\faegdotnetcore_segundosemestre\myshop\Views\Product\Form.cshtml"
         Write(Html.ValidationMessageFor(m => m.Description));

#line default
#line hidden
                EndContext();
                BeginContext(4807, 70, true);
                WriteLiteral("\r\n          </div>\r\n          <div class=\"form-group\">\r\n              ");
                EndContext();
                BeginContext(4878, 27, false);
#line 128 "d:\2019\faegdotnetcore_segundosemestre\myshop\Views\Product\Form.cshtml"
         Write(Html.LabelFor(m => m.Price));

#line default
#line hidden
                EndContext();
                BeginContext(4905, 16, true);
                WriteLiteral("\r\n              ");
                EndContext();
                BeginContext(4922, 85, false);
#line 129 "d:\2019\faegdotnetcore_segundosemestre\myshop\Views\Product\Form.cshtml"
         Write(Html.EditorFor(m => m.Price, new { htmlAttributes = new { @class = "form-control" }}));

#line default
#line hidden
                EndContext();
                BeginContext(5007, 16, true);
                WriteLiteral("\r\n              ");
                EndContext();
                BeginContext(5024, 39, false);
#line 130 "d:\2019\faegdotnetcore_segundosemestre\myshop\Views\Product\Form.cshtml"
         Write(Html.ValidationMessageFor(m => m.Price));

#line default
#line hidden
                EndContext();
                BeginContext(5063, 127, true);
                WriteLiteral("\r\n          </div>          \r\n          <button type=\"submit\" class=\"btn btn-primary\">Salvar</button>\r\n        <!--</form>-->\r\n");
                EndContext();
#line 134 "d:\2019\faegdotnetcore_segundosemestre\myshop\Views\Product\Form.cshtml"
        }

#line default
#line hidden
                BeginContext(5201, 635, true);
                WriteLiteral(@"    </div> <!-- card-body .// -->
</article> <!-- card product .// -->
 
 
 
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
            BeginContext(5843, 9, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<myshop.Models.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
