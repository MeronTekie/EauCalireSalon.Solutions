#pragma checksum "/Users/ramenimo/Desktop/EauClaireHairSalon.Solutions/HairSalon/Views/Stylists/Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd3e09a4ddfeae1d8b070f8652a1c4adf4d005b0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Stylists_Create), @"mvc.1.0.view", @"/Views/Stylists/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd3e09a4ddfeae1d8b070f8652a1c4adf4d005b0", @"/Views/Stylists/Create.cshtml")]
    #nullable restore
    public class Views_Stylists_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HairSalon.Models.Stylist>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/ramenimo/Desktop/EauClaireHairSalon.Solutions/HairSalon/Views/Stylists/Create.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("  <h1>Add a new Stylist here!</h1>\n");
#nullable restore
#line 7 "/Users/ramenimo/Desktop/EauClaireHairSalon.Solutions/HairSalon/Views/Stylists/Create.cshtml"
 using (Html.BeginForm())
{
  

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/ramenimo/Desktop/EauClaireHairSalon.Solutions/HairSalon/Views/Stylists/Create.cshtml"
Write(Html.LabelFor(model => model.Name));

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/ramenimo/Desktop/EauClaireHairSalon.Solutions/HairSalon/Views/Stylists/Create.cshtml"
Write(Html.TextBoxFor(model => model.Name));

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/ramenimo/Desktop/EauClaireHairSalon.Solutions/HairSalon/Views/Stylists/Create.cshtml"
Write(Html.LabelFor(model => model.Specialty));

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Users/ramenimo/Desktop/EauClaireHairSalon.Solutions/HairSalon/Views/Stylists/Create.cshtml"
Write(Html.TextBoxFor(model => model.Specialty));

#line default
#line hidden
#nullable disable
            WriteLiteral("  <input type=\"submit\" value=\"Add a Stylist\" />\n");
#nullable restore
#line 14 "/Users/ramenimo/Desktop/EauClaireHairSalon.Solutions/HairSalon/Views/Stylists/Create.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>");
#nullable restore
#line 15 "/Users/ramenimo/Desktop/EauClaireHairSalon.Solutions/HairSalon/Views/Stylists/Create.cshtml"
Write(Html.ActionLink("List of Stylists", "Index"));

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HairSalon.Models.Stylist> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591