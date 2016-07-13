# TrackPack
As an electronic musician I need an application that will allow me to keep track of the settings for all my MIDI devices for each song I'm writing. The code and presentation from this repository were used in the .NET Developers Association user group meeting on 2016-07-11. 

## Prerequisites 
1. [.NET Core 1.0](https://www.microsoft.com/net/core)
1. [Visual Studio 2015 Community](https://www.visualstudio.com/post-download-vs?sku=community&clcid=0x409) or [Visual Studio Code](http://code.visualstudio.com)
1. [Node.js](http://nodejs.org)

## Web API Project
Simply open the project up in VS or Code and compile/run it. If you'd like to publish it to Azure you'll need an Azure subscription and a Git client. Learn more about deploying your ASP.NET application to Azure [here](https://azure.microsoft.com/en-us/documentation/articles/web-sites-deploy/). 

## Angular2 App
Using a command line while in the **client** folder of the downloaded source code, enter the following commands:

        npm install
        npm start

You'll probably need to change the URL in the **client/services/songlist.service.ts** file, too, to match your localhost configuration or to reflect the URL of the site following your deploying it to Azure. 

        getSongs() {
            return this.http.get('http://trackpack.azurewebsites.net/api/song')
                            .map(response => <Song[]>response.json());
        }

## Presentation
The presentation from my session is included in the repository. Feel free to use it if you'd like to give the session in your own user group or team room. 

## Contributions
They are very much welcome. Please feel free to send me a pull request. 