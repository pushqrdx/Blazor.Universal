# Blazor for Universal Windows Platform

1. Want to develop your application using HTML/CSS/C# ?
2. Want to develop your application using HTML/CSS/C# but still want to have access to Native APIs ?
3. Want to develop your application using HTML/CSS/C# but still want to have access to Native APIs and you also want to run you're app cross platform ?!!

### DREAM NO MORE!

In this example project you can see `Blazor` bootstrapped inside a `Xamarin.UWP` project and being accessed through a `WebView` so that no web assembly is used, no sandbox, access to whatever `Xamarin` API you want, Even use `Xamarin.Forms` `MessagingCenter` to invoke platform specific APIs whenever needed.

> CHEERS MAN THIS IS AWESOME, FINALLY I CAN BUILD ONCE AND DEPLOY EVERYWHERE! HELL YEAH.

Ah.... Actually. I lied about the cross platform thing 😂. Although the concept is same and in theory you can apply this to any other platform, I haven't had any luck with that so far mostly because of hosting `ASP.NET` Core application on `Mono.Android` or `iOS` isn't that straightforward.
