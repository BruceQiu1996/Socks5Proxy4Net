﻿using Socks5Client.ViewModels;
using System.Windows.Controls;

namespace Socks5Client.Pages
{
    /// <summary>
    /// SettingsPage.xaml 的交互逻辑
    /// </summary>
    public partial class SettingsPage : Page
    {
        public SettingsPage(SettingsPageViewModel settingsPageViewModel)
        {
            InitializeComponent();
            DataContext = settingsPageViewModel;
        }
    }
}
