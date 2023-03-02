using SmartHome.Models;

namespace SmartHome.Selectors
{
    internal class LightItemTemplateSelector : DataTemplateSelector
    {
        public DataTemplate DT1 { get; set; }
        public DataTemplate DT2 { get; set; }
        public DataTemplate DT3 { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            LightItemModel model = item as LightItemModel;
            if (model != null)
            {
                if (model.ItemType == 1)
                    return DT1;
                else if (model.ItemType == 2)
                    return DT2;
                else if (model.ItemType == 3)
                    return DT3;
            }
            return null;
        }
    }
}
