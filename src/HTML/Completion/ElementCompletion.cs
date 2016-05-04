﻿using System.Collections.Generic;
using Microsoft.Html.Editor.Completion;
using Microsoft.Html.Editor.Completion.Def;
using Microsoft.VisualStudio.Utilities;

namespace VuePack
{
    [HtmlCompletionProvider(CompletionTypes.Children, "*")]
    [ContentType("htmlx")]
    class ElementCompletion : BaseCompletion
    {
        public override string CompletionType
        {
            get { return CompletionTypes.Children; }
        }

        public override IList<HtmlCompletion> GetEntries(HtmlCompletionContext context)
        {
            var list = new List<HtmlCompletion>
            {
                CreateItem("partial", "<partial> tags serve as outlets for registered partials. Partial contents are also compiled by Vue when inserted. The <partial> element itself will be replaced. It requires a name attribute to be provided.", context.Session)
            };

            return list;
        }
    }
}