using System;

namespace CompUI
{
    public interface IWindow : IDialog
    {
        // Get/Set 
        IDialog IDialogSearch { get; set; }
        IDialog IDialogSearchView { get; set; }
        IDialog IDialogSell { get; set; }
    }
}