// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.Elastic;

namespace Azure.ResourceManager.Elastic.Samples
{
    public partial class Sample_MonitoringTagRuleResource
    {
        // TagRules_CreateOrUpdate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_TagRulesCreateOrUpdate()
        {
            // Generated from example definition: specification/elastic/resource-manager/Microsoft.Elastic/preview/2020-07-01-preview/examples/TagRules_CreateOrUpdate.json
            // this example is just showing the usage of "TagRules_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MonitoringTagRuleResource created on azure
            // for more information of creating MonitoringTagRuleResource, please refer to the document of MonitoringTagRuleResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string monitorName = "myMonitor";
            string ruleSetName = "default";
            ResourceIdentifier monitoringTagRuleResourceId = MonitoringTagRuleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, monitorName, ruleSetName);
            MonitoringTagRuleResource monitoringTagRule = client.GetMonitoringTagRuleResource(monitoringTagRuleResourceId);

            // invoke the operation
            MonitoringTagRuleData data = new MonitoringTagRuleData();
            ArmOperation<MonitoringTagRuleResource> lro = await monitoringTagRule.UpdateAsync(WaitUntil.Completed, data);
            MonitoringTagRuleResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MonitoringTagRuleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // TagRules_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_TagRulesGet()
        {
            // Generated from example definition: specification/elastic/resource-manager/Microsoft.Elastic/preview/2020-07-01-preview/examples/TagRules_Get.json
            // this example is just showing the usage of "TagRules_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MonitoringTagRuleResource created on azure
            // for more information of creating MonitoringTagRuleResource, please refer to the document of MonitoringTagRuleResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string monitorName = "myMonitor";
            string ruleSetName = "default";
            ResourceIdentifier monitoringTagRuleResourceId = MonitoringTagRuleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, monitorName, ruleSetName);
            MonitoringTagRuleResource monitoringTagRule = client.GetMonitoringTagRuleResource(monitoringTagRuleResourceId);

            // invoke the operation
            MonitoringTagRuleResource result = await monitoringTagRule.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MonitoringTagRuleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // TagRules_Delete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_TagRulesDelete()
        {
            // Generated from example definition: specification/elastic/resource-manager/Microsoft.Elastic/preview/2020-07-01-preview/examples/TagRules_Delete.json
            // this example is just showing the usage of "TagRules_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MonitoringTagRuleResource created on azure
            // for more information of creating MonitoringTagRuleResource, please refer to the document of MonitoringTagRuleResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string monitorName = "myMonitor";
            string ruleSetName = "default";
            ResourceIdentifier monitoringTagRuleResourceId = MonitoringTagRuleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, monitorName, ruleSetName);
            MonitoringTagRuleResource monitoringTagRule = client.GetMonitoringTagRuleResource(monitoringTagRuleResourceId);

            // invoke the operation
            await monitoringTagRule.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}
