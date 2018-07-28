using Amazon.CDK;
using AWS.Jsii.Runtime.Deputy;

namespace Amazon.CDK.AWS.KinesisFirehose.cloudformation.DeliveryStreamResource
{
    /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-kinesisstreamsourceconfiguration.html </remarks>
    [JsiiInterface(typeof(IKinesisStreamSourceConfigurationProperty), "@aws-cdk/aws-kinesisfirehose.cloudformation.DeliveryStreamResource.KinesisStreamSourceConfigurationProperty")]
    public interface IKinesisStreamSourceConfigurationProperty
    {
        /// <summary>``DeliveryStreamResource.KinesisStreamSourceConfigurationProperty.KinesisStreamARN``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-kinesisstreamsourceconfiguration.html#cfn-kinesisfirehose-deliverystream-kinesisstreamsourceconfiguration-kinesisstreamarn </remarks>
        [JsiiProperty("kinesisStreamArn", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]}}")]
        object KinesisStreamArn
        {
            get;
            set;
        }

        /// <summary>``DeliveryStreamResource.KinesisStreamSourceConfigurationProperty.RoleARN``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-kinesisstreamsourceconfiguration.html#cfn-kinesisfirehose-deliverystream-kinesisstreamsourceconfiguration-rolearn </remarks>
        [JsiiProperty("roleArn", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]}}")]
        object RoleArn
        {
            get;
            set;
        }
    }
}