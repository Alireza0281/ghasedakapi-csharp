# ghasedakapi-csharp

  ghasedakapi C#/.NET Helper Library 

## Adding Ghasedakapi libraries to your .NET project

  The best and easiest way to add the Ghasedakapi libraries to your .NET project is to use the NuGet package manager.

## Package Manager
     Install-Package GhasedakApi.SMSTest -Version 1.0.1
 
## .NET CLI 
    dotnet add package GhasedakApi.SMSTest --version 1.0.1

## Simple Send

          try 
            {
                var sms = new GhasedakApi.Api("apikey");
                long messageid = sms.SendSMS("message", "lineNumber", "receptor").Items[0];
            }
            catch (GhasedakApi.Exceptions.ApiException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (GhasedakApi.Exceptions.ConnectionException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
## Bulk Send
          
          try
            {
                var bulksms = new GhasedakApi.Api("apikey");
                var res = bulksms.SendSMS("message", "linenumber", new string[] { "receptor" });
                foreach(var item in res.Items)
                {
                    Console.WriteLine("messageids:" + item);
                }
            }
            catch (GhasedakApi.Exceptions.ApiException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (GhasedakApi.Exceptions.ConnectionException ex)
            {
                Console.WriteLine(ex.Message);
            }
