using System;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;



namespace TestPlugin
{
    public class CrmPlugin : IPlugin
    {

        //Constructor
        public CrmPlugin(string unsecure, string secure)
        {
            // Do something with the parameter strings.
        }


        ITracingService tracingService;
        public void Execute(IServiceProvider serviceProvider)
        {
            //Context
            IPluginExecutionContext context = (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));
            IOrganizationServiceFactory serviceFactory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
            //Service
            IOrganizationService organizationService = serviceFactory.CreateOrganizationService(context.UserId);

            //Tracing
            tracingService = (ITracingService)serviceProvider.GetService(typeof(ITracingService));


            //Input Image
            Entity thisEntity = context.InputParameters["Target"] as Entity;
            /*
            Image           Stage   Create  Update      Delete
            Pre - Image     PRE     No      Yes         Yes
            Pre - Image     POST    Yes     Yes         Yes
            Post - Image    PRE     No      No          No
            Post - Image    POST    Yes     Yes         No
            */
            //Other Images
            Entity preImage = context.PreEntityImages["preImage"] as Entity;
            Entity postImage = context.PostEntityImages["preImage"] as Entity;


            //check
            if (context.InputParameters.Contains("Target") && context.InputParameters["Target"] is Entity)
            {
                if (context.MessageName == "Create")
                {

                }
            }



            // Pass the data to the post event handler in an execution context shared variable named PrimaryContact.
            context.SharedVariables.Add("SharedEntity", (Guid)thisEntity.Id));
            // Alternate code: 
            context.SharedVariables["SharedEntity"] = thisEntity.ToString();

        }
    }

    public class SharedPluginHandler : IPlugin
    {
        public void Execute(IServiceProvider serviceProvider)
        {
            // Obtain the execution context from the service provider.
            IPluginExecutionContext context = (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));

            // Obtain the contact from the execution context shared variables.
            if (context.SharedVariables.Contains("PrimaryContact"))
            {
                Guid contact =
                    new Guid((string)context.SharedVariables["SharedEntity"]);
                // Do something with the contact.
            }
        }
    }
}
