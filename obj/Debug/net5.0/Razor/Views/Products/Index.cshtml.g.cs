#pragma checksum "C:\Users\Marcus\Desktop\InventorySite.Solution\Inventory\Views\Products\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f404e6166a80ef59d77390a300ffe810e475deb2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Index), @"mvc.1.0.view", @"/Views/Products/Index.cshtml")]
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
#line 5 "C:\Users\Marcus\Desktop\InventorySite.Solution\Inventory\Views\Products\Index.cshtml"
using Inventory.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f404e6166a80ef59d77390a300ffe810e475deb2", @"/Views/Products/Index.cshtml")]
    #nullable restore
    public class Views_Products_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Marcus\Desktop\InventorySite.Solution\Inventory\Views\Products\Index.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h1>View Product</h1>\r\n");
#nullable restore
#line 8 "C:\Users\Marcus\Desktop\InventorySite.Solution\Inventory\Views\Products\Index.cshtml"
 if (@Model.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <h3>No inventory has been added yet!</h3>\r\n");
#nullable restore
#line 11 "C:\Users\Marcus\Desktop\InventorySite.Solution\Inventory\Views\Products\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<ul>\r\n");
#nullable restore
#line 14 "C:\Users\Marcus\Desktop\InventorySite.Solution\Inventory\Views\Products\Index.cshtml"
 foreach (Product product in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <li>");
#nullable restore
#line 16 "C:\Users\Marcus\Desktop\InventorySite.Solution\Inventory\Views\Products\Index.cshtml"
 Write(Html.ActionLink($"{product.Name}", "Details", new { id = product.ProductId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n  <li>");
#nullable restore
#line 17 "C:\Users\Marcus\Desktop\InventorySite.Solution\Inventory\Views\Products\Index.cshtml"
 Write(product.Collection);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n  <li>");
#nullable restore
#line 18 "C:\Users\Marcus\Desktop\InventorySite.Solution\Inventory\Views\Products\Index.cshtml"
 Write(product.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n  <li>");
#nullable restore
#line 19 "C:\Users\Marcus\Desktop\InventorySite.Solution\Inventory\Views\Products\Index.cshtml"
 Write(product.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 20 "C:\Users\Marcus\Desktop\InventorySite.Solution\Inventory\Views\Products\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n\r\n<p>");
#nullable restore
#line 23 "C:\Users\Marcus\Desktop\InventorySite.Solution\Inventory\Views\Products\Index.cshtml"
Write(Html.ActionLink("Back to homepage", "Index", "Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591