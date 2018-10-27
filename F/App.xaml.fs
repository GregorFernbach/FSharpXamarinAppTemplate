namespace F

open System;
open Xamarin.Forms;
open Xamarin.Forms.Xaml;

type App() =
    inherit Application()

    do base.LoadFromXaml(typeof<App>) |> ignore 
    do base.MainPage <- new MainPage()

    override this.OnStart() = ()
    override this.OnSleep() = ()
    override this.OnResume() = ()

    

