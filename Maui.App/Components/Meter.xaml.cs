using Microsoft.Maui.Controls.Shapes;

namespace Maui.App.Components;

public partial class Meter : ContentView
{

    public double Value
    {
        get { return (double)GetValue(ValueProperty); }
        set { SetValue(ValueProperty, value); }
    }

    public static readonly BindableProperty ValueProperty =
        BindableProperty.Create("Value", typeof(double), typeof(Meter), 0.0, propertyChanged: new BindableProperty.BindingPropertyChangedDelegate(OnValueChanged));

    private static void OnValueChanged(BindableObject bindable, object oldValue, object newValue)
    {
        (bindable as Meter).pointerGrid.RotateTo(double.Parse(newValue.ToString()) * 2.7 + 135);
    }

    public Meter()
    {
        InitializeComponent();
    }

    protected override void OnSizeAllocated(double width, double height)
    {
        base.OnSizeAllocated(width, height);

        this.root.WidthRequest = width;
        this.root.HeightRequest = width;

        //double radius = width / 2 - 20;
        //if (radius <= 0) return;
        this.Refresh();

    }

    private void Refresh()
    {
        double width = this.root.WidthRequest - 40;
        double radius = width / 2;
        if (radius <= 0) return;

        // PATH的微语法    
        string borderPathData = $"M4,{radius}A{radius - 2} {radius - 2} 0 1 1 {radius} {width - 2}";
        // 将字符串转换成Geometry
        this.plateBorder.Data = (Geometry)new PathGeometryConverter().ConvertFromInvariantString(borderPathData);

        this.plateBorder.RenderTransform = new RotateTransform { Angle = -45, CenterX = radius, CenterY = radius };

        // 绘制刻度  
        double step = 2.7;
        for (int i = 0; i <= 100; i++)
        {
            Line lineScale = new Line();

            //两个点 半径进行计算   半径-5的样子进行计算
            // X值 ：  半径   Cos     Y值 ：半径  Sin
            lineScale.X1 = radius - (radius - 10) * Math.Cos((step * i - 45) * Math.PI / 180);
            lineScale.Y1 = radius - (radius - 10) * Math.Sin((step * i - 45) * Math.PI / 180);
            lineScale.X2 = radius - (radius - 5) * Math.Cos((step * i - 45) * Math.PI / 180);
            lineScale.Y2 = radius - (radius - 5) * Math.Sin((step * i - 45) * Math.PI / 180);

            if (i % 10 == 0)
            {
                lineScale.Stroke = Brush.Red;
                lineScale.StrokeThickness = 2;

                // 刻度标记
                Label txtScale = new Label();
                txtScale.Text = i.ToString();
                txtScale.WidthRequest = 34;
                txtScale.HorizontalTextAlignment = TextAlignment.Center;
                txtScale.TextColor = Colors.White;
                txtScale.FontSize = 11;

                // 绝对定位 
                AbsoluteLayout.SetLayoutBounds(txtScale,
                new Rect(
                    radius - (radius - 30) * Math.Cos((i * step - 45) * Math.PI / 180) - 19,
                    radius - (radius - 30) * Math.Sin((i * step - 45) * Math.PI / 180) - 9, 35, 12));

                this.alScale.Children.Add(txtScale);
            }
            else
            {
                lineScale.Stroke = Brush.Gray;
                lineScale.StrokeThickness = 1;
            }

            AbsoluteLayout.SetLayoutBounds(lineScale, new Rect(lineScale.X1 - 3, lineScale.Y1 - 3, 10, 10));
            //AbsoluteLayout.SetLayoutBounds(lineScale,
            //    new Rect(
            //       Math.Min(lineScale.X1, lineScale.X2),
            //       Math.Min(lineScale.Y1, lineScale.Y2),
            //        10,
            //        10));
            this.alScale.Children.Add(lineScale);


            // 指针
            string sData = "M{0} {1},{2} {0},{0} {3},{3} {0}z";
            sData = string.Format(sData, radius, radius + 5, this.root.Width - 60, radius - 5);
            this.pointer.Data = (Geometry)new PathGeometryConverter().ConvertFromInvariantString(sData);

            // RotateTo   带动画 
            this.pointerGrid.RotateTo(Value * step + 135);
        }
    }
}