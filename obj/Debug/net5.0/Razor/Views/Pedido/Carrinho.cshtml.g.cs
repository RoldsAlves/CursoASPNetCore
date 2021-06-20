#pragma checksum "D:\Cursos Alura\CasaDoCodigo\Views\Pedido\Carrinho.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ddcaed719b89b30a8a23760d540faa085ccee927"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pedido_Carrinho), @"mvc.1.0.view", @"/Views/Pedido/Carrinho.cshtml")]
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
#line 1 "D:\Cursos Alura\CasaDoCodigo\Views\_ViewImports.cshtml"
using CasaDoCodigo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Cursos Alura\CasaDoCodigo\Views\_ViewImports.cshtml"
using CasaDoCodigo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ddcaed719b89b30a8a23760d540faa085ccee927", @"/Views/Pedido/Carrinho.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f425103b9042481fbdd49f3917720d72e9a0d106", @"/Views/_ViewImports.cshtml")]
    public class Views_Pedido_Carrinho : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<CasaDoCodigo.Models.ItemPedido>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "carrossel", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "resumo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n");
#nullable restore
#line 3 "D:\Cursos Alura\CasaDoCodigo\Views\Pedido\Carrinho.cshtml"
   ViewData["Title"] = "Carrinho"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h3>Meu Carrinho</h3>

<div class=""panel panel-default"">
    <div class=""panel-heading"">

        <div class=""row"">
            <div class=""col-md-6"">
                Item
            </div>
            <div class=""col-md-2 text-center"">
                Preço Unitário
            </div>
            <div class=""col-md-2 text-center"">
                Quantidade
            </div>
            <div class=""col-md-2"">
                <span class=""pull-right"">
                    Subtotal
                </span>
            </div>
        </div>
    </div>
    <div class=""panel-body"">
");
#nullable restore
#line 28 "D:\Cursos Alura\CasaDoCodigo\Views\Pedido\Carrinho.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"row row-center linha-produto\"");
            BeginWriteAttribute("item-id", " item-id=\"", 770, "\"", 788, 1);
#nullable restore
#line 30 "D:\Cursos Alura\CasaDoCodigo\Views\Pedido\Carrinho.cshtml"
WriteAttributeValue("", 780, item.Id, 780, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                <div class=\"col-md-3\">\n                    <img class=\"img-produto-carrinho\"");
            BeginWriteAttribute("src", " src=\"", 883, "\"", 938, 3);
            WriteAttributeValue("", 889, "/images/produtos/large_", 889, 23, true);
#nullable restore
#line 32 "D:\Cursos Alura\CasaDoCodigo\Views\Pedido\Carrinho.cshtml"
WriteAttributeValue("", 912, item.Produto.Codigo, 912, 22, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 934, ".jpg", 934, 4, true);
            EndWriteAttribute();
            WriteLiteral(" />\n                </div>\n                <div class=\"col-md-3\">");
#nullable restore
#line 34 "D:\Cursos Alura\CasaDoCodigo\Views\Pedido\Carrinho.cshtml"
                                  Write(item.Produto.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n                <div class=\"col-md-2 text-center\">R$ ");
#nullable restore
#line 35 "D:\Cursos Alura\CasaDoCodigo\Views\Pedido\Carrinho.cshtml"
                                                 Write(item.PrecoUnitario);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                <div class=""col-md-2 text-center"">
                    <div class=""input-group"">
                        <span class=""input-group-btn"">
                            <button class=""btn btn-default"">
                                <span class=""glyphicon-minus""></span>
                            </button>
                        </span>
                        <input type=""text""");
            BeginWriteAttribute("value", " value=\"", 1507, "\"", 1533, 1);
#nullable restore
#line 43 "D:\Cursos Alura\CasaDoCodigo\Views\Pedido\Carrinho.cshtml"
WriteAttributeValue("", 1515, item.Quantidade, 1515, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"
                               class=""form-control text-center"" />
                        <span class=""input-group-btn"">
                            <button class=""btn btn-default"">
                                <span class=""glyphicon-plus"" onclick=""clickIncremento(this)""></span>
                            </button>
                        </span>
                    </div>
                </div>
                <div class=""col-md-2"">
                    R$ <span class=""pull-right"" subtotal>
                        ");
#nullable restore
#line 54 "D:\Cursos Alura\CasaDoCodigo\Views\Pedido\Carrinho.cshtml"
                    Write(item.Quantidade * item.PrecoUnitario);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </span>\n                </div>\n            </div>\n");
#nullable restore
#line 58 "D:\Cursos Alura\CasaDoCodigo\Views\Pedido\Carrinho.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n    <div class=\"panel-footer\">\n        <div class=\"row\">\n            <div class=\"col-md-10\">\n                <span numero-itens>\n                    Total: ");
#nullable restore
#line 64 "D:\Cursos Alura\CasaDoCodigo\Views\Pedido\Carrinho.cshtml"
                       Write(Model.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    itens\n                </span>\n            </div>\n            <div class=\"col-md-2\">\n                Total: R$ <span class=\"pull-right\" total>\n                    ");
#nullable restore
#line 70 "D:\Cursos Alura\CasaDoCodigo\Views\Pedido\Carrinho.cshtml"
                Write(Model.Sum(i => i.Quantidade * i.PrecoUnitario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </span>\n            </div>\n        </div>\n    </div>\n</div>\n\n<div class=\"row\">\n    <div class=\"col-md-12\">\n        <div class=\"pull-right\">\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ddcaed719b89b30a8a23760d540faa085ccee9279435", async() => {
                WriteLiteral("\n                Adicionar Produtos\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ddcaed719b89b30a8a23760d540faa085ccee92710727", async() => {
                WriteLiteral("\n                Finalizar Pedido\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n        </div>\n    </div>\n</div>\n\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script type=""text/javascript"">
        function clickIncremento(btn) {
            var linhaDoItem = $(btn).parents('[item-id]');
            var itemId = $(linhaDoItem).attr('item-id');
            var novaQtde = $(linhaDoItem).find('input').val();
            var data = {
                Id: itemId,
                Quantidade: novaQtde
            }

            $.ajax({
                url: '/Pedido/UpdateQuantidade',
                type: 'POST',
                contentType: 'application/JSON',
                data: JSON.stringify(data)
            });
            //debugger;
        }
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<CasaDoCodigo.Models.ItemPedido>> Html { get; private set; }
    }
}
#pragma warning restore 1591
