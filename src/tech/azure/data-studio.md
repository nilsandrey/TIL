# Azure Data Studio tips

  https://stackoverflow.com/questions/69481416/token-retrieval-failed-with-an-error-in-azure-data-studio#69628006

> Token retrieval failed with an error. 



Problem seems to be with a cached token. try to delete the token from here `C:\Users{UserNameHere}\AppData\Roaming\azuredatastudio\Azure Accounts` and try to re authenticate.
