#pragma checksum "C:\Git\PotatoChat\src\ChatInbox\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "747e50e1821fde0688ca20648d6570c9786df0c9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Git\PotatoChat\src\ChatInbox\Views\_ViewImports.cshtml"
using ChatInbox;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Git\PotatoChat\src\ChatInbox\Views\_ViewImports.cshtml"
using ChatInbox.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"747e50e1821fde0688ca20648d6570c9786df0c9", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac5b47c26f881fdd72999fd09d6d3fe41d671c49", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Chat.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Git\PotatoChat\src\ChatInbox\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "747e50e1821fde0688ca20648d6570c9786df0c93898", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<div id=\"ChatInbox\" class=\"d-flex\">\r\n    <div id=\"Profile\" class=\"d-inline-block col-4\">\r\n        <!-- User Profile -->\r\n        <div id=\"UserSection\">\r\n            <div class=\"profile\">\r\n                <div class=\"image\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 347, "\"", 353, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                </div>
                <div class=""name"">
                    Nome da Pessoa
                </div>
            </div>
        </div>
        <!-- Contact List -->
        <div id=""ContactsSection"">
            <div id=""Search"" class=""input-group"">
                <i class=""fas fa-search""></i>
                <input class=""form-control"" type=""text"" placeholder=""Pesquise por um contato..."" />
            </div>
            <div class=""contact"">
                <div class=""header"">
                    <div class=""image"">
                        <img");
            BeginWriteAttribute("src", " src=\"", 943, "\"", 949, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                    </div>
                    <div class=""name"">
                        Vinícius de Souza
                    </div>
                </div>
                <div class=""preview"">
                    Teste de envio de mensagem em tempo real ut...
                </div>
            </div>
        </div>
    </div>
    <div id=""MessageSection"" class=""d-inline-block"">
        <!-- Message List -->
        <div id=""Messages"">
            <div class=""message other"">
                <div class=""message-box"">
                    <div class=""content"">
                        Teste de envio de mensagem em tempo real utilizando banco não relacional.
                    </div>
                    <div class=""details"">
                        <div class=""time"">
                            ");
#nullable restore
#line 51 "C:\Git\PotatoChat\src\ChatInbox\Views\Home\Index.cshtml"
                       Write(DateTime.Now.AddMinutes( -1 ).ToString( "dd/MM/yyyy hh:mm" ));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>
                    </div>
                </div>
            </div>
            <div class=""message self"">
                <div class=""message-box"">
                    <div class=""content"">
                        Está funcionando que é uma beleza!
                    </div>
                    <div class=""details"">
                        <div class=""time"">
                            ");
#nullable restore
#line 63 "C:\Git\PotatoChat\src\ChatInbox\Views\Home\Index.cshtml"
                       Write(DateTime.Now.AddMinutes( -1 ).ToString( "dd/MM/yyyy hh:mm" ));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"status h\" data-toggle=\"tooltip\" data-placement=\"left\" title=\"Lido\">\r\n");
            WriteLiteral(@"                            <i class=""fas fa-check-double""></i>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""message self"">
                <div class=""message-box"">
                    <div class=""content"">
                        Ou será que...
                    </div>
                    <div class=""details"">
                        <div class=""time"">
                            ");
#nullable restore
#line 79 "C:\Git\PotatoChat\src\ChatInbox\Views\Home\Index.cshtml"
                       Write(DateTime.Now.AddMinutes( -1 ).ToString( "dd/MM/yyyy hh:mm" ));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"status l\" data-toggle=\"tooltip\" data-placement=\"left\" title=\"Enviado\">\r\n");
            WriteLiteral(@"                            <i class=""fas fa-check""></i>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div id=""InputField"" class=""col-12"">
            <!-- Toolbar -->
            <div class=""toolpanel"" style=""text-align: center;"">
                <ul class=""d-flex justify-content-around"">
                    <li class=""i-emoji""><i class=""fas fa-laugh-beam""></i></li>
                    <li class=""i-gallery""><i class=""fas fa-image""></i></li>
                    <li>Adesivos</li>
                </ul>
            </div>
            <!-- Message Input -->
            <div class=""content"">
                <div class=""form-group d-flex"">
                    <textarea id=""msg-input"" class=""form-control"" placeholder=""Insira uma mensagem...""></textarea>
                    <button id=""msg-send"" class=""btn btn-primary"" type=""button"">Enviar</button>
                </div> 
            </div>
        </div>
    </div>
");
            WriteLiteral("</div>\r\n");
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
