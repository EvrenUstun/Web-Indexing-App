#pragma checksum "C:\Users\Evren Ustun\Desktop\yazlab\yazlab.webui\Views\Home\asama4.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "58dd9143672cf52a9e535c1933ec3b89f39918d5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_asama4), @"mvc.1.0.view", @"/Views/Home/asama4.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58dd9143672cf52a9e535c1933ec3b89f39918d5", @"/Views/Home/asama4.cshtml")]
    public class Views_Home_asama4 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<yazlab.webui.Models.Asama4>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Evren Ustun\Desktop\yazlab\yazlab.webui\Views\Home\asama4.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\Evren Ustun\Desktop\yazlab\yazlab.webui\Views\Home\asama4.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"<div class=""form-group mt-3"">
    <form action=""/home/asama4"" class=""input-group mb-3 input-group-sm "">
        <input type=""text"" name=""url"" class=""form-control py-3"" placeholder=""Url giriniz.."">
        <button type=""submit"" class=""btn btn-primary px-5"">Ara</button>
    </form>
</div>
");
#nullable restore
#line 17 "C:\Users\Evren Ustun\Desktop\yazlab\yazlab.webui\Views\Home\asama4.cshtml"
  if(ViewBag.kontrol != false)
{
    ViewBag.durum=0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <table class=""table table-striped table-hover"">
        <thead>
            <tr>
            <th scope=""col"">#</th>
            <th scope=""col"" >2. Derinlik Seviyesi</th>
            <th scope=""col"" >3. Derinlik Seviyesi</th>
            </tr>
        </thead>
        <tbody>      
");
#nullable restore
#line 29 "C:\Users\Evren Ustun\Desktop\yazlab\yazlab.webui\Views\Home\asama4.cshtml"
             for (int i = 0; i <@Model.Links1.Count; i++)
            {
                ViewBag.durum++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <th scope=\"row\" rowspan=\"4\">");
#nullable restore
#line 33 "C:\Users\Evren Ustun\Desktop\yazlab\yazlab.webui\Views\Home\asama4.cshtml"
                                            Write(i+1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <td rowspan=\"4\" ><a");
            BeginWriteAttribute("href", " href=\"", 995, "\"", 1018, 1);
#nullable restore
#line 34 "C:\Users\Evren Ustun\Desktop\yazlab\yazlab.webui\Views\Home\asama4.cshtml"
WriteAttributeValue("", 1002, Model.Links1[i], 1002, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" >");
#nullable restore
#line 34 "C:\Users\Evren Ustun\Desktop\yazlab\yazlab.webui\Views\Home\asama4.cshtml"
                                                            Write(Model.Links1[i]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n");
#nullable restore
#line 35 "C:\Users\Evren Ustun\Desktop\yazlab\yazlab.webui\Views\Home\asama4.cshtml"
                     for (int j = i*3; j < Model.Links2.Count; j++)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr >\r\n                            <td ><a");
            BeginWriteAttribute("href", " href=\"", 1206, "\"", 1229, 1);
#nullable restore
#line 38 "C:\Users\Evren Ustun\Desktop\yazlab\yazlab.webui\Views\Home\asama4.cshtml"
WriteAttributeValue("", 1213, Model.Links2[i], 1213, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" >");
#nullable restore
#line 38 "C:\Users\Evren Ustun\Desktop\yazlab\yazlab.webui\Views\Home\asama4.cshtml"
                                                        Write(Model.Links2[j]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n                        </tr>\r\n");
#nullable restore
#line 40 "C:\Users\Evren Ustun\Desktop\yazlab\yazlab.webui\Views\Home\asama4.cshtml"
                         if(j==i*3+2) break;

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\Evren Ustun\Desktop\yazlab\yazlab.webui\Views\Home\asama4.cshtml"
                                            
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tr>\r\n");
#nullable restore
#line 43 "C:\Users\Evren Ustun\Desktop\yazlab\yazlab.webui\Views\Home\asama4.cshtml"
                 if(i==2)break;

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\Users\Evren Ustun\Desktop\yazlab\yazlab.webui\Views\Home\asama4.cshtml"
                               
            }          

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>    \r\n");
#nullable restore
#line 47 "C:\Users\Evren Ustun\Desktop\yazlab\yazlab.webui\Views\Home\asama4.cshtml"
}
else if(ViewBag.kontrol == false)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>Hatalı url girdiniz!</h1>\r\n    <br>\r\n    <h3>hata: ");
#nullable restore
#line 52 "C:\Users\Evren Ustun\Desktop\yazlab\yazlab.webui\Views\Home\asama4.cshtml"
         Write(ViewBag.hata);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
#nullable restore
#line 53 "C:\Users\Evren Ustun\Desktop\yazlab\yazlab.webui\Views\Home\asama4.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<yazlab.webui.Models.Asama4> Html { get; private set; }
    }
}
#pragma warning restore 1591
