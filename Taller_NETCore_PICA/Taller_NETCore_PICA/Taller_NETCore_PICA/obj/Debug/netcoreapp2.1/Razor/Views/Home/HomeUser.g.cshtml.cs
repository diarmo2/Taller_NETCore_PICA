#pragma checksum "C:\Users\cian\Desktop\Taller_NETCore_PICA\Taller_NETCore_PICA\Taller_NETCore_PICA\Views\Home\HomeUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "961d34ba1fad86e4664a52b7dba4ce5047a609e4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_HomeUser), @"mvc.1.0.view", @"/Views/Home/HomeUser.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/HomeUser.cshtml", typeof(AspNetCore.Views_Home_HomeUser))]
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
#line 1 "C:\Users\cian\Desktop\Taller_NETCore_PICA\Taller_NETCore_PICA\Taller_NETCore_PICA\Views\_ViewImports.cshtml"
using Taller_NETCore_PICA;

#line default
#line hidden
#line 2 "C:\Users\cian\Desktop\Taller_NETCore_PICA\Taller_NETCore_PICA\Taller_NETCore_PICA\Views\_ViewImports.cshtml"
using Taller_NETCore_PICA.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"961d34ba1fad86e4664a52b7dba4ce5047a609e4", @"/Views/Home/HomeUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d768b8b27b08456419d1ca054829a5c6d6102686", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_HomeUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\cian\Desktop\Taller_NETCore_PICA\Taller_NETCore_PICA\Taller_NETCore_PICA\Views\Home\HomeUser.cshtml"
  
    ViewData["Title"] = "HomeUser";

#line default
#line hidden
            BeginContext(46, 624, true);
            WriteLiteral(@"
<h2>Bienvenido Usuario</h2>

<h3>Ahora tienes permiso para acceder a todos los recursos personalizados de este sitio web.</h3>

<div class=""jumbotron"">
    <h1 class=""display-4"">Bievenido</h1>
    <p class=""lead"">Somos una empresa dedicada al desarrollo de Software y mucho más para tu empresa.</p>
    <hr class=""my-4"">
    <p>Puedes tomar contacto con nosotros cuando desees.</p>

</div>

<div class=""row"">
    <div class=""col-md-6"">
        <h2>¿Quiénes somos?</h2>
        <p>Somos una empresa dedicada al desarrollo de Software y mucho más para tu empresa.</p>        
        <ul>
            <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=", 670, "", 703, 1);
#line 23 "C:\Users\cian\Desktop\Taller_NETCore_PICA\Taller_NETCore_PICA\Taller_NETCore_PICA\Views\Home\HomeUser.cshtml"
WriteAttributeValue("", 676, Url.Action("About","Home"), 676, 27, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(703, 272, true);
            WriteLiteral(@">¿Quiénes somos?</a></li>
        </ul>
    </div>
    <div class=""col-md-6"">
        <h2>Contáctanos</h2>

        <p>En este espacio podrá dejarnos cualquier comentario o sugerencia que desees sea tenida en cuenta por nosotros</p>
        <ul>
            <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 975, "\"", 1011, 1);
#line 31 "C:\Users\cian\Desktop\Taller_NETCore_PICA\Taller_NETCore_PICA\Taller_NETCore_PICA\Views\Home\HomeUser.cshtml"
WriteAttributeValue("", 982, Url.Action("Contact","Home"), 982, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1012, 73, true);
            WriteLiteral(">Toma contacto con nosotros</a></li>\r\n        </ul>\r\n    </div>\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
