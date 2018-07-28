using Amazon.CDK;
using AWS.Jsii.Runtime.Deputy;

namespace Amazon.CDK.AWS.S3.cloudformation.BucketResource
{
    /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-lifecycleconfig.html </remarks>
    [JsiiInterface(typeof(ILifecycleConfigurationProperty), "@aws-cdk/aws-s3.cloudformation.BucketResource.LifecycleConfigurationProperty")]
    public interface ILifecycleConfigurationProperty
    {
        /// <summary>``BucketResource.LifecycleConfigurationProperty.Rules``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-lifecycleconfig.html#cfn-s3-bucket-lifecycleconfig-rules </remarks>
        [JsiiProperty("rules", "{\"union\":{\"types\":[{\"fqn\":\"@aws-cdk/cdk.Token\"},{\"collection\":{\"kind\":\"array\",\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"@aws-cdk/cdk.Token\"},{\"fqn\":\"@aws-cdk/aws-s3.cloudformation.BucketResource.RuleProperty\"}]}}}}]}}")]
        object Rules
        {
            get;
            set;
        }
    }
}