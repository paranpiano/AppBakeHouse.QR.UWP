using System;

using AppBakeHouse.QR.UWP.Models;

namespace AppBakeHouse.QR.UWP.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public Item Item { get; set; }
        public ItemDetailViewModel(Item item = null)
        {
            Title = item?.Text;
            Item = item;
        }
    }
}
