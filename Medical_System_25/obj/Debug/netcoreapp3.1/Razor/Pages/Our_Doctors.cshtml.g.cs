#pragma checksum "/Users/nikitapimenov/Downloads/Medical_System/Medical_System_25/Pages/Our_Doctors.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5743499eebd996bed602b258e022b9d282112b13"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Medical_System.Pages.Pages_Our_Doctors), @"mvc.1.0.razor-page", @"/Pages/Our_Doctors.cshtml")]
namespace Medical_System.Pages
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
#line 1 "/Users/nikitapimenov/Downloads/Medical_System/Medical_System_25/Pages/_ViewImports.cshtml"
using Medical_System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/nikitapimenov/Downloads/Medical_System/Medical_System_25/Pages/Our_Doctors.cshtml"
using Medical_System.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5743499eebd996bed602b258e022b9d282112b13", @"/Pages/Our_Doctors.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08cbfbb18b76ccea2f04318de46b779d71daec08", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Our_Doctors : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            WriteLiteral("\n<div class=\"del\">\n    \n    <div>\n        <h2>Список наших специалистов</h2>\n        <div class=\"container-fluid\">\n            <div class=\"row\">\n");
#nullable restore
#line 12 "/Users/nikitapimenov/Downloads/Medical_System/Medical_System_25/Pages/Our_Doctors.cshtml"
                 foreach (Doctor sale in @Model.Doctors)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"card\" style=\"width: 18rem;\">\n                        <img src=\"/image/lol.jpeg\" class=\"card-img-top\" alt=\"...\">\n                        <div class=\"card-body\">\n                            <h5 class=\"card-title\">");
#nullable restore
#line 17 "/Users/nikitapimenov/Downloads/Medical_System/Medical_System_25/Pages/Our_Doctors.cshtml"
                                              Write(sale.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 17 "/Users/nikitapimenov/Downloads/Medical_System/Medical_System_25/Pages/Our_Doctors.cshtml"
                                                         Write(sale.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n\n                            <p class=\"card-text\">\n                                Специальность: ");
#nullable restore
#line 20 "/Users/nikitapimenov/Downloads/Medical_System/Medical_System_25/Pages/Our_Doctors.cshtml"
                                          Write(sale.personalization);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                <br /> Название больницы:");
#nullable restore
#line 21 "/Users/nikitapimenov/Downloads/Medical_System/Medical_System_25/Pages/Our_Doctors.cshtml"
                                                    Write(sale.hospital_name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                <br />Адрес больницы:");
#nullable restore
#line 22 "/Users/nikitapimenov/Downloads/Medical_System/Medical_System_25/Pages/Our_Doctors.cshtml"
                                                Write(sale.location_hospital);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </p>\n                            <a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=", 936, "", 976, 1);
#nullable restore
#line 24 "/Users/nikitapimenov/Downloads/Medical_System/Medical_System_25/Pages/Our_Doctors.cshtml"
WriteAttributeValue("", 942, Url.Page("./Doctor",new{sale.Id}), 942, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Записаться к врачу</a>\n                        </div>\n                    </div>\n");
#nullable restore
#line 27 "/Users/nikitapimenov/Downloads/Medical_System/Medical_System_25/Pages/Our_Doctors.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\n\n\n\n        </div>\n    </div>\n\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Medical_System.Pages.Our_DoctorsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Medical_System.Pages.Our_DoctorsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Medical_System.Pages.Our_DoctorsModel>)PageContext?.ViewData;
        public Medical_System.Pages.Our_DoctorsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591