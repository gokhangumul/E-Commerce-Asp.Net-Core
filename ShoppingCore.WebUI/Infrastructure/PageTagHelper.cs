using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using ShoppingCore.WebUI.Models;
using System;

namespace ShoppingCore.WebUI.Infrastructure
{
    [HtmlTargetElement("div",Attributes ="page-model")]
    public class PageTagHelper:TagHelper
    {
        private readonly IUrlHelperFactory urlHelperFactory;

        public PageTagHelper(IUrlHelperFactory urlHelperFactory)
        {
            this.urlHelperFactory = urlHelperFactory ?? throw new ArgumentNullException(nameof(urlHelperFactory));
        }

        [ViewContext]
        [HtmlAttributeNotBound]
        public ViewContext ViewContext { get; set; }

        public PagingInfo PageModel { get; set; }
        public string PageAction { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var urlHelper = urlHelperFactory.GetUrlHelper(ViewContext);

            var result = new TagBuilder("div");
            var tp = PageModel.TotalPages();
            for (int i = 1; i <= tp; i++)
            {
                var tag = new TagBuilder("a");
                tag.Attributes["href"] = urlHelper.Action(PageAction, new { page = i });
                tag.InnerHtml.Append(i.ToString());
                tag.AddCssClass("btn btn-default");
                result.InnerHtml.AppendHtml(tag);
            }
            output.Content.AppendHtml(result.InnerHtml);
        }
    }
}
