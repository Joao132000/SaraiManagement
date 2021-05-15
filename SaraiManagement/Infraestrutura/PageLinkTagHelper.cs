using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using SaraiManagement.Models.ViewModels;
using Microsoft.AspNetCore.Razor.TagHelpers;


namespace SaraiManagement.Infraestrutura
{
    //Define a tag HTML que receberá a TagHelper, por meio do atributo
    //page-model
    [HtmlTargetElement("div", Attributes = "page-model")]

    public class PageLinkTagHelper : TagHelper
    {
        //carrega para a classe o interpretador Helper
        //Helper é o interpretador de C#
        private IUrlHelperFactory urlHelperFactory;

        public PageLinkTagHelper(IUrlHelperFactory helperFactory)
        {
            urlHelperFactory = helperFactory;
        }

        //ViewContext é o conteúdo da página HTML (View)
        [ViewContext]
        //Verifica erros de renderização
        [HtmlAttributeNotBound]

        //página HTML
        public ViewContext ViewContext { get; set; }
        //Objeto da paginação
        public PagingInfo PageModel { get; set; }

        //representa as Ações do link (href)
        public string PageAction { get; set; }

        //definição para os atributos da tag <a> correspondentes aos links da paginação

        //utilizado para formatar o número da página atual
        public bool PageClassesEnabled { get; set; } = false;

        //classe CSS para formatação da paginação
        public string PageClass { get; set; }

        //Formatação CSS da página qe não é atual
        public string PageClassNormal { get; set; }

        //Usado para formação CSS da página selecionada
        public string PageClassSelected { get; set; }


        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            //Elementos para o renderizador HTML ViewContext. Reconhece a página HTML
            IUrlHelper urlHelper = urlHelperFactory.GetUrlHelper(ViewContext);

            //Modificar a renderização do elemento div da View
            TagBuilder result = new TagBuilder("div");

            //insere os links para a paginação da View
            for (int i = 1; i <= PageModel.TotalDePaginas; i++)
            {
                //insere um link com o atributo href correspondente à paginação
                TagBuilder tag = new TagBuilder("a");
                tag.Attributes["href"] = urlHelper.Action(PageAction, new
                {
                    pagina = i
                });

                //ações para a formatação dos numeros de páginas na div de paginação
                if (PageClassesEnabled)
                {
                    tag.AddCssClass(PageClass);
                    tag.AddCssClass(i == PageModel.PaginaAtual ? PageClassSelected : PageClassNormal);
                }

                //insere o número da página
                tag.InnerHtml.Append(i.ToString());

                //insere o link
                result.InnerHtml.AppendHtml(tag);
            }
            //insere a div com os links da paginação
            output.Content.AppendHtml(result.InnerHtml);
        }
    }
}
