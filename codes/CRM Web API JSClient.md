# Javascript Class to consume CRM Web API

This below code can be used in CRM form to consume `data` & `discovery` api version 8.2

## The Class
```js
// Instance Web API
// HTTP REST API providing access to this instance of Dynamics 365.   

class CrmWebApi {
    constructor() {
        this.dataEndPoint =  Xrm.Page.context.getClientUrl() + "/api/data/v8.2/";
        this.service = this.GetRequestObject();
        this.discoveryEndPoint =  Xrm.Page.context.getClientUrl() + "/api/discovery/v8.2/";
    }

    GetRequestObject(){
        if (window.XMLHttpRequest) {
            return new window.XMLHttpRequest;
            //return new ActiveXObject("MSXML2.XMLHTTP.3.0");
    
        }
        else {
            try {
                return new ActiveXObject("MSXML2.XMLHTTP.3.0");
            }
            catch (ex) {
                return null;
            }
        }
    }

    Request(apiQuery) {  
        
        let queryUrl = this.dataEndPoint + apiQuery;

        this.service.open("GET", queryUrl, false);
        this.service.setRequestHeader("Accept", "application/json");
        this.service.setRequestHeader("Content-Type", "application/json; charset=utf-8");
        this.service.send();
        
        
        if (this.service.readyState == 4 /* complete */) {
            
            //Success 
            if (this.service.status == 200) {               
                var result = JSON.parse(this.service.responseText);
                return result;
            }

            //Failure
            else {
                //alert("Error: " + req.responseText);
                return null;
            }
        }
    }

    RequestCallabck(apiQuery,sucessCallback,failureCallback){
        
        let queryUrl = this.dataEndPoint + apiQuery;

        this.service.open("GET", queryUrl, false);
        this.service.setRequestHeader("Accept", "application/json");
        this.service.setRequestHeader("Content-Type", "application/json; charset=utf-8");
        this.service.send();
        
        
        if (this.service.readyState == 4 /* complete */) {
            //Success 
            if (this.service.status == 200) {
                var result = JSON.parse(this.service.responseText);
                sucessCallback(result);
            }
            //Failure
            else {
                failureCallback(this.service.responseText);
                return null;
            }
        }
    }
}
```
