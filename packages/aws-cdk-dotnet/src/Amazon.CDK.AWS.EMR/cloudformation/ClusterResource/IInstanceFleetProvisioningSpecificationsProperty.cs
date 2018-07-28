using Amazon.CDK;
using AWS.Jsii.Runtime.Deputy;

namespace Amazon.CDK.AWS.EMR.cloudformation.ClusterResource
{
    /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-instancefleetprovisioningspecifications.html </remarks>
    [JsiiInterface(typeof(IInstanceFleetProvisioningSpecificationsProperty), "@aws-cdk/aws-emr.cloudformation.ClusterResource.InstanceFleetProvisioningSpecificationsProperty")]
    public interface IInstanceFleetProvisioningSpecificationsProperty
    {
        /// <summary>``ClusterResource.InstanceFleetProvisioningSpecificationsProperty.SpotSpecification``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-instancefleetprovisioningspecifications.html#cfn-elasticmapreduce-cluster-instancefleetprovisioningspecifications-spotspecification </remarks>
        [JsiiProperty("spotSpecification", "{\"union\":{\"types\":[{\"fqn\":\"@aws-cdk/cdk.Token\"},{\"fqn\":\"@aws-cdk/aws-emr.cloudformation.ClusterResource.SpotProvisioningSpecificationProperty\"}]}}")]
        object SpotSpecification
        {
            get;
            set;
        }
    }
}