#pragma checksum "C:\Users\shell\Desktop\ExperienceBookingSite\ExperienceBookingSite\WebMvc\Views\Shared\Components\CartList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dad87761c3db46c65133d80abfd77e16f9e2684e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_CartList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/CartList/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/CartList/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_CartList_Default))]
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
#line 1 "C:\Users\shell\Desktop\ExperienceBookingSite\ExperienceBookingSite\WebMvc\Views\_ViewImports.cshtml"
using WebMvc.Models.CartModels;

#line default
#line hidden
#line 2 "C:\Users\shell\Desktop\ExperienceBookingSite\ExperienceBookingSite\WebMvc\Views\_ViewImports.cshtml"
using WebMvc.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dad87761c3db46c65133d80abfd77e16f9e2684e", @"/Views/Shared/Components/CartList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4341fbaf0897b61d8c7b4ca459ee4d2056d94c4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_CartList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebMvc.Models.CartModels.Cart>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(38, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\shell\Desktop\ExperienceBookingSite\ExperienceBookingSite\WebMvc\Views\Shared\Components\CartList\Default.cshtml"
  
    ViewData["Title"] = "My Cart";

#line default
#line hidden
            BeginContext(79, 25, true);
            WriteLiteral("\n<div class=\"container\">\n");
            EndContext();
#line 8 "C:\Users\shell\Desktop\ExperienceBookingSite\ExperienceBookingSite\WebMvc\Views\Shared\Components\CartList\Default.cshtml"
     if (TempData.ContainsKey("BasketInoperativeMsg"))
    {

#line default
#line hidden
            BeginContext(165, 88, true);
            WriteLiteral("        <br />\n        <div class=\"alert alert-warning\" role=\"alert\">\n            &nbsp;");
            EndContext();
            BeginContext(254, 32, false);
#line 12 "C:\Users\shell\Desktop\ExperienceBookingSite\ExperienceBookingSite\WebMvc\Views\Shared\Components\CartList\Default.cshtml"
             Write(TempData["BasketInoperativeMsg"]);

#line default
#line hidden
            EndContext();
            BeginContext(286, 16, true);
            WriteLiteral("\n        </div>\n");
            EndContext();
#line 14 "C:\Users\shell\Desktop\ExperienceBookingSite\ExperienceBookingSite\WebMvc\Views\Shared\Components\CartList\Default.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(323, 67, true);
            WriteLiteral("        <article class=\"esh-basket-titles row\">\n            <br />\n");
            EndContext();
#line 19 "C:\Users\shell\Desktop\ExperienceBookingSite\ExperienceBookingSite\WebMvc\Views\Shared\Components\CartList\Default.cshtml"
             if (TempData.ContainsKey("BasketInoperativeMsg"))
            {

#line default
#line hidden
            BeginContext(467, 89, true);
            WriteLiteral("                <div class=\"alert alert-warning\" role=\"alert\">\n                    &nbsp;");
            EndContext();
            BeginContext(557, 32, false);
#line 22 "C:\Users\shell\Desktop\ExperienceBookingSite\ExperienceBookingSite\WebMvc\Views\Shared\Components\CartList\Default.cshtml"
                     Write(TempData["BasketInoperativeMsg"]);

#line default
#line hidden
            EndContext();
            BeginContext(589, 24, true);
            WriteLiteral("\n                </div>\n");
            EndContext();
#line 24 "C:\Users\shell\Desktop\ExperienceBookingSite\ExperienceBookingSite\WebMvc\Views\Shared\Components\CartList\Default.cshtml"
            }

#line default
#line hidden
            BeginContext(627, 389, true);
            WriteLiteral(@"
            <section class=""esh-basket-title col-xs-3"">Product</section>
            <section class=""esh-basket-title col-xs-3 hidden-lg-down""></section>
            <section class=""esh-basket-title col-xs-2"">Price</section>
            <section class=""esh-basket-title col-xs-2"">Quantity</section>
            <section class=""esh-basket-title col-xs-2"">Cost</section>
        </article>
");
            EndContext();
#line 33 "C:\Users\shell\Desktop\ExperienceBookingSite\ExperienceBookingSite\WebMvc\Views\Shared\Components\CartList\Default.cshtml"
         for (int i = 0; i < Model.Items.Count; i++)
        {
            var item = Model.Items[i];


#line default
#line hidden
            BeginContext(1120, 229, true);
            WriteLiteral("            <article class=\"esh-basket-items  row\">\n                <div>\n                    <section class=\"esh-basket-item esh-basket-item--middle col-lg-3 hidden-lg-down\">\n                        <img class=\"esh-basket-image\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1349, "\"", 1371, 1);
#line 40 "C:\Users\shell\Desktop\ExperienceBookingSite\ExperienceBookingSite\WebMvc\Views\Shared\Components\CartList\Default.cshtml"
WriteAttributeValue("", 1355, item.PictureUrl, 1355, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1372, 121, true);
            WriteLiteral(" />\n                    </section>\n                    <section class=\"esh-basket-item esh-basket-item--middle col-xs-3\">");
            EndContext();
            BeginContext(1494, 16, false);
#line 42 "C:\Users\shell\Desktop\ExperienceBookingSite\ExperienceBookingSite\WebMvc\Views\Shared\Components\CartList\Default.cshtml"
                                                                                 Write(item.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(1510, 99, true);
            WriteLiteral("</section>\n                    <section class=\"esh-basket-item esh-basket-item--middle col-xs-2\">$ ");
            EndContext();
            BeginContext(1610, 29, false);
#line 43 "C:\Users\shell\Desktop\ExperienceBookingSite\ExperienceBookingSite\WebMvc\Views\Shared\Components\CartList\Default.cshtml"
                                                                                   Write(item.UnitPrice.ToString("N2"));

#line default
#line hidden
            EndContext();
            BeginContext(1639, 142, true);
            WriteLiteral("</section>\n                    <section class=\"esh-basket-item esh-basket-item--middle col-xs-2\">\n                        <input type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("name", " name=\"", 1781, "\"", 1817, 1);
#line 45 "C:\Users\shell\Desktop\ExperienceBookingSite\ExperienceBookingSite\WebMvc\Views\Shared\Components\CartList\Default.cshtml"
WriteAttributeValue("", 1788, "quantities[" + i +"].Key", 1788, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 1818, "\"", 1834, 1);
#line 45 "C:\Users\shell\Desktop\ExperienceBookingSite\ExperienceBookingSite\WebMvc\Views\Shared\Components\CartList\Default.cshtml"
WriteAttributeValue("", 1826, item.Id, 1826, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1835, 81, true);
            WriteLiteral(" />\n                        <input type=\"number\" class=\"esh-basket-input\" min=\"1\"");
            EndContext();
            BeginWriteAttribute("name", " name=\"", 1916, "\"", 1954, 1);
#line 46 "C:\Users\shell\Desktop\ExperienceBookingSite\ExperienceBookingSite\WebMvc\Views\Shared\Components\CartList\Default.cshtml"
WriteAttributeValue("", 1923, "quantities[" + i +"].Value", 1923, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 1955, "\"", 1977, 1);
#line 46 "C:\Users\shell\Desktop\ExperienceBookingSite\ExperienceBookingSite\WebMvc\Views\Shared\Components\CartList\Default.cshtml"
WriteAttributeValue("", 1963, item.Quantity, 1963, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1978, 145, true);
            WriteLiteral(" />\n                    </section>\n                    <section class=\"esh-basket-item esh-basket-item--middle esh-basket-item--mark col-xs-2\">$ ");
            EndContext();
            BeginContext(2124, 60, false);
#line 48 "C:\Users\shell\Desktop\ExperienceBookingSite\ExperienceBookingSite\WebMvc\Views\Shared\Components\CartList\Default.cshtml"
                                                                                                         Write(Math.Round(item.Quantity * item.UnitPrice, 2).ToString("N2"));

#line default
#line hidden
            EndContext();
            BeginContext(2184, 115, true);
            WriteLiteral("</section>\n                </div>\n                <div class=\"row\">\n\n                </div>\n            </article>\n");
            EndContext();
            BeginContext(2300, 55, true);
            WriteLiteral("            <div class=\"esh-basket-items--border row\">\n");
            EndContext();
#line 56 "C:\Users\shell\Desktop\ExperienceBookingSite\ExperienceBookingSite\WebMvc\Views\Shared\Components\CartList\Default.cshtml"
                 if (item.OldUnitPrice != 0)
                {

#line default
#line hidden
            BeginContext(2418, 215, true);
            WriteLiteral("                    <div class=\"alert alert-warning esh-basket-margin12\" role=\"alert\">&nbsp;Note that the price of this article changed in our Catalog. The old price when you originally added it to the basket was $ ");
            EndContext();
            BeginContext(2634, 17, false);
#line 58 "C:\Users\shell\Desktop\ExperienceBookingSite\ExperienceBookingSite\WebMvc\Views\Shared\Components\CartList\Default.cshtml"
                                                                                                                                                                                                                  Write(item.OldUnitPrice);

#line default
#line hidden
            EndContext();
            BeginContext(2651, 8, true);
            WriteLiteral(" </div>\n");
            EndContext();
#line 59 "C:\Users\shell\Desktop\ExperienceBookingSite\ExperienceBookingSite\WebMvc\Views\Shared\Components\CartList\Default.cshtml"
                }

#line default
#line hidden
            BeginContext(2677, 38, true);
            WriteLiteral("            </div>\n            <br />\n");
            EndContext();
#line 62 "C:\Users\shell\Desktop\ExperienceBookingSite\ExperienceBookingSite\WebMvc\Views\Shared\Components\CartList\Default.cshtml"
        }

#line default
#line hidden
            BeginContext(2726, 482, true);
            WriteLiteral(@"        <div class=""container"">
            <article class=""esh-basket-titles esh-basket-titles--clean row"">
                <section class=""esh-basket-title col-xs-10""></section>
                <section class=""esh-basket-title col-xs-2"">Total</section>
            </article>

            <article class=""esh-basket-items row"">
                <section class=""esh-basket-item col-xs-10""></section>
                <section class=""esh-basket-item esh-basket-item--mark col-xs-2"">$ ");
            EndContext();
            BeginContext(3209, 13, false);
#line 72 "C:\Users\shell\Desktop\ExperienceBookingSite\ExperienceBookingSite\WebMvc\Views\Shared\Components\CartList\Default.cshtml"
                                                                             Write(Model.Total());

#line default
#line hidden
            EndContext();
            BeginContext(3222, 645, true);
            WriteLiteral(@"</section>
            </article>

            <article class=""esh-basket-items row"">
                <section class=""esh-basket-item col-xs-7""></section>
                <section class=""esh-basket-item col-xs-2"">
                    <button class=""btn esh-basket-checkout"" name=""name"" value="""" type=""submit"">[ Update ]</button>
                </section>
                <section class=""esh-basket-item col-xs-3"">
                    <input type=""submit""
                           class=""btn esh-basket-checkout""
                           value=""[ Checkout ]"" name=""action"" />
                </section>
            </article>
        </div>
");
            EndContext();
#line 87 "C:\Users\shell\Desktop\ExperienceBookingSite\ExperienceBookingSite\WebMvc\Views\Shared\Components\CartList\Default.cshtml"
    }

#line default
#line hidden
            BeginContext(3873, 8, true);
            WriteLiteral("\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebMvc.Models.CartModels.Cart> Html { get; private set; }
    }
}
#pragma warning restore 1591
