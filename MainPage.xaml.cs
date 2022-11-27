

using Plugin.Maui.Audio;
using System.Diagnostics;

namespace EOKeksi;

public partial class MainPage : ContentPage
{
    private readonly IAudioManager audioManager;

    public MainPage(IAudioManager audioManager)
    {
        InitializeComponent();
        this.audioManager = audioManager;
    }

    private async void OnCounterClicked(object sender, EventArgs e)
    {
        try
        {
            var player = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("crack.mp3"));
            player.Play();
        }
        catch (Exception evirhe)
        {
            Debug.WriteLine("Soundplayer failure" + evirhe);
        }

        Misfortune BadLuckBaby = new();
        BadLuckBaby.GetMisfortune();
        LabelMisfortuneFin.Text = BadLuckBaby.TextFin;
        
    }
}

