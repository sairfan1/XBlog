﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XBlogHelper.ItemMapper;
using XBlogHelper.ItemMapper.Configuration.Attributes;

namespace XBlogHelper.Models.Blog
{
    [SitecoreItemTemplate(AuthorViewTemplateId)]
    public class AuthorView : SitecoreItem
    {
            public const string AuthorViewTemplateId = "{0255B9A9-6CCE-4840-A445-E3F1A29506A0}";
            public const string AuthorDefaultTitleFieldId = "{D2BA506D-AFDE-4688-92A9-2D80806B0410}";


            [SitecoreItemField(AuthorDefaultTitleFieldId)]
            public virtual string DefaultTitleField { get; set; }

    }

}
