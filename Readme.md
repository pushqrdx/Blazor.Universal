# Blazor for Universal Windows Platform

- Want to develop your application using HTML/CSS/C# ?
- Want to develop your application using HTML/CSS/C# but still want to have access to the Native APIs ?
- Want to develop your application using HTML/CSS/C# but still want to have access to the Native APIs ? and target EVERY MAJOR PLATFORM ?!!

### DREAM NO MORE!

In this example project `Blazor.Server` is bootstrapped in a `Xamarin.UWP` project and being accessed through a `WebView`.
**Benefits:**

1. No sandbox (WASM isn't used).
2. Direct access to Xamarin APIs/.Net Standard Libraries and Xamarin's `MessagingCenter` to invoke platform specific code.
3. Full debugging capability (again because no web assembly involved).

> CHEERS MAN THIS IS AWESOME, FINALLY I CAN BUILD ONCE AND DEPLOY EVERYWHERE! HELL YEAH.

Ah.... Actually. I lied about the cross platform thing 😂. Although the concept is same and in theory you can apply this to any other platform, I haven't had any luck with that so far mostly because that hosting `ASP.NET` Core application on `Mono.Android` or `iOS` isn't that straightforward or even supported.
