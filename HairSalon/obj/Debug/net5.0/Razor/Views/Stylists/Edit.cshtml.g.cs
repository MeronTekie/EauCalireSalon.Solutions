#pragma checksum "/Users/ramenimo/Desktop/EauClaireHairSalon.Solutions/HairSalon/Views/Stylists/Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3380d88f51359775b0a951a81296a7c95b61eeff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Stylists_Edit), @"mvc.1.0.view", @"/Views/Stylists/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3380d88f51359775b0a951a81296a7c95b61eeff", @"/Views/Stylists/Edit.cshtml")]
    #nullable restore
    public class Views_Stylists_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HairSalon.Models.Stylist>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/ramenimo/Desktop/EauClaireHairSalon.Solutions/HairSalon/Views/Stylists/Edit.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n<h2>Edit</h2>\n\n\n<h4>Edit this Stylists Profile: ");
#nullable restore
#line 10 "/Users/ramenimo/Desktop/EauClaireHairSalon.Solutions/HairSalon/Views/Stylists/Edit.cshtml"
                           Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n\n");
#nullable restore
#line 12 "/Users/ramenimo/Desktop/EauClaireHairSalon.Solutions/HairSalon/Views/Stylists/Edit.cshtml"
 using (Html.BeginForm())
{
  

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "/Users/ramenimo/Desktop/EauClaireHairSalon.Solutions/HairSalon/Views/Stylists/Edit.cshtml"
Write(Html.HiddenFor(model => model.StylistId));

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "/Users/ramenimo/Desktop/EauClaireHairSalon.Solutions/HairSalon/Views/Stylists/Edit.cshtml"
Write(Html.LabelFor(model => model.Name));

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "/Users/ramenimo/Desktop/EauClaireHairSalon.Solutions/HairSalon/Views/Stylists/Edit.cshtml"
Write(Html.EditorFor(model => model.Name));

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "/Users/ramenimo/Desktop/EauClaireHairSalon.Solutions/HairSalon/Views/Stylists/Edit.cshtml"
Write(Html.LabelFor(model => model.Specialty));

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "/Users/ramenimo/Desktop/EauClaireHairSalon.Solutions/HairSalon/Views/Stylists/Edit.cshtml"
Write(Html.EditorFor(model => model.Specialty));

#line default
#line hidden
#nullable disable
            WriteLiteral("  <input type=\"submit\" value=\"Save\" />\n");
#nullable restore
#line 24 "/Users/ramenimo/Desktop/EauClaireHairSalon.Solutions/HairSalon/Views/Stylists/Edit.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>");
#nullable restore
#line 25 "/Users/ramenimo/Desktop/EauClaireHairSalon.Solutions/HairSalon/Views/Stylists/Edit.cshtml"
Write(Html.ActionLink("Back", "Index"));

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
