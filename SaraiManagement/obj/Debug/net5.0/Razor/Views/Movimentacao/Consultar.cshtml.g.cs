<<<<<<< HEAD
#pragma checksum "C:\Users\elian\source\repos\SaraiManagement\SaraiManagement\Views\Movimentacao\Consultar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d96b6c95ff89c74f475d62b8791d77c40e16f7e8"
=======
#pragma checksum "C:\Users\elian\source\repos\SaraiManagement\SaraiManagement\Views\Movimentacao\Consultar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99fc0455f1f68285d69319992341c552aff9ac82"
>>>>>>> Master
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movimentacao_Consultar), @"mvc.1.0.view", @"/Views/Movimentacao/Consultar.cshtml")]
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
#line 1 "C:\Users\elian\source\repos\SaraiManagement\SaraiManagement\Views\_ViewImports.cshtml"
using SaraiManagement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\elian\source\repos\SaraiManagement\SaraiManagement\Views\_ViewImports.cshtml"
using SaraiManagement.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\elian\source\repos\SaraiManagement\SaraiManagement\Views\_ViewImports.cshtml"
using SaraiManagement.Models.Enuns;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\elian\source\repos\SaraiManagement\SaraiManagement\Views\_ViewImports.cshtml"
using SaraiManagement.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\elian\source\repos\SaraiManagement\SaraiManagement\Views\_ViewImports.cshtml"
using SaraiManagement.Infraestrutura;

#line default
#line hidden
#nullable disable
<<<<<<< HEAD
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d96b6c95ff89c74f475d62b8791d77c40e16f7e8", @"/Views/Movimentacao/Consultar.cshtml")]
=======
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99fc0455f1f68285d69319992341c552aff9ac82", @"/Views/Movimentacao/Consultar.cshtml")]
>>>>>>> Master
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d952a69ecbabda7b37f2440026741ec893a02eec", @"/Views/_ViewImports.cshtml")]
    public class Views_Movimentacao_Consultar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SaraiManagement.Models.Movimentacao>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary botao"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("aria-pressed", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger botao"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "List", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success botao"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\elian\source\repos\SaraiManagement\SaraiManagement\Views\Movimentacao\Consultar.cshtml"
  
    ViewData["Title"] = "Consultar";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
<<<<<<< HEAD
            WriteLiteral("\r\n<h1>Detalhes</h1>\r\n\r\n<div>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Users\elian\source\repos\SaraiManagement\SaraiManagement\Views\Movimentacao\Consultar.cshtml"
       Write(Html.DisplayNameFor(model => model.Valor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\Users\elian\source\repos\SaraiManagement\SaraiManagement\Views\Movimentacao\Consultar.cshtml"
       Write(Html.DisplayFor(model=> model.Valor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\Users\elian\source\repos\SaraiManagement\SaraiManagement\Views\Movimentacao\Consultar.cshtml"
       Write(Html.DisplayNameFor(model => model.TipoMovimentacao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "C:\Users\elian\source\repos\SaraiManagement\SaraiManagement\Views\Movimentacao\Consultar.cshtml"
       Write(Html.DisplayFor(model => model.TipoMovimentacao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "C:\Users\elian\source\repos\SaraiManagement\SaraiManagement\Views\Movimentacao\Consultar.cshtml"
       Write(Html.DisplayNameFor(model => model.DataMovimentacao));
=======
            WriteLiteral(@"
<style>
    .botao {
        margin: 0 5px;
    }

    .fonte {
        font-size: 20px;
    }

    .centraliza {
        display: flex;
        justify-content: center;
        align-items: center;
    }
</style>

<h1 style=""text-align: center"">Detalhes da Movimentação</h1>
<hr />

<div class=""centraliza"">
>>>>>>> Master

    <dl class=""row"">
        <dt class=""col-sm-2"">
");
            WriteLiteral("            <label class=\"fonte\">Valor: </label>\r\n        </dt>\r\n        <dd class = \"col-sm-10 fonte\">\r\n            ");
#nullable restore
<<<<<<< HEAD
#line 29 "C:\Users\elian\source\repos\SaraiManagement\SaraiManagement\Views\Movimentacao\Consultar.cshtml"
       Write(Html.DisplayFor(model => model.DataMovimentacao.ToString("d")));
=======
#line 35 "C:\Users\elian\source\repos\SaraiManagement\SaraiManagement\Views\Movimentacao\Consultar.cshtml"
       Write(Html.DisplayFor(model=> model.Valor));
>>>>>>> Master

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt class = \"col-sm-2\">\r\n");
            WriteLiteral("            <label class=\"fonte\">Tipo de Movimentação: </label>\r\n        </dt>\r\n        <dd class = \"col-sm-10 fonte\">\r\n            ");
#nullable restore
<<<<<<< HEAD
#line 32 "C:\Users\elian\source\repos\SaraiManagement\SaraiManagement\Views\Movimentacao\Consultar.cshtml"
       Write(Html.DisplayNameFor(model => model.Descricao));
=======
#line 43 "C:\Users\elian\source\repos\SaraiManagement\SaraiManagement\Views\Movimentacao\Consultar.cshtml"
       Write(Html.DisplayFor(model => model.TipoMovimentacao));
>>>>>>> Master

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt class = \"col-sm-2\">\r\n");
            WriteLiteral("            <label class=\"fonte\">Data da Movimentação: </label>\r\n        </dt>\r\n        <dd class = \"col-sm-10 fonte\">\r\n            ");
#nullable restore
<<<<<<< HEAD
#line 35 "C:\Users\elian\source\repos\SaraiManagement\SaraiManagement\Views\Movimentacao\Consultar.cshtml"
       Write(Html.DisplayFor(model => model.Descricao));
=======
#line 51 "C:\Users\elian\source\repos\SaraiManagement\SaraiManagement\Views\Movimentacao\Consultar.cshtml"
       Write(Html.DisplayFor(model => model.DataMovimentacao));
>>>>>>> Master

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt class=\"col-sm-2\">\r\n");
            WriteLiteral("            <label class=\"fonte\">Descrição: </label>\r\n        </dt>\r\n        <dd class = \"col-sm-10 fonte\">\r\n            ");
#nullable restore
<<<<<<< HEAD
#line 38 "C:\Users\elian\source\repos\SaraiManagement\SaraiManagement\Views\Movimentacao\Consultar.cshtml"
       Write(Html.DisplayNameFor(model => model.Doador));
=======
#line 59 "C:\Users\elian\source\repos\SaraiManagement\SaraiManagement\Views\Movimentacao\Consultar.cshtml"
       Write(Html.DisplayFor(model => model.Descricao));
>>>>>>> Master

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt class=\"col-sm-2\">\r\n");
            WriteLiteral("            <label class=\"fonte\">Doador: </label>\r\n        </dt>\r\n        <dd class = \"col-sm-10 fonte\">\r\n            ");
#nullable restore
<<<<<<< HEAD
#line 41 "C:\Users\elian\source\repos\SaraiManagement\SaraiManagement\Views\Movimentacao\Consultar.cshtml"
       Write(Html.DisplayFor(model => model.Doador.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 44 "C:\Users\elian\source\repos\SaraiManagement\SaraiManagement\Views\Movimentacao\Consultar.cshtml"
       Write(Html.DisplayNameFor(model => model.Usuario));
=======
#line 67 "C:\Users\elian\source\repos\SaraiManagement\SaraiManagement\Views\Movimentacao\Consultar.cshtml"
       Write(Html.DisplayFor(model => model.Doador.Nome));
>>>>>>> Master

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt class = \"col-sm-2\">\r\n");
            WriteLiteral("            <label class=\"fonte\">Usuário: </label>\r\n        </dt>\r\n        <dd class = \"col-sm-10 fonte\">\r\n            ");
#nullable restore
<<<<<<< HEAD
#line 47 "C:\Users\elian\source\repos\SaraiManagement\SaraiManagement\Views\Movimentacao\Consultar.cshtml"
=======
#line 75 "C:\Users\elian\source\repos\SaraiManagement\SaraiManagement\Views\Movimentacao\Consultar.cshtml"
>>>>>>> Master
       Write(Html.DisplayFor(model => model.Usuario.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt class = \"col-sm-2\">\r\n");
            WriteLiteral("            <label class=\"fonte\">Caixa: </label>\r\n        </dt>\r\n        <dd class = \"col-sm-10 fonte\">\r\n            ");
#nullable restore
<<<<<<< HEAD
#line 50 "C:\Users\elian\source\repos\SaraiManagement\SaraiManagement\Views\Movimentacao\Consultar.cshtml"
       Write(Html.DisplayNameFor(model => model.Caixa));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 53 "C:\Users\elian\source\repos\SaraiManagement\SaraiManagement\Views\Movimentacao\Consultar.cshtml"
=======
#line 83 "C:\Users\elian\source\repos\SaraiManagement\SaraiManagement\Views\Movimentacao\Consultar.cshtml"
>>>>>>> Master
       Write(Html.DisplayFor(model => model.Caixa.Descricao));

#line default
#line hidden
#nullable disable
<<<<<<< HEAD
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d96b6c95ff89c74f475d62b8791d77c40e16f7e811636", async() => {
=======
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<hr />\r\n<div class=\"centraliza\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "99fc0455f1f68285d69319992341c552aff9ac8210642", async() => {
>>>>>>> Master
                WriteLiteral("Editar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
<<<<<<< HEAD
#line 58 "C:\Users\elian\source\repos\SaraiManagement\SaraiManagement\Views\Movimentacao\Consultar.cshtml"
=======
#line 89 "C:\Users\elian\source\repos\SaraiManagement\SaraiManagement\Views\Movimentacao\Consultar.cshtml"
>>>>>>> Master
                           WriteLiteral(Model.MovimentacaoID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    ");
<<<<<<< HEAD
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d96b6c95ff89c74f475d62b8791d77c40e16f7e814056", async() => {
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "99fc0455f1f68285d69319992341c552aff9ac8213062", async() => {
>>>>>>> Master
                WriteLiteral("Excluir");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
<<<<<<< HEAD
#line 59 "C:\Users\elian\source\repos\SaraiManagement\SaraiManagement\Views\Movimentacao\Consultar.cshtml"
=======
#line 90 "C:\Users\elian\source\repos\SaraiManagement\SaraiManagement\Views\Movimentacao\Consultar.cshtml"
>>>>>>> Master
                             WriteLiteral(Model.MovimentacaoID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    ");
<<<<<<< HEAD
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d96b6c95ff89c74f475d62b8791d77c40e16f7e816479", async() => {
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "99fc0455f1f68285d69319992341c552aff9ac8215485", async() => {
>>>>>>> Master
                WriteLiteral("Voltar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
<<<<<<< HEAD
#line 60 "C:\Users\elian\source\repos\SaraiManagement\SaraiManagement\Views\Movimentacao\Consultar.cshtml"
=======
#line 91 "C:\Users\elian\source\repos\SaraiManagement\SaraiManagement\Views\Movimentacao\Consultar.cshtml"
>>>>>>> Master
                           WriteLiteral(Model.MovimentacaoID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SaraiManagement.Models.Movimentacao> Html { get; private set; }
    }
}
#pragma warning restore 1591
