#pragma checksum "C:\Users\novad\Development\my-projects\GTI-Solution-Teste\GTI Solution Site MVC e Site Web Forms VS 2022\GTI Solution\Views\Home\ClientList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c3f1a5c9c5c96d796434fcd3abddb34175c1201"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ClientList), @"mvc.1.0.view", @"/Views/Home/ClientList.cshtml")]
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
#line 1 "C:\Users\novad\Development\my-projects\GTI-Solution-Teste\GTI Solution Site MVC e Site Web Forms VS 2022\GTI Solution\Views\_ViewImports.cshtml"
using GTI_Solution;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\novad\Development\my-projects\GTI-Solution-Teste\GTI Solution Site MVC e Site Web Forms VS 2022\GTI Solution\Views\_ViewImports.cshtml"
using GTI_Solution.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\novad\Development\my-projects\GTI-Solution-Teste\GTI Solution Site MVC e Site Web Forms VS 2022\GTI Solution\Views\Home\ClientList.cshtml"
using Projeto_API.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c3f1a5c9c5c96d796434fcd3abddb34175c1201", @"/Views/Home/ClientList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28b51f1b59630621099cf6ba22fc5c1d9ddaddca", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_ClientList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Cliente>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString(" background:red;color:white;font-weight:bolder;margin-top:5px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn   btnNovoRegistro"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/site.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\novad\Development\my-projects\GTI-Solution-Teste\GTI Solution Site MVC e Site Web Forms VS 2022\GTI Solution\Views\Home\ClientList.cshtml"
  
    ViewData["Title"] = "ClientesCadastrados";

#line default
#line hidden
#nullable disable
            WriteLiteral("    <!--Autor:Novadson Thelus-->\r\n");
            WriteLiteral("\r\n<div>\r\n    <div>\r\n        <p class=\"panelTitulo\">Clientes Cadastrados</p>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6c3f1a5c9c5c96d796434fcd3abddb34175c12015598", async() => {
                WriteLiteral("\r\n            <i class=\"glyphicon glyphicon-plus\"></i>Adicionar\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        <br />
        <br />
        <div class=""form-group input-group"" style=""margin-bottom:-5px;"">
            <span class=""input-group-addon""><i class=""glyphicon glyphicon-search colorIconEditar""></i></span>
             <input type=""text"" id=""myInput"" onkeyup=""tableSearch()"" placeholder=""Buscar nome ou cpf...."" title=""Type in a name"" class=""form-control"">
        </div>
    </div>
    <table id=""myTable"" class=""table table-bordered display  table-condensed  table-responsive"">
        <thead style=""background-color:royalblue;color:whitesmoke"" class=""tabelaHeaderColor"">
            <tr>
                <td class=""col-2"">Cpf</td>
                <td class=""col-2"">Nome</td>
                <td class=""col-1"">Rg</td>
                <td class=""col-2"">Data Nascimento</td>
                <td class=""col-1"">Cidade</td>
                <td class=""col-1"">Estado</td>
                <td class=""col-1"">Estado Civil</td>
                <td style=""text-align:center"" colspan=""3"">Ações</td>
         ");
            WriteLiteral("   </tr>\r\n        </thead>\r\n\r\n");
#nullable restore
#line 35 "C:\Users\novad\Development\my-projects\GTI-Solution-Teste\GTI Solution Site MVC e Site Web Forms VS 2022\GTI Solution\Views\Home\ClientList.cshtml"
         foreach (var cliente in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 39 "C:\Users\novad\Development\my-projects\GTI-Solution-Teste\GTI Solution Site MVC e Site Web Forms VS 2022\GTI Solution\Views\Home\ClientList.cshtml"
               Write(Html.DisplayFor(model => cliente.Cpf));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n                <td>\r\n                    ");
#nullable restore
#line 43 "C:\Users\novad\Development\my-projects\GTI-Solution-Teste\GTI Solution Site MVC e Site Web Forms VS 2022\GTI Solution\Views\Home\ClientList.cshtml"
               Write(Html.DisplayFor(model => cliente.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 46 "C:\Users\novad\Development\my-projects\GTI-Solution-Teste\GTI Solution Site MVC e Site Web Forms VS 2022\GTI Solution\Views\Home\ClientList.cshtml"
               Write(Html.DisplayFor(model => cliente.Rg));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n                <td>\r\n                    ");
#nullable restore
#line 50 "C:\Users\novad\Development\my-projects\GTI-Solution-Teste\GTI Solution Site MVC e Site Web Forms VS 2022\GTI Solution\Views\Home\ClientList.cshtml"
               Write(Html.DisplayFor(qtd => cliente.DataNascimento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 53 "C:\Users\novad\Development\my-projects\GTI-Solution-Teste\GTI Solution Site MVC e Site Web Forms VS 2022\GTI Solution\Views\Home\ClientList.cshtml"
               Write(Html.DisplayFor(model => cliente.Endereco.Cidade));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 56 "C:\Users\novad\Development\my-projects\GTI-Solution-Teste\GTI Solution Site MVC e Site Web Forms VS 2022\GTI Solution\Views\Home\ClientList.cshtml"
               Write(Html.DisplayFor(model => cliente.Endereco.EstadoDesc));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 59 "C:\Users\novad\Development\my-projects\GTI-Solution-Teste\GTI Solution Site MVC e Site Web Forms VS 2022\GTI Solution\Views\Home\ClientList.cshtml"
               Write(Html.DisplayFor(model => cliente.EstadoCivilDesc));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n                <td>\r\n                    <a style=\"color:blue;text-align:center\" title=\"Editar\"");
            BeginWriteAttribute("href", " href=\"", 2436, "\"", 2499, 1);
#nullable restore
#line 63 "C:\Users\novad\Development\my-projects\GTI-Solution-Teste\GTI Solution Site MVC e Site Web Forms VS 2022\GTI Solution\Views\Home\ClientList.cshtml"
WriteAttributeValue("", 2443, Url.Action("Edit",new { IdCliente  =cliente.IdCliente}), 2443, 56, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Editar</a>\r\n                </td>\r\n\r\n                <td>\r\n                    <a style=\"color:red;text-align:center\" title=\"Remove\"");
            BeginWriteAttribute("href", " href=\"", 2633, "\"", 2698, 1);
#nullable restore
#line 67 "C:\Users\novad\Development\my-projects\GTI-Solution-Teste\GTI Solution Site MVC e Site Web Forms VS 2022\GTI Solution\Views\Home\ClientList.cshtml"
WriteAttributeValue("", 2640, Url.Action("Remove",new { IdCliente  =cliente.IdCliente}), 2640, 58, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Remover</a>\r\n                </td>\r\n\r\n            </tr>\r\n");
#nullable restore
#line 71 "C:\Users\novad\Development\my-projects\GTI-Solution-Teste\GTI Solution Site MVC e Site Web Forms VS 2022\GTI Solution\Views\Home\ClientList.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n\r\n    <br />\r\n");
#nullable restore
#line 75 "C:\Users\novad\Development\my-projects\GTI-Solution-Teste\GTI Solution Site MVC e Site Web Forms VS 2022\GTI Solution\Views\Home\ClientList.cshtml"
     if (Model.Count().Equals(0))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <span class=\"msmEmptyTable\">\r\n            <i class=\"fa fa-thumbs-o-down\" aria-hidden=\"true\"></i>\r\n            Nenhum registro encontrado...\r\n        </span>\r\n");
#nullable restore
#line 81 "C:\Users\novad\Development\my-projects\GTI-Solution-Teste\GTI Solution Site MVC e Site Web Forms VS 2022\GTI Solution\Views\Home\ClientList.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6c3f1a5c9c5c96d796434fcd3abddb34175c120113698", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Cliente>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591