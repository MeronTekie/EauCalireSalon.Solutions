#pragma checksum "/Users/ramenimo/Desktop/EauClaireHairSalon.Solutions/HairSalon/Views/Clients/Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3568eefe83ba91ea7bbd42b832f8dc34833334f9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Clients_Create), @"mvc.1.0.view", @"/Views/Clients/Create.cshtml")]
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
#line 4 "/Users/ramenimo/Desktop/EauClaireHairSalon.Solutions/HairSalon/Views/Clients/Create.cshtml"
using HairSalon.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3568eefe83ba91ea7bbd42b832f8dc34833334f9", @"/Views/Clients/Create.cshtml")]
    #nullable restore
    public class Views_Clients_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HairSalon.Models.Client>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/ramenimo/Desktop/EauClaireHairSalon.Solutions/HairSalon/Views/Clients/Create.cshtml"
  
  Layout ="_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n<h1>Add a new Client</h1>\n");
#nullable restore
#line 9 "/Users/ramenimo/Desktop/EauClaireHairSalon.Solutions/HairSalon/Views/Clients/Create.cshtml"
   using (Html.BeginForm())
{
  

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/ramenimo/Desktop/EauClaireHairSalon.Solutions/HairSalon/Views/Clients/Create.cshtml"
Write(Html.LabelFor(model =>model.Name));

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Users/ramenimo/Desktop/EauClaireHairSalon.Solutions/HairSalon/Views/Clients/Create.cshtml"
Write(Html.TextBoxFor(model =>model.Name));

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/Users/ramenimo/Desktop/EauClaireHairSalon.Solutions/HairSalon/Views/Clients/Create.cshtml"
Write(Html.LabelFor(model =>model.Wax));

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "/Users/ramenimo/Desktop/EauClaireHairSalon.Solutions/HairSalon/Views/Clients/Create.cshtml"
Write(Html.TextBoxFor(model =>model.Wax));

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "/Users/ramenimo/Desktop/EauClaireHairSalon.Solutions/HairSalon/Views/Clients/Create.cshtml"
Write(Html.LabelFor(model =>model.Massage));

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "/Users/ramenimo/Desktop/EauClaireHairSalon.Solutions/HairSalon/Views/Clients/Create.cshtml"
Write(Html.TextBoxFor(model =>model.Massage));

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "/Users/ramenimo/Desktop/EauClaireHairSalon.Solutions/HairSalon/Views/Clients/Create.cshtml"
Write(Html.LabelFor(model => model.Stylist));

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "/Users/ramenimo/Desktop/EauClaireHairSalon.Solutions/HairSalon/Views/Clients/Create.cshtml"
Write(Html.DropDownList("StylistId"));

#line default
#line hidden
#nullable disable
            WriteLiteral("  <input type=\"Submit\" value =\"Register\"/>\n");
#nullable restore
#line 21 "/Users/ramenimo/Desktop/EauClaireHairSalon.Solutions/HairSalon/Views/Clients/Create.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n\n<h4>");
#nullable restore
#line 25 "/Users/ramenimo/Desktop/EauClaireHairSalon.Solutions/HairSalon/Views/Clients/Create.cshtml"
Write(Html.ActionLink("Client's List","Index","Clients"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HairSalon.Models.Client> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
