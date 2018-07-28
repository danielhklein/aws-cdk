using Amazon.CDK;
using AWS.Jsii.Runtime.Deputy;

namespace Amazon.CDK.AWS.S3.cloudformation.BucketResource
{
    /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-websiteconfiguration.html </remarks>
    [JsiiInterface(typeof(IWebsiteConfigurationProperty), "@aws-cdk/aws-s3.cloudformation.BucketResource.WebsiteConfigurationProperty")]
    public interface IWebsiteConfigurationProperty
    {
        /// <summary>``BucketResource.WebsiteConfigurationProperty.ErrorDocument``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-websiteconfiguration.html#cfn-s3-websiteconfiguration-errordocument </remarks>
        [JsiiProperty("errorDocument", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]},\"optional\":true}")]
        object ErrorDocument
        {
            get;
            set;
        }

        /// <summary>``BucketResource.WebsiteConfigurationProperty.IndexDocument``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-websiteconfiguration.html#cfn-s3-websiteconfiguration-indexdocument </remarks>
        [JsiiProperty("indexDocument", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]},\"optional\":true}")]
        object IndexDocument
        {
            get;
            set;
        }

        /// <summary>``BucketResource.WebsiteConfigurationProperty.RedirectAllRequestsTo``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-websiteconfiguration.html#cfn-s3-websiteconfiguration-redirectallrequeststo </remarks>
        [JsiiProperty("redirectAllRequestsTo", "{\"union\":{\"types\":[{\"fqn\":\"@aws-cdk/cdk.Token\"},{\"fqn\":\"@aws-cdk/aws-s3.cloudformation.BucketResource.RedirectAllRequestsToProperty\"}]},\"optional\":true}")]
        object RedirectAllRequestsTo
        {
            get;
            set;
        }

        /// <summary>``BucketResource.WebsiteConfigurationProperty.RoutingRules``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-websiteconfiguration.html#cfn-s3-websiteconfiguration-routingrules </remarks>
        [JsiiProperty("routingRules", "{\"union\":{\"types\":[{\"fqn\":\"@aws-cdk/cdk.Token\"},{\"collection\":{\"kind\":\"array\",\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"@aws-cdk/cdk.Token\"},{\"fqn\":\"@aws-cdk/aws-s3.cloudformation.BucketResource.RoutingRuleProperty\"}]}}}}]},\"optional\":true}")]
        object RoutingRules
        {
            get;
            set;
        }
    }
}