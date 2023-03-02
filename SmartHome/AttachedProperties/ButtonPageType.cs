namespace SmartHome.AttachedProperties
{
    public class ButtonPageType : BindableObject
    {
        public static readonly BindableProperty PageTypeProperty =
   BindableProperty.CreateAttached("PageType", typeof(Type), typeof(ButtonPageType), defaultValue: typeof(BindableObject));

        public static Type GetPageType(BindableObject view)
        {
            return (Type)view.GetValue(PageTypeProperty);
        }

        public static void SetPageType(BindableObject view, Type value)
        {
            view.SetValue(PageTypeProperty, value);
        }
    }
}
