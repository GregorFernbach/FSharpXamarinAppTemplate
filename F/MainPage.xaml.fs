namespace F

open System;
open System.Collections.Generic;
open System.Linq;
open System.Text;
open System.Threading.Tasks;
open Xamarin.Forms;
open Xamarin.Forms.Xaml


type MainPage() =
    inherit ContentPage()
    
    do base.LoadFromXaml(typeof<MainPage>) |> ignore