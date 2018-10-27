namespace F.Android

open System

open F
open Android.App
open Android.Content.PM;
open Android.Content
open Android.OS
open Android.Runtime
open Android.Views
open Android.Widget
open Xamarin.Forms.Platform.Android
open Xamarin.Forms

type Resources = F.Android.Resource

[<Activity (Label = "F.Android", MainLauncher = true, Icon = "@mipmap/icon", Theme = "@style/MainTheme", ConfigurationChanges = (ConfigChanges.ScreenSize ||| ConfigChanges.Orientation))>]
type MainActivity () =
    inherit FormsAppCompatActivity ()

    override this.OnCreate (bundle) =

        FormsAppCompatActivity.ToolbarResource <- Resources.Layout.Toolbar
        FormsAppCompatActivity.TabLayoutResource <- Resources.Layout.Tabbar

        base.OnCreate (bundle)

        Forms.Init(this, bundle)

        base.LoadApplication(new App())

        

