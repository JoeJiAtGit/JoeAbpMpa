using Abp.Web.Mvc.Views;

namespace JoeAbpMpa.Web.Views
{
    public abstract class JoeAbpMpaWebViewPageBase : JoeAbpMpaWebViewPageBase<dynamic>
    {

    }

    public abstract class JoeAbpMpaWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected JoeAbpMpaWebViewPageBase()
        {
            LocalizationSourceName = JoeAbpMpaConsts.LocalizationSourceName;
        }
    }
}