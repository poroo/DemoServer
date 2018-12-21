# DemoServer
Simple http server for serving static files based on Asp.Net Core Kestrel. Uses [CoreRT](https://github.com/dotnet/corert) to create a small native executable.

Main purpose of the software is to package small and efficient http server together with Webgl / Html canvas demo. This enables the browser to access features that are not available when running demos directly in a browser.

# Build
dotnet publish -c release -r win-x64 (for windows)

It's possible to compile to other platforms as well, haven't tested them.

# Usage
* Simply copy your demo to .../publish/demo/
* Main entry file should be index.html
* Start httpserver.exe 

Browser automatically starts up and loads index.html