using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rg.Plugins.Popup.Animations;
using Rg.Plugins.Popup.Enums;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PopPud_prueba
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MiPopupPage : Rg.Plugins.Popup.Pages.PopupPage
    {
        public MiPopupPage()
        {
            //animacion 
            var scaleAnimation = new ScaleAnimation
            {
                PositionIn = MoveAnimationOptions.Right,
                PositionOut = MoveAnimationOptions.Left
            };

            this.Animation = scaleAnimation;
            InitializeComponent();
            BackgroundColor = Color.AliceBlue; //cuando se abre el popup el fondo se pone del color asignado

        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            // Cerrar el popup
            await Rg.Plugins.Popup.Services.PopupNavigation.Instance.PopAsync();

        }
    }
}