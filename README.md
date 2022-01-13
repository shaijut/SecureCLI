This repo is related to a CLI App created for MongoDb and Dev.to Hackathon :) 

# Prerequisites

- Install .NET Core 5.0 SDK : https://dotnet.microsoft.com/en-us/download/dotnet/5.0
- Create you own Mongo DB Atlas FREE account, and create required DB and Collection : https://cloud.mongodb.com/
- Add below sample documents inside your collection:

      {
          "_id": {
              "$oid": "auto_generated_id"
          },
          "link": "https://cloud.mongodb.com/",
          "isSecure": true
      }


      {
          "_id": {
                   "$oid": "auto_generated_id"
          },
          "link": "https://dev.to/",
          "isSecure": true
      }


      {
          "_id": {
                  "$oid": "auto_generated_id"
          },
          "link": "https://www.exampleunsecuresite.com/",
          "isSecure": false
      }

- Open the SearchSecureAPIController.cs file under Secure Cli API project and add all related config for Mongo DB Atlas like: Connection string, DB Name, Collection Name.

# Steps to Run the Secure Cli API

**1.** Open the command prompt into folder SecureCliAPI

**2.** Type `dotnet restore`

**3.** Type `dotnet build`

**4.** Type `dotnet run`

**5.** Let this `API` be in running mode

# Steps to Run the Secure Cli App

**1.** Open the command prompt into folder SecureCli

**2.** Type `dotnet restore`

**3.** Type `dotnet build`

**4.** Type `dotnet pack`

**5.** Type `dotnet tool install --global --add-source ./nupkg SecureCli`

**6.** Lets Test the CLI: Type `secure space any link to check`

# Example : 

 `secure https://cloud.mongodb.com/`
 
# Enjoy the CLI :) 

Kindly open issues if you face any problem running the projects.

# Top Refrences:

- https://www.mongodb.com/languages/how-to-use-mongodb-with-dotnet
- How to create your own .NET CLI tools to make your life easier - YouTube · Nick Chapsas
- https://docs.microsoft.com/en-us/dotnet/core/tools/global-tools-how-to-create
