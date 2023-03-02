using Maui.App.ViewModels;

namespace Maui.App.Views;

public partial class DevicePage : ContentPage
{
    DeviceViewModel model = new DeviceViewModel();
    public DevicePage()
    {
        InitializeComponent();

        this.BindingContext = model;
    }

    private void CarouselView_Scrolled(object sender, ItemsViewScrolledEventArgs e)
    {
        // ��Ϊ����¼��ᴥ�����
        if (e.CenterItemIndex == e.LastVisibleItemIndex)
        {
            // ��������ʱ����ʾ�������
            // ���ﻹʼ������ʾ��Ϣ
            // ��Ϣ���ģ���ģ�����ݽ��������������Ѿ�׼�����������
            model.SwtichContent(e.LastVisibleItemIndex);
        }
    }
}