#pragma checksum "C:\Users\Evren Ustun\Desktop\yazlab\yazlab.webui\Views\Home\asama5.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd66a5a48e4389a9c1a74ed34c38a971524beee0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_asama5), @"mvc.1.0.view", @"/Views/Home/asama5.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd66a5a48e4389a9c1a74ed34c38a971524beee0", @"/Views/Home/asama5.cshtml")]
    public class Views_Home_asama5 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<yazlab.webui.Models.Asama5>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Evren Ustun\Desktop\yazlab\yazlab.webui\Views\Home\asama5.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\Evren Ustun\Desktop\yazlab\yazlab.webui\Views\Home\asama5.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"<div class=""form-group mt-3"">
    <form action=""/home/asama5"" class=""input-group mb-3 input-group-sm "">
        <input type=""text"" name=""url"" class=""form-control py-3"" placeholder=""Url giriniz.."">
        <button type=""submit"" class=""btn btn-primary px-5"">Ara</button>
    </form>
</div>
");
#nullable restore
#line 17 "C:\Users\Evren Ustun\Desktop\yazlab\yazlab.webui\Views\Home\asama5.cshtml"
 if(ViewBag.kontrol != false)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <table class=""table table-striped table-hover"">
        <thead>
            <tr>
            <th scope=""col"">#</th>
            <th scope=""col"">Kelime</th>
            <th scope=""col"">Frekans</th>
            </tr>
        </thead>
        <tbody>      
");
#nullable restore
#line 28 "C:\Users\Evren Ustun\Desktop\yazlab\yazlab.webui\Views\Home\asama5.cshtml"
             for (int i = 0; i < Model.text.Count; i++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <th scope=\"row\">");
#nullable restore
#line 31 "C:\Users\Evren Ustun\Desktop\yazlab\yazlab.webui\Views\Home\asama5.cshtml"
                                Write(i+1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <td>");
#nullable restore
#line 32 "C:\Users\Evren Ustun\Desktop\yazlab\yazlab.webui\Views\Home\asama5.cshtml"
                   Write(Model.text[i].Item1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 33 "C:\Users\Evren Ustun\Desktop\yazlab\yazlab.webui\Views\Home\asama5.cshtml"
                   Write(Model.text[i].Item2.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 35 "C:\Users\Evren Ustun\Desktop\yazlab\yazlab.webui\Views\Home\asama5.cshtml"
                 if(i==4)break;

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\Evren Ustun\Desktop\yazlab\yazlab.webui\Views\Home\asama5.cshtml"
                               
            }          

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </tbody>
    </table>
    <table class=""table table-striped table-hover"">
        <thead>
            <tr>
            <th scope=""col"">#</th>
            <th scope=""col"">Kelime</th>
            <th scope=""col"">Eş Anlamlısı</th>
            </tr>
        </thead>
        <tbody>      
");
#nullable restore
#line 48 "C:\Users\Evren Ustun\Desktop\yazlab\yazlab.webui\Views\Home\asama5.cshtml"
             for (int i = 0; i <@Model.text.Count; i++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <th scope=\"row\" rowspan=\"4\">");
#nullable restore
#line 51 "C:\Users\Evren Ustun\Desktop\yazlab\yazlab.webui\Views\Home\asama5.cshtml"
                                            Write(ViewBag.index[i]+1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <td rowspan=\"4\">");
#nullable restore
#line 52 "C:\Users\Evren Ustun\Desktop\yazlab\yazlab.webui\Views\Home\asama5.cshtml"
                               Write(Model.text[ViewBag.index[i]].Item1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 53 "C:\Users\Evren Ustun\Desktop\yazlab\yazlab.webui\Views\Home\asama5.cshtml"
                     for (int j = i*3; j < Model.esanlamlilar.Count; j++)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td >");
#nullable restore
#line 56 "C:\Users\Evren Ustun\Desktop\yazlab\yazlab.webui\Views\Home\asama5.cshtml"
                            Write(Model.esanlamlilar[j]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n");
#nullable restore
#line 58 "C:\Users\Evren Ustun\Desktop\yazlab\yazlab.webui\Views\Home\asama5.cshtml"
                         if(j==i*3+2) break;

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "C:\Users\Evren Ustun\Desktop\yazlab\yazlab.webui\Views\Home\asama5.cshtml"
                                            
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tr>\r\n");
#nullable restore
#line 61 "C:\Users\Evren Ustun\Desktop\yazlab\yazlab.webui\Views\Home\asama5.cshtml"
                 if(i==4)break;

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "C:\Users\Evren Ustun\Desktop\yazlab\yazlab.webui\Views\Home\asama5.cshtml"
                               
            }          

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>    \r\n");
#nullable restore
#line 65 "C:\Users\Evren Ustun\Desktop\yazlab\yazlab.webui\Views\Home\asama5.cshtml"
     for (int i = 0; i < @ViewBag.index.Length; i++)
    {
        if(i!=@ViewBag.index[i])
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h3 style=\"text-align: center;\">");
#nullable restore
#line 69 "C:\Users\Evren Ustun\Desktop\yazlab\yazlab.webui\Views\Home\asama5.cshtml"
                                        Write(i+1);

#line default
#line hidden
#nullable disable
            WriteLiteral(". Kelimenin Eşanlamlısı Bulunamadı</h3>\r\n");
#nullable restore
#line 70 "C:\Users\Evren Ustun\Desktop\yazlab\yazlab.webui\Views\Home\asama5.cshtml"
        }
        if(i==4)break;
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h6 style=\"text-align: center;\">!eğer bir kelimenin eş anlamlısı bulunamazsa sıradaki kelimenin eş anlamlısı gösterilir!</h6>\r\n");
#nullable restore
#line 74 "C:\Users\Evren Ustun\Desktop\yazlab\yazlab.webui\Views\Home\asama5.cshtml"
}
else if(ViewBag.kontrol == false)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>Hatalı url girdiniz!</h1>\r\n    <br>\r\n    <h3>hata: ");
#nullable restore
#line 79 "C:\Users\Evren Ustun\Desktop\yazlab\yazlab.webui\Views\Home\asama5.cshtml"
         Write(ViewBag.hata);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
#nullable restore
#line 80 "C:\Users\Evren Ustun\Desktop\yazlab\yazlab.webui\Views\Home\asama5.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<yazlab.webui.Models.Asama5> Html { get; private set; }
    }
}
#pragma warning restore 1591
