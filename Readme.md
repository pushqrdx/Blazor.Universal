# Blazor for Universal Windows Platform

1. Want to develop your application using HTML/CSS/C# ?
2. Want to develop your application using HTML/CSS/C# but still want to have access to the Native APIs ?
3. Want to develop your application using HTML/CSS/C# but still want to have access to the Native APIs ? and target EVERY MAJOR PLATFORM ?!!

### DREAM NO MORE!

In this example project `Blazor.Server` is bootstrapped in a `Xamarin.UWP` project and being accessed through a `WebView`.
**Benefits:**

- No sandbox (WASM isn't used).
- Direct access to Xamarin APIs/.Net Standard Libraries and Xamarin's `MessagingCenter` to invoke platform specific code.
- Full debugging capability (again because no web assembly involved).

> CHEERS MAN THIS IS AWESOME, FINALLY I CAN BUILD ONCE AND DEPLOY EVERYWHERE! HELL YEAH.

Ah.... Actually. I lied about the cross platform thing 😂. Although the concept is same and in theory you can apply this to any other platform, I haven't had any luck with that so far mostly because that hosting `ASP.NET` Core application on `Mono.Android` or `iOS` isn't that straightforward or even supported.
