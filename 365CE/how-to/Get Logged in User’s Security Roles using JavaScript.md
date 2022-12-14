D365 CE:XRM Get Logged in User’s Security Roles
===

we can use Xrm.Utility.getGlobalContext().userSettings.roles which returns collection of objects with GUID and name of each security role that is assigned to the user directly or through the teams.

Below is the script which checks if the user has certain security roles based on names and hides the ribbon button if the user doesn’t have any of those security roles:

```cs
SAB.ShowHideReopenButton = function () {
    var roles = Xrm.Utility.getGlobalContext().userSettings.roles;
 
    if (roles === null) return false;
 
    var hasRole = false;
    roles.forEach(function (item) {
        if (item.name.toLowerCase() === "cs manager" || item.name.toLowerCase() === "cs administrator") {
            hasRole = true;
        }
    });
    
    return hasRole;
}
```
