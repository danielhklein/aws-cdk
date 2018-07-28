using Amazon.CDK;
using AWS.Jsii.Runtime.Deputy;

namespace Amazon.CDK.AWS.S3.cloudformation.BucketResource
{
    /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-bucketencryption.html </remarks>
    public class BucketEncryptionProperty : DeputyBase, IBucketEncryptionProperty
    {
        /// <summary>``BucketResource.BucketEncryptionProperty.ServerSideEncryptionConfiguration``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-bucketencryption.html#cfn-s3-bucket-bucketencryption-serversideencryptionconfiguration </remarks>
        [JsiiProperty("serverSideEncryptionConfiguration", "{\"union\":{\"types\":[{\"fqn\":\"@aws-cdk/cdk.Token\"},{\"collection\":{\"kind\":\"array\",\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"@aws-cdk/cdk.Token\"},{\"fqn\":\"@aws-cdk/aws-s3.cloudformation.BucketResource.ServerSideEncryptionRuleProperty\"}]}}}}]}}", true)]
        public object ServerSideEncryptionConfiguration
        {
            get;
            set;
        }
    }
}