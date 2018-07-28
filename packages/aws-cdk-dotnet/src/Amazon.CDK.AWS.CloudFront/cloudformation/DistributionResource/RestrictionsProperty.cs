using Amazon.CDK;
using AWS.Jsii.Runtime.Deputy;

namespace Amazon.CDK.AWS.CloudFront.cloudformation.DistributionResource
{
    /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-restrictions.html </remarks>
    public class RestrictionsProperty : DeputyBase, IRestrictionsProperty
    {
        /// <summary>``DistributionResource.RestrictionsProperty.GeoRestriction``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-restrictions.html#cfn-cloudfront-distribution-restrictions-georestriction </remarks>
        [JsiiProperty("geoRestriction", "{\"union\":{\"types\":[{\"fqn\":\"@aws-cdk/cdk.Token\"},{\"fqn\":\"@aws-cdk/aws-cloudfront.cloudformation.DistributionResource.GeoRestrictionProperty\"}]}}", true)]
        public object GeoRestriction
        {
            get;
            set;
        }
    }
}